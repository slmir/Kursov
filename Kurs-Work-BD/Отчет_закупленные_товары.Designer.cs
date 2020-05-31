namespace Kurs_Work_BD
{
	partial class Отчет_закупленные_товары
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
			this.кодтовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.датапоставкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ценазаединицуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.поставщикDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.отчетзакупленныетоварыBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this._Kurs_WORKDataSet3 = new Kurs_Work_BD._Kurs_WORKDataSet3();
			this.отчет_закупленные_товарыTableAdapter = new Kurs_Work_BD._Kurs_WORKDataSet3TableAdapters.Отчет_закупленные_товарыTableAdapter();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.отчетзакупленныетоварыBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._Kurs_WORKDataSet3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// Close
			// 
			this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Close.Location = new System.Drawing.Point(12, 416);
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
            this.кодтовараDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.датапоставкиDataGridViewTextBoxColumn,
            this.ценазаединицуDataGridViewTextBoxColumn,
            this.поставщикDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.отчетзакупленныетоварыBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(13, 13);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(968, 397);
			this.dataGridView1.TabIndex = 2;
			// 
			// кодтовараDataGridViewTextBoxColumn
			// 
			this.кодтовараDataGridViewTextBoxColumn.DataPropertyName = "Код_товара";
			this.кодтовараDataGridViewTextBoxColumn.HeaderText = "Код_товара";
			this.кодтовараDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.кодтовараDataGridViewTextBoxColumn.Name = "кодтовараDataGridViewTextBoxColumn";
			this.кодтовараDataGridViewTextBoxColumn.Width = 125;
			// 
			// наименованиеDataGridViewTextBoxColumn
			// 
			this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
			this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
			this.наименованиеDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
			this.наименованиеDataGridViewTextBoxColumn.Width = 125;
			// 
			// количествоDataGridViewTextBoxColumn
			// 
			this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
			this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
			this.количествоDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
			this.количествоDataGridViewTextBoxColumn.Width = 125;
			// 
			// датапоставкиDataGridViewTextBoxColumn
			// 
			this.датапоставкиDataGridViewTextBoxColumn.DataPropertyName = "Дата_поставки";
			this.датапоставкиDataGridViewTextBoxColumn.HeaderText = "Дата_поставки";
			this.датапоставкиDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.датапоставкиDataGridViewTextBoxColumn.Name = "датапоставкиDataGridViewTextBoxColumn";
			this.датапоставкиDataGridViewTextBoxColumn.Width = 125;
			// 
			// ценазаединицуDataGridViewTextBoxColumn
			// 
			this.ценазаединицуDataGridViewTextBoxColumn.DataPropertyName = "Цена_за_единицу";
			this.ценазаединицуDataGridViewTextBoxColumn.HeaderText = "Цена_за_единицу";
			this.ценазаединицуDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.ценазаединицуDataGridViewTextBoxColumn.Name = "ценазаединицуDataGridViewTextBoxColumn";
			this.ценазаединицуDataGridViewTextBoxColumn.Width = 125;
			// 
			// поставщикDataGridViewTextBoxColumn
			// 
			this.поставщикDataGridViewTextBoxColumn.DataPropertyName = "Поставщик";
			this.поставщикDataGridViewTextBoxColumn.HeaderText = "Поставщик";
			this.поставщикDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.поставщикDataGridViewTextBoxColumn.Name = "поставщикDataGridViewTextBoxColumn";
			this.поставщикDataGridViewTextBoxColumn.Width = 125;
			// 
			// отчетзакупленныетоварыBindingSource
			// 
			this.отчетзакупленныетоварыBindingSource.DataMember = "Отчет_закупленные_товары";
			this.отчетзакупленныетоварыBindingSource.DataSource = this._Kurs_WORKDataSet3;
			// 
			// _Kurs_WORKDataSet3
			// 
			this._Kurs_WORKDataSet3.DataSetName = "_Kurs_WORKDataSet3";
			this._Kurs_WORKDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// отчет_закупленные_товарыTableAdapter
			// 
			this.отчет_закупленные_товарыTableAdapter.ClearBeforeFill = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Kurs_Work_BD.Properties.Resources.фитнес_клуб_с_гантелями_строки_гантелей_металла_на_шкафе_для_150233004;
			this.pictureBox1.Location = new System.Drawing.Point(-3, -32);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(998, 551);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 31;
			this.pictureBox1.TabStop = false;
			// 
			// Отчет_закупленные_товары
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(993, 487);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.Close);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Отчет_закупленные_товары";
			this.Text = "Отчет_закупленные_товары";
			this.Load += new System.EventHandler(this.Отчет_закупленные_товары_Load);
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.отчетзакупленныетоварыBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._Kurs_WORKDataSet3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Close;
		private System.Windows.Forms.BindingSource bindingSource1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private _Kurs_WORKDataSet3 _Kurs_WORKDataSet3;
		private System.Windows.Forms.BindingSource отчетзакупленныетоварыBindingSource;
		private _Kurs_WORKDataSet3TableAdapters.Отчет_закупленные_товарыTableAdapter отчет_закупленные_товарыTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn кодтовараDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn датапоставкиDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ценазаединицуDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn поставщикDataGridViewTextBoxColumn;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}