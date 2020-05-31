namespace Kurs_Work_BD
{
	partial class Отчет_абонементы
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
			this.видтренировкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.стоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.времядействиямесяцыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.количествопосещенийDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.возможностьзаморозкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.отчетабонементклиентобщийBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this._Kurs_WORKDataSet3 = new Kurs_Work_BD._Kurs_WORKDataSet3();
			this.отчет_абонемент_клиент_общийTableAdapter = new Kurs_Work_BD._Kurs_WORKDataSet3TableAdapters.Отчет_абонемент_клиент_общийTableAdapter();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.отчетабонементклиентобщийBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._Kurs_WORKDataSet3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// Close
			// 
			this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Close.Location = new System.Drawing.Point(12, 409);
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
            this.видтренировкиDataGridViewTextBoxColumn,
            this.стоимостьDataGridViewTextBoxColumn,
            this.времядействиямесяцыDataGridViewTextBoxColumn,
            this.количествопосещенийDataGridViewTextBoxColumn,
            this.возможностьзаморозкиDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.отчетабонементклиентобщийBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(13, 13);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(942, 390);
			this.dataGridView1.TabIndex = 2;
			// 
			// видтренировкиDataGridViewTextBoxColumn
			// 
			this.видтренировкиDataGridViewTextBoxColumn.DataPropertyName = "Вид_тренировки";
			this.видтренировкиDataGridViewTextBoxColumn.HeaderText = "Вид_тренировки";
			this.видтренировкиDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.видтренировкиDataGridViewTextBoxColumn.Name = "видтренировкиDataGridViewTextBoxColumn";
			this.видтренировкиDataGridViewTextBoxColumn.Width = 125;
			// 
			// стоимостьDataGridViewTextBoxColumn
			// 
			this.стоимостьDataGridViewTextBoxColumn.DataPropertyName = "Стоимость";
			this.стоимостьDataGridViewTextBoxColumn.HeaderText = "Стоимость";
			this.стоимостьDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.стоимостьDataGridViewTextBoxColumn.Name = "стоимостьDataGridViewTextBoxColumn";
			this.стоимостьDataGridViewTextBoxColumn.Width = 125;
			// 
			// времядействиямесяцыDataGridViewTextBoxColumn
			// 
			this.времядействиямесяцыDataGridViewTextBoxColumn.DataPropertyName = "Время_действия_месяцы";
			this.времядействиямесяцыDataGridViewTextBoxColumn.HeaderText = "Время_действия_месяцы";
			this.времядействиямесяцыDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.времядействиямесяцыDataGridViewTextBoxColumn.Name = "времядействиямесяцыDataGridViewTextBoxColumn";
			this.времядействиямесяцыDataGridViewTextBoxColumn.Width = 125;
			// 
			// количествопосещенийDataGridViewTextBoxColumn
			// 
			this.количествопосещенийDataGridViewTextBoxColumn.DataPropertyName = "Количество_посещений";
			this.количествопосещенийDataGridViewTextBoxColumn.HeaderText = "Количество_посещений";
			this.количествопосещенийDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.количествопосещенийDataGridViewTextBoxColumn.Name = "количествопосещенийDataGridViewTextBoxColumn";
			this.количествопосещенийDataGridViewTextBoxColumn.Width = 125;
			// 
			// возможностьзаморозкиDataGridViewTextBoxColumn
			// 
			this.возможностьзаморозкиDataGridViewTextBoxColumn.DataPropertyName = "Возможность_заморозки";
			this.возможностьзаморозкиDataGridViewTextBoxColumn.HeaderText = "Возможность_заморозки";
			this.возможностьзаморозкиDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.возможностьзаморозкиDataGridViewTextBoxColumn.Name = "возможностьзаморозкиDataGridViewTextBoxColumn";
			this.возможностьзаморозкиDataGridViewTextBoxColumn.Width = 125;
			// 
			// отчетабонементклиентобщийBindingSource
			// 
			this.отчетабонементклиентобщийBindingSource.DataMember = "Отчет_абонемент_клиент+общий";
			this.отчетабонементклиентобщийBindingSource.DataSource = this._Kurs_WORKDataSet3;
			// 
			// _Kurs_WORKDataSet3
			// 
			this._Kurs_WORKDataSet3.DataSetName = "_Kurs_WORKDataSet3";
			this._Kurs_WORKDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// отчет_абонемент_клиент_общийTableAdapter
			// 
			this.отчет_абонемент_клиент_общийTableAdapter.ClearBeforeFill = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Kurs_Work_BD.Properties.Resources.фитнес_клуб_с_гантелями_строки_гантелей_металла_на_шкафе_для_150233004;
			this.pictureBox1.Location = new System.Drawing.Point(-16, -35);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(998, 551);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 31;
			this.pictureBox1.TabStop = false;
			// 
			// Отчет_абонементы
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(967, 480);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.Close);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Отчет_абонементы";
			this.Text = "Отчет_абонементы";
			this.Load += new System.EventHandler(this.Отчет_абонементы_Load);
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.отчетабонементклиентобщийBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._Kurs_WORKDataSet3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Close;
		private System.Windows.Forms.BindingSource bindingSource1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private _Kurs_WORKDataSet3 _Kurs_WORKDataSet3;
		private System.Windows.Forms.BindingSource отчетабонементклиентобщийBindingSource;
		private _Kurs_WORKDataSet3TableAdapters.Отчет_абонемент_клиент_общийTableAdapter отчет_абонемент_клиент_общийTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn видтренировкиDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn времядействиямесяцыDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn количествопосещенийDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn возможностьзаморозкиDataGridViewTextBoxColumn;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}