namespace Kurs_Work_BD
{
	partial class Form1
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
			this.button1 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.номеркартыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.кодклиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.кодабонементаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.датаначаладействияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.осталосьпосещенийDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.активенDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.оформлениеабонементовBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this._Kurs_WORKDataSet7 = new Kurs_Work_BD._Kurs_WORKDataSet7();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this._Kurs_WORKDataSet6 = new Kurs_Work_BD._Kurs_WORKDataSet6();
			this.findClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.findClientTableAdapter = new Kurs_Work_BD._Kurs_WORKDataSet6TableAdapters.findClientTableAdapter();
			this.оформление_абонементовTableAdapter = new Kurs_Work_BD._Kurs_WORKDataSet7TableAdapters.Оформление_абонементовTableAdapter();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.findClientPhoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this._Kurs_WORKDataSet9 = new Kurs_Work_BD._Kurs_WORKDataSet9();
			this.button2 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.findClientPhoneTableAdapter = new Kurs_Work_BD._Kurs_WORKDataSet9TableAdapters.findClientPhoneTableAdapter();
			this.b_back_Client = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.оформлениеабонементовBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._Kurs_WORKDataSet7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._Kurs_WORKDataSet6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.findClientBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.findClientPhoneBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._Kurs_WORKDataSet9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(13, 288);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(165, 83);
			this.button1.TabIndex = 0;
			this.button1.Text = "Найти информацию о карте!";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номеркартыDataGridViewTextBoxColumn,
            this.кодклиентаDataGridViewTextBoxColumn,
            this.кодабонементаDataGridViewTextBoxColumn,
            this.датаначаладействияDataGridViewTextBoxColumn,
            this.осталосьпосещенийDataGridViewTextBoxColumn,
            this.активенDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.оформлениеабонементовBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(13, 13);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1016, 211);
			this.dataGridView1.TabIndex = 1;
			// 
			// номеркартыDataGridViewTextBoxColumn
			// 
			this.номеркартыDataGridViewTextBoxColumn.DataPropertyName = "Номер_карты";
			this.номеркартыDataGridViewTextBoxColumn.HeaderText = "Номер_карты";
			this.номеркартыDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.номеркартыDataGridViewTextBoxColumn.Name = "номеркартыDataGridViewTextBoxColumn";
			this.номеркартыDataGridViewTextBoxColumn.Width = 125;
			// 
			// кодклиентаDataGridViewTextBoxColumn
			// 
			this.кодклиентаDataGridViewTextBoxColumn.DataPropertyName = "Код_клиента";
			this.кодклиентаDataGridViewTextBoxColumn.HeaderText = "Код_клиента";
			this.кодклиентаDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.кодклиентаDataGridViewTextBoxColumn.Name = "кодклиентаDataGridViewTextBoxColumn";
			this.кодклиентаDataGridViewTextBoxColumn.Width = 125;
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
			// активенDataGridViewTextBoxColumn
			// 
			this.активенDataGridViewTextBoxColumn.DataPropertyName = "Активен";
			this.активенDataGridViewTextBoxColumn.HeaderText = "Активен";
			this.активенDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.активенDataGridViewTextBoxColumn.Name = "активенDataGridViewTextBoxColumn";
			this.активенDataGridViewTextBoxColumn.Width = 125;
			// 
			// оформлениеабонементовBindingSource
			// 
			this.оформлениеабонементовBindingSource.DataMember = "Оформление_абонементов";
			this.оформлениеабонементовBindingSource.DataSource = this._Kurs_WORKDataSet7;
			// 
			// _Kurs_WORKDataSet7
			// 
			this._Kurs_WORKDataSet7.DataSetName = "_Kurs_WORKDataSet7";
			this._Kurs_WORKDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// _Kurs_WORKDataSet6
			// 
			this._Kurs_WORKDataSet6.DataSetName = "_Kurs_WORKDataSet6";
			this._Kurs_WORKDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// findClientBindingSource
			// 
			this.findClientBindingSource.DataMember = "findClient";
			this.findClientBindingSource.DataSource = this._Kurs_WORKDataSet6;
			// 
			// findClientTableAdapter
			// 
			this.findClientTableAdapter.ClearBeforeFill = true;
			// 
			// оформление_абонементовTableAdapter
			// 
			this.оформление_абонементовTableAdapter.ClearBeforeFill = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(13, 260);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 22);
			this.textBox1.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(9, 237);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(251, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "Введите ваш личный номер:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(580, 266);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(235, 20);
			this.label2.TabIndex = 6;
			this.label2.Text = "Найти свой личный номер:";
			// 
			// textBox2
			// 
			this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.findClientPhoneBindingSource, "Код_клиента", true));
			this.textBox2.Location = new System.Drawing.Point(861, 291);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(154, 22);
			this.textBox2.TabIndex = 5;
			// 
			// findClientPhoneBindingSource
			// 
			this.findClientPhoneBindingSource.DataMember = "findClientPhone";
			this.findClientPhoneBindingSource.DataSource = this._Kurs_WORKDataSet9;
			// 
			// _Kurs_WORKDataSet9
			// 
			this._Kurs_WORKDataSet9.DataSetName = "_Kurs_WORKDataSet9";
			this._Kurs_WORKDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.Location = new System.Drawing.Point(861, 330);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(154, 51);
			this.button2.TabIndex = 4;
			this.button2.Text = "Найти номер!";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(580, 291);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(275, 20);
			this.label3.TabIndex = 7;
			this.label3.Text = "Введите ваш номер телефона:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Bisque;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(580, 236);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(200, 20);
			this.label4.TabIndex = 8;
			this.label4.Text = "Я не знаю свой номер!";
			// 
			// bindingSource2
			// 
			this.bindingSource2.CurrentChanged += new System.EventHandler(this.bindingSource2_CurrentChanged);
			// 
			// findClientPhoneTableAdapter
			// 
			this.findClientPhoneTableAdapter.ClearBeforeFill = true;
			// 
			// b_back_Client
			// 
			this.b_back_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.b_back_Client.Location = new System.Drawing.Point(12, 377);
			this.b_back_Client.Name = "b_back_Client";
			this.b_back_Client.Size = new System.Drawing.Size(248, 75);
			this.b_back_Client.TabIndex = 10;
			this.b_back_Client.Text = "Закрыть окно поиска информации о карте";
			this.b_back_Client.UseVisualStyleBackColor = true;
			this.b_back_Client.Click += new System.EventHandler(this.b_back_Client_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1041, 464);
			this.Controls.Add(this.b_back_Client);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.оформлениеабонементовBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._Kurs_WORKDataSet7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._Kurs_WORKDataSet6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.findClientBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.findClientPhoneBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._Kurs_WORKDataSet9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.BindingSource bindingSource1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn номеркартыDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn кодклиентаDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn кодабонементаDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn датаначаладействияDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn осталосьпосещенийDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn активенDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource findClientBindingSource;
		private _Kurs_WORKDataSet6 _Kurs_WORKDataSet6;
		private _Kurs_WORKDataSet6TableAdapters.findClientTableAdapter findClientTableAdapter;
		private _Kurs_WORKDataSet7 _Kurs_WORKDataSet7;
		private System.Windows.Forms.BindingSource оформлениеабонементовBindingSource;
		private _Kurs_WORKDataSet7TableAdapters.Оформление_абонементовTableAdapter оформление_абонементовTableAdapter;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.BindingSource bindingSource2;
		private System.Windows.Forms.BindingSource findClientPhoneBindingSource;
		private _Kurs_WORKDataSet9 _Kurs_WORKDataSet9;
		private _Kurs_WORKDataSet9TableAdapters.findClientPhoneTableAdapter findClientPhoneTableAdapter;
		private System.Windows.Forms.Button b_back_Client;
	}
}