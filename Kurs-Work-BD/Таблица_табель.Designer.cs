namespace Kurs_Work_BD
{
	partial class Таблица_табель
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxCode_Abon = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxKolVoPoseshenie = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxTimeDeystvia = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxStoimost = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxVidTrenirovki = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonDobav = new System.Windows.Forms.Button();
			this.buttonRedact = new System.Windows.Forms.Button();
			this.back = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this._Kurs_WORKDataSet3 = new Kurs_Work_BD._Kurs_WORKDataSet3();
			this.табельBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.табельTableAdapter = new Kurs_Work_BD._Kurs_WORKDataSet3TableAdapters.ТабельTableAdapter();
			this.кодТРтабельDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.кодтренераDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.времяначаласменыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.времяконцасменыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.кодтренировкитDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.работазаменяющимтренеромDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.кодзаменяемоготренераDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.кодзаменяемойтренировкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.описаниезаменыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._Kurs_WORKDataSet3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.табельBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодТРтабельDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.кодтренераDataGridViewTextBoxColumn,
            this.времяначаласменыDataGridViewTextBoxColumn,
            this.времяконцасменыDataGridViewTextBoxColumn,
            this.кодтренировкитDataGridViewTextBoxColumn,
            this.описаниеDataGridViewTextBoxColumn,
            this.работазаменяющимтренеромDataGridViewTextBoxColumn,
            this.кодзаменяемоготренераDataGridViewTextBoxColumn,
            this.кодзаменяемойтренировкиDataGridViewTextBoxColumn,
            this.описаниезаменыDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.табельBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1433, 337);
			this.dataGridView1.TabIndex = 66;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
			this.panel1.Controls.Add(this.textBox8);
			this.panel1.Controls.Add(this.label15);
			this.panel1.Controls.Add(this.textBox3);
			this.panel1.Controls.Add(this.textBox4);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.textBox5);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.textBox6);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.label14);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.textBoxCode_Abon);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.textBoxKolVoPoseshenie);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.textBoxTimeDeystvia);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.textBoxStoimost);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.textBoxVidTrenirovki);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 355);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1200, 210);
			this.panel1.TabIndex = 65;
			// 
			// textBox1
			// 
			this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.табельBindingSource, "Код_тренировки_т", true));
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(239, 169);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(305, 27);
			this.textBox1.TabIndex = 14;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(3, 172);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(174, 20);
			this.label7.TabIndex = 13;
			this.label7.Text = "Код_тренировки_т:";
			// 
			// textBoxCode_Abon
			// 
			this.textBoxCode_Abon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.табельBindingSource, "Код_ТР_табель", true));
			this.textBoxCode_Abon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxCode_Abon.Location = new System.Drawing.Point(239, 7);
			this.textBoxCode_Abon.Name = "textBoxCode_Abon";
			this.textBoxCode_Abon.Size = new System.Drawing.Size(305, 27);
			this.textBoxCode_Abon.TabIndex = 12;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(3, 172);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(0, 20);
			this.label6.TabIndex = 10;
			// 
			// textBoxKolVoPoseshenie
			// 
			this.textBoxKolVoPoseshenie.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.табельBindingSource, "Время_конца_смены", true));
			this.textBoxKolVoPoseshenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxKolVoPoseshenie.Location = new System.Drawing.Point(239, 136);
			this.textBoxKolVoPoseshenie.Name = "textBoxKolVoPoseshenie";
			this.textBoxKolVoPoseshenie.Size = new System.Drawing.Size(305, 27);
			this.textBoxKolVoPoseshenie.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(3, 139);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(188, 20);
			this.label5.TabIndex = 8;
			this.label5.Text = "Время_конца_смены:";
			// 
			// textBoxTimeDeystvia
			// 
			this.textBoxTimeDeystvia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.табельBindingSource, "Время_начала_смены", true));
			this.textBoxTimeDeystvia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxTimeDeystvia.Location = new System.Drawing.Point(239, 103);
			this.textBoxTimeDeystvia.Name = "textBoxTimeDeystvia";
			this.textBoxTimeDeystvia.Size = new System.Drawing.Size(305, 27);
			this.textBoxTimeDeystvia.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(3, 106);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(199, 20);
			this.label4.TabIndex = 6;
			this.label4.Text = "Время_начала_смены:";
			// 
			// textBoxStoimost
			// 
			this.textBoxStoimost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.табельBindingSource, "Код_тренера", true));
			this.textBoxStoimost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxStoimost.Location = new System.Drawing.Point(239, 73);
			this.textBoxStoimost.Name = "textBoxStoimost";
			this.textBoxStoimost.Size = new System.Drawing.Size(305, 27);
			this.textBoxStoimost.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(3, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(126, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Код_тренера:";
			// 
			// textBoxVidTrenirovki
			// 
			this.textBoxVidTrenirovki.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.табельBindingSource, "Дата", true));
			this.textBoxVidTrenirovki.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxVidTrenirovki.Location = new System.Drawing.Point(239, 40);
			this.textBoxVidTrenirovki.Name = "textBoxVidTrenirovki";
			this.textBoxVidTrenirovki.Size = new System.Drawing.Size(305, 27);
			this.textBoxVidTrenirovki.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(3, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Дата:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(3, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(146, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Код_ТР_табель:";
			// 
			// buttonDelete
			// 
			this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonDelete.Location = new System.Drawing.Point(1073, 571);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(139, 60);
			this.buttonDelete.TabIndex = 64;
			this.buttonDelete.Text = "Удалить";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// buttonDobav
			// 
			this.buttonDobav.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonDobav.Location = new System.Drawing.Point(887, 571);
			this.buttonDobav.Name = "buttonDobav";
			this.buttonDobav.Size = new System.Drawing.Size(143, 60);
			this.buttonDobav.TabIndex = 63;
			this.buttonDobav.Text = "Добавить";
			this.buttonDobav.UseVisualStyleBackColor = true;
			this.buttonDobav.Click += new System.EventHandler(this.buttonDobav_Click);
			// 
			// buttonRedact
			// 
			this.buttonRedact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonRedact.Location = new System.Drawing.Point(695, 571);
			this.buttonRedact.Name = "buttonRedact";
			this.buttonRedact.Size = new System.Drawing.Size(157, 60);
			this.buttonRedact.TabIndex = 62;
			this.buttonRedact.Text = "Сохранить изменения";
			this.buttonRedact.UseVisualStyleBackColor = true;
			this.buttonRedact.Click += new System.EventHandler(this.buttonRedact_Click);
			// 
			// back
			// 
			this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.back.Location = new System.Drawing.Point(12, 571);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(258, 71);
			this.back.TabIndex = 61;
			this.back.Text = "Закрыть форму редактирования таблицы";
			this.back.UseVisualStyleBackColor = true;
			this.back.Click += new System.EventHandler(this.back_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Kurs_Work_BD.Properties.Resources.фитнес_клуб_с_гантелями_строки_гантелей_металла_на_шкафе_для_150233004;
			this.pictureBox1.Location = new System.Drawing.Point(-31, -8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1585, 802);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 67;
			this.pictureBox1.TabStop = false;
			// 
			// _Kurs_WORKDataSet3
			// 
			this._Kurs_WORKDataSet3.DataSetName = "_Kurs_WORKDataSet3";
			this._Kurs_WORKDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// табельBindingSource
			// 
			this.табельBindingSource.DataMember = "Табель";
			this.табельBindingSource.DataSource = this._Kurs_WORKDataSet3;
			// 
			// табельTableAdapter
			// 
			this.табельTableAdapter.ClearBeforeFill = true;
			// 
			// кодТРтабельDataGridViewTextBoxColumn
			// 
			this.кодТРтабельDataGridViewTextBoxColumn.DataPropertyName = "Код_ТР_табель";
			this.кодТРтабельDataGridViewTextBoxColumn.HeaderText = "Код_ТР_табель";
			this.кодТРтабельDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.кодТРтабельDataGridViewTextBoxColumn.Name = "кодТРтабельDataGridViewTextBoxColumn";
			this.кодТРтабельDataGridViewTextBoxColumn.Width = 125;
			// 
			// датаDataGridViewTextBoxColumn
			// 
			this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
			this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
			this.датаDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
			this.датаDataGridViewTextBoxColumn.Width = 125;
			// 
			// кодтренераDataGridViewTextBoxColumn
			// 
			this.кодтренераDataGridViewTextBoxColumn.DataPropertyName = "Код_тренера";
			this.кодтренераDataGridViewTextBoxColumn.HeaderText = "Код_тренера";
			this.кодтренераDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.кодтренераDataGridViewTextBoxColumn.Name = "кодтренераDataGridViewTextBoxColumn";
			this.кодтренераDataGridViewTextBoxColumn.Width = 125;
			// 
			// времяначаласменыDataGridViewTextBoxColumn
			// 
			this.времяначаласменыDataGridViewTextBoxColumn.DataPropertyName = "Время_начала_смены";
			this.времяначаласменыDataGridViewTextBoxColumn.HeaderText = "Время_начала_смены";
			this.времяначаласменыDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.времяначаласменыDataGridViewTextBoxColumn.Name = "времяначаласменыDataGridViewTextBoxColumn";
			this.времяначаласменыDataGridViewTextBoxColumn.Width = 125;
			// 
			// времяконцасменыDataGridViewTextBoxColumn
			// 
			this.времяконцасменыDataGridViewTextBoxColumn.DataPropertyName = "Время_конца_смены";
			this.времяконцасменыDataGridViewTextBoxColumn.HeaderText = "Время_конца_смены";
			this.времяконцасменыDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.времяконцасменыDataGridViewTextBoxColumn.Name = "времяконцасменыDataGridViewTextBoxColumn";
			this.времяконцасменыDataGridViewTextBoxColumn.Width = 125;
			// 
			// кодтренировкитDataGridViewTextBoxColumn
			// 
			this.кодтренировкитDataGridViewTextBoxColumn.DataPropertyName = "Код_тренировки_т";
			this.кодтренировкитDataGridViewTextBoxColumn.HeaderText = "Код_тренировки_т";
			this.кодтренировкитDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.кодтренировкитDataGridViewTextBoxColumn.Name = "кодтренировкитDataGridViewTextBoxColumn";
			this.кодтренировкитDataGridViewTextBoxColumn.Width = 125;
			// 
			// описаниеDataGridViewTextBoxColumn
			// 
			this.описаниеDataGridViewTextBoxColumn.DataPropertyName = "Описание";
			this.описаниеDataGridViewTextBoxColumn.HeaderText = "Описание";
			this.описаниеDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.описаниеDataGridViewTextBoxColumn.Name = "описаниеDataGridViewTextBoxColumn";
			this.описаниеDataGridViewTextBoxColumn.Width = 125;
			// 
			// работазаменяющимтренеромDataGridViewTextBoxColumn
			// 
			this.работазаменяющимтренеромDataGridViewTextBoxColumn.DataPropertyName = "Работа_заменяющим_тренером";
			this.работазаменяющимтренеромDataGridViewTextBoxColumn.HeaderText = "Работа_заменяющим_тренером";
			this.работазаменяющимтренеромDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.работазаменяющимтренеромDataGridViewTextBoxColumn.Name = "работазаменяющимтренеромDataGridViewTextBoxColumn";
			this.работазаменяющимтренеромDataGridViewTextBoxColumn.Width = 125;
			// 
			// кодзаменяемоготренераDataGridViewTextBoxColumn
			// 
			this.кодзаменяемоготренераDataGridViewTextBoxColumn.DataPropertyName = "Код_заменяемого_тренера";
			this.кодзаменяемоготренераDataGridViewTextBoxColumn.HeaderText = "Код_заменяемого_тренера";
			this.кодзаменяемоготренераDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.кодзаменяемоготренераDataGridViewTextBoxColumn.Name = "кодзаменяемоготренераDataGridViewTextBoxColumn";
			this.кодзаменяемоготренераDataGridViewTextBoxColumn.Width = 125;
			// 
			// кодзаменяемойтренировкиDataGridViewTextBoxColumn
			// 
			this.кодзаменяемойтренировкиDataGridViewTextBoxColumn.DataPropertyName = "Код_заменяемой_тренировки";
			this.кодзаменяемойтренировкиDataGridViewTextBoxColumn.HeaderText = "Код_заменяемой_тренировки";
			this.кодзаменяемойтренировкиDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.кодзаменяемойтренировкиDataGridViewTextBoxColumn.Name = "кодзаменяемойтренировкиDataGridViewTextBoxColumn";
			this.кодзаменяемойтренировкиDataGridViewTextBoxColumn.Width = 125;
			// 
			// описаниезаменыDataGridViewTextBoxColumn
			// 
			this.описаниезаменыDataGridViewTextBoxColumn.DataPropertyName = "Описание_замены";
			this.описаниезаменыDataGridViewTextBoxColumn.HeaderText = "Описание_замены";
			this.описаниезаменыDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.описаниезаменыDataGridViewTextBoxColumn.Name = "описаниезаменыDataGridViewTextBoxColumn";
			this.описаниезаменыDataGridViewTextBoxColumn.Width = 125;
			// 
			// textBox3
			// 
			this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.табельBindingSource, "Работа_заменяющим_тренером", true));
			this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox3.Location = new System.Drawing.Point(884, 43);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(305, 27);
			this.textBox3.TabIndex = 25;
			// 
			// textBox4
			// 
			this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.табельBindingSource, "Описание_замены", true));
			this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox4.Location = new System.Drawing.Point(884, 139);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(305, 27);
			this.textBox4.TabIndex = 23;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label10.Location = new System.Drawing.Point(591, 142);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(168, 20);
			this.label10.TabIndex = 22;
			this.label10.Text = "Описание_замены:";
			// 
			// textBox5
			// 
			this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.табельBindingSource, "Код_заменяемой_тренировки", true));
			this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox5.Location = new System.Drawing.Point(884, 106);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(305, 27);
			this.textBox5.TabIndex = 21;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label11.Location = new System.Drawing.Point(591, 109);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(267, 20);
			this.label11.TabIndex = 20;
			this.label11.Text = "Код_заменяемой_тренировки:";
			// 
			// textBox6
			// 
			this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.табельBindingSource, "Код_заменяемого_тренера", true));
			this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox6.Location = new System.Drawing.Point(884, 76);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(305, 27);
			this.textBox6.TabIndex = 19;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label12.Location = new System.Drawing.Point(591, 76);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(246, 20);
			this.label12.TabIndex = 18;
			this.label12.Text = "Код_заменяемого_тренера:";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label14.Location = new System.Drawing.Point(591, 43);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(285, 20);
			this.label14.TabIndex = 15;
			this.label14.Text = "Работа_заменяющим_тренером:";
			// 
			// textBox8
			// 
			this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.табельBindingSource, "Описание", true));
			this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox8.Location = new System.Drawing.Point(884, 10);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(305, 27);
			this.textBox8.TabIndex = 29;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label15.Location = new System.Drawing.Point(590, 10);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(96, 20);
			this.label15.TabIndex = 28;
			this.label15.Text = "Описание:";
			// 
			// Таблица_табель
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1457, 648);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonDobav);
			this.Controls.Add(this.buttonRedact);
			this.Controls.Add(this.back);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Таблица_табель";
			this.Text = "Таблица_табель";
			this.Load += new System.EventHandler(this.Таблица_табель_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._Kurs_WORKDataSet3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.табельBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxCode_Abon;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxKolVoPoseshenie;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxTimeDeystvia;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxStoimost;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxVidTrenirovki;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonDobav;
		private System.Windows.Forms.Button buttonRedact;
		private System.Windows.Forms.Button back;
		private System.Windows.Forms.PictureBox pictureBox1;
		private _Kurs_WORKDataSet3 _Kurs_WORKDataSet3;
		private System.Windows.Forms.BindingSource табельBindingSource;
		private _Kurs_WORKDataSet3TableAdapters.ТабельTableAdapter табельTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn кодТРтабельDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn кодтренераDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn времяначаласменыDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn времяконцасменыDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn кодтренировкитDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn работазаменяющимтренеромDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn кодзаменяемоготренераDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn кодзаменяемойтренировкиDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn описаниезаменыDataGridViewTextBoxColumn;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label14;
	}
}