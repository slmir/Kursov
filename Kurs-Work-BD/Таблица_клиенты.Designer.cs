namespace Kurs_Work_BD
{
	partial class Таблица_клиенты
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.textBoxCode_Abon = new System.Windows.Forms.TextBox();
			this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this._Kurs_WORKDataSet3 = new Kurs_Work_BD._Kurs_WORKDataSet3();
			this.textBoxStoimost = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxVidTrenirovki = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonDobav = new System.Windows.Forms.Button();
			this.buttonRedact = new System.Windows.Forms.Button();
			this.back = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.кодклиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.паспортныеданныеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.клиентыTableAdapter = new Kurs_Work_BD._Kurs_WORKDataSet3TableAdapters.КлиентыTableAdapter();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.паспортныеданныеDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.датарожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.паспортныеданныеклиентовBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.buttonDELPD = new System.Windows.Forms.Button();
			this.buttonDOBAVPD = new System.Windows.Forms.Button();
			this.buttonSAVEPD = new System.Windows.Forms.Button();
			this.посещенияBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.посещенияTableAdapter = new Kurs_Work_BD._Kurs_WORKDataSet3TableAdapters.ПосещенияTableAdapter();
			this.паспортные_данные_клиентовTableAdapter = new Kurs_Work_BD._Kurs_WORKDataSet3TableAdapters.Паспортные_данные_клиентовTableAdapter();
			this.panel3 = new System.Windows.Forms.Panel();
			this.textBoxPD = new System.Windows.Forms.TextBox();
			this.textBoxAdr = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxDate_rojdenia = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.textBoxOtchestvo = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.textBoxFamilia = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._Kurs_WORKDataSet3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.паспортныеданныеклиентовBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.посещенияBindingSource)).BeginInit();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
			this.panel1.Controls.Add(this.textBoxCode_Abon);
			this.panel1.Controls.Add(this.textBoxStoimost);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.textBoxVidTrenirovki);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 421);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(468, 107);
			this.panel1.TabIndex = 9;
			// 
			// textBoxCode_Abon
			// 
			this.textBoxCode_Abon.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.клиентыBindingSource, "Код_клиента", true));
			this.textBoxCode_Abon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "Код_клиента", true));
			this.textBoxCode_Abon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxCode_Abon.Location = new System.Drawing.Point(239, 7);
			this.textBoxCode_Abon.Name = "textBoxCode_Abon";
			this.textBoxCode_Abon.Size = new System.Drawing.Size(226, 27);
			this.textBoxCode_Abon.TabIndex = 12;
			// 
			// клиентыBindingSource
			// 
			this.клиентыBindingSource.DataMember = "Клиенты";
			this.клиентыBindingSource.DataSource = this._Kurs_WORKDataSet3;
			// 
			// _Kurs_WORKDataSet3
			// 
			this._Kurs_WORKDataSet3.DataSetName = "_Kurs_WORKDataSet3";
			this._Kurs_WORKDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// textBoxStoimost
			// 
			this.textBoxStoimost.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.клиентыBindingSource, "Телефон", true));
			this.textBoxStoimost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "Телефон", true));
			this.textBoxStoimost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxStoimost.Location = new System.Drawing.Point(239, 73);
			this.textBoxStoimost.Name = "textBoxStoimost";
			this.textBoxStoimost.Size = new System.Drawing.Size(226, 27);
			this.textBoxStoimost.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(3, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Телефон:";
			// 
			// textBoxVidTrenirovki
			// 
			this.textBoxVidTrenirovki.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.клиентыBindingSource, "Паспортные_данные", true));
			this.textBoxVidTrenirovki.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "Паспортные_данные", true));
			this.textBoxVidTrenirovki.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxVidTrenirovki.Location = new System.Drawing.Point(239, 40);
			this.textBoxVidTrenirovki.Name = "textBoxVidTrenirovki";
			this.textBoxVidTrenirovki.Size = new System.Drawing.Size(226, 27);
			this.textBoxVidTrenirovki.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(3, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(191, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Паспортные_данные:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(3, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Код_клиента:";
			// 
			// buttonDelete
			// 
			this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonDelete.Location = new System.Drawing.Point(166, 538);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(148, 108);
			this.buttonDelete.TabIndex = 8;
			this.buttonDelete.Text = "Удалить строку из таблицы Клиенты";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// buttonDobav
			// 
			this.buttonDobav.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonDobav.Location = new System.Drawing.Point(12, 538);
			this.buttonDobav.Name = "buttonDobav";
			this.buttonDobav.Size = new System.Drawing.Size(148, 108);
			this.buttonDobav.TabIndex = 7;
			this.buttonDobav.Text = "Добавить строку в таблицу Клиенты";
			this.buttonDobav.UseVisualStyleBackColor = true;
			this.buttonDobav.Click += new System.EventHandler(this.buttonDobav_Click);
			// 
			// buttonRedact
			// 
			this.buttonRedact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonRedact.Location = new System.Drawing.Point(320, 538);
			this.buttonRedact.Name = "buttonRedact";
			this.buttonRedact.Size = new System.Drawing.Size(166, 108);
			this.buttonRedact.TabIndex = 6;
			this.buttonRedact.Text = "Сохранить изменения в таблице Клиенты";
			this.buttonRedact.UseVisualStyleBackColor = true;
			this.buttonRedact.Click += new System.EventHandler(this.buttonRedact_Click);
			// 
			// back
			// 
			this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.back.Location = new System.Drawing.Point(12, 690);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(208, 97);
			this.back.TabIndex = 5;
			this.back.Text = "Закрыть форму редактирования таблицы";
			this.back.UseVisualStyleBackColor = true;
			this.back.Click += new System.EventHandler(this.back_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодклиентаDataGridViewTextBoxColumn,
            this.паспортныеданныеDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.клиентыBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(468, 403);
			this.dataGridView1.TabIndex = 10;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// кодклиентаDataGridViewTextBoxColumn
			// 
			this.кодклиентаDataGridViewTextBoxColumn.DataPropertyName = "Код_клиента";
			this.кодклиентаDataGridViewTextBoxColumn.HeaderText = "Код_клиента";
			this.кодклиентаDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.кодклиентаDataGridViewTextBoxColumn.Name = "кодклиентаDataGridViewTextBoxColumn";
			this.кодклиентаDataGridViewTextBoxColumn.Width = 125;
			// 
			// паспортныеданныеDataGridViewTextBoxColumn
			// 
			this.паспортныеданныеDataGridViewTextBoxColumn.DataPropertyName = "Паспортные_данные";
			this.паспортныеданныеDataGridViewTextBoxColumn.HeaderText = "Паспортные_данные";
			this.паспортныеданныеDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.паспортныеданныеDataGridViewTextBoxColumn.Name = "паспортныеданныеDataGridViewTextBoxColumn";
			this.паспортныеданныеDataGridViewTextBoxColumn.Width = 125;
			// 
			// телефонDataGridViewTextBoxColumn
			// 
			this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
			this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
			this.телефонDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
			this.телефонDataGridViewTextBoxColumn.Width = 125;
			// 
			// клиентыTableAdapter
			// 
			this.клиентыTableAdapter.ClearBeforeFill = true;
			// 
			// dataGridView2
			// 
			this.dataGridView2.AutoGenerateColumns = false;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.паспортныеданныеDataGridViewTextBoxColumn1,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.датарожденияDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn});
			this.dataGridView2.DataSource = this.паспортныеданныеклиентовBindingSource;
			this.dataGridView2.Location = new System.Drawing.Point(549, 12);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.RowHeadersWidth = 51;
			this.dataGridView2.RowTemplate.Height = 24;
			this.dataGridView2.Size = new System.Drawing.Size(851, 403);
			this.dataGridView2.TabIndex = 22;
			// 
			// паспортныеданныеDataGridViewTextBoxColumn1
			// 
			this.паспортныеданныеDataGridViewTextBoxColumn1.DataPropertyName = "Паспортные_данные";
			this.паспортныеданныеDataGridViewTextBoxColumn1.HeaderText = "Паспортные_данные";
			this.паспортныеданныеDataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.паспортныеданныеDataGridViewTextBoxColumn1.Name = "паспортныеданныеDataGridViewTextBoxColumn1";
			this.паспортныеданныеDataGridViewTextBoxColumn1.Width = 125;
			// 
			// фамилияDataGridViewTextBoxColumn
			// 
			this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
			this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
			this.фамилияDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
			this.фамилияDataGridViewTextBoxColumn.Width = 125;
			// 
			// имяDataGridViewTextBoxColumn
			// 
			this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
			this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
			this.имяDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
			this.имяDataGridViewTextBoxColumn.Width = 125;
			// 
			// отчествоDataGridViewTextBoxColumn
			// 
			this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
			this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
			this.отчествоDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
			this.отчествоDataGridViewTextBoxColumn.Width = 125;
			// 
			// датарожденияDataGridViewTextBoxColumn
			// 
			this.датарожденияDataGridViewTextBoxColumn.DataPropertyName = "Дата_рождения";
			this.датарожденияDataGridViewTextBoxColumn.HeaderText = "Дата_рождения";
			this.датарожденияDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.датарожденияDataGridViewTextBoxColumn.Name = "датарожденияDataGridViewTextBoxColumn";
			this.датарожденияDataGridViewTextBoxColumn.Width = 125;
			// 
			// адресDataGridViewTextBoxColumn
			// 
			this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
			this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
			this.адресDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
			this.адресDataGridViewTextBoxColumn.Width = 125;
			// 
			// паспортныеданныеклиентовBindingSource
			// 
			this.паспортныеданныеклиентовBindingSource.DataMember = "Паспортные_данные_клиентов";
			this.паспортныеданныеклиентовBindingSource.DataSource = this._Kurs_WORKDataSet3;
			// 
			// buttonDELPD
			// 
			this.buttonDELPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonDELPD.Location = new System.Drawing.Point(1205, 421);
			this.buttonDELPD.Name = "buttonDELPD";
			this.buttonDELPD.Size = new System.Drawing.Size(195, 107);
			this.buttonDELPD.TabIndex = 20;
			this.buttonDELPD.Text = "Удалить строку из таблицы с паспортными\r\nданными клиентов";
			this.buttonDELPD.UseVisualStyleBackColor = true;
			this.buttonDELPD.Click += new System.EventHandler(this.buttonDELPD_Click);
			// 
			// buttonDOBAVPD
			// 
			this.buttonDOBAVPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonDOBAVPD.Location = new System.Drawing.Point(1073, 534);
			this.buttonDOBAVPD.Name = "buttonDOBAVPD";
			this.buttonDOBAVPD.Size = new System.Drawing.Size(230, 93);
			this.buttonDOBAVPD.TabIndex = 19;
			this.buttonDOBAVPD.Text = "Добавить строку в таблицу с паспортными\r\nданными клиентов\r\n";
			this.buttonDOBAVPD.UseVisualStyleBackColor = true;
			this.buttonDOBAVPD.Click += new System.EventHandler(this.buttonDOBAVPD_Click);
			// 
			// buttonSAVEPD
			// 
			this.buttonSAVEPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonSAVEPD.Location = new System.Drawing.Point(952, 421);
			this.buttonSAVEPD.Name = "buttonSAVEPD";
			this.buttonSAVEPD.Size = new System.Drawing.Size(230, 107);
			this.buttonSAVEPD.TabIndex = 18;
			this.buttonSAVEPD.Text = "Сохранить изменения в таблице с паспортными\r\nданными клиентов";
			this.buttonSAVEPD.UseVisualStyleBackColor = true;
			this.buttonSAVEPD.Click += new System.EventHandler(this.buttonSAVEPD_Click);
			// 
			// посещенияBindingSource
			// 
			this.посещенияBindingSource.DataMember = "Посещения";
			this.посещенияBindingSource.DataSource = this._Kurs_WORKDataSet3;
			// 
			// посещенияTableAdapter
			// 
			this.посещенияTableAdapter.ClearBeforeFill = true;
			// 
			// паспортные_данные_клиентовTableAdapter
			// 
			this.паспортные_данные_клиентовTableAdapter.ClearBeforeFill = true;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.PaleTurquoise;
			this.panel3.Controls.Add(this.textBoxPD);
			this.panel3.Controls.Add(this.textBoxAdr);
			this.panel3.Controls.Add(this.label6);
			this.panel3.Controls.Add(this.textBoxDate_rojdenia);
			this.panel3.Controls.Add(this.label13);
			this.panel3.Controls.Add(this.textBoxOtchestvo);
			this.panel3.Controls.Add(this.label14);
			this.panel3.Controls.Add(this.textBoxName);
			this.panel3.Controls.Add(this.label15);
			this.panel3.Controls.Add(this.textBoxFamilia);
			this.panel3.Controls.Add(this.label16);
			this.panel3.Controls.Add(this.label17);
			this.panel3.Location = new System.Drawing.Point(550, 421);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(396, 202);
			this.panel3.TabIndex = 23;
			// 
			// textBoxPD
			// 
			this.textBoxPD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.паспортныеданныеклиентовBindingSource, "Паспортные_данные", true));
			this.textBoxPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxPD.Location = new System.Drawing.Point(197, 3);
			this.textBoxPD.Name = "textBoxPD";
			this.textBoxPD.Size = new System.Drawing.Size(190, 27);
			this.textBoxPD.TabIndex = 21;
			this.textBoxPD.TextChanged += new System.EventHandler(this.textBoxPD_TextChanged);
			// 
			// textBoxAdr
			// 
			this.textBoxAdr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.паспортныеданныеклиентовBindingSource, "Адрес", true));
			this.textBoxAdr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxAdr.Location = new System.Drawing.Point(197, 168);
			this.textBoxAdr.Name = "textBoxAdr";
			this.textBoxAdr.Size = new System.Drawing.Size(190, 27);
			this.textBoxAdr.TabIndex = 10;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(4, 171);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(67, 20);
			this.label6.TabIndex = 9;
			this.label6.Text = "Адрес:";
			// 
			// textBoxDate_rojdenia
			// 
			this.textBoxDate_rojdenia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.паспортныеданныеклиентовBindingSource, "Дата_рождения", true));
			this.textBoxDate_rojdenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxDate_rojdenia.Location = new System.Drawing.Point(197, 135);
			this.textBoxDate_rojdenia.Name = "textBoxDate_rojdenia";
			this.textBoxDate_rojdenia.Size = new System.Drawing.Size(190, 27);
			this.textBoxDate_rojdenia.TabIndex = 8;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label13.Location = new System.Drawing.Point(4, 138);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(150, 20);
			this.label13.TabIndex = 7;
			this.label13.Text = "Дата_рождения:";
			// 
			// textBoxOtchestvo
			// 
			this.textBoxOtchestvo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.паспортныеданныеклиентовBindingSource, "Отчество", true));
			this.textBoxOtchestvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxOtchestvo.Location = new System.Drawing.Point(197, 102);
			this.textBoxOtchestvo.Name = "textBoxOtchestvo";
			this.textBoxOtchestvo.Size = new System.Drawing.Size(190, 27);
			this.textBoxOtchestvo.TabIndex = 6;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label14.Location = new System.Drawing.Point(4, 105);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(96, 20);
			this.label14.TabIndex = 5;
			this.label14.Text = "Отчество:";
			// 
			// textBoxName
			// 
			this.textBoxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.паспортныеданныеклиентовBindingSource, "Имя", true));
			this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxName.Location = new System.Drawing.Point(197, 69);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(190, 27);
			this.textBoxName.TabIndex = 4;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label15.Location = new System.Drawing.Point(4, 72);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(47, 20);
			this.label15.TabIndex = 3;
			this.label15.Text = "Имя:";
			// 
			// textBoxFamilia
			// 
			this.textBoxFamilia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.паспортныеданныеклиентовBindingSource, "Фамилия", true));
			this.textBoxFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxFamilia.Location = new System.Drawing.Point(197, 36);
			this.textBoxFamilia.Name = "textBoxFamilia";
			this.textBoxFamilia.Size = new System.Drawing.Size(190, 27);
			this.textBoxFamilia.TabIndex = 2;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label16.Location = new System.Drawing.Point(4, 39);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(92, 20);
			this.label16.TabIndex = 1;
			this.label16.Text = "Фамилия:";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label17.Location = new System.Drawing.Point(4, 4);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(191, 20);
			this.label17.TabIndex = 0;
			this.label17.Text = "Паспортные_данные:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Kurs_Work_BD.Properties.Resources.фитнес_клуб_с_гантелями_строки_гантелей_металла_на_шкафе_для_150233004;
			this.pictureBox1.Location = new System.Drawing.Point(-153, -56);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1794, 881);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 32;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// Таблица_клиенты
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1423, 799);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.buttonDELPD);
			this.Controls.Add(this.buttonDOBAVPD);
			this.Controls.Add(this.buttonSAVEPD);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonDobav);
			this.Controls.Add(this.buttonRedact);
			this.Controls.Add(this.back);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Таблица_клиенты";
			this.Text = "Редактирование данных о клиенте";
			this.Load += new System.EventHandler(this.Таблица_клиенты_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._Kurs_WORKDataSet3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.паспортныеданныеклиентовBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.посещенияBindingSource)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBoxCode_Abon;
		private System.Windows.Forms.TextBox textBoxStoimost;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxVidTrenirovki;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonDobav;
		private System.Windows.Forms.Button buttonRedact;
		private System.Windows.Forms.Button back;
		private System.Windows.Forms.BindingSource bindingSource1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private _Kurs_WORKDataSet3 _Kurs_WORKDataSet3;
		private System.Windows.Forms.BindingSource клиентыBindingSource;
		private _Kurs_WORKDataSet3TableAdapters.КлиентыTableAdapter клиентыTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn кодклиентаDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn паспортныеданныеDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.Button buttonDELPD;
		private System.Windows.Forms.Button buttonDOBAVPD;
		private System.Windows.Forms.Button buttonSAVEPD;
		private System.Windows.Forms.BindingSource посещенияBindingSource;
		private _Kurs_WORKDataSet3TableAdapters.ПосещенияTableAdapter посещенияTableAdapter;
		private System.Windows.Forms.BindingSource паспортныеданныеклиентовBindingSource;
		private _Kurs_WORKDataSet3TableAdapters.Паспортные_данные_клиентовTableAdapter паспортные_данные_клиентовTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn паспортныеданныеDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn датарожденияDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox textBoxPD;
		private System.Windows.Forms.TextBox textBoxAdr;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxDate_rojdenia;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox textBoxOtchestvo;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox textBoxFamilia;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}