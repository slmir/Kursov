namespace Kurs_Work_BD
{
	partial class Директор
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
			this.b_back_Director = new System.Windows.Forms.Button();
			this.b_exit1 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.b_Entire_Director = new System.Windows.Forms.Button();
			this.textBoxDirectorPass = new System.Windows.Forms.TextBox();
			this.textBoxDirectorLogin = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// b_back_Director
			// 
			this.b_back_Director.Location = new System.Drawing.Point(12, 486);
			this.b_back_Director.Name = "b_back_Director";
			this.b_back_Director.Size = new System.Drawing.Size(119, 48);
			this.b_back_Director.TabIndex = 0;
			this.b_back_Director.Text = "Назад";
			this.b_back_Director.UseVisualStyleBackColor = true;
			this.b_back_Director.Click += new System.EventHandler(this.b_back_Director_Click);
			// 
			// b_exit1
			// 
			this.b_exit1.Location = new System.Drawing.Point(845, 486);
			this.b_exit1.Name = "b_exit1";
			this.b_exit1.Size = new System.Drawing.Size(124, 47);
			this.b_exit1.TabIndex = 1;
			this.b_exit1.Text = "Выйти из приложения";
			this.b_exit1.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.GreenYellow;
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.b_Entire_Director);
			this.panel1.Controls.Add(this.textBoxDirectorPass);
			this.panel1.Controls.Add(this.textBoxDirectorLogin);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(260, 130);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(398, 197);
			this.panel1.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(51, 11);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(295, 40);
			this.label3.TabIndex = 5;
			this.label3.Text = "Пожалуйста, для входа в систему\r\n введите логин и пароль:";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// b_Entire_Director
			// 
			this.b_Entire_Director.Location = new System.Drawing.Point(243, 142);
			this.b_Entire_Director.Name = "b_Entire_Director";
			this.b_Entire_Director.Size = new System.Drawing.Size(152, 52);
			this.b_Entire_Director.TabIndex = 4;
			this.b_Entire_Director.Text = "Войти!";
			this.b_Entire_Director.UseVisualStyleBackColor = true;
			// 
			// textBoxDirectorPass
			// 
			this.textBoxDirectorPass.Location = new System.Drawing.Point(110, 100);
			this.textBoxDirectorPass.Name = "textBoxDirectorPass";
			this.textBoxDirectorPass.PasswordChar = '*';
			this.textBoxDirectorPass.Size = new System.Drawing.Size(285, 22);
			this.textBoxDirectorPass.TabIndex = 3;
			// 
			// textBoxDirectorLogin
			// 
			this.textBoxDirectorLogin.Location = new System.Drawing.Point(110, 70);
			this.textBoxDirectorLogin.Name = "textBoxDirectorLogin";
			this.textBoxDirectorLogin.Size = new System.Drawing.Size(285, 22);
			this.textBoxDirectorLogin.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 103);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Пароль:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(4, 70);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Логин:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(209, 36);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(497, 39);
			this.label4.TabIndex = 3;
			this.label4.Text = "Войти в систему как директор";
			// 
			// Директор
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(981, 546);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.b_exit1);
			this.Controls.Add(this.b_back_Director);
			this.Name = "Директор";
			this.Text = "Директор";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button b_back_Director;
		private System.Windows.Forms.Button b_exit1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button b_Entire_Director;
		private System.Windows.Forms.TextBox textBoxDirectorPass;
		private System.Windows.Forms.TextBox textBoxDirectorLogin;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
	}
}