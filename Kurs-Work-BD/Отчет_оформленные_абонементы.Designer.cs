namespace Kurs_Work_BD
{
	partial class Отчет_оформленные_абонементы
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
			this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.номеркартыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.кодабонементаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.датаначаладействияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.осталосьпосещенийDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.отчетоформлениеабонементовBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this._Kurs_WORKDataSet3 = new Kurs_Work_BD._Kurs_WORKDataSet3();
			this.отчет_оформление_абонементовTableAdapter = new Kurs_Work_BD._Kurs_WORKDataSet3TableAdapters.Отчет_оформление_абонементовTableAdapter();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.отчетоформлениеабонементовBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._Kurs_WORKDataSet3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// Close
			// 
			this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Close.Location = new System.Drawing.Point(12, 468);
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
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.номеркартыDataGridViewTextBoxColumn,
            this.кодабонементаDataGridViewTextBoxColumn,
            this.датаначаладействияDataGridViewTextBoxColumn,
            this.осталосьпосещенийDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.отчетоформлениеабонементовBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(13, 13);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1214, 449);
			this.dataGridView1.TabIndex = 2;
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
			// номеркартыDataGridViewTextBoxColumn
			// 
			this.номеркартыDataGridViewTextBoxColumn.DataPropertyName = "Номер_карты";
			this.номеркартыDataGridViewTextBoxColumn.HeaderText = "Номер_карты";
			this.номеркартыDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.номеркартыDataGridViewTextBoxColumn.Name = "номеркартыDataGridViewTextBoxColumn";
			this.номеркартыDataGridViewTextBoxColumn.Width = 125;
			// 
			// кодабонементаDataGridViewTextBoxColumn
			// 
			this.кодабонементаDataGridViewTextBoxColumn.DataPropertyName = "Код_абонемента";
			this.кодабонементаDataGridViewTextBoxColumn.HeaderText = "Код_абонемента";
			this.кодабонементаDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.кодабонементаDataGridViewTextBoxColumn.Name = "кодабонементаDataGridViewTextBoxColumn";
			this.кодабонементаDataGridViewTextBoxColumn.Width = 125;
			// 
			// датаначаладействияDataGridViewTextBoxColumn
			// 
			this.датаначаладействияDataGridViewTextBoxColumn.DataPropertyName = "Дата_начала_действия";
			this.датаначаладействияDataGridViewTextBoxColumn.HeaderText = "Дата_начала_действия";
			this.датаначаладействияDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.датаначаладействияDataGridViewTextBoxColumn.Name = "датаначаладействияDataGridViewTextBoxColumn";
			this.датаначаладействияDataGridViewTextBoxColumn.Width = 125;
			// 
			// осталосьпосещенийDataGridViewTextBoxColumn
			// 
			this.осталосьпосещенийDataGridViewTextBoxColumn.DataPropertyName = "Осталось_посещений";
			this.осталосьпосещенийDataGridViewTextBoxColumn.HeaderText = "Осталось_посещений";
			this.осталосьпосещенийDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.осталосьпосещенийDataGridViewTextBoxColumn.Name = "осталосьпосещенийDataGridViewTextBoxColumn";
			this.осталосьпосещенийDataGridViewTextBoxColumn.Width = 125;
			// 
			// отчетоформлениеабонементовBindingSource
			// 
			this.отчетоформлениеабонементовBindingSource.DataMember = "Отчет_оформление_абонементов";
			this.отчетоформлениеабонементовBindingSource.DataSource = this._Kurs_WORKDataSet3;
			// 
			// _Kurs_WORKDataSet3
			// 
			this._Kurs_WORKDataSet3.DataSetName = "_Kurs_WORKDataSet3";
			this._Kurs_WORKDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// отчет_оформление_абонементовTableAdapter
			// 
			this.отчет_оформление_абонементовTableAdapter.ClearBeforeFill = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Kurs_Work_BD.Properties.Resources.фитнес_клуб_с_гантелями_строки_гантелей_металла_на_шкафе_для_150233004;
			this.pictureBox1.Location = new System.Drawing.Point(-4, -6);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1243, 551);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 31;
			this.pictureBox1.TabStop = false;
			// 
			// Отчет_оформленные_абонементы
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1239, 539);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.Close);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Отчет_оформленные_абонементы";
			this.Text = "Отчет_оформленные_абонементы";
			this.Load += new System.EventHandler(this.Отчет_оформленные_абонементы_Load);
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.отчетоформлениеабонементовBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._Kurs_WORKDataSet3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Close;
		private System.Windows.Forms.BindingSource bindingSource1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private _Kurs_WORKDataSet3 _Kurs_WORKDataSet3;
		private System.Windows.Forms.BindingSource отчетоформлениеабонементовBindingSource;
		private _Kurs_WORKDataSet3TableAdapters.Отчет_оформление_абонементовTableAdapter отчет_оформление_абонементовTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn номеркартыDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn кодабонементаDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn датаначаладействияDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn осталосьпосещенийDataGridViewTextBoxColumn;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}