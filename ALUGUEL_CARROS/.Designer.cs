namespace ALUGUEL_CARROS
{
    partial class frmCadastroCarros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblChassi = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtChassi = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.dtGrvCarro = new System.Windows.Forms.DataGridView();
            this.gpbPesquisa = new System.Windows.Forms.GroupBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.rdbId = new System.Windows.Forms.RadioButton();
            this.rdbModelo = new System.Windows.Forms.RadioButton();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrvCarro)).BeginInit();
            this.gpbPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SpringGreen;
            this.label1.Location = new System.Drawing.Point(196, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblModelo.Location = new System.Drawing.Point(164, 74);
            this.lblModelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(79, 24);
            this.lblModelo.TabIndex = 1;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblMarca.Location = new System.Drawing.Point(171, 122);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(67, 24);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca:";
            // 
            // lblChassi
            // 
            this.lblChassi.AutoSize = true;
            this.lblChassi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChassi.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblChassi.Location = new System.Drawing.Point(169, 170);
            this.lblChassi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChassi.Name = "lblChassi";
            this.lblChassi.Size = new System.Drawing.Size(71, 24);
            this.lblChassi.TabIndex = 3;
            this.lblChassi.Text = "Chassi:";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblAno.Location = new System.Drawing.Point(185, 218);
            this.lblAno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(50, 24);
            this.lblAno.TabIndex = 4;
            this.lblAno.Text = "Ano:";
            this.lblAno.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblPlaca.Location = new System.Drawing.Point(175, 266);
            this.lblPlaca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(61, 24);
            this.lblPlaca.TabIndex = 5;
            this.lblPlaca.Text = "Placa:";
            // 
            // lblId
            // 
            this.lblId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblId.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblId.Location = new System.Drawing.Point(267, 26);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(47, 25);
            this.lblId.TabIndex = 7;
            this.lblId.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtModelo
            // 
            this.txtModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            this.txtModelo.ForeColor = System.Drawing.Color.SpringGreen;
            this.txtModelo.Location = new System.Drawing.Point(271, 68);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(4);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(275, 22);
            this.txtModelo.TabIndex = 1;
            // 
            // txtAno
            // 
            this.txtAno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            this.txtAno.ForeColor = System.Drawing.Color.SpringGreen;
            this.txtAno.Location = new System.Drawing.Point(269, 213);
            this.txtAno.Margin = new System.Windows.Forms.Padding(4);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(276, 22);
            this.txtAno.TabIndex = 4;
            // 
            // txtChassi
            // 
            this.txtChassi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            this.txtChassi.ForeColor = System.Drawing.Color.SpringGreen;
            this.txtChassi.Location = new System.Drawing.Point(271, 167);
            this.txtChassi.Margin = new System.Windows.Forms.Padding(4);
            this.txtChassi.Name = "txtChassi";
            this.txtChassi.Size = new System.Drawing.Size(275, 22);
            this.txtChassi.TabIndex = 3;
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            this.txtMarca.ForeColor = System.Drawing.Color.SpringGreen;
            this.txtMarca.Location = new System.Drawing.Point(269, 117);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(276, 22);
            this.txtMarca.TabIndex = 2;
            // 
            // txtPlaca
            // 
            this.txtPlaca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            this.txtPlaca.ForeColor = System.Drawing.Color.SpringGreen;
            this.txtPlaca.Location = new System.Drawing.Point(269, 261);
            this.txtPlaca.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(276, 22);
            this.txtPlaca.TabIndex = 5;
            // 
            // dtGrvCarro
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.SpringGreen;
            this.dtGrvCarro.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGrvCarro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGrvCarro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtGrvCarro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGrvCarro.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtGrvCarro.Location = new System.Drawing.Point(131, 478);
            this.dtGrvCarro.Margin = new System.Windows.Forms.Padding(4);
            this.dtGrvCarro.Name = "dtGrvCarro";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGrvCarro.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtGrvCarro.RowHeadersWidth = 51;
            this.dtGrvCarro.Size = new System.Drawing.Size(981, 185);
            this.dtGrvCarro.TabIndex = 20;
            this.dtGrvCarro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrvCadastroCarro_CellContentClick);
            this.dtGrvCarro.DoubleClick += new System.EventHandler(this.dtGrvCarro_DoubleClick);
            // 
            // gpbPesquisa
            // 
            this.gpbPesquisa.Controls.Add(this.btnFiltro);
            this.gpbPesquisa.Controls.Add(this.txtFiltro);
            this.gpbPesquisa.Controls.Add(this.lblFiltrar);
            this.gpbPesquisa.Controls.Add(this.rdbTodos);
            this.gpbPesquisa.Controls.Add(this.rdbId);
            this.gpbPesquisa.Controls.Add(this.rdbModelo);
            this.gpbPesquisa.ForeColor = System.Drawing.Color.SpringGreen;
            this.gpbPesquisa.Location = new System.Drawing.Point(695, 74);
            this.gpbPesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.gpbPesquisa.Name = "gpbPesquisa";
            this.gpbPesquisa.Padding = new System.Windows.Forms.Padding(4);
            this.gpbPesquisa.Size = new System.Drawing.Size(417, 256);
            this.gpbPesquisa.TabIndex = 21;
            this.gpbPesquisa.TabStop = false;
            this.gpbPesquisa.Text = "Pesquisa";
            this.gpbPesquisa.Visible = false;
            // 
            // btnFiltro
            // 
            this.btnFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltro.Image = global::ALUGUEL_CARROS.Properties.Resources.filtro;
            this.btnFiltro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltro.Location = new System.Drawing.Point(307, 215);
            this.btnFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(100, 28);
            this.btnFiltro.TabIndex = 5;
            this.btnFiltro.Text = "&Filtrar";
            this.btnFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            this.txtFiltro.ForeColor = System.Drawing.Color.SpringGreen;
            this.txtFiltro.Location = new System.Drawing.Point(32, 164);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(361, 22);
            this.txtFiltro.TabIndex = 4;
            this.txtFiltro.Visible = false;
            this.txtFiltro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.Location = new System.Drawing.Point(28, 121);
            this.lblFiltrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(289, 28);
            this.lblFiltrar.TabIndex = 3;
            this.lblFiltrar.Visible = false;
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Checked = true;
            this.rdbTodos.ForeColor = System.Drawing.Color.SpringGreen;
            this.rdbTodos.Location = new System.Drawing.Point(28, 23);
            this.rdbTodos.Margin = new System.Windows.Forms.Padding(4);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(69, 21);
            this.rdbTodos.TabIndex = 2;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "&Todos";
            this.rdbTodos.UseVisualStyleBackColor = true;
            this.rdbTodos.CheckedChanged += new System.EventHandler(this.rdbTodos_CheckedChanged);
            // 
            // rdbId
            // 
            this.rdbId.AutoSize = true;
            this.rdbId.ForeColor = System.Drawing.Color.SpringGreen;
            this.rdbId.Location = new System.Drawing.Point(28, 54);
            this.rdbId.Margin = new System.Windows.Forms.Padding(4);
            this.rdbId.Name = "rdbId";
            this.rdbId.Size = new System.Drawing.Size(42, 21);
            this.rdbId.TabIndex = 1;
            this.rdbId.Text = "&ID";
            this.rdbId.UseVisualStyleBackColor = true;
            this.rdbId.CheckedChanged += new System.EventHandler(this.rdbId_CheckedChanged);
            // 
            // rdbModelo
            // 
            this.rdbModelo.AutoSize = true;
            this.rdbModelo.ForeColor = System.Drawing.Color.SpringGreen;
            this.rdbModelo.Location = new System.Drawing.Point(28, 82);
            this.rdbModelo.Margin = new System.Windows.Forms.Padding(4);
            this.rdbModelo.Name = "rdbModelo";
            this.rdbModelo.Size = new System.Drawing.Size(75, 21);
            this.rdbModelo.TabIndex = 0;
            this.rdbModelo.Text = "&Modelo";
            this.rdbModelo.UseVisualStyleBackColor = true;
            this.rdbModelo.CheckedChanged += new System.EventHandler(this.rdbModelo_CheckedChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnPesquisar.Image = global::ALUGUEL_CARROS.Properties.Resources.pesquisa;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPesquisar.Location = new System.Drawing.Point(893, 386);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(165, 55);
            this.btnPesquisar.TabIndex = 22;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnVoltar.Image = global::ALUGUEL_CARROS.Properties.Resources.left;
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVoltar.Location = new System.Drawing.Point(695, 386);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(80, 53);
            this.btnVoltar.TabIndex = 12;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravar.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnGravar.Image = global::ALUGUEL_CARROS.Properties.Resources.place;
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGravar.Location = new System.Drawing.Point(595, 386);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(80, 54);
            this.btnGravar.TabIndex = 11;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnCancelar.Image = global::ALUGUEL_CARROS.Properties.Resources.X;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(497, 386);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 54);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnEditar.Image = global::ALUGUEL_CARROS.Properties.Resources.edit;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.Location = new System.Drawing.Point(269, 386);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(81, 55);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnRemover.Image = global::ALUGUEL_CARROS.Properties.Resources.delete;
            this.btnRemover.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRemover.Location = new System.Drawing.Point(384, 386);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(80, 55);
            this.btnRemover.TabIndex = 9;
            this.btnRemover.Text = "&Remover";
            this.btnRemover.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnAdd.Image = global::ALUGUEL_CARROS.Properties.Resources.profile_plus_1354;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(157, 386);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 54);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "&Adicionar";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.SpringGreen;
            this.button1.Image = global::ALUGUEL_CARROS.Properties.Resources.tab;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(794, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 54);
            this.button1.TabIndex = 23;
            this.button1.Text = "Relatorio";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCadastroCarros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1355, 734);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.gpbPesquisa);
            this.Controls.Add(this.dtGrvCarro);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtChassi);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblChassi);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCadastroCarros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FrmCarros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrvCarro)).EndInit();
            this.gpbPesquisa.ResumeLayout(false);
            this.gpbPesquisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblChassi;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.TextBox txtChassi;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dtGrvCarro;
        private System.Windows.Forms.GroupBox gpbPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.RadioButton rdbId;
        private System.Windows.Forms.RadioButton rdbModelo;
        private System.Windows.Forms.Button button1;
    }
}