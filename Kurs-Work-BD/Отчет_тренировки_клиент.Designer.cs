namespace Kurs_Work_BD
{
	partial class Отчет_тренировки_клиент
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
			this.наименованиеуслугиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.номерзалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.длительностьчасовDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.времяначалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.отчеттренировкиклиентBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this._Kurs_WORKDataSet3 = new Kurs_Work_BD._Kurs_WORKDataSet3();
			this.отчет_тренировки_клиентTableAdapter = new Kurs_Work_BD._Kurs_WORKDataSet3TableAdapters.Отчет_тренировки_клиентTableAdapter();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.отчеттренировкиклиентBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._Kurs_WORKDataSet3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// Close
			// 
			this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Close.Location = new System.Drawing.Point(13, 312);
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
            this.наименованиеуслугиDataGridViewTextBoxColumn,
            this.номерзалаDataGridViewTextBoxColumn,
            this.длительностьчасовDataGridViewTextBoxColumn,
            this.времяначалаDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.отчеттренировкиклиентBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(13, 13);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(933, 293);
			this.dataGridView1.TabIndex = 2;
			// 
			// наименованиеуслугиDataGridViewTextBoxColumn
			// 
			this.наименованиеуслугиDataGridViewTextBoxColumn.DataPropertyName = "Наименование_услуги";
			this.наименованиеуслугиDataGridViewTextBoxColumn.HeaderText = "Наименование_услуги";
			this.наименованиеуслугиDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.наименованиеуслугиDataGridViewTextBoxColumn.Name = "наименованиеуслугиDataGridViewTextBoxColumn";
			this.наименованиеуслугиDataGridViewTextBoxColumn.Width = 125;
			// 
			// номерзалаDataGridViewTextBoxColumn
			// 
			this.номерзалаDataGridViewTextBoxColumn.DataPropertyName = "Номер_зала";
			this.номерзалаDataGridViewTextBoxColumn.HeaderText = "Номер_зала";
			this.номерзалаDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.номерзалаDataGridViewTextBoxColumn.Name = "номерзалаDataGridViewTextBoxColumn";
			this.номерзалаDataGridViewTextBoxColumn.Width = 125;
			// 
			// длительностьчасовDataGridViewTextBoxColumn
			// 
			this.длительностьчасовDataGridViewTextBoxColumn.DataPropertyName = "Длительность_часов";
			this.длительностьчасовDataGridViewTextBoxColumn.HeaderText = "Длительность_часов";
			this.длительностьчасовDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.длительностьчасовDataGridViewTextBoxColumn.Name = "длительностьчасовDataGridViewTextBoxColumn";
			this.длительностьчасовDataGridViewTextBoxColumn.Width = 125;
			// 
			// времяначалаDataGridViewTextBoxColumn
			// 
			this.времяначалаDataGridViewTextBoxColumn.DataPropertyName = "Время_начала";
			this.времяначалаDataGridViewTextBoxColumn.HeaderText = "Время_начала";
			this.времяначалаDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.времяначалаDataGridViewTextBoxColumn.Name = "времяначалаDataGridViewTextBoxColumn";
			this.времяначалаDataGridViewTextBoxColumn.Width = 125;
			// 
			// отчеттренировкиклиентBindingSource
			// 
			this.отчеттренировкиклиентBindingSource.DataMember = "Отчет_тренировки_клиент";
			this.отчеттренировкиклиентBindingSource.DataSource = this._Kurs_WORKDataSet3;
			// 
			// _Kurs_WORKDataSet3
			// 
			this._Kurs_WORKDataSet3.DataSetName = "_Kurs_WORKDataSet3";
			this._Kurs_WORKDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// отчет_тренировки_клиентTableAdapter
			// 
			this.отчет_тренировки_клиентTableAdapter.ClearBeforeFill = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Kurs_Work_BD.Properties.Resources.фитнес_клуб_с_гантелями_строки_гантелей_металла_на_шкафе_для_150233004;
			this.pictureBox1.Location = new System.Drawing.Point(-133, -112);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1220, 604);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 32;
			this.pictureBox1.TabStop = false;
			// 
			// Отчет_тренировки_клиент
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(954, 380);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.Close);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Отчет_тренировки_клиент";
			this.Text = "Отчет_тренировки_клиент";
			this.Load += new System.EventHandler(this.Отчет_тренировки_клиент_Load);
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.отчеттренировкиклиентBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._Kurs_WORKDataSet3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Close;
		private System.Windows.Forms.BindingSource bindingSource1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private _Kurs_WORKDataSet3 _Kurs_WORKDataSet3;
		private System.Windows.Forms.BindingSource отчеттренировкиклиентBindingSource;
		private _Kurs_WORKDataSet3TableAdapters.Отчет_тренировки_клиентTableAdapter отчет_тренировки_клиентTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеуслугиDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn номерзалаDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn длительностьчасовDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn времяначалаDataGridViewTextBoxColumn;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}