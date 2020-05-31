namespace Kurs_Work_BD
{
	partial class Таблица_должности
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
			this.должностиBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.должностиTableAdapter = new Kurs_Work_BD._Kurs_WORKDataSet3TableAdapters.ДолжностиTableAdapter();
			this.коддолжностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.окладDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._Kurs_WORKDataSet3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.коддолжностиDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn,
            this.окладDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.должностиBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 9);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(713, 437);
			this.dataGridView1.TabIndex = 38;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
			this.panel1.Controls.Add(this.textBoxCode_Abon);
			this.panel1.Controls.Add(this.textBoxStoimost);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.textBoxVidTrenirovki);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(172, 452);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(553, 108);
			this.panel1.TabIndex = 37;
			// 
			// textBoxCode_Abon
			// 
			this.textBoxCode_Abon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.должностиBindingSource, "Код_должности", true));
			this.textBoxCode_Abon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxCode_Abon.Location = new System.Drawing.Point(239, 7);
			this.textBoxCode_Abon.Name = "textBoxCode_Abon";
			this.textBoxCode_Abon.Size = new System.Drawing.Size(305, 27);
			this.textBoxCode_Abon.TabIndex = 12;
			// 
			// textBoxStoimost
			// 
			this.textBoxStoimost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.должностиBindingSource, "Оклад", true));
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
			this.label3.Size = new System.Drawing.Size(68, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Оклад:";
			// 
			// textBoxVidTrenirovki
			// 
			this.textBoxVidTrenirovki.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.должностиBindingSource, "Должность", true));
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
			this.label2.Size = new System.Drawing.Size(108, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Должность:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(3, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(149, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Код_должности:";
			// 
			// buttonDelete
			// 
			this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonDelete.Location = new System.Drawing.Point(577, 606);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(148, 60);
			this.buttonDelete.TabIndex = 36;
			this.buttonDelete.Text = "Удалить";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// buttonDobav
			// 
			this.buttonDobav.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonDobav.Location = new System.Drawing.Point(423, 606);
			this.buttonDobav.Name = "buttonDobav";
			this.buttonDobav.Size = new System.Drawing.Size(148, 60);
			this.buttonDobav.TabIndex = 35;
			this.buttonDobav.Text = "Добавить";
			this.buttonDobav.UseVisualStyleBackColor = true;
			this.buttonDobav.Click += new System.EventHandler(this.buttonDobav_Click);
			// 
			// buttonRedact
			// 
			this.buttonRedact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonRedact.Location = new System.Drawing.Point(251, 606);
			this.buttonRedact.Name = "buttonRedact";
			this.buttonRedact.Size = new System.Drawing.Size(166, 60);
			this.buttonRedact.TabIndex = 34;
			this.buttonRedact.Text = "Сохранить изменения";
			this.buttonRedact.UseVisualStyleBackColor = true;
			this.buttonRedact.Click += new System.EventHandler(this.buttonRedact_Click);
			// 
			// back
			// 
			this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.back.Location = new System.Drawing.Point(12, 606);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(181, 86);
			this.back.TabIndex = 33;
			this.back.Text = "Закрыть форму редактирования таблицы";
			this.back.UseVisualStyleBackColor = true;
			this.back.Click += new System.EventHandler(this.back_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Kurs_Work_BD.Properties.Resources.фитнес_клуб_с_гантелями_строки_гантелей_металла_на_шкафе_для_150233004;
			this.pictureBox1.Location = new System.Drawing.Point(-89, -18);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1220, 775);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 39;
			this.pictureBox1.TabStop = false;
			// 
			// _Kurs_WORKDataSet3
			// 
			this._Kurs_WORKDataSet3.DataSetName = "_Kurs_WORKDataSet3";
			this._Kurs_WORKDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// должностиBindingSource
			// 
			this.должностиBindingSource.DataMember = "Должности";
			this.должностиBindingSource.DataSource = this._Kurs_WORKDataSet3;
			// 
			// должностиTableAdapter
			// 
			this.должностиTableAdapter.ClearBeforeFill = true;
			// 
			// коддолжностиDataGridViewTextBoxColumn
			// 
			this.коддолжностиDataGridViewTextBoxColumn.DataPropertyName = "Код_должности";
			this.коддолжностиDataGridViewTextBoxColumn.HeaderText = "Код_должности";
			this.коддолжностиDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.коддолжностиDataGridViewTextBoxColumn.Name = "коддолжностиDataGridViewTextBoxColumn";
			this.коддолжностиDataGridViewTextBoxColumn.Width = 125;
			// 
			// должностьDataGridViewTextBoxColumn
			// 
			this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
			this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
			this.должностьDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
			this.должностьDataGridViewTextBoxColumn.Width = 200;
			// 
			// окладDataGridViewTextBoxColumn
			// 
			this.окладDataGridViewTextBoxColumn.DataPropertyName = "Оклад";
			this.окладDataGridViewTextBoxColumn.HeaderText = "Оклад";
			this.окладDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.окладDataGridViewTextBoxColumn.Name = "окладDataGridViewTextBoxColumn";
			this.окладDataGridViewTextBoxColumn.Width = 125;
			// 
			// Таблица_должности
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(737, 703);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonDobav);
			this.Controls.Add(this.buttonRedact);
			this.Controls.Add(this.back);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Таблица_должности";
			this.Text = "Таблица_должности";
			this.Load += new System.EventHandler(this.Таблица_должности_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._Kurs_WORKDataSet3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBoxCode_Abon;
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
		private System.Windows.Forms.BindingSource должностиBindingSource;
		private _Kurs_WORKDataSet3TableAdapters.ДолжностиTableAdapter должностиTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn коддолжностиDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn окладDataGridViewTextBoxColumn;
	}
}