using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALUGUEL_CARROS
{
    public partial class frmCadastroCarros : Form
    {
        public frmCadastroCarros()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void controlesOnOff(bool status)
        {
            txtModelo.Enabled = status;
            txtMarca.Enabled = status;
            txtChassi.Enabled = status;
            txtAno.Enabled = status;
            txtPlaca.Enabled = status;
            

        }

        private void btnOnOff(bool status)
        {
            btnAdd.Enabled = status;
            btnCancelar.Enabled = status;
            btnEditar.Enabled = status;
            btnRemover.Enabled = status;
            btnCancelar.Enabled = !status;
            btnGravar.Enabled = !status;
        }

        private void limparTxts()
        {
            lblId.Text = "-1";
            txtModelo.Clear();
            txtMarca.Clear();
            txtChassi.Clear();
            txtAno.Clear();
            txtPlaca.Clear();
            
        }
        private void FrmCarros_Load(object sender, EventArgs e)
        {            
            controlesOnOff(false);
            btnOnOff(true);

            CAMADAS.BLL.Carros bllCarro = new CAMADAS.BLL.Carros();
            dtGrvCarro.DataSource = "";
            dtGrvCarro.DataSource = bllCarro.Select();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblId.Text = "-1";
            controlesOnOff(true);
            btnOnOff(false);
            CAMADAS.BLL.Carros bllCarro = new CAMADAS.BLL.Carros();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlesOnOff(true);
            btnOnOff(false);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparTxts();
            controlesOnOff(false);
            btnOnOff(true);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            
            CAMADAS.BLL.Carros bllCarro = new CAMADAS.BLL.Carros();
            string msg = "";

            if(lblId.Text == "-1")
            {
                msg = "Deseja Inserir um novo Carro?";
            }
            else
            {
                msg = "Deseja Alterar o Carro atual?";
            }
            DialogResult resposta = MessageBox.Show(msg, "Gravar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if(resposta == DialogResult.Yes)
            {
                CAMADAS.MODEL.Carros carro = new CAMADAS.MODEL.Carros();
                carro.id = Convert.ToInt32(lblId.Text);
                carro.modelo = txtModelo.Text;
                carro.marca = txtMarca.Text;
                carro.chassi = txtChassi.Text;
                carro.ano = Convert.ToInt32(txtAno.Text);
                carro.placa = txtPlaca.Text;
                
                if(lblId.Text == "-1")
                {
                    bllCarro.Insert(carro);
                }
                else
                {
                    bllCarro.Update(carro);
                }
            }
            else
            {
                MessageBox.Show("Não Gravado", "Gravar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            dtGrvCarro.DataSource = bllCarro.Select();

            //apaga
            limparTxts();
            controlesOnOff(false);
            btnOnOff(true);
        }

        private void dtGrvCadastroCarro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtGrvCarro_DoubleClick(object sender, EventArgs e)
        {
            lblId.Text = dtGrvCarro.SelectedRows[0].Cells["id"].Value.ToString();
            txtModelo.Text = dtGrvCarro.SelectedRows[0].Cells["modelo"].Value.ToString();
            txtMarca.Text = dtGrvCarro.SelectedRows[0].Cells["marca"].Value.ToString();
            txtChassi.Text = dtGrvCarro.SelectedRows[0].Cells["chassi"].Value.ToString();
            txtAno.Text = dtGrvCarro.SelectedRows[0].Cells["ano"].Value.ToString();
            txtPlaca.Text = dtGrvCarro.SelectedRows[0].Cells["placa"].Value.ToString();
            
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.Carros bllCarro = new CAMADAS.BLL.Carros();
            string msg = "";

            if (lblId.Text != "-1")
            {
                msg = "Deseja Remover o Carro selecionado?";
                DialogResult resp = MessageBox.Show(msg, "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);
                if(resp == DialogResult.Yes)
                {
                    int idCarro = Convert.ToInt32(lblId.Text);
                    bllCarro.Delete(idCarro);
                }
            }
            else
            {
                MessageBox.Show("Não há dados para Remover", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dtGrvCarro.DataSource = "";
            dtGrvCarro.DataSource = bllCarro.Select();
            limparTxts();

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            gpbPesquisa.Visible = !gpbPesquisa.Visible;
            rdbTodos.Checked = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdbId_CheckedChanged(object sender, EventArgs e)
        {
            txtFiltro.Clear();
            lblFiltrar.Text = "Digite o Id: ";
            lblFiltrar.Visible = true;
            txtFiltro.Visible = true;
            txtFiltro.Focus();
        }

        private void rdbModelo_CheckedChanged(object sender, EventArgs e)
        {
            txtFiltro.Clear();
            lblFiltrar.Text = "Digite o Modelo: ";
            lblFiltrar.Visible = true;
            txtFiltro.Visible = true;
            txtFiltro.Focus();
        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            lblFiltrar.Visible = false;
            txtFiltro.Visible = false;
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.Carros bllcarro = new CAMADAS.BLL.Carros();
            List<CAMADAS.MODEL.Carros> lstCarros = new List<CAMADAS.MODEL.Carros>();

            if (rdbTodos.Checked)
            {
                lstCarros = bllcarro.Select();
            }
            else if (rdbId.Checked)
            {
                int id = Convert.ToInt32(txtFiltro.Text);
                lstCarros = bllcarro.SelectById(id);
            }
                else
                {
                lstCarros = bllcarro.SelectByModelo(txtFiltro.Text);
                }
            dtGrvCarro.DataSource = "";
            dtGrvCarro.DataSource = lstCarros;
        }
    }
}
