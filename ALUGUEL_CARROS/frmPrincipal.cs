﻿using System;
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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        

        private void btnCadastarCli_Click(object sender, EventArgs e)
        {
            new frmCadastroCli().Show();

        }

        private void btnCadastrarCarro_Click(object sender, EventArgs e)
        {
            new frmCadastroCarros().Show();
        }
    }
}
