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
        private void FrmCarros_Load(object sender, EventArgs e)
        {
            controlesOnOff(false);
            btnOnOff(true);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            controlesOnOff(true);
            btnOnOff(false);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlesOnOff(true);
            btnOnOff(false);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            controlesOnOff(false);
            btnOnOff(false);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            controlesOnOff(false);
            btnOnOff(true);
        }
    }
}
