namespace Kurs_Work_BD
{
	partial class Доступ_к_системе
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this._Kurs_WORKDataSet = new Kurs_Work_BD._Kurs_WORKDataSet();
			this.доступBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.доступTableAdapter = new Kurs_Work_BD._Kurs_WORKDataSetTableAdapters.ДоступTableAdapter();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.b_Exit2 = new System.Windows.Forms.Button();
			this._Kurs_WORKDataSet1 = new Kurs_Work_BD._Kurs_WORKDataSet1();
			this.testView1TableAdapter = new Kurs_Work_BD._Kurs_WORKDataSet1TableAdapters.testView1TableAdapter();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.b_Entire_Obshie = new System.Windows.Forms.Button();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.textBoxLogin = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this._Kurs_WORKDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.доступBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._Kurs_WORKDataSet1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// _Kurs_WORKDataSet
			// 
			this._Kurs_WORKDataSet.DataSetName = "_Kurs_WORKDataSet";
			this._Kurs_WORKDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// доступBindingSource
			// 
			this.доступBindingSource.DataMember = "Доступ";
			this.доступBindingSource.DataSource = this._Kurs_WORKDataSet;
			// 
			// доступTableAdapter
			// 
			this.доступTableAdapter.ClearBeforeFill = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.GreenYellow;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(59, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(513, 59);
			this.label1.TabIndex = 6;
			this.label1.Text = "АИС \"Фитнес-центр\"";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.LightYellow;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(28, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(569, 39);
			this.label2.TabIndex = 7;
			this.label2.Text = "Форма авторизации пользователя";
			// 
			// b_Exit2
			// 
			this.b_Exit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.b_Exit2.Location = new System.Drawing.Point(12, 391);
			this.b_Exit2.Name = "b_Exit2";
			this.b_Exit2.Size = new System.Drawing.Size(106, 54);
			this.b_Exit2.TabIndex = 13;
			this.b_Exit2.Text = "Назад";
			this.b_Exit2.UseVisualStyleBackColor = true;
			this.b_Exit2.Click += new System.EventHandler(this.button1_Click);
			// 
			// _Kurs_WORKDataSet1
			// 
			this._Kurs_WORKDataSet1.DataSetName = "_Kurs_WORKDataSet1";
			this._Kurs_WORKDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// testView1TableAdapter
			// 
			this.testView1TableAdapter.ClearBeforeFill = true;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.GreenYellow;
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.b_Entire_Obshie);
			this.panel1.Controls.Add(this.textBoxPassword);
			this.panel1.Controls.Add(this.textBoxLogin);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Location = new System.Drawing.Point(69, 151);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(503, 210);
			this.panel1.TabIndex = 25;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(3, 10);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(421, 60);
			this.label4.TabIndex = 5;
			this.label4.Text = "Пожалуйста, для входа в систему\r\nвведите логин и пароль:";
			// 
			// b_Entire_Obshie
			// 
			this.b_Entire_Obshie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.b_Entire_Obshie.Location = new System.Drawing.Point(338, 146);
			this.b_Entire_Obshie.Name = "b_Entire_Obshie";
			this.b_Entire_Obshie.Size = new System.Drawing.Size(162, 58);
			this.b_Entire_Obshie.TabIndex = 4;
			this.b_Entire_Obshie.Text = "Войти!";
			this.b_Entire_Obshie.UseVisualStyleBackColor = true;
			this.b_Entire_Obshie.Click += new System.EventHandler(this.b_Entire_Obshie_Click);
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxPassword.Location = new System.Drawing.Point(107, 113);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PasswordChar = '*';
			this.textBoxPassword.Size = new System.Drawing.Size(393, 27);
			this.textBoxPassword.TabIndex = 3;
			// 
			// textBoxLogin
			// 
			this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxLogin.Location = new System.Drawing.Point(107, 83);
			this.textBoxLogin.Name = "textBoxLogin";
			this.textBoxLogin.Size = new System.Drawing.Size(393, 27);
			this.textBoxLogin.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(0, 116);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(77, 20);
			this.label5.TabIndex = 1;
			this.label5.Text = "Пароль:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(1, 83);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 20);
			this.label6.TabIndex = 0;
			this.label6.Text = "Логин:";
			// 
			// bindingSource1
			// 
			this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Kurs_Work_BD.Properties.Resources.фитнес_клуб_с_гантелями_строки_гантелей_металла_на_шкафе_для_150233004;
			this.pictureBox1.Location = new System.Drawing.Point(-180, -3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(821, 466);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 31;
			this.pictureBox1.TabStop = false;
			// 
			// Доступ_к_системе
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(638, 457);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.b_Exit2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Доступ_к_системе";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this._Kurs_WORKDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.доступBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._Kurs_WORKDataSet1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingSource bindingSource1;
		private _Kurs_WORKDataSet _Kurs_WORKDataSet;
		private System.Windows.Forms.BindingSource доступBindingSource;
		private _Kurs_WORKDataSetTableAdapters.ДоступTableAdapter доступTableAdapter;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button b_Exit2;
		private _Kurs_WORKDataSet1 _Kurs_WORKDataSet1;
		private _Kurs_WORKDataSet1TableAdapters.testView1TableAdapter testView1TableAdapter;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button b_Entire_Obshie;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.TextBox textBoxLogin;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

