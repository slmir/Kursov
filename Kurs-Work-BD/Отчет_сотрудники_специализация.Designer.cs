namespace Kurs_Work_BD
{
	partial class Отчет_сотрудники_специализация
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
			this.основнаяспециализацияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.видтренировкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.достиженияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.отчетсотрудникиспециализацияBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this._Kurs_WORKDataSet3 = new Kurs_Work_BD._Kurs_WORKDataSet3();
			this.отчет_сотрудники_специализацияTableAdapter = new Kurs_Work_BD._Kurs_WORKDataSet3TableAdapters.Отчет_сотрудники_специализацияTableAdapter();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.отчетсотрудникиспециализацияBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._Kurs_WORKDataSet3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// Close
			// 
			this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Close.Location = new System.Drawing.Point(13, 399);
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
            this.основнаяспециализацияDataGridViewTextBoxColumn,
            this.видтренировкиDataGridViewTextBoxColumn,
            this.достиженияDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.описаниеDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.отчетсотрудникиспециализацияBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(13, 13);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1323, 380);
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
			// основнаяспециализацияDataGridViewTextBoxColumn
			// 
			this.основнаяспециализацияDataGridViewTextBoxColumn.DataPropertyName = "Основная_специализация";
			this.основнаяспециализацияDataGridViewTextBoxColumn.HeaderText = "Основная_специализация";
			this.основнаяспециализацияDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.основнаяспециализацияDataGridViewTextBoxColumn.Name = "основнаяспециализацияDataGridViewTextBoxColumn";
			this.основнаяспециализацияDataGridViewTextBoxColumn.Width = 125;
			// 
			// видтренировкиDataGridViewTextBoxColumn
			// 
			this.видтренировкиDataGridViewTextBoxColumn.DataPropertyName = "Вид_тренировки";
			this.видтренировкиDataGridViewTextBoxColumn.HeaderText = "Вид_тренировки";
			this.видтренировкиDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.видтренировкиDataGridViewTextBoxColumn.Name = "видтренировкиDataGridViewTextBoxColumn";
			this.видтренировкиDataGridViewTextBoxColumn.Width = 125;
			// 
			// достиженияDataGridViewTextBoxColumn
			// 
			this.достиженияDataGridViewTextBoxColumn.DataPropertyName = "Достижения";
			this.достиженияDataGridViewTextBoxColumn.HeaderText = "Достижения";
			this.достиженияDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.достиженияDataGridViewTextBoxColumn.Name = "достиженияDataGridViewTextBoxColumn";
			this.достиженияDataGridViewTextBoxColumn.Width = 125;
			// 
			// телефонDataGridViewTextBoxColumn
			// 
			this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
			this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
			this.телефонDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
			this.телефонDataGridViewTextBoxColumn.Width = 125;
			// 
			// описаниеDataGridViewTextBoxColumn
			// 
			this.описаниеDataGridViewTextBoxColumn.DataPropertyName = "Описание";
			this.описаниеDataGridViewTextBoxColumn.HeaderText = "Описание";
			this.описаниеDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.описаниеDataGridViewTextBoxColumn.Name = "описаниеDataGridViewTextBoxColumn";
			this.описаниеDataGridViewTextBoxColumn.Width = 125;
			// 
			// отчетсотрудникиспециализацияBindingSource
			// 
			this.отчетсотрудникиспециализацияBindingSource.DataMember = "Отчет_сотрудники_специализация";
			this.отчетсотрудникиспециализацияBindingSource.DataSource = this._Kurs_WORKDataSet3;
			// 
			// _Kurs_WORKDataSet3
			// 
			this._Kurs_WORKDataSet3.DataSetName = "_Kurs_WORKDataSet3";
			this._Kurs_WORKDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// отчет_сотрудники_специализацияTableAdapter
			// 
			this.отчет_сотрудники_специализацияTableAdapter.ClearBeforeFill = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Kurs_Work_BD.Properties.Resources.фитнес_клуб_с_гантелями_строки_гантелей_металла_на_шкафе_для_150233004;
			this.pictureBox1.Location = new System.Drawing.Point(0, -68);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1284, 604);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 32;
			this.pictureBox1.TabStop = false;
			// 
			// Отчет_сотрудники_специализация
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1348, 469);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.Close);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Отчет_сотрудники_специализация";
			this.Text = "Отчет_сотрудники_специализация";
			this.Load += new System.EventHandler(this.Отчет_сотрудники_специализация_Load);
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.отчетсотрудникиспециализацияBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._Kurs_WORKDataSet3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Close;
		private System.Windows.Forms.BindingSource bindingSource1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private _Kurs_WORKDataSet3 _Kurs_WORKDataSet3;
		private System.Windows.Forms.BindingSource отчетсотрудникиспециализацияBindingSource;
		private _Kurs_WORKDataSet3TableAdapters.Отчет_сотрудники_специализацияTableAdapter отчет_сотрудники_специализацияTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn основнаяспециализацияDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn видтренировкиDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn достиженияDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}