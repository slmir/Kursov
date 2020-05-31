namespace Kurs_Work_BD
{
	partial class Таблица_абонементы
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
			this.back = new System.Windows.Forms.Button();
			this.buttonRedact = new System.Windows.Forms.Button();
			this.buttonDobav = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.textBoxCode_Abon = new System.Windows.Forms.TextBox();
			this.абонементыBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this._Kurs_WORKDataSet3 = new Kurs_Work_BD._Kurs_WORKDataSet3();
			this.textBoxVozmojnostZamorozki = new System.Windows.Forms.TextBox();
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
			this.абонементыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.кодабонементаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.видтренировкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.стоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.времядействиямесяцыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.количествопосещенийDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.возможностьзаморозкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.абонементыTableAdapter = new Kurs_Work_BD._Kurs_WORKDataSet3TableAdapters.АбонементыTableAdapter();
			this.абонементыBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.абонементыBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.абонементыBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._Kurs_WORKDataSet3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.абонементыBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.абонементыBindingSource2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.абонементыBindingSource3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
			this.SuspendLayout();
			// 
			// back
			// 
			this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.back.Location = new System.Drawing.Point(12, 627);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(208, 97);
			this.back.TabIndex = 0;
			this.back.Text = "Закрыть форму редактирования таблицы";
			this.back.UseVisualStyleBackColor = true;
			this.back.Click += new System.EventHandler(this.back_Click);
			// 
			// buttonRedact
			// 
			this.buttonRedact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonRedact.Location = new System.Drawing.Point(347, 664);
			this.buttonRedact.Name = "buttonRedact";
			this.buttonRedact.Size = new System.Drawing.Size(166, 60);
			this.buttonRedact.TabIndex = 1;
			this.buttonRedact.Text = "Сохранить изменения";
			this.buttonRedact.UseVisualStyleBackColor = true;
			this.buttonRedact.Click += new System.EventHandler(this.button2_Click);
			// 
			// buttonDobav
			// 
			this.buttonDobav.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonDobav.Location = new System.Drawing.Point(565, 664);
			this.buttonDobav.Name = "buttonDobav";
			this.buttonDobav.Size = new System.Drawing.Size(148, 60);
			this.buttonDobav.TabIndex = 2;
			this.buttonDobav.Text = "Добавить";
			this.buttonDobav.UseVisualStyleBackColor = true;
			this.buttonDobav.Click += new System.EventHandler(this.buttonDobav_Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonDelete.Location = new System.Drawing.Point(762, 664);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(148, 60);
			this.buttonDelete.TabIndex = 3;
			this.buttonDelete.Text = "Удалить";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
			this.panel1.Controls.Add(this.textBoxCode_Abon);
			this.panel1.Controls.Add(this.textBoxVozmojnostZamorozki);
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
			this.panel1.DataBindings.Add(new System.Windows.Forms.Binding("BorderStyle", this.абонементыBindingSource1, "Код_абонемента", true));
			this.panel1.Location = new System.Drawing.Point(347, 455);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(563, 203);
			this.panel1.TabIndex = 4;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// textBoxCode_Abon
			// 
			this.textBoxCode_Abon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.абонементыBindingSource, "Код_абонемента", true));
			this.textBoxCode_Abon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxCode_Abon.Location = new System.Drawing.Point(239, 7);
			this.textBoxCode_Abon.Name = "textBoxCode_Abon";
			this.textBoxCode_Abon.Size = new System.Drawing.Size(305, 27);
			this.textBoxCode_Abon.TabIndex = 12;
			// 
			// абонементыBindingSource
			// 
			this.абонементыBindingSource.DataMember = "Абонементы";
			this.абонементыBindingSource.DataSource = this._Kurs_WORKDataSet3;
			// 
			// _Kurs_WORKDataSet3
			// 
			this._Kurs_WORKDataSet3.DataSetName = "_Kurs_WORKDataSet3";
			this._Kurs_WORKDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// textBoxVozmojnostZamorozki
			// 
			this.textBoxVozmojnostZamorozki.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.абонементыBindingSource, "Возможность_заморозки", true));
			this.textBoxVozmojnostZamorozki.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxVozmojnostZamorozki.Location = new System.Drawing.Point(239, 169);
			this.textBoxVozmojnostZamorozki.Name = "textBoxVozmojnostZamorozki";
			this.textBoxVozmojnostZamorozki.Size = new System.Drawing.Size(305, 27);
			this.textBoxVozmojnostZamorozki.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(3, 172);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(226, 20);
			this.label6.TabIndex = 10;
			this.label6.Text = "Возможность_заморозки:";
			// 
			// textBoxKolVoPoseshenie
			// 
			this.textBoxKolVoPoseshenie.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.абонементыBindingSource, "Количество_посещений", true));
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
			this.label5.Size = new System.Drawing.Size(216, 20);
			this.label5.TabIndex = 8;
			this.label5.Text = "Количество_посещений:";
			// 
			// textBoxTimeDeystvia
			// 
			this.textBoxTimeDeystvia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.абонементыBindingSource, "Время_действия_месяцы", true));
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
			this.label4.Size = new System.Drawing.Size(230, 20);
			this.label4.TabIndex = 6;
			this.label4.Text = "Время_действия_месяцы:";
			// 
			// textBoxStoimost
			// 
			this.textBoxStoimost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.абонементыBindingSource, "Стоимость", true));
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
			this.label3.Size = new System.Drawing.Size(107, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Стоимость:";
			// 
			// textBoxVidTrenirovki
			// 
			this.textBoxVidTrenirovki.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.абонементыBindingSource, "Вид_тренировки", true));
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
			this.label2.Size = new System.Drawing.Size(156, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Вид_тренировки:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(3, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(158, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Код_абонемента:";
			// 
			// абонементыBindingSource1
			// 
			this.абонементыBindingSource1.DataMember = "Абонементы";
			this.абонементыBindingSource1.DataSource = this._Kurs_WORKDataSet3;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодабонементаDataGridViewTextBoxColumn,
            this.видтренировкиDataGridViewTextBoxColumn,
            this.стоимостьDataGridViewTextBoxColumn,
            this.времядействиямесяцыDataGridViewTextBoxColumn,
            this.количествопосещенийDataGridViewTextBoxColumn,
            this.возможностьзаморозкиDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.абонементыBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(13, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(897, 437);
			this.dataGridView1.TabIndex = 6;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// кодабонементаDataGridViewTextBoxColumn
			// 
			this.кодабонементаDataGridViewTextBoxColumn.DataPropertyName = "Код_абонемента";
			this.кодабонементаDataGridViewTextBoxColumn.HeaderText = "Код_абонемента";
			this.кодабонементаDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.кодабонементаDataGridViewTextBoxColumn.Name = "кодабонементаDataGridViewTextBoxColumn";
			this.кодабонементаDataGridViewTextBoxColumn.Width = 125;
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
			// абонементыTableAdapter
			// 
			this.абонементыTableAdapter.ClearBeforeFill = true;
			// 
			// абонементыBindingSource2
			// 
			this.абонементыBindingSource2.DataMember = "Абонементы";
			this.абонементыBindingSource2.DataSource = this._Kurs_WORKDataSet3;
			// 
			// абонементыBindingSource3
			// 
			this.абонементыBindingSource3.DataMember = "Абонементы";
			this.абонементыBindingSource3.DataSource = this._Kurs_WORKDataSet3;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Kurs_Work_BD.Properties.Resources.фитнес_клуб_с_гантелями_строки_гантелей_металла_на_шкафе_для_150233004;
			this.pictureBox1.Location = new System.Drawing.Point(-31, -8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1220, 764);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 32;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// Таблица_абонементы
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(930, 744);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonDobav);
			this.Controls.Add(this.buttonRedact);
			this.Controls.Add(this.back);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Таблица_абонементы";
			this.Text = "Таблица_абонементы";
			this.Load += new System.EventHandler(this.Таблица_абонементы_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.абонементыBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._Kurs_WORKDataSet3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.абонементыBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.абонементыBindingSource2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.абонементыBindingSource3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button back;
		private System.Windows.Forms.Button buttonRedact;
		private System.Windows.Forms.Button buttonDobav;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBoxVozmojnostZamorozki;
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
		private System.Windows.Forms.BindingSource bindingSource1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private _Kurs_WORKDataSet3 _Kurs_WORKDataSet3;
		private System.Windows.Forms.BindingSource абонементыBindingSource;
		private _Kurs_WORKDataSet3TableAdapters.АбонементыTableAdapter абонементыTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn кодабонементаDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn видтренировкиDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn времядействиямесяцыDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn количествопосещенийDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn возможностьзаморозкиDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource абонементыBindingSource1;
		private System.Windows.Forms.TextBox textBoxCode_Abon;
		private System.Windows.Forms.BindingSource абонементыBindingSource2;
		private System.Windows.Forms.BindingSource абонементыBindingSource3;
		private System.Windows.Forms.BindingSource bindingSource2;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}