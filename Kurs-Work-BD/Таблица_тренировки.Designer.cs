namespace Kurs_Work_BD
{
	partial class Таблица_тренировки
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
			this.panel1 = new System.Windows.Forms.Panel();
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
			this._Kurs_WORKDataSet3 = new Kurs_Work_BD._Kurs_WORKDataSet3();
			this.тренировкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.тренировкиTableAdapter = new Kurs_Work_BD._Kurs_WORKDataSet3TableAdapters.ТренировкиTableAdapter();
			this.кодтренировкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.времяначалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.длительностьчасовDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.кодуслугиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.номерзалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._Kurs_WORKDataSet3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.тренировкиBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодтренировкиDataGridViewTextBoxColumn,
            this.времяначалаDataGridViewTextBoxColumn,
            this.длительностьчасовDataGridViewTextBoxColumn,
            this.кодуслугиDataGridViewTextBoxColumn,
            this.номерзалаDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.тренировкиBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(888, 410);
			this.dataGridView1.TabIndex = 52;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
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
			this.panel1.Location = new System.Drawing.Point(347, 428);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(554, 173);
			this.panel1.TabIndex = 51;
			// 
			// textBoxCode_Abon
			// 
			this.textBoxCode_Abon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.тренировкиBindingSource, "Код_тренировки", true));
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
			this.textBoxKolVoPoseshenie.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.тренировкиBindingSource, "Номер_зала", true));
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
			this.label5.Size = new System.Drawing.Size(117, 20);
			this.label5.TabIndex = 8;
			this.label5.Text = "Номер_зала:";
			// 
			// textBoxTimeDeystvia
			// 
			this.textBoxTimeDeystvia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.тренировкиBindingSource, "Код_услуги", true));
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
			this.label4.Size = new System.Drawing.Size(109, 20);
			this.label4.TabIndex = 6;
			this.label4.Text = "Код_услуги:";
			// 
			// textBoxStoimost
			// 
			this.textBoxStoimost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.тренировкиBindingSource, "Длительность_часов", true));
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
			this.label3.Size = new System.Drawing.Size(194, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Длительность_часов:";
			// 
			// textBoxVidTrenirovki
			// 
			this.textBoxVidTrenirovki.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.тренировкиBindingSource, "Время_начала", true));
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
			this.label2.Size = new System.Drawing.Size(137, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Время_начала:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(3, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(155, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Код_тренировки:";
			// 
			// buttonDelete
			// 
			this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonDelete.Location = new System.Drawing.Point(762, 607);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(139, 60);
			this.buttonDelete.TabIndex = 50;
			this.buttonDelete.Text = "Удалить";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// buttonDobav
			// 
			this.buttonDobav.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonDobav.Location = new System.Drawing.Point(567, 607);
			this.buttonDobav.Name = "buttonDobav";
			this.buttonDobav.Size = new System.Drawing.Size(139, 60);
			this.buttonDobav.TabIndex = 49;
			this.buttonDobav.Text = "Добавить";
			this.buttonDobav.UseVisualStyleBackColor = true;
			this.buttonDobav.Click += new System.EventHandler(this.buttonDobav_Click);
			// 
			// buttonRedact
			// 
			this.buttonRedact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonRedact.Location = new System.Drawing.Point(347, 607);
			this.buttonRedact.Name = "buttonRedact";
			this.buttonRedact.Size = new System.Drawing.Size(157, 60);
			this.buttonRedact.TabIndex = 48;
			this.buttonRedact.Text = "Сохранить изменения";
			this.buttonRedact.UseVisualStyleBackColor = true;
			this.buttonRedact.Click += new System.EventHandler(this.buttonRedact_Click);
			// 
			// back
			// 
			this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.back.Location = new System.Drawing.Point(21, 570);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(199, 97);
			this.back.TabIndex = 47;
			this.back.Text = "Закрыть форму редактирования таблицы";
			this.back.UseVisualStyleBackColor = true;
			this.back.Click += new System.EventHandler(this.back_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Kurs_Work_BD.Properties.Resources.фитнес_клуб_с_гантелями_строки_гантелей_металла_на_шкафе_для_150233004;
			this.pictureBox1.Location = new System.Drawing.Point(-31, -8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(974, 704);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 53;
			this.pictureBox1.TabStop = false;
			// 
			// _Kurs_WORKDataSet3
			// 
			this._Kurs_WORKDataSet3.DataSetName = "_Kurs_WORKDataSet3";
			this._Kurs_WORKDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// тренировкиBindingSource
			// 
			this.тренировкиBindingSource.DataMember = "Тренировки";
			this.тренировкиBindingSource.DataSource = this._Kurs_WORKDataSet3;
			// 
			// тренировкиTableAdapter
			// 
			this.тренировкиTableAdapter.ClearBeforeFill = true;
			// 
			// кодтренировкиDataGridViewTextBoxColumn
			// 
			this.кодтренировкиDataGridViewTextBoxColumn.DataPropertyName = "Код_тренировки";
			this.кодтренировкиDataGridViewTextBoxColumn.HeaderText = "Код_тренировки";
			this.кодтренировкиDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.кодтренировкиDataGridViewTextBoxColumn.Name = "кодтренировкиDataGridViewTextBoxColumn";
			this.кодтренировкиDataGridViewTextBoxColumn.Width = 125;
			// 
			// времяначалаDataGridViewTextBoxColumn
			// 
			this.времяначалаDataGridViewTextBoxColumn.DataPropertyName = "Время_начала";
			this.времяначалаDataGridViewTextBoxColumn.HeaderText = "Время_начала";
			this.времяначалаDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.времяначалаDataGridViewTextBoxColumn.Name = "времяначалаDataGridViewTextBoxColumn";
			this.времяначалаDataGridViewTextBoxColumn.Width = 125;
			// 
			// длительностьчасовDataGridViewTextBoxColumn
			// 
			this.длительностьчасовDataGridViewTextBoxColumn.DataPropertyName = "Длительность_часов";
			this.длительностьчасовDataGridViewTextBoxColumn.HeaderText = "Длительность_часов";
			this.длительностьчасовDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.длительностьчасовDataGridViewTextBoxColumn.Name = "длительностьчасовDataGridViewTextBoxColumn";
			this.длительностьчасовDataGridViewTextBoxColumn.Width = 125;
			// 
			// кодуслугиDataGridViewTextBoxColumn
			// 
			this.кодуслугиDataGridViewTextBoxColumn.DataPropertyName = "Код_услуги";
			this.кодуслугиDataGridViewTextBoxColumn.HeaderText = "Код_услуги";
			this.кодуслугиDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.кодуслугиDataGridViewTextBoxColumn.Name = "кодуслугиDataGridViewTextBoxColumn";
			this.кодуслугиDataGridViewTextBoxColumn.Width = 125;
			// 
			// номерзалаDataGridViewTextBoxColumn
			// 
			this.номерзалаDataGridViewTextBoxColumn.DataPropertyName = "Номер_зала";
			this.номерзалаDataGridViewTextBoxColumn.HeaderText = "Номер_зала";
			this.номерзалаDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.номерзалаDataGridViewTextBoxColumn.Name = "номерзалаDataGridViewTextBoxColumn";
			this.номерзалаDataGridViewTextBoxColumn.Width = 125;
			// 
			// Таблица_тренировки
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(919, 681);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonDobav);
			this.Controls.Add(this.buttonRedact);
			this.Controls.Add(this.back);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Таблица_тренировки";
			this.Text = "Таблица_тренировки";
			this.Load += new System.EventHandler(this.Таблица_тренировки_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._Kurs_WORKDataSet3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.тренировкиBindingSource)).EndInit();
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
		private _Kurs_WORKDataSet3 _Kurs_WORKDataSet3;
		private System.Windows.Forms.BindingSource тренировкиBindingSource;
		private _Kurs_WORKDataSet3TableAdapters.ТренировкиTableAdapter тренировкиTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn кодтренировкиDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn времяначалаDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn длительностьчасовDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn кодуслугиDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn номерзалаDataGridViewTextBoxColumn;
	}
}