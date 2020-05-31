namespace Kurs_Work_BD
{
	partial class Отчет_ЧС_карт
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
			this._Kurs_WORKDataSet3 = new Kurs_Work_BD._Kurs_WORKDataSet3();
			this.отчетЧСкартBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.отчет_ЧС_картTableAdapter = new Kurs_Work_BD._Kurs_WORKDataSet3TableAdapters.Отчет_ЧС_картTableAdapter();
			this.отчетуслугиBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.отчет_услугиTableAdapter = new Kurs_Work_BD._Kurs_WORKDataSet3TableAdapters.Отчет_услугиTableAdapter();
			this.отчетЧСкартBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.отчетЧСкартBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.отчетЧСкартBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.кодЧСDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.датаобращенияDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.номерутеряннойкартыDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.датааннулированияDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.выданановаякартаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.номерновойкартыDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.описаниеDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this._Kurs_WORKDataSet3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.отчетЧСкартBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.отчетуслугиBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.отчетЧСкартBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.отчетЧСкартBindingSource2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.отчетЧСкартBindingSource3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// Close
			// 
			this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Close.Location = new System.Drawing.Point(12, 381);
			this.Close.Name = "Close";
			this.Close.Size = new System.Drawing.Size(224, 59);
			this.Close.TabIndex = 0;
			this.Close.Text = "Закрыть окно просмотра отчета";
			this.Close.UseVisualStyleBackColor = true;
			this.Close.Click += new System.EventHandler(this.Close_Click);
			// 
			// _Kurs_WORKDataSet3
			// 
			this._Kurs_WORKDataSet3.DataSetName = "_Kurs_WORKDataSet3";
			this._Kurs_WORKDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// отчетЧСкартBindingSource
			// 
			this.отчетЧСкартBindingSource.DataMember = "Отчет_ЧС_карт";
			this.отчетЧСкартBindingSource.DataSource = this._Kurs_WORKDataSet3;
			// 
			// отчет_ЧС_картTableAdapter
			// 
			this.отчет_ЧС_картTableAdapter.ClearBeforeFill = true;
			// 
			// отчетуслугиBindingSource
			// 
			this.отчетуслугиBindingSource.DataMember = "Отчет_услуги";
			this.отчетуслугиBindingSource.DataSource = this._Kurs_WORKDataSet3;
			// 
			// отчет_услугиTableAdapter
			// 
			this.отчет_услугиTableAdapter.ClearBeforeFill = true;
			// 
			// отчетЧСкартBindingSource1
			// 
			this.отчетЧСкартBindingSource1.DataMember = "Отчет_ЧС_карт";
			this.отчетЧСкартBindingSource1.DataSource = this._Kurs_WORKDataSet3;
			// 
			// отчетЧСкартBindingSource2
			// 
			this.отчетЧСкартBindingSource2.DataMember = "Отчет_ЧС_карт";
			this.отчетЧСкартBindingSource2.DataSource = this._Kurs_WORKDataSet3;
			// 
			// отчетЧСкартBindingSource3
			// 
			this.отчетЧСкартBindingSource3.DataMember = "Отчет_ЧС_карт";
			this.отчетЧСкартBindingSource3.DataSource = this._Kurs_WORKDataSet3;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Kurs_Work_BD.Properties.Resources.фитнес_клуб_с_гантелями_строки_гантелей_металла_на_шкафе_для_150233004;
			this.pictureBox1.Location = new System.Drawing.Point(-34, -50);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1046, 515);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 32;
			this.pictureBox1.TabStop = false;
			// 
			// dataGridView2
			// 
			this.dataGridView2.AutoGenerateColumns = false;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодЧСDataGridViewTextBoxColumn1,
            this.датаобращенияDataGridViewTextBoxColumn1,
            this.номерутеряннойкартыDataGridViewTextBoxColumn1,
            this.датааннулированияDataGridViewTextBoxColumn1,
            this.выданановаякартаDataGridViewTextBoxColumn1,
            this.номерновойкартыDataGridViewTextBoxColumn1,
            this.описаниеDataGridViewTextBoxColumn1});
			this.dataGridView2.DataSource = this.отчетЧСкартBindingSource3;
			this.dataGridView2.Location = new System.Drawing.Point(13, 13);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.RowHeadersWidth = 51;
			this.dataGridView2.RowTemplate.Height = 24;
			this.dataGridView2.Size = new System.Drawing.Size(960, 362);
			this.dataGridView2.TabIndex = 33;
			// 
			// кодЧСDataGridViewTextBoxColumn1
			// 
			this.кодЧСDataGridViewTextBoxColumn1.DataPropertyName = "Код_ЧС";
			this.кодЧСDataGridViewTextBoxColumn1.HeaderText = "Код_ЧС";
			this.кодЧСDataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.кодЧСDataGridViewTextBoxColumn1.Name = "кодЧСDataGridViewTextBoxColumn1";
			this.кодЧСDataGridViewTextBoxColumn1.Width = 125;
			// 
			// датаобращенияDataGridViewTextBoxColumn1
			// 
			this.датаобращенияDataGridViewTextBoxColumn1.DataPropertyName = "Дата_обращения";
			this.датаобращенияDataGridViewTextBoxColumn1.HeaderText = "Дата_обращения";
			this.датаобращенияDataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.датаобращенияDataGridViewTextBoxColumn1.Name = "датаобращенияDataGridViewTextBoxColumn1";
			this.датаобращенияDataGridViewTextBoxColumn1.Width = 125;
			// 
			// номерутеряннойкартыDataGridViewTextBoxColumn1
			// 
			this.номерутеряннойкартыDataGridViewTextBoxColumn1.DataPropertyName = "Номер_утерянной_карты";
			this.номерутеряннойкартыDataGridViewTextBoxColumn1.HeaderText = "Номер_утерянной_карты";
			this.номерутеряннойкартыDataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.номерутеряннойкартыDataGridViewTextBoxColumn1.Name = "номерутеряннойкартыDataGridViewTextBoxColumn1";
			this.номерутеряннойкартыDataGridViewTextBoxColumn1.Width = 125;
			// 
			// датааннулированияDataGridViewTextBoxColumn1
			// 
			this.датааннулированияDataGridViewTextBoxColumn1.DataPropertyName = "Дата_аннулирования";
			this.датааннулированияDataGridViewTextBoxColumn1.HeaderText = "Дата_аннулирования";
			this.датааннулированияDataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.датааннулированияDataGridViewTextBoxColumn1.Name = "датааннулированияDataGridViewTextBoxColumn1";
			this.датааннулированияDataGridViewTextBoxColumn1.Width = 125;
			// 
			// выданановаякартаDataGridViewTextBoxColumn1
			// 
			this.выданановаякартаDataGridViewTextBoxColumn1.DataPropertyName = "Выдана_новая_карта";
			this.выданановаякартаDataGridViewTextBoxColumn1.HeaderText = "Выдана_новая_карта";
			this.выданановаякартаDataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.выданановаякартаDataGridViewTextBoxColumn1.Name = "выданановаякартаDataGridViewTextBoxColumn1";
			this.выданановаякартаDataGridViewTextBoxColumn1.Width = 125;
			// 
			// номерновойкартыDataGridViewTextBoxColumn1
			// 
			this.номерновойкартыDataGridViewTextBoxColumn1.DataPropertyName = "Номер_новой_карты";
			this.номерновойкартыDataGridViewTextBoxColumn1.HeaderText = "Номер_новой_карты";
			this.номерновойкартыDataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.номерновойкартыDataGridViewTextBoxColumn1.Name = "номерновойкартыDataGridViewTextBoxColumn1";
			this.номерновойкартыDataGridViewTextBoxColumn1.Width = 125;
			// 
			// описаниеDataGridViewTextBoxColumn1
			// 
			this.описаниеDataGridViewTextBoxColumn1.DataPropertyName = "Описание";
			this.описаниеDataGridViewTextBoxColumn1.HeaderText = "Описание";
			this.описаниеDataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.описаниеDataGridViewTextBoxColumn1.Name = "описаниеDataGridViewTextBoxColumn1";
			this.описаниеDataGridViewTextBoxColumn1.Width = 125;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(13, 381);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(224, 59);
			this.button1.TabIndex = 34;
			this.button1.Text = "Закрыть окно просмотра отчета";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Отчет_ЧС_карт
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(991, 453);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.Close);
			this.Name = "Отчет_ЧС_карт";
			this.Text = "Отчет_ЧС_карт";
			this.Load += new System.EventHandler(this.Отчет_ЧС_карт_Load);
			((System.ComponentModel.ISupportInitialize)(this._Kurs_WORKDataSet3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.отчетЧСкартBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.отчетуслугиBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.отчетЧСкартBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.отчетЧСкартBindingSource2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.отчетЧСкартBindingSource3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Close;
		private System.Windows.Forms.BindingSource bindingSource1;
		private _Kurs_WORKDataSet3 _Kurs_WORKDataSet3;
		private System.Windows.Forms.BindingSource отчетЧСкартBindingSource;
		private _Kurs_WORKDataSet3TableAdapters.Отчет_ЧС_картTableAdapter отчет_ЧС_картTableAdapter;
		private System.Windows.Forms.BindingSource отчетуслугиBindingSource;
		private _Kurs_WORKDataSet3TableAdapters.Отчет_услугиTableAdapter отчет_услугиTableAdapter;
		private System.Windows.Forms.BindingSource отчетЧСкартBindingSource2;
		private System.Windows.Forms.BindingSource отчетЧСкартBindingSource1;
		private System.Windows.Forms.BindingSource bindingSource2;
		private System.Windows.Forms.BindingSource отчетЧСкартBindingSource3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.DataGridViewTextBoxColumn кодЧСDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn датаобращенияDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn номерутеряннойкартыDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn датааннулированияDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn выданановаякартаDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn номерновойкартыDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn1;
		private System.Windows.Forms.Button button1;
	}
}