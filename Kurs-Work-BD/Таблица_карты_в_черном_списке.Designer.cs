namespace Kurs_Work_BD
{
	partial class Таблица_карты_в_черном_списке
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
			this.кодЧСDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.датаобращенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.номерутеряннойкартыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.датааннулированияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.выданановаякартаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.номерновойкартыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.черныйсписокBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this._Kurs_WORKDataSet3 = new Kurs_Work_BD._Kurs_WORKDataSet3();
			this.panel1 = new System.Windows.Forms.Panel();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.textBoxCode_Abon = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
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
			this.черный_списокTableAdapter = new Kurs_Work_BD._Kurs_WORKDataSet3TableAdapters.Черный_списокTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.черныйсписокBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._Kurs_WORKDataSet3)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодЧСDataGridViewTextBoxColumn,
            this.датаобращенияDataGridViewTextBoxColumn,
            this.номерутеряннойкартыDataGridViewTextBoxColumn,
            this.датааннулированияDataGridViewTextBoxColumn,
            this.выданановаякартаDataGridViewTextBoxColumn,
            this.номерновойкартыDataGridViewTextBoxColumn,
            this.описаниеDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.черныйсписокBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1150, 337);
			this.dataGridView1.TabIndex = 73;
			// 
			// кодЧСDataGridViewTextBoxColumn
			// 
			this.кодЧСDataGridViewTextBoxColumn.DataPropertyName = "Код_ЧС";
			this.кодЧСDataGridViewTextBoxColumn.HeaderText = "Код_ЧС";
			this.кодЧСDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.кодЧСDataGridViewTextBoxColumn.Name = "кодЧСDataGridViewTextBoxColumn";
			this.кодЧСDataGridViewTextBoxColumn.Width = 125;
			// 
			// датаобращенияDataGridViewTextBoxColumn
			// 
			this.датаобращенияDataGridViewTextBoxColumn.DataPropertyName = "Дата_обращения";
			this.датаобращенияDataGridViewTextBoxColumn.HeaderText = "Дата_обращения";
			this.датаобращенияDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.датаобращенияDataGridViewTextBoxColumn.Name = "датаобращенияDataGridViewTextBoxColumn";
			this.датаобращенияDataGridViewTextBoxColumn.Width = 125;
			// 
			// номерутеряннойкартыDataGridViewTextBoxColumn
			// 
			this.номерутеряннойкартыDataGridViewTextBoxColumn.DataPropertyName = "Номер_утерянной_карты";
			this.номерутеряннойкартыDataGridViewTextBoxColumn.HeaderText = "Номер_утерянной_карты";
			this.номерутеряннойкартыDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.номерутеряннойкартыDataGridViewTextBoxColumn.Name = "номерутеряннойкартыDataGridViewTextBoxColumn";
			this.номерутеряннойкартыDataGridViewTextBoxColumn.Width = 125;
			// 
			// датааннулированияDataGridViewTextBoxColumn
			// 
			this.датааннулированияDataGridViewTextBoxColumn.DataPropertyName = "Дата_аннулирования";
			this.датааннулированияDataGridViewTextBoxColumn.HeaderText = "Дата_аннулирования";
			this.датааннулированияDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.датааннулированияDataGridViewTextBoxColumn.Name = "датааннулированияDataGridViewTextBoxColumn";
			this.датааннулированияDataGridViewTextBoxColumn.Width = 125;
			// 
			// выданановаякартаDataGridViewTextBoxColumn
			// 
			this.выданановаякартаDataGridViewTextBoxColumn.DataPropertyName = "Выдана_новая_карта";
			this.выданановаякартаDataGridViewTextBoxColumn.HeaderText = "Выдана_новая_карта";
			this.выданановаякартаDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.выданановаякартаDataGridViewTextBoxColumn.Name = "выданановаякартаDataGridViewTextBoxColumn";
			this.выданановаякартаDataGridViewTextBoxColumn.Width = 125;
			// 
			// номерновойкартыDataGridViewTextBoxColumn
			// 
			this.номерновойкартыDataGridViewTextBoxColumn.DataPropertyName = "Номер_новой_карты";
			this.номерновойкартыDataGridViewTextBoxColumn.HeaderText = "Номер_новой_карты";
			this.номерновойкартыDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.номерновойкартыDataGridViewTextBoxColumn.Name = "номерновойкартыDataGridViewTextBoxColumn";
			this.номерновойкартыDataGridViewTextBoxColumn.Width = 125;
			// 
			// описаниеDataGridViewTextBoxColumn
			// 
			this.описаниеDataGridViewTextBoxColumn.DataPropertyName = "Описание";
			this.описаниеDataGridViewTextBoxColumn.HeaderText = "Описание";
			this.описаниеDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.описаниеDataGridViewTextBoxColumn.Name = "описаниеDataGridViewTextBoxColumn";
			this.описаниеDataGridViewTextBoxColumn.Width = 125;
			// 
			// черныйсписокBindingSource
			// 
			this.черныйсписокBindingSource.DataMember = "Черный_список";
			this.черныйсписокBindingSource.DataSource = this._Kurs_WORKDataSet3;
			// 
			// _Kurs_WORKDataSet3
			// 
			this._Kurs_WORKDataSet3.DataSetName = "_Kurs_WORKDataSet3";
			this._Kurs_WORKDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
			this.panel1.Controls.Add(this.textBox8);
			this.panel1.Controls.Add(this.label15);
			this.panel1.Controls.Add(this.textBox3);
			this.panel1.Controls.Add(this.textBox6);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.label14);
			this.panel1.Controls.Add(this.textBoxCode_Abon);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.textBoxTimeDeystvia);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.textBoxStoimost);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.textBoxVidTrenirovki);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(14, 355);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1148, 139);
			this.panel1.TabIndex = 72;
			// 
			// textBox8
			// 
			this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.черныйсписокBindingSource, "Выдана_новая_карта", true));
			this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox8.Location = new System.Drawing.Point(830, 7);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(305, 27);
			this.textBox8.TabIndex = 29;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label15.Location = new System.Drawing.Point(631, 7);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(197, 20);
			this.label15.TabIndex = 28;
			this.label15.Text = "Выдана_новая_карта:";
			// 
			// textBox3
			// 
			this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.черныйсписокBindingSource, "Номер_новой_карты", true));
			this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox3.Location = new System.Drawing.Point(830, 40);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(305, 27);
			this.textBox3.TabIndex = 25;
			// 
			// textBox6
			// 
			this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.черныйсписокBindingSource, "Описание", true));
			this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox6.Location = new System.Drawing.Point(830, 73);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(305, 27);
			this.textBox6.TabIndex = 19;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label12.Location = new System.Drawing.Point(632, 73);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(96, 20);
			this.label12.TabIndex = 18;
			this.label12.Text = "Описание:";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label14.Location = new System.Drawing.Point(632, 40);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(188, 20);
			this.label14.TabIndex = 15;
			this.label14.Text = "Номер_новой_карты:";
			// 
			// textBoxCode_Abon
			// 
			this.textBoxCode_Abon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.черныйсписокBindingSource, "Код_ЧС", true));
			this.textBoxCode_Abon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxCode_Abon.Location = new System.Drawing.Point(279, 7);
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
			// textBoxTimeDeystvia
			// 
			this.textBoxTimeDeystvia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.черныйсписокBindingSource, "Дата_аннулирования", true));
			this.textBoxTimeDeystvia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxTimeDeystvia.Location = new System.Drawing.Point(279, 103);
			this.textBoxTimeDeystvia.Name = "textBoxTimeDeystvia";
			this.textBoxTimeDeystvia.Size = new System.Drawing.Size(305, 27);
			this.textBoxTimeDeystvia.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(43, 106);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(194, 20);
			this.label4.TabIndex = 6;
			this.label4.Text = "Дата_аннулирования:";
			// 
			// textBoxStoimost
			// 
			this.textBoxStoimost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.черныйсписокBindingSource, "Номер_утерянной_карты", true));
			this.textBoxStoimost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxStoimost.Location = new System.Drawing.Point(279, 73);
			this.textBoxStoimost.Name = "textBoxStoimost";
			this.textBoxStoimost.Size = new System.Drawing.Size(305, 27);
			this.textBoxStoimost.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(43, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(226, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Номер_утерянной_карты:";
			// 
			// textBoxVidTrenirovki
			// 
			this.textBoxVidTrenirovki.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.черныйсписокBindingSource, "Дата_обращения", true));
			this.textBoxVidTrenirovki.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxVidTrenirovki.Location = new System.Drawing.Point(279, 40);
			this.textBoxVidTrenirovki.Name = "textBoxVidTrenirovki";
			this.textBoxVidTrenirovki.Size = new System.Drawing.Size(305, 27);
			this.textBoxVidTrenirovki.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(43, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(160, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Дата_обращения:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(43, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Код_ЧС:";
			// 
			// buttonDelete
			// 
			this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonDelete.Location = new System.Drawing.Point(1021, 517);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(139, 60);
			this.buttonDelete.TabIndex = 71;
			this.buttonDelete.Text = "Удалить";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// buttonDobav
			// 
			this.buttonDobav.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonDobav.Location = new System.Drawing.Point(835, 517);
			this.buttonDobav.Name = "buttonDobav";
			this.buttonDobav.Size = new System.Drawing.Size(143, 60);
			this.buttonDobav.TabIndex = 70;
			this.buttonDobav.Text = "Добавить";
			this.buttonDobav.UseVisualStyleBackColor = true;
			this.buttonDobav.Click += new System.EventHandler(this.buttonDobav_Click);
			// 
			// buttonRedact
			// 
			this.buttonRedact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonRedact.Location = new System.Drawing.Point(640, 517);
			this.buttonRedact.Name = "buttonRedact";
			this.buttonRedact.Size = new System.Drawing.Size(157, 60);
			this.buttonRedact.TabIndex = 69;
			this.buttonRedact.Text = "Сохранить изменения";
			this.buttonRedact.UseVisualStyleBackColor = true;
			this.buttonRedact.Click += new System.EventHandler(this.buttonRedact_Click);
			// 
			// back
			// 
			this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.back.Location = new System.Drawing.Point(14, 506);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(258, 71);
			this.back.TabIndex = 68;
			this.back.Text = "Закрыть форму редактирования таблицы";
			this.back.UseVisualStyleBackColor = true;
			this.back.Click += new System.EventHandler(this.back_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Kurs_Work_BD.Properties.Resources.фитнес_клуб_с_гантелями_строки_гантелей_металла_на_шкафе_для_150233004;
			this.pictureBox1.Location = new System.Drawing.Point(-116, -45);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1585, 822);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 74;
			this.pictureBox1.TabStop = false;
			// 
			// черный_списокTableAdapter
			// 
			this.черный_списокTableAdapter.ClearBeforeFill = true;
			// 
			// Таблица_карты_в_черном_списке
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1182, 593);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonDobav);
			this.Controls.Add(this.buttonRedact);
			this.Controls.Add(this.back);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Таблица_карты_в_черном_списке";
			this.Text = "Таблица_карты_в_черном_списке";
			this.Load += new System.EventHandler(this.Таблица_карты_в_черном_списке_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.черныйсписокBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._Kurs_WORKDataSet3)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox textBoxCode_Abon;
		private System.Windows.Forms.Label label6;
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
		private System.Windows.Forms.BindingSource черныйсписокBindingSource;
		private _Kurs_WORKDataSet3TableAdapters.Черный_списокTableAdapter черный_списокTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn кодЧСDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn датаобращенияDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn номерутеряннойкартыDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn датааннулированияDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn выданановаякартаDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn номерновойкартыDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
	}
}