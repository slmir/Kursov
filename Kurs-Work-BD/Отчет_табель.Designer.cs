namespace Kurs_Work_BD
{
	partial class Отчет_табель
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
			this.Close = new System.Windows.Forms.Button();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.отчеттабельBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this._Kurs_WORKDataSet3 = new Kurs_Work_BD._Kurs_WORKDataSet3();
			this.отчет_табельTableAdapter = new Kurs_Work_BD._Kurs_WORKDataSet3TableAdapters.Отчет_табельTableAdapter();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this._Kurs_WORKDataSet15 = new Kurs_Work_BD._Kurs_WORKDataSet15();
			this.отчеттабельBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.отчет_табельTableAdapter1 = new Kurs_Work_BD._Kurs_WORKDataSet15TableAdapters.Отчет_табельTableAdapter();
			this.кодТРтабельDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.времяначаласменыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.времяконцасменыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.кодтренировкитDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.работазаменяющимтренеромDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.фамилияЗаменяемогоТренераDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.кодзаменяемойтренировкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.описаниезаменыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.отчеттабельBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._Kurs_WORKDataSet3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._Kurs_WORKDataSet15)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.отчеттабельBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// Close
			// 
			this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Close.Location = new System.Drawing.Point(13, 431);
			this.Close.Name = "Close";
			this.Close.Size = new System.Drawing.Size(224, 59);
			this.Close.TabIndex = 1;
			this.Close.Text = "Закрыть окно просмотра отчета";
			this.Close.UseVisualStyleBackColor = true;
			this.Close.Click += new System.EventHandler(this.Close_Click);
			// 
			// отчеттабельBindingSource
			// 
			this.отчеттабельBindingSource.DataMember = "Отчет_табель";
			this.отчеттабельBindingSource.DataSource = this._Kurs_WORKDataSet3;
			// 
			// _Kurs_WORKDataSet3
			// 
			this._Kurs_WORKDataSet3.DataSetName = "_Kurs_WORKDataSet3";
			this._Kurs_WORKDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// отчет_табельTableAdapter
			// 
			this.отчет_табельTableAdapter.ClearBeforeFill = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Kurs_Work_BD.Properties.Resources.фитнес_клуб_с_гантелями_строки_гантелей_металла_на_шкафе_для_150233004;
			this.pictureBox1.Location = new System.Drawing.Point(0, -51);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1574, 636);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 32;
			this.pictureBox1.TabStop = false;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодТРтабельDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.времяначаласменыDataGridViewTextBoxColumn,
            this.времяконцасменыDataGridViewTextBoxColumn,
            this.кодтренировкитDataGridViewTextBoxColumn,
            this.описаниеDataGridViewTextBoxColumn,
            this.работазаменяющимтренеромDataGridViewTextBoxColumn,
            this.фамилияЗаменяемогоТренераDataGridViewTextBoxColumn,
            this.кодзаменяемойтренировкиDataGridViewTextBoxColumn,
            this.описаниезаменыDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.отчеттабельBindingSource1;
			this.dataGridView1.Location = new System.Drawing.Point(13, 13);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1518, 412);
			this.dataGridView1.TabIndex = 33;
			// 
			// _Kurs_WORKDataSet15
			// 
			this._Kurs_WORKDataSet15.DataSetName = "_Kurs_WORKDataSet15";
			this._Kurs_WORKDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// отчеттабельBindingSource1
			// 
			this.отчеттабельBindingSource1.DataMember = "Отчет_табель";
			this.отчеттабельBindingSource1.DataSource = this._Kurs_WORKDataSet15;
			// 
			// отчет_табельTableAdapter1
			// 
			this.отчет_табельTableAdapter1.ClearBeforeFill = true;
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
			// фамилияDataGridViewTextBoxColumn
			// 
			this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
			this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
			this.фамилияDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
			this.фамилияDataGridViewTextBoxColumn.Width = 125;
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
			// фамилияЗаменяемогоТренераDataGridViewTextBoxColumn
			// 
			this.фамилияЗаменяемогоТренераDataGridViewTextBoxColumn.DataPropertyName = "Фамилия заменяемого тренера";
			this.фамилияЗаменяемогоТренераDataGridViewTextBoxColumn.HeaderText = "Фамилия заменяемого тренера";
			this.фамилияЗаменяемогоТренераDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.фамилияЗаменяемогоТренераDataGridViewTextBoxColumn.Name = "фамилияЗаменяемогоТренераDataGridViewTextBoxColumn";
			this.фамилияЗаменяемогоТренераDataGridViewTextBoxColumn.Width = 125;
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
			// Отчет_табель
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1543, 502);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.Close);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Отчет_табель";
			this.Text = "Отчет_табель";
			this.Load += new System.EventHandler(this.Отчет_табель_Load);
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.отчеттабельBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._Kurs_WORKDataSet3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._Kurs_WORKDataSet15)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.отчеттабельBindingSource1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Close;
		private System.Windows.Forms.BindingSource bindingSource1;
		private _Kurs_WORKDataSet3 _Kurs_WORKDataSet3;
		private System.Windows.Forms.BindingSource отчеттабельBindingSource;
		private _Kurs_WORKDataSet3TableAdapters.Отчет_табельTableAdapter отчет_табельTableAdapter;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private _Kurs_WORKDataSet15 _Kurs_WORKDataSet15;
		private System.Windows.Forms.BindingSource отчеттабельBindingSource1;
		private _Kurs_WORKDataSet15TableAdapters.Отчет_табельTableAdapter отчет_табельTableAdapter1;
		private System.Windows.Forms.DataGridViewTextBoxColumn кодТРтабельDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn времяначаласменыDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn времяконцасменыDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn кодтренировкитDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn работазаменяющимтренеромDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn фамилияЗаменяемогоТренераDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn кодзаменяемойтренировкиDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn описаниезаменыDataGridViewTextBoxColumn;
	}
}