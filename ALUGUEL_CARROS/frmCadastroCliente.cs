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
            CAMADAS.DAL.Clientes dalCli = new CAMADAS.DAL.Clientes();
            dtGrvClientes.DataSource = dalCli.Select();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //criando objeto cliente
            CAMADAS.MODEL.Clientes cliente = new CAMADAS.MODEL.Clientes();
            cliente.nome = txtNome.Text;
            cliente.cpf = txtCpf.Text;
            cliente.sexo = txtSexo.Text;

            //criando objeto dalCliente para inserir dados
            CAMADAS.DAL.Clientes dalCliente = new CAMADAS.DAL.Clientes();
            dalCliente.Insert(cliente);

            //atualizando dataGridView
            dtGrvClientes.DataSource = "";
            dtGrvClientes.DataSource = dalCliente.Select();

            //limpando campos txts
            txtNome.Clear();
            txtCpf.Clear();
            txtSexo.Clear();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //criando objeto cliente
            CAMADAS.MODEL.Clientes cliente = new CAMADAS.MODEL.Clientes();
            cliente.id = Convert.ToInt32(txtId.Text);
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
            txtId.Clear();
            txtNome.Clear();
            txtCpf.Clear();
            txtSexo.Clear();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //buscando id
            int idCli = Convert.ToInt32(txtId.Text);

            //criando obj Cliente
            CAMADAS.DAL.Clientes dalCliente = new CAMADAS.DAL.Clientes();
            dalCliente.Delete(idCli);

            //carregando dtgrv
            dtGrvClientes.DataSource = "";
            dtGrvClientes.DataSource = dalCliente.Select();

            //limpando txtId
            txtId.Clear();

        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            
        }

       
    }
}
