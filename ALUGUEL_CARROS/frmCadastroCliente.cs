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
            //criando objeto cliente
            CAMADAS.MODEL.Clientes cliente = new CAMADAS.MODEL.Clientes();
            //cliente.id = Convert.ToInt32(txtId.Text);
            cliente.nome = txtNome.Text;
            cliente.cpf = txtCpf.Text;
            cliente.sexo = txtSexo.Text;

            //criando objeto dalCliente para att dados
            CAMADAS.DAL.Clientes dalCliente = new CAMADAS.DAL.Clientes();
            dalCliente.Update(cliente);

            //atualizando dataGridView
            dtGrvClientes.DataSource = "";
            dtGrvClientes.DataSource = dalCliente.Select();

            //limpando campos txts
            //txtId.Clear();
            txtNome.Clear();
            txtCpf.Clear();
            txtSexo.Clear();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //buscando id
            //int idCli = Convert.ToInt32(txtId.Text);

            //criando obj Cliente
            CAMADAS.DAL.Clientes dalCliente = new CAMADAS.DAL.Clientes();
            //bllCli.Delete(idCli);

            //carregando dtgrv
            dtGrvClientes.DataSource = "";
            dtGrvClientes.DataSource = dalCliente.Select();

            //limpando txtId
            //txtId.Clear();

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
    }
}
