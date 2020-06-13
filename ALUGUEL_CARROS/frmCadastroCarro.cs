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
            txtSituacao.Enabled = status;

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
            txtModelo.Clear();
            txtMarca.Clear();
            txtChassi.Clear();
            txtAno.Clear();
            txtPlaca.Clear();
            txtSituacao.Clear();
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
            //coloca aqui antes de apagar
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
                carro.situacao = Convert.ToInt32(txtSituacao.Text);
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
    }
}
