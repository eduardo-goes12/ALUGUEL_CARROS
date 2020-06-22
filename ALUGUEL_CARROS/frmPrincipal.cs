using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ALUGUEL_CARROS.CAMADAS.Relatorios;


namespace ALUGUEL_CARROS
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void limparCamposAluguel()
        {
            lblIdAluguel.Text = "-1";

        }
        
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CAMADAS.BLL.Aluguel bllAlu = new CAMADAS.BLL.Aluguel();
            

            CAMADAS.DAL.Clientes dalCli = new CAMADAS.DAL.Clientes();
            cmbCliente.DisplayMember = "nome";
            cmbCliente.ValueMember = "id";
            cmbCliente.DataSource = dalCli.Select();

            CAMADAS.DAL.Carros dalCar = new CAMADAS.DAL.Carros();
            cmbCarro.DisplayMember = "modelo";
            cmbCarro.ValueMember = "id";
            cmbCarro.DataSource = dalCar.Select();

            dtGvAluguel.DataSource = bllAlu.Select();
        }

        

        private void btnCadastarCli_Click(object sender, EventArgs e)
        {
            frmCadastroCli frmCli = new frmCadastroCli();            
            frmCli.Show();

        }

        private void btnCadastrarCarro_Click(object sender, EventArgs e)
        {
            frmCadastroCarros frmCar = new frmCadastroCarros();            
            frmCar.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbmCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtClienteId.Text = cmbCliente.SelectedValue.ToString();
        }

        private void cmbCarro_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCarroId.Text = cmbCarro.SelectedValue.ToString();
        }

        private void txtClienteId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cmbCliente.SelectedValue = Convert.ToInt32(txtClienteId.Text);
            }
            catch
            {
                MessageBox.Show("Cliente não existe");
                txtClienteId.Focus();
            }
        }



        private void txtCarroId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cmbCarro.SelectedValue = Convert.ToInt32(txtCarroId.Text);
            }
            catch
            {
                MessageBox.Show("Carro não existe");
                txtCarroId.Focus();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            limparCamposAluguel();
            cmbCliente.Focus();
        }        

        private void btnGravar_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Aluguel aluguel = new CAMADAS.MODEL.Aluguel();
            CAMADAS.MODEL.Carros carro = new CAMADAS.MODEL.Carros();

            aluguel.id = Convert.ToInt32(lblIdAluguel.Text);
            aluguel.clienteID = Convert.ToInt32(cmbCliente.SelectedValue.ToString());
            aluguel.nome = cmbCliente.Text;
            aluguel.carroID = Convert.ToInt32(cmbCarro.SelectedValue.ToString());
            aluguel.modelo = cmbCarro.Text;

            CAMADAS.BLL.Aluguel bllAlu = new CAMADAS.BLL.Aluguel();
            int idC = Convert.ToInt32(txtClienteId.Text);
            int idCr = Convert.ToInt32(txtCarroId.Text);

            CAMADAS.MODEL.Aluguel aluguel1 = bllAlu.BuscaCliente(idC);
            CAMADAS.MODEL.Aluguel aluguel2 = bllAlu.BuscaCarro(idCr);


            if (lblIdAluguel.Text == "-1")
            {
                if (aluguel1.clienteID == idC)
                {
                    MessageBox.Show("Cliente ja possui aluguel");
                }
                    else if (aluguel2.carroID == idCr)
                    {
                    MessageBox.Show("Carro não esta Disponivel");
                    }
                    else
                    {
                    bllAlu.Insert(aluguel);
                    }
                 
            }
            else
            {
                bllAlu.Update(aluguel); 
            }
            dtGvAluguel.DataSource = "";
            dtGvAluguel.DataSource = bllAlu.Select();            


        }
        private void dtGvAluguel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtGvAluguel_DoubleClick(object sender, EventArgs e)
        {
            lblIdAluguel.Text = dtGvAluguel.SelectedRows[0].Cells["id"].Value.ToString();
            txtClienteId.Text = dtGvAluguel.SelectedRows[0].Cells["clienteID"].Value.ToString();
            txtCarroId.Text = dtGvAluguel.SelectedRows[0].Cells["carroID"].Value.ToString();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (lblIdAluguel.Text != "-1")
            {
                
                
            }
            else
            {
                MessageBox.Show("Não há aluguel selecionado");
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Aluguel aluguel = new CAMADAS.MODEL.Aluguel();
            CAMADAS.BLL.Aluguel bllAlu = new CAMADAS.BLL.Aluguel();

            if(lblIdAluguel.Text != "-1")
            {
                bllAlu.Delete(Convert.ToInt32(lblIdAluguel.Text));
                dtGvAluguel.DataSource = "";
                dtGvAluguel.DataSource = bllAlu.Select();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CAMADAS.DAL.Clientes dalCli = new CAMADAS.DAL.Clientes();
            cmbCliente.DisplayMember = "nome";
            cmbCliente.ValueMember = "id";
            cmbCliente.DataSource = dalCli.Select();
            CAMADAS.DAL.Carros dalCar = new CAMADAS.DAL.Carros();
            cmbCarro.DisplayMember = "modelo";
            cmbCarro.ValueMember = "id";
            cmbCarro.DataSource = dalCar.Select();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
