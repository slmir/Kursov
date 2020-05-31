namespace Kurs_Work_BD
{
	partial class Отчет_поставщики
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
			this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.специализацияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.лицензияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.отчетпоставщикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this._Kurs_WORKDataSet3 = new Kurs_Work_BD._Kurs_WORKDataSet3();
			this.отчет_поставщикиTableAdapter = new Kurs_Work_BD._Kurs_WORKDataSet3TableAdapters.Отчет_поставщикиTableAdapter();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.отчетпоставщикиBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._Kurs_WORKDataSet3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// Close
			// 
			this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Close.Location = new System.Drawing.Point(12, 415);
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
            this.названиеDataGridViewTextBoxColumn,
            this.специализацияDataGridViewTextBoxColumn,
            this.лицензияDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.отчетпоставщикиBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(13, 13);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(732, 396);
			this.dataGridView1.TabIndex = 2;
			// 
			// названиеDataGridViewTextBoxColumn
			// 
			this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
			this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
			this.названиеDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
			this.названиеDataGridViewTextBoxColumn.Width = 125;
			// 
			// специализацияDataGridViewTextBoxColumn
			// 
			this.специализацияDataGridViewTextBoxColumn.DataPropertyName = "Специализация";
			this.специализацияDataGridViewTextBoxColumn.HeaderText = "Специализация";
			this.специализацияDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.специализацияDataGridViewTextBoxColumn.Name = "специализацияDataGridViewTextBoxColumn";
			this.специализацияDataGridViewTextBoxColumn.Width = 125;
			// 
			// лицензияDataGridViewTextBoxColumn
			// 
			this.лицензияDataGridViewTextBoxColumn.DataPropertyName = "Лицензия";
			this.лицензияDataGridViewTextBoxColumn.HeaderText = "Лицензия";
			this.лицензияDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.лицензияDataGridViewTextBoxColumn.Name = "лицензияDataGridViewTextBoxColumn";
			this.лицензияDataGridViewTextBoxColumn.Width = 125;
			// 
			// отчетпоставщикиBindingSource
			// 
			this.отчетпоставщикиBindingSource.DataMember = "Отчет_поставщики";
			this.отчетпоставщикиBindingSource.DataSource = this._Kurs_WORKDataSet3;
			// 
			// _Kurs_WORKDataSet3
			// 
			this._Kurs_WORKDataSet3.DataSetName = "_Kurs_WORKDataSet3";
			this._Kurs_WORKDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// отчет_поставщикиTableAdapter
			// 
			this.отчет_поставщикиTableAdapter.ClearBeforeFill = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Kurs_Work_BD.Properties.Resources.фитнес_клуб_с_гантелями_строки_гантелей_металла_на_шкафе_для_150233004;
			this.pictureBox1.Location = new System.Drawing.Point(-233, -59);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1220, 604);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 32;
			this.pictureBox1.TabStop = false;
			// 
			// Отчет_поставщики
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(755, 486);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.Close);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Отчет_поставщики";
			this.Text = "Отчет_поставщики";
			this.Load += new System.EventHandler(this.Отчет_поставщики_Load);
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.отчетпоставщикиBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._Kurs_WORKDataSet3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Close;
		private System.Windows.Forms.BindingSource bindingSource1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private _Kurs_WORKDataSet3 _Kurs_WORKDataSet3;
		private System.Windows.Forms.BindingSource отчетпоставщикиBindingSource;
		private _Kurs_WORKDataSet3TableAdapters.Отчет_поставщикиTableAdapter отчет_поставщикиTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn специализацияDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn лицензияDataGridViewTextBoxColumn;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}