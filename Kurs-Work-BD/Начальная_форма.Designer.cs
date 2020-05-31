namespace Kurs_Work_BD
{
	partial class Начальная_форма
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
			this.b_Exit2 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonAutorization = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// b_Exit2
			// 
			this.b_Exit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.b_Exit2.Location = new System.Drawing.Point(894, 424);
			this.b_Exit2.Name = "b_Exit2";
			this.b_Exit2.Size = new System.Drawing.Size(195, 54);
			this.b_Exit2.TabIndex = 28;
			this.b_Exit2.Text = "Выйти из приложения";
			this.b_Exit2.UseVisualStyleBackColor = true;
			this.b_Exit2.Click += new System.EventHandler(this.b_Exit2_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.LightYellow;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(25, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(1022, 39);
			this.label2.TabIndex = 27;
			this.label2.Text = "Здравствуйте, вас приветствует АИС фитнес-центра Арисфит!";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.GreenYellow;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(302, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(513, 59);
			this.label1.TabIndex = 26;
			this.label1.Text = "АИС \"Фитнес-центр\"";
			// 
			// buttonAutorization
			// 
			this.buttonAutorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonAutorization.Location = new System.Drawing.Point(802, 179);
			this.buttonAutorization.Name = "buttonAutorization";
			this.buttonAutorization.Size = new System.Drawing.Size(195, 63);
			this.buttonAutorization.TabIndex = 29;
			this.buttonAutorization.Text = "Авторизоваться в системе";
			this.buttonAutorization.UseVisualStyleBackColor = true;
			this.buttonAutorization.Click += new System.EventHandler(this.buttonAutorization_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(466, 179);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(195, 63);
			this.button1.TabIndex = 34;
			this.button1.Text = "Стать клиентом фитнес-центра";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::Kurs_Work_BD.Properties.Resources.фитнес_клуб_с_гантелями_строки_гантелей_металла_на_шкафе_для_150233004;
			this.pictureBox2.Location = new System.Drawing.Point(-1, -118);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(1103, 611);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 35;
			this.pictureBox2.TabStop = false;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.Control;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.Location = new System.Drawing.Point(104, 179);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(218, 63);
			this.button2.TabIndex = 36;
			this.button2.Text = "Информация о нашем фитнес-центре";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Начальная_форма
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1101, 490);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.buttonAutorization);
			this.Controls.Add(this.b_Exit2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox2);
			this.Name = "Начальная_форма";
			this.Text = "Начальная_форма";
			this.Load += new System.EventHandler(this.Начальная_форма_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button b_Exit2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonAutorization;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button button2;
	}
}