namespace ALUGUEL_CARROS
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbCarro = new System.Windows.Forms.ComboBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.lblCarro = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.dtGvAluguel = new System.Windows.Forms.DataGridView();
            this.txtClienteId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCarroId = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnCadastarCli = new System.Windows.Forms.Button();
            this.btnCadastrarCarro = new System.Windows.Forms.Button();
            this.lblIdAluguel = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGvAluguel)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCarro
            // 
            this.cmbCarro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            this.cmbCarro.ForeColor = System.Drawing.Color.SpringGreen;
            this.cmbCarro.FormattingEnabled = true;
            this.cmbCarro.Location = new System.Drawing.Point(250, 138);
            this.cmbCarro.Name = "cmbCarro";
            this.cmbCarro.Size = new System.Drawing.Size(311, 21);
            this.cmbCarro.TabIndex = 4;
            this.cmbCarro.SelectedIndexChanged += new System.EventHandler(this.cmbCarro_SelectedIndexChanged);
            // 
            // cmbCliente
            // 
            this.cmbCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            this.cmbCliente.ForeColor = System.Drawing.Color.SpringGreen;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(250, 107);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(311, 21);
            this.cmbCliente.TabIndex = 3;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cbmCliente_SelectedIndexChanged);
            // 
            // lblCarro
            // 
            this.lblCarro.AutoSize = true;
            this.lblCarro.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblCarro.Location = new System.Drawing.Point(175, 138);
            this.lblCarro.Name = "lblCarro";
            this.lblCarro.Size = new System.Drawing.Size(32, 13);
            this.lblCarro.TabIndex = 8;
            this.lblCarro.Text = "Carro";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblCliente.Location = new System.Drawing.Point(175, 115);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 7;
            this.lblCliente.Text = "Cliente";
            // 
            // dtGvAluguel
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.SpringGreen;
            this.dtGvAluguel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGvAluguel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            this.dtGvAluguel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtGvAluguel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGvAluguel.Location = new System.Drawing.Point(178, 273);
            this.dtGvAluguel.Name = "dtGvAluguel";
            this.dtGvAluguel.RowHeadersWidth = 51;
            this.dtGvAluguel.Size = new System.Drawing.Size(715, 150);
            this.dtGvAluguel.TabIndex = 0;
            this.dtGvAluguel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGvAluguel_CellContentClick);
            this.dtGvAluguel.DoubleClick += new System.EventHandler(this.dtGvAluguel_DoubleClick);
            // 
            // txtClienteId
            // 
            this.txtClienteId.Location = new System.Drawing.Point(583, 107);
            this.txtClienteId.Name = "txtClienteId";
            this.txtClienteId.ReadOnly = true;
            this.txtClienteId.Size = new System.Drawing.Size(100, 20);
            this.txtClienteId.TabIndex = 10;
            this.txtClienteId.TextChanged += new System.EventHandler(this.txtClienteId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(175, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Aluguel Id:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnAdd.Image = global::ALUGUEL_CARROS.Properties.Resources.profile_plus_1354;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(178, 196);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 51);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCarroId
            // 
            this.txtCarroId.Location = new System.Drawing.Point(583, 139);
            this.txtCarroId.Name = "txtCarroId";
            this.txtCarroId.ReadOnly = true;
            this.txtCarroId.Size = new System.Drawing.Size(100, 20);
            this.txtCarroId.TabIndex = 11;
            this.txtCarroId.TextChanged += new System.EventHandler(this.txtCarroId_TextChanged);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(720, 225);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 14;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnRemover.Image = global::ALUGUEL_CARROS.Properties.Resources.delete;
            this.btnRemover.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRemover.Location = new System.Drawing.Point(284, 196);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(90, 51);
            this.btnRemover.TabIndex = 5;
            this.btnRemover.Text = "Remover";
            this.btnRemover.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnCadastarCli
            // 
            this.btnCadastarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastarCli.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnCadastarCli.Location = new System.Drawing.Point(396, 196);
            this.btnCadastarCli.Name = "btnCadastarCli";
            this.btnCadastarCli.Size = new System.Drawing.Size(90, 51);
            this.btnCadastarCli.TabIndex = 2;
            this.btnCadastarCli.Text = "Cadastrar Cliente";
            this.btnCadastarCli.UseVisualStyleBackColor = true;
            this.btnCadastarCli.Click += new System.EventHandler(this.btnCadastarCli_Click);
            // 
            // btnCadastrarCarro
            // 
            this.btnCadastrarCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarCarro.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnCadastrarCarro.Location = new System.Drawing.Point(505, 196);
            this.btnCadastrarCarro.Name = "btnCadastrarCarro";
            this.btnCadastrarCarro.Size = new System.Drawing.Size(90, 51);
            this.btnCadastrarCarro.TabIndex = 1;
            this.btnCadastrarCarro.Text = "Cadastrar Carro";
            this.btnCadastrarCarro.UseVisualStyleBackColor = true;
            this.btnCadastrarCarro.Click += new System.EventHandler(this.btnCadastrarCarro_Click);
            // 
            // lblIdAluguel
            // 
            this.lblIdAluguel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblIdAluguel.Location = new System.Drawing.Point(247, 78);
            this.lblIdAluguel.Name = "lblIdAluguel";
            this.lblIdAluguel.Size = new System.Drawing.Size(100, 23);
            this.lblIdAluguel.TabIndex = 13;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(720, 196);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(762, 88);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 15;
            this.btnAtualizar.Text = "&Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1007, 578);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblIdAluguel);
            this.Controls.Add(this.dtGvAluguel);
            this.Controls.Add(this.btnCadastrarCarro);
            this.Controls.Add(this.cmbCarro);
            this.Controls.Add(this.btnCadastarCli);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.lblCarro);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtCarroId);
            this.Controls.Add(this.txtClienteId);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGvAluguel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCarro;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lblCarro;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.DataGridView dtGvAluguel;
        private System.Windows.Forms.TextBox txtClienteId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCarroId;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnCadastarCli;
        private System.Windows.Forms.Button btnCadastrarCarro;
        private System.Windows.Forms.Label lblIdAluguel;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAtualizar;
    }
}