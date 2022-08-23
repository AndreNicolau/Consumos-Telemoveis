namespace Consumos_Telemóveis
{
    partial class Consumos
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
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbNovo = new System.Windows.Forms.ToolStripButton();
            this.tsbSalvar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idConsumoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTelemovelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroTelemovelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumoMinutosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumoDadosMoveisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbConsumosTelemoveisDataSet = new Consumos_Telemóveis.DbConsumosTelemoveisDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdConsumo = new System.Windows.Forms.TextBox();
            this.txtIdTelemovel = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtConsumoMinutos = new System.Windows.Forms.TextBox();
            this.txtConsumoDadosMoveis = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLimiteConsumoMinutos = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLimiteConsumoDadosMoveis = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEnviarEmail = new System.Windows.Forms.Button();
            this.consumosTableAdapter = new Consumos_Telemóveis.DbConsumosTelemoveisDataSetTableAdapters.consumosTableAdapter();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConsumosTelemoveisDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbEditar,
            this.tsbNovo,
            this.tsbSalvar,
            this.tsbEliminar,
            this.tsbCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1184, 38);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = global::Consumos_Telemóveis.Properties.Resources.edit;
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Margin = new System.Windows.Forms.Padding(5);
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(28, 28);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // tsbNovo
            // 
            this.tsbNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNovo.Image = global::Consumos_Telemóveis.Properties.Resources.add_file;
            this.tsbNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNovo.Margin = new System.Windows.Forms.Padding(5);
            this.tsbNovo.Name = "tsbNovo";
            this.tsbNovo.Size = new System.Drawing.Size(28, 28);
            this.tsbNovo.Text = "Novo";
            this.tsbNovo.Click += new System.EventHandler(this.tsbNovo_Click);
            // 
            // tsbSalvar
            // 
            this.tsbSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSalvar.Enabled = false;
            this.tsbSalvar.Image = global::Consumos_Telemóveis.Properties.Resources.save;
            this.tsbSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalvar.Margin = new System.Windows.Forms.Padding(5);
            this.tsbSalvar.Name = "tsbSalvar";
            this.tsbSalvar.Size = new System.Drawing.Size(28, 28);
            this.tsbSalvar.Text = "Salvar";
            this.tsbSalvar.Click += new System.EventHandler(this.tsbSalvar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Enabled = false;
            this.tsbEliminar.Image = global::Consumos_Telemóveis.Properties.Resources.delete;
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Margin = new System.Windows.Forms.Padding(5);
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(28, 28);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCancelar.Enabled = false;
            this.tsbCancelar.Image = global::Consumos_Telemóveis.Properties.Resources.cancel;
            this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(28, 35);
            this.tsbCancelar.Text = "Cancelar";
            this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idConsumoDataGridViewTextBoxColumn,
            this.idTelemovelDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.numeroTelemovelDataGridViewTextBoxColumn,
            this.mesDataGridViewTextBoxColumn,
            this.consumoMinutosDataGridViewTextBoxColumn,
            this.consumoDadosMoveisDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.consumosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 237);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // idConsumoDataGridViewTextBoxColumn
            // 
            this.idConsumoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idConsumoDataGridViewTextBoxColumn.DataPropertyName = "IdConsumo";
            this.idConsumoDataGridViewTextBoxColumn.HeaderText = "Id Consumo";
            this.idConsumoDataGridViewTextBoxColumn.Name = "idConsumoDataGridViewTextBoxColumn";
            this.idConsumoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idTelemovelDataGridViewTextBoxColumn
            // 
            this.idTelemovelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idTelemovelDataGridViewTextBoxColumn.DataPropertyName = "IdTelemovel";
            this.idTelemovelDataGridViewTextBoxColumn.FillWeight = 445.3608F;
            this.idTelemovelDataGridViewTextBoxColumn.HeaderText = "Id Telemovel";
            this.idTelemovelDataGridViewTextBoxColumn.Name = "idTelemovelDataGridViewTextBoxColumn";
            this.idTelemovelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.FillWeight = 30.92783F;
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroTelemovelDataGridViewTextBoxColumn
            // 
            this.numeroTelemovelDataGridViewTextBoxColumn.DataPropertyName = "numeroTelemovel";
            this.numeroTelemovelDataGridViewTextBoxColumn.FillWeight = 30.92783F;
            this.numeroTelemovelDataGridViewTextBoxColumn.HeaderText = "Número Telemóvel";
            this.numeroTelemovelDataGridViewTextBoxColumn.Name = "numeroTelemovelDataGridViewTextBoxColumn";
            this.numeroTelemovelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mesDataGridViewTextBoxColumn
            // 
            this.mesDataGridViewTextBoxColumn.DataPropertyName = "mes";
            this.mesDataGridViewTextBoxColumn.FillWeight = 30.92783F;
            this.mesDataGridViewTextBoxColumn.HeaderText = "Mês";
            this.mesDataGridViewTextBoxColumn.Name = "mesDataGridViewTextBoxColumn";
            this.mesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // consumoMinutosDataGridViewTextBoxColumn
            // 
            this.consumoMinutosDataGridViewTextBoxColumn.DataPropertyName = "consumoMinutos";
            this.consumoMinutosDataGridViewTextBoxColumn.FillWeight = 30.92783F;
            this.consumoMinutosDataGridViewTextBoxColumn.HeaderText = "Consumo Minutos";
            this.consumoMinutosDataGridViewTextBoxColumn.Name = "consumoMinutosDataGridViewTextBoxColumn";
            this.consumoMinutosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // consumoDadosMoveisDataGridViewTextBoxColumn
            // 
            this.consumoDadosMoveisDataGridViewTextBoxColumn.DataPropertyName = "consumoDadosMoveis";
            this.consumoDadosMoveisDataGridViewTextBoxColumn.FillWeight = 30.92783F;
            this.consumoDadosMoveisDataGridViewTextBoxColumn.HeaderText = "Consumo Dados Móveis";
            this.consumoDadosMoveisDataGridViewTextBoxColumn.Name = "consumoDadosMoveisDataGridViewTextBoxColumn";
            this.consumoDadosMoveisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // consumosBindingSource
            // 
            this.consumosBindingSource.DataMember = "consumos";
            this.consumosBindingSource.DataSource = this.dbConsumosTelemoveisDataSet;
            // 
            // dbConsumosTelemoveisDataSet
            // 
            this.dbConsumosTelemoveisDataSet.DataSetName = "DbConsumosTelemoveisDataSet";
            this.dbConsumosTelemoveisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id Consumo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Id Telemovel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Número Telemóvel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mês";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Consumo Minutos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Consumo Dados Móveis";
            // 
            // txtIdConsumo
            // 
            this.txtIdConsumo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consumosBindingSource, "IdConsumo", true));
            this.txtIdConsumo.Enabled = false;
            this.txtIdConsumo.Location = new System.Drawing.Point(6, 45);
            this.txtIdConsumo.Name = "txtIdConsumo";
            this.txtIdConsumo.Size = new System.Drawing.Size(50, 26);
            this.txtIdConsumo.TabIndex = 10;
            // 
            // txtIdTelemovel
            // 
            this.txtIdTelemovel.Enabled = false;
            this.txtIdTelemovel.Location = new System.Drawing.Point(107, 45);
            this.txtIdTelemovel.Name = "txtIdTelemovel";
            this.txtIdTelemovel.Size = new System.Drawing.Size(50, 26);
            this.txtIdTelemovel.TabIndex = 11;
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(6, 201);
            this.txtNumero.MaxLength = 9;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(164, 26);
            this.txtNumero.TabIndex = 12;
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(6, 97);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(164, 26);
            this.txtNome.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nome";
            // 
            // txtConsumoMinutos
            // 
            this.txtConsumoMinutos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consumosBindingSource, "consumoMinutos", true));
            this.txtConsumoMinutos.ForeColor = System.Drawing.Color.Black;
            this.txtConsumoMinutos.Location = new System.Drawing.Point(6, 98);
            this.txtConsumoMinutos.MaxLength = 20;
            this.txtConsumoMinutos.Name = "txtConsumoMinutos";
            this.txtConsumoMinutos.ReadOnly = true;
            this.txtConsumoMinutos.Size = new System.Drawing.Size(100, 26);
            this.txtConsumoMinutos.TabIndex = 16;
            this.txtConsumoMinutos.Text = "0";
            this.txtConsumoMinutos.TextChanged += new System.EventHandler(this.txtConsumoMinutos_TextChanged);
            // 
            // txtConsumoDadosMoveis
            // 
            this.txtConsumoDadosMoveis.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consumosBindingSource, "consumoDadosMoveis", true));
            this.txtConsumoDadosMoveis.Location = new System.Drawing.Point(6, 150);
            this.txtConsumoDadosMoveis.MaxLength = 20;
            this.txtConsumoDadosMoveis.Name = "txtConsumoDadosMoveis";
            this.txtConsumoDadosMoveis.ReadOnly = true;
            this.txtConsumoDadosMoveis.Size = new System.Drawing.Size(100, 26);
            this.txtConsumoDadosMoveis.TabIndex = 17;
            this.txtConsumoDadosMoveis.Text = "0";
            this.txtConsumoDadosMoveis.TextChanged += new System.EventHandler(this.txtDados_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(112, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Kb";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIdConsumo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtIdTelemovel);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Location = new System.Drawing.Point(221, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 241);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(6, 149);
            this.txtEmail.MaxLength = 9;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(229, 26);
            this.txtEmail.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Limite consumo minutos";
            // 
            // txtLimiteConsumoMinutos
            // 
            this.txtLimiteConsumoMinutos.Enabled = false;
            this.txtLimiteConsumoMinutos.Location = new System.Drawing.Point(10, 45);
            this.txtLimiteConsumoMinutos.Name = "txtLimiteConsumoMinutos";
            this.txtLimiteConsumoMinutos.Size = new System.Drawing.Size(96, 26);
            this.txtLimiteConsumoMinutos.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtLimiteConsumoDadosMoveis);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtLimiteConsumoMinutos);
            this.groupBox2.Location = new System.Drawing.Point(471, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 134);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(112, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "Kb";
            // 
            // txtLimiteConsumoDadosMoveis
            // 
            this.txtLimiteConsumoDadosMoveis.Enabled = false;
            this.txtLimiteConsumoDadosMoveis.Location = new System.Drawing.Point(10, 97);
            this.txtLimiteConsumoDadosMoveis.Name = "txtLimiteConsumoDadosMoveis";
            this.txtLimiteConsumoDadosMoveis.Size = new System.Drawing.Size(96, 26);
            this.txtLimiteConsumoDadosMoveis.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(221, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Limite consumo dados móveis";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox3.Controls.Add(this.cbMes);
            this.groupBox3.Controls.Add(this.btnEnviarEmail);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtConsumoDadosMoveis);
            this.groupBox3.Controls.Add(this.txtConsumoMinutos);
            this.groupBox3.Location = new System.Drawing.Point(720, 284);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(243, 241);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            // 
            // btnEnviarEmail
            // 
            this.btnEnviarEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEnviarEmail.AutoSize = true;
            this.btnEnviarEmail.Location = new System.Drawing.Point(6, 182);
            this.btnEnviarEmail.Name = "btnEnviarEmail";
            this.btnEnviarEmail.Size = new System.Drawing.Size(106, 30);
            this.btnEnviarEmail.TabIndex = 22;
            this.btnEnviarEmail.Text = "Enviar Email";
            this.btnEnviarEmail.UseVisualStyleBackColor = true;
            this.btnEnviarEmail.Click += new System.EventHandler(this.btnEnviarEmail_Click);
            // 
            // consumosTableAdapter
            // 
            this.consumosTableAdapter.ClearBeforeFill = true;
            // 
            // cbMes
            // 
            this.cbMes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Items.AddRange(new object[] {
            "janeiro",
            "fevereiro",
            "março",
            "abril",
            "maio",
            "junho",
            "julho",
            "agosto",
            "setembro",
            "outubro",
            "novembro",
            "dezembro"});
            this.cbMes.Location = new System.Drawing.Point(10, 43);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(100, 28);
            this.cbMes.TabIndex = 22;
            this.cbMes.Text = "janeiro";
            // 
            // Consumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Consumos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consumos";
            this.Load += new System.EventHandler(this.Consumos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConsumosTelemoveisDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbNovo;
        private System.Windows.Forms.ToolStripButton tsbSalvar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdConsumo;
        private System.Windows.Forms.TextBox txtIdTelemovel;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtConsumoMinutos;
        private System.Windows.Forms.TextBox txtConsumoDadosMoveis;
        private System.Windows.Forms.Label label8;
        private DbConsumosTelemoveisDataSet dbConsumosTelemoveisDataSet;
        private System.Windows.Forms.BindingSource consumosBindingSource;
        private DbConsumosTelemoveisDataSetTableAdapters.consumosTableAdapter consumosTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLimiteConsumoMinutos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtLimiteConsumoDadosMoveis;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idConsumoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTelemovelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroTelemovelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumoMinutosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumoDadosMoveisDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnEnviarEmail;
        private System.Windows.Forms.ComboBox cbMes;
    }
}