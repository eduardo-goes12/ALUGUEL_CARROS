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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbCarro = new System.Windows.Forms.ComboBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.lblCarro = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.dtGvAluguel = new System.Windows.Forms.DataGridView();
            this.txtClienteId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCarroId = new System.Windows.Forms.TextBox();
            this.lblIdAluguel = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCadastrarCarro = new System.Windows.Forms.Button();
            this.btnCadastarCli = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGvAluguel)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCarro
            // 
            this.cmbCarro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            this.cmbCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCarro.ForeColor = System.Drawing.Color.SpringGreen;
            this.cmbCarro.FormattingEnabled = true;
            this.cmbCarro.Location = new System.Drawing.Point(333, 170);
            this.cmbCarro.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCarro.Name = "cmbCarro";
            this.cmbCarro.Size = new System.Drawing.Size(413, 24);
            this.cmbCarro.TabIndex = 4;
            this.cmbCarro.SelectedIndexChanged += new System.EventHandler(this.cmbCarro_SelectedIndexChanged);
            // 
            // cmbCliente
            // 
            this.cmbCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            this.cmbCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCliente.ForeColor = System.Drawing.Color.SpringGreen;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(333, 132);
            this.cmbCliente.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(413, 24);
            this.cmbCliente.TabIndex = 3;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cbmCliente_SelectedIndexChanged);
            // 
            // lblCarro
            // 
            this.lblCarro.AutoSize = true;
            this.lblCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarro.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblCarro.Location = new System.Drawing.Point(233, 170);
            this.lblCarro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarro.Name = "lblCarro";
            this.lblCarro.Size = new System.Drawing.Size(61, 24);
            this.lblCarro.TabIndex = 8;
            this.lblCarro.Text = "Carro:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblCliente.Location = new System.Drawing.Point(233, 142);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(73, 24);
            this.lblCliente.TabIndex = 7;
            this.lblCliente.Text = "Cliente:";
            // 
            // dtGvAluguel
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.SpringGreen;
            this.dtGvAluguel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtGvAluguel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            this.dtGvAluguel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGvAluguel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtGvAluguel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGvAluguel.DefaultCellStyle = dataGridViewCellStyle7;
            this.dtGvAluguel.Location = new System.Drawing.Point(292, 337);
            this.dtGvAluguel.Margin = new System.Windows.Forms.Padding(4);
            this.dtGvAluguel.Name = "dtGvAluguel";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGvAluguel.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtGvAluguel.RowHeadersWidth = 51;
            this.dtGvAluguel.Size = new System.Drawing.Size(733, 185);
            this.dtGvAluguel.TabIndex = 0;
            this.dtGvAluguel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGvAluguel_CellContentClick);
            this.dtGvAluguel.DoubleClick += new System.EventHandler(this.dtGvAluguel_DoubleClick);
            // 
            // txtClienteId
            // 
            this.txtClienteId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            this.txtClienteId.ForeColor = System.Drawing.Color.SpringGreen;
            this.txtClienteId.Location = new System.Drawing.Point(777, 132);
            this.txtClienteId.Margin = new System.Windows.Forms.Padding(4);
            this.txtClienteId.Name = "txtClienteId";
            this.txtClienteId.ReadOnly = true;
            this.txtClienteId.Size = new System.Drawing.Size(132, 22);
            this.txtClienteId.TabIndex = 10;
            this.txtClienteId.TextChanged += new System.EventHandler(this.txtClienteId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SpringGreen;
            this.label1.Location = new System.Drawing.Point(233, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Aluguel ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCarroId
            // 
            this.txtCarroId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            this.txtCarroId.ForeColor = System.Drawing.Color.SpringGreen;
            this.txtCarroId.Location = new System.Drawing.Point(777, 171);
            this.txtCarroId.Margin = new System.Windows.Forms.Padding(4);
            this.txtCarroId.Name = "txtCarroId";
            this.txtCarroId.ReadOnly = true;
            this.txtCarroId.Size = new System.Drawing.Size(132, 22);
            this.txtCarroId.TabIndex = 11;
            this.txtCarroId.TextChanged += new System.EventHandler(this.txtCarroId_TextChanged);
            // 
            // lblIdAluguel
            // 
            this.lblIdAluguel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblIdAluguel.Location = new System.Drawing.Point(329, 96);
            this.lblIdAluguel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdAluguel.Name = "lblIdAluguel";
            this.lblIdAluguel.Size = new System.Drawing.Size(133, 28);
            this.lblIdAluguel.TabIndex = 13;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnAtualizar.Image = global::ALUGUEL_CARROS.Properties.Resources.arrow_repeat_242;
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAtualizar.Location = new System.Drawing.Point(979, 122);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(120, 65);
            this.btnAtualizar.TabIndex = 15;
            this.btnAtualizar.Text = "&Atualizar";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnSair.Image = global::ALUGUEL_CARROS.Properties.Resources.X;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(979, 242);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(120, 64);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCadastrarCarro
            // 
            this.btnCadastrarCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCarro.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnCadastrarCarro.Image = global::ALUGUEL_CARROS.Properties.Resources.car_640;
            this.btnCadastrarCarro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastrarCarro.Location = new System.Drawing.Point(689, 241);
            this.btnCadastrarCarro.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastrarCarro.Name = "btnCadastrarCarro";
            this.btnCadastrarCarro.Size = new System.Drawing.Size(120, 63);
            this.btnCadastrarCarro.TabIndex = 1;
            this.btnCadastrarCarro.Text = "Cadastrar Carro";
            this.btnCadastrarCarro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrarCarro.UseVisualStyleBackColor = true;
            this.btnCadastrarCarro.Click += new System.EventHandler(this.btnCadastrarCarro_Click);
            // 
            // btnCadastarCli
            // 
            this.btnCadastarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastarCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastarCli.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnCadastarCli.Image = global::ALUGUEL_CARROS.Properties.Resources.profile_1341;
            this.btnCadastarCli.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastarCli.Location = new System.Drawing.Point(539, 242);
            this.btnCadastarCli.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastarCli.Name = "btnCadastarCli";
            this.btnCadastarCli.Size = new System.Drawing.Size(120, 63);
            this.btnCadastarCli.TabIndex = 2;
            this.btnCadastarCli.Text = "Cadastrar Cliente";
            this.btnCadastarCli.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastarCli.UseVisualStyleBackColor = true;
            this.btnCadastarCli.Click += new System.EventHandler(this.btnCadastarCli_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnRemover.Image = global::ALUGUEL_CARROS.Properties.Resources.delete;
            this.btnRemover.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRemover.Location = new System.Drawing.Point(393, 241);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(120, 63);
            this.btnRemover.TabIndex = 5;
            this.btnRemover.Text = "Remover";
            this.btnRemover.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnGravar.Image = global::ALUGUEL_CARROS.Properties.Resources.place;
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGravar.Location = new System.Drawing.Point(831, 241);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(120, 64);
            this.btnGravar.TabIndex = 14;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnAdd.Image = global::ALUGUEL_CARROS.Properties.Resources.profile_plus_1354;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(247, 241);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 63);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1343, 711);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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