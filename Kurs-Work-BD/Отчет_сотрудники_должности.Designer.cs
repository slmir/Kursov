namespace Kurs_Work_BD
{
	partial class Отчет_сотрудники_должности
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.кодсотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.датаначалаработыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.окладDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.отчетсотрудникидолжностиBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this._Kurs_WORKDataSet3 = new Kurs_Work_BD._Kurs_WORKDataSet3();
			this.отчет_сотрудники_должностиTableAdapter = new Kurs_Work_BD._Kurs_WORKDataSet3TableAdapters.Отчет_сотрудники_должностиTableAdapter();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.отчетсотрудникидолжностиBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._Kurs_WORKDataSet3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// Close
			// 
			this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Close.Location = new System.Drawing.Point(12, 388);
			this.Close.Name = "Close";
			this.Close.Size = new System.Drawing.Size(224, 59);
			this.Close.TabIndex = 1;
			this.Close.Text = "Закрыть окно просмотра отчета";
			this.Close.UseVisualStyleBackColor = true;
			this.Close.Click += new System.EventHandler(this.Close_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодсотрудникаDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.датаначалаработыDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn,
            this.окладDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.отчетсотрудникидолжностиBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 13);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1240, 369);
			this.dataGridView1.TabIndex = 2;
			// 
			// кодсотрудникаDataGridViewTextBoxColumn
			// 
			this.кодсотрудникаDataGridViewTextBoxColumn.DataPropertyName = "Код_сотрудника";
			this.кодсотрудникаDataGridViewTextBoxColumn.HeaderText = "Код_сотрудника";
			this.кодсотрудникаDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.кодсотрудникаDataGridViewTextBoxColumn.Name = "кодсотрудникаDataGridViewTextBoxColumn";
			this.кодсотрудникаDataGridViewTextBoxColumn.Width = 125;
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
			// телефонDataGridViewTextBoxColumn
			// 
			this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
			this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
			this.телефонDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
			this.телефонDataGridViewTextBoxColumn.Width = 125;
			// 
			// датаначалаработыDataGridViewTextBoxColumn
			// 
			this.датаначалаработыDataGridViewTextBoxColumn.DataPropertyName = "Дата_начала_работы";
			this.датаначалаработыDataGridViewTextBoxColumn.HeaderText = "Дата_начала_работы";
			this.датаначалаработыDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.датаначалаработыDataGridViewTextBoxColumn.Name = "датаначалаработыDataGridViewTextBoxColumn";
			this.датаначалаработыDataGridViewTextBoxColumn.Width = 125;
			// 
			// должностьDataGridViewTextBoxColumn
			// 
			this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
			this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
			this.должностьDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
			this.должностьDataGridViewTextBoxColumn.Width = 125;
			// 
			// окладDataGridViewTextBoxColumn
			// 
			this.окладDataGridViewTextBoxColumn.DataPropertyName = "Оклад";
			this.окладDataGridViewTextBoxColumn.HeaderText = "Оклад";
			this.окладDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.окладDataGridViewTextBoxColumn.Name = "окладDataGridViewTextBoxColumn";
			this.окладDataGridViewTextBoxColumn.Width = 125;
			// 
			// отчетсотрудникидолжностиBindingSource
			// 
			this.отчетсотрудникидолжностиBindingSource.DataMember = "Отчет_сотрудники_должности";
			this.отчетсотрудникидолжностиBindingSource.DataSource = this._Kurs_WORKDataSet3;
			// 
			// _Kurs_WORKDataSet3
			// 
			this._Kurs_WORKDataSet3.DataSetName = "_Kurs_WORKDataSet3";
			this._Kurs_WORKDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// отчет_сотрудники_должностиTableAdapter
			// 
			this.отчет_сотрудники_должностиTableAdapter.ClearBeforeFill = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Kurs_Work_BD.Properties.Resources.фитнес_клуб_с_гантелями_строки_гантелей_металла_на_шкафе_для_150233004;
			this.pictureBox1.Location = new System.Drawing.Point(-8, -74);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1278, 604);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 32;
			this.pictureBox1.TabStop = false;
			// 
			// Отчет_сотрудники_должности
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1264, 456);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.Close);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Отчет_сотрудники_должности";
			this.Text = "Отчет_сотрудники_должности";
			this.Load += new System.EventHandler(this.Отчет_сотрудники_должности_Load);
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.отчетсотрудникидолжностиBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._Kurs_WORKDataSet3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Close;
		private System.Windows.Forms.BindingSource bindingSource1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private _Kurs_WORKDataSet3 _Kurs_WORKDataSet3;
		private System.Windows.Forms.BindingSource отчетсотрудникидолжностиBindingSource;
		private _Kurs_WORKDataSet3TableAdapters.Отчет_сотрудники_должностиTableAdapter отчет_сотрудники_должностиTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn кодсотрудникаDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn датаначалаработыDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn окладDataGridViewTextBoxColumn;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}