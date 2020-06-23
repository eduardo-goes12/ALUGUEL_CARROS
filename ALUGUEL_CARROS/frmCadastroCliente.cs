using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ALUGUEL_CARROS
{
    public partial class frmCadastroCli : Form 
    {
        public frmCadastroCli()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            controlesOnOff(false);
            btnOnOff(true);

            CAMADAS.BLL.Clientes bllCliente = new CAMADAS.BLL.Clientes();
            dtGrvClientes.DataSource = bllCliente.Select();

            

        }


        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void controlesOnOff(bool status)
        {
            txtNome.Enabled = status;
            txtCpf.Enabled = status;
            txtSexo.Enabled = status;

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
            txtNome.Clear();
            txtCpf.Clear();
            txtSexo.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblId.Text = "-1";
            controlesOnOff(true);
            btnOnOff(false);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlesOnOff(true);
            btnOnOff(false);            
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.Clientes bllCliente = new CAMADAS.BLL.Clientes();
            string msg = "";

            if (lblId.Text != "-1")
            {
                msg = "Deseja Remover o Cliente selecionado?";
                DialogResult resp = MessageBox.Show(msg, "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);
                if (resp == DialogResult.Yes)
                {
                    int idCliente = Convert.ToInt32(lblId.Text);
                    bllCliente.Delete(idCliente);
                }
            }
            else
            {
                MessageBox.Show("Não há dados para Remover", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dtGrvClientes.DataSource = "";
            dtGrvClientes.DataSource = bllCliente.Select();
            limparTxts();





        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            
        }

       

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparTxts();
            controlesOnOff(false);
            btnOnOff(true);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.Clientes bllCliente = new CAMADAS.BLL.Clientes();
            string msg = "";

            if (lblId.Text == "-1")
            {
                msg = "Deseja Inserir um novo Cliente?";
            }
            else
            {
                msg = "Deseja Alterar o Cliente atual?";
            }
            DialogResult resposta = MessageBox.Show(msg, "Gravar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (resposta == DialogResult.Yes)
            {
                CAMADAS.MODEL.Clientes cliente = new CAMADAS.MODEL.Clientes();
                cliente.id = Convert.ToInt32(lblId.Text);
                cliente.nome = txtNome.Text;
                cliente.cpf = txtCpf.Text;
                cliente.sexo = txtSexo.Text;
                
                if (lblId.Text == "-1")
                {
                    bllCliente.Insert(cliente);
                }
                else
                {
                    bllCliente.Update(cliente);
                }
            }
            else
            {
                MessageBox.Show("Não Gravado", "Gravar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            dtGrvClientes.DataSource = bllCliente.Select();

            //apaga
            limparTxts();
            controlesOnOff(false);
            btnOnOff(true);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dtGrvClientes_DoubleClick(object sender, EventArgs e)
        {
            lblId.Text = dtGrvClientes.SelectedRows[0].Cells["id"].Value.ToString();
            txtNome.Text = dtGrvClientes.SelectedRows[0].Cells["nome"].Value.ToString();
            txtCpf.Text = dtGrvClientes.SelectedRows[0].Cells["cpf"].Value.ToString();
            txtSexo.Text = dtGrvClientes.SelectedRows[0].Cells["sexo"].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            lblFiltrar.Visible = false;
            txtFiltro.Visible = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            gpbPesquisa.Visible = !gpbPesquisa.Visible;
            rdbTodos.Checked = true;
        }

        private void rdbId_CheckedChanged(object sender, EventArgs e)
        {
            txtFiltro.Clear();
            lblFiltrar.Text = "Digite o Id: ";
            lblFiltrar.Visible = true;
            txtFiltro.Visible = true;
            txtFiltro.Focus();
        }

     

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            txtFiltro.Clear();
            lblFiltrar.Text = "Digite o Nome: ";
            lblFiltrar.Visible = true;
            txtFiltro.Visible = true;
            txtFiltro.Focus();
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.Clientes bllCliente = new CAMADAS.BLL.Clientes();
            List<CAMADAS.MODEL.Clientes> lstClientes = new List<CAMADAS.MODEL.Clientes>();

            if (rdbTodos.Checked)
            {
                lstClientes = bllCliente.Select();
            }
            else if (rdbId.Checked)
            {
                int id = Convert.ToInt32(txtFiltro.Text);
                lstClientes = bllCliente.SelectById(id);
            }
            else if (rdbNome.Checked)
            {
                lstClientes = bllCliente.SelectByNome(txtFiltro.Text);
            }
            else if (rdbCPF.Checked)
            {
                lstClientes = bllCliente.SelectByCPF(txtFiltro.Text);
            }
            dtGrvClientes.DataSource = "";
            dtGrvClientes.DataSource = lstClientes;
        }

        private void rdbCPF_CheckedChanged(object sender, EventArgs e)
        {
            txtFiltro.Clear();
            lblFiltrar.Text = "Digite o CPF: ";
            lblFiltrar.Visible = true;
            txtFiltro.Visible = true;
            txtFiltro.Focus();
        }
    }
}
