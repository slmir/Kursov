namespace Kurs_Work_BD
{
	partial class Таблица_продажа_товаров
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.кодпродажитовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.кодтовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.кодклиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.итоговаястоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.продажатоваровBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this._Kurs_WORKDataSet3 = new Kurs_Work_BD._Kurs_WORKDataSet3();
			this.panel1 = new System.Windows.Forms.Panel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxCode_Abon = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxKolVoPoseshenie = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxTimeDeystvia = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxStoimost = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxVidTrenirovki = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonDobav = new System.Windows.Forms.Button();
			this.buttonRedact = new System.Windows.Forms.Button();
			this.back = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.продажа_товаровTableAdapter = new Kurs_Work_BD._Kurs_WORKDataSet3TableAdapters.Продажа_товаровTableAdapter();
			this._Kurs_WORKDataSet11 = new Kurs_Work_BD._Kurs_WORKDataSet11();
			this.продажатоваровBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.продажа_товаровTableAdapter1 = new Kurs_Work_BD._Kurs_WORKDataSet11TableAdapters.Продажа_товаровTableAdapter();
			this._Kurs_WORKDataSet12 = new Kurs_Work_BD._Kurs_WORKDataSet12();
			this.продажатоваровBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.продажа_товаровTableAdapter2 = new Kurs_Work_BD._Kurs_WORKDataSet12TableAdapters.Продажа_товаровTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.продажатоваровBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._Kurs_WORKDataSet3)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._Kurs_WORKDataSet11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.продажатоваровBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._Kurs_WORKDataSet12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.продажатоваровBindingSource2)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодпродажитовараDataGridViewTextBoxColumn,
            this.кодтовараDataGridViewTextBoxColumn,
            this.кодклиентаDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.итоговаястоимостьDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.продажатоваровBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(15, 14);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(888, 381);
			this.dataGridView1.TabIndex = 59;
			// 
			// кодпродажитовараDataGridViewTextBoxColumn
			// 
			this.кодпродажитовараDataGridViewTextBoxColumn.DataPropertyName = "Код_продажи_товара";
			this.кодпродажитовараDataGridViewTextBoxColumn.HeaderText = "Код_продажи_товара";
			this.кодпродажитовараDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.кодпродажитовараDataGridViewTextBoxColumn.Name = "кодпродажитовараDataGridViewTextBoxColumn";
			this.кодпродажитовараDataGridViewTextBoxColumn.Width = 125;
			// 
			// кодтовараDataGridViewTextBoxColumn
			// 
			this.кодтовараDataGridViewTextBoxColumn.DataPropertyName = "Код_товара";
			this.кодтовараDataGridViewTextBoxColumn.HeaderText = "Код_товара";
			this.кодтовараDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.кодтовараDataGridViewTextBoxColumn.Name = "кодтовараDataGridViewTextBoxColumn";
			this.кодтовараDataGridViewTextBoxColumn.Width = 125;
			// 
			// кодклиентаDataGridViewTextBoxColumn
			// 
			this.кодклиентаDataGridViewTextBoxColumn.DataPropertyName = "Код_клиента";
			this.кодклиентаDataGridViewTextBoxColumn.HeaderText = "Код_клиента";
			this.кодклиентаDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.кодклиентаDataGridViewTextBoxColumn.Name = "кодклиентаDataGridViewTextBoxColumn";
			this.кодклиентаDataGridViewTextBoxColumn.Width = 125;
			// 
			// количествоDataGridViewTextBoxColumn
			// 
			this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
			this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
			this.количествоDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
			this.количествоDataGridViewTextBoxColumn.Width = 125;
			// 
			// ценаDataGridViewTextBoxColumn
			// 
			this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
			this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
			this.ценаDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
			this.ценаDataGridViewTextBoxColumn.Width = 125;
			// 
			// итоговаястоимостьDataGridViewTextBoxColumn
			// 
			this.итоговаястоимостьDataGridViewTextBoxColumn.DataPropertyName = "Итоговая_стоимость";
			this.итоговаястоимостьDataGridViewTextBoxColumn.HeaderText = "Итоговая_стоимость";
			this.итоговаястоимостьDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.итоговаястоимостьDataGridViewTextBoxColumn.Name = "итоговаястоимостьDataGridViewTextBoxColumn";
			this.итоговаястоимостьDataGridViewTextBoxColumn.Width = 125;
			// 
			// продажатоваровBindingSource
			// 
			this.продажатоваровBindingSource.DataMember = "Продажа_товаров";
			this.продажатоваровBindingSource.DataSource = this._Kurs_WORKDataSet3;
			// 
			// _Kurs_WORKDataSet3
			// 
			this._Kurs_WORKDataSet3.DataSetName = "_Kurs_WORKDataSet3";
			this._Kurs_WORKDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.textBoxCode_Abon);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.textBoxKolVoPoseshenie);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.textBoxTimeDeystvia);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.textBoxStoimost);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.textBoxVidTrenirovki);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(350, 401);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(554, 202);
			this.panel1.TabIndex = 58;
			// 
			// textBox1
			// 
			this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.продажатоваровBindingSource, "Итоговая_стоимость", true));
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(239, 169);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(305, 27);
			this.textBox1.TabIndex = 14;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(3, 172);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(192, 20);
			this.label7.TabIndex = 13;
			this.label7.Text = "Итоговая_стоимость:";
			// 
			// textBoxCode_Abon
			// 
			this.textBoxCode_Abon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.продажатоваровBindingSource, "Код_продажи_товара", true));
			this.textBoxCode_Abon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxCode_Abon.Location = new System.Drawing.Point(239, 7);
			this.textBoxCode_Abon.Name = "textBoxCode_Abon";
			this.textBoxCode_Abon.Size = new System.Drawing.Size(305, 27);
			this.textBoxCode_Abon.TabIndex = 12;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(3, 172);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(0, 20);
			this.label6.TabIndex = 10;
			// 
			// textBoxKolVoPoseshenie
			// 
			this.textBoxKolVoPoseshenie.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.продажатоваровBindingSource, "Цена", true));
			this.textBoxKolVoPoseshenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxKolVoPoseshenie.Location = new System.Drawing.Point(239, 136);
			this.textBoxKolVoPoseshenie.Name = "textBoxKolVoPoseshenie";
			this.textBoxKolVoPoseshenie.Size = new System.Drawing.Size(305, 27);
			this.textBoxKolVoPoseshenie.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(3, 139);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(57, 20);
			this.label5.TabIndex = 8;
			this.label5.Text = "Цена:";
			// 
			// textBoxTimeDeystvia
			// 
			this.textBoxTimeDeystvia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.продажатоваровBindingSource, "Количество", true));
			this.textBoxTimeDeystvia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxTimeDeystvia.Location = new System.Drawing.Point(239, 103);
			this.textBoxTimeDeystvia.Name = "textBoxTimeDeystvia";
			this.textBoxTimeDeystvia.Size = new System.Drawing.Size(305, 27);
			this.textBoxTimeDeystvia.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(3, 106);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(114, 20);
			this.label4.TabIndex = 6;
			this.label4.Text = "Количество:";
			// 
			// textBoxStoimost
			// 
			this.textBoxStoimost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.продажатоваровBindingSource, "Код_клиента", true));
			this.textBoxStoimost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxStoimost.Location = new System.Drawing.Point(239, 73);
			this.textBoxStoimost.Name = "textBoxStoimost";
			this.textBoxStoimost.Size = new System.Drawing.Size(305, 27);
			this.textBoxStoimost.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(3, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(125, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Код_клиента:";
			// 
			// textBoxVidTrenirovki
			// 
			this.textBoxVidTrenirovki.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.продажатоваровBindingSource, "Код_товара", true));
			this.textBoxVidTrenirovki.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxVidTrenirovki.Location = new System.Drawing.Point(239, 40);
			this.textBoxVidTrenirovki.Name = "textBoxVidTrenirovki";
			this.textBoxVidTrenirovki.Size = new System.Drawing.Size(305, 27);
			this.textBoxVidTrenirovki.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(3, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(116, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Код_товара:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(3, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(199, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Код_продажи_товара:";
			// 
			// buttonDelete
			// 
			this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonDelete.Location = new System.Drawing.Point(765, 609);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(139, 60);
			this.buttonDelete.TabIndex = 57;
			this.buttonDelete.Text = "Удалить";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// buttonDobav
			// 
			this.buttonDobav.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonDobav.Location = new System.Drawing.Point(570, 609);
			this.buttonDobav.Name = "buttonDobav";
			this.buttonDobav.Size = new System.Drawing.Size(139, 60);
			this.buttonDobav.TabIndex = 56;
			this.buttonDobav.Text = "Добавить";
			this.buttonDobav.UseVisualStyleBackColor = true;
			this.buttonDobav.Click += new System.EventHandler(this.buttonDobav_Click);
			// 
			// buttonRedact
			// 
			this.buttonRedact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonRedact.Location = new System.Drawing.Point(350, 609);
			this.buttonRedact.Name = "buttonRedact";
			this.buttonRedact.Size = new System.Drawing.Size(157, 60);
			this.buttonRedact.TabIndex = 55;
			this.buttonRedact.Text = "Сохранить изменения";
			this.buttonRedact.UseVisualStyleBackColor = true;
			this.buttonRedact.Click += new System.EventHandler(this.buttonRedact_Click);
			// 
			// back
			// 
			this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.back.Location = new System.Drawing.Point(15, 572);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(199, 97);
			this.back.TabIndex = 54;
			this.back.Text = "Закрыть форму редактирования таблицы";
			this.back.UseVisualStyleBackColor = true;
			this.back.Click += new System.EventHandler(this.back_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Kurs_Work_BD.Properties.Resources.фитнес_клуб_с_гантелями_строки_гантелей_металла_на_шкафе_для_150233004;
			this.pictureBox1.Location = new System.Drawing.Point(-25, -18);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1102, 704);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 60;
			this.pictureBox1.TabStop = false;
			// 
			// продажа_товаровTableAdapter
			// 
			this.продажа_товаровTableAdapter.ClearBeforeFill = true;
			// 
			// _Kurs_WORKDataSet11
			// 
			this._Kurs_WORKDataSet11.DataSetName = "_Kurs_WORKDataSet11";
			this._Kurs_WORKDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// продажатоваровBindingSource1
			// 
			this.продажатоваровBindingSource1.DataMember = "Продажа_товаров";
			this.продажатоваровBindingSource1.DataSource = this._Kurs_WORKDataSet11;
			// 
			// продажа_товаровTableAdapter1
			// 
			this.продажа_товаровTableAdapter1.ClearBeforeFill = true;
			// 
			// _Kurs_WORKDataSet12
			// 
			this._Kurs_WORKDataSet12.DataSetName = "_Kurs_WORKDataSet12";
			this._Kurs_WORKDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// продажатоваровBindingSource2
			// 
			this.продажатоваровBindingSource2.DataMember = "Продажа_товаров";
			this.продажатоваровBindingSource2.DataSource = this._Kurs_WORKDataSet12;
			// 
			// продажа_товаровTableAdapter2
			// 
			this.продажа_товаровTableAdapter2.ClearBeforeFill = true;
			// 
			// Таблица_продажа_товаров
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(921, 689);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonDobav);
			this.Controls.Add(this.buttonRedact);
			this.Controls.Add(this.back);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Таблица_продажа_товаров";
			this.Text = "Таблица_продажа_товаров";
			this.Load += new System.EventHandler(this.Таблица_продажа_товаров_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.продажатоваровBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._Kurs_WORKDataSet3)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._Kurs_WORKDataSet11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.продажатоваровBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._Kurs_WORKDataSet12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.продажатоваровBindingSource2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBoxCode_Abon;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxKolVoPoseshenie;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxTimeDeystvia;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxStoimost;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxVidTrenirovki;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonDobav;
		private System.Windows.Forms.Button buttonRedact;
		private System.Windows.Forms.Button back;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label7;
		private _Kurs_WORKDataSet3 _Kurs_WORKDataSet3;
		private System.Windows.Forms.BindingSource продажатоваровBindingSource;
		private _Kurs_WORKDataSet3TableAdapters.Продажа_товаровTableAdapter продажа_товаровTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn кодпродажитовараDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn кодтовараDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn кодклиентаDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn итоговаястоимостьDataGridViewTextBoxColumn;
		private _Kurs_WORKDataSet11 _Kurs_WORKDataSet11;
		private System.Windows.Forms.BindingSource продажатоваровBindingSource1;
		private _Kurs_WORKDataSet11TableAdapters.Продажа_товаровTableAdapter продажа_товаровTableAdapter1;
		private _Kurs_WORKDataSet12 _Kurs_WORKDataSet12;
		private System.Windows.Forms.BindingSource продажатоваровBindingSource2;
		private _Kurs_WORKDataSet12TableAdapters.Продажа_товаровTableAdapter продажа_товаровTableAdapter2;
	}
}