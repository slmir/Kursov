﻿namespace Kurs_Work_BD
{
	partial class Менеджер
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
			this.label4 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.b_Entire_Menej = new System.Windows.Forms.Button();
			this.textBoxMenejPass = new System.Windows.Forms.TextBox();
			this.textBoxMenejLogin = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.b_exit = new System.Windows.Forms.Button();
			this.b_back_upravl = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(226, 27);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(512, 39);
			this.label4.TabIndex = 11;
			this.label4.Text = "Войти в систему как менеджер";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.GreenYellow;
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.b_Entire_Menej);
			this.panel1.Controls.Add(this.textBoxMenejPass);
			this.panel1.Controls.Add(this.textBoxMenejLogin);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(274, 121);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(398, 197);
			this.panel1.TabIndex = 10;
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
			// 
			// b_Entire_Menej
			// 
			this.b_Entire_Menej.Location = new System.Drawing.Point(243, 142);
			this.b_Entire_Menej.Name = "b_Entire_Menej";
			this.b_Entire_Menej.Size = new System.Drawing.Size(152, 52);
			this.b_Entire_Menej.TabIndex = 4;
			this.b_Entire_Menej.Text = "Войти!";
			this.b_Entire_Menej.UseVisualStyleBackColor = true;
			this.b_Entire_Menej.Click += new System.EventHandler(this.b_Entire_Menej_Click);
			// 
			// textBoxMenejPass
			// 
			this.textBoxMenejPass.Location = new System.Drawing.Point(110, 100);
			this.textBoxMenejPass.Name = "textBoxMenejPass";
			this.textBoxMenejPass.PasswordChar = '*';
			this.textBoxMenejPass.Size = new System.Drawing.Size(285, 22);
			this.textBoxMenejPass.TabIndex = 3;
			// 
			// textBoxMenejLogin
			// 
			this.textBoxMenejLogin.Location = new System.Drawing.Point(110, 70);
			this.textBoxMenejLogin.Name = "textBoxMenejLogin";
			this.textBoxMenejLogin.Size = new System.Drawing.Size(285, 22);
			this.textBoxMenejLogin.TabIndex = 2;
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
			// b_exit
			// 
			this.b_exit.Location = new System.Drawing.Point(828, 477);
			this.b_exit.Name = "b_exit";
			this.b_exit.Size = new System.Drawing.Size(124, 47);
			this.b_exit.TabIndex = 9;
			this.b_exit.Text = "Выйти из приложения";
			this.b_exit.UseVisualStyleBackColor = true;
			this.b_exit.Click += new System.EventHandler(this.b_exit_Click);
			// 
			// b_back_upravl
			// 
			this.b_back_upravl.Location = new System.Drawing.Point(8, 477);
			this.b_back_upravl.Name = "b_back_upravl";
			this.b_back_upravl.Size = new System.Drawing.Size(119, 48);
			this.b_back_upravl.TabIndex = 8;
			this.b_back_upravl.Text = "Назад";
			this.b_back_upravl.UseVisualStyleBackColor = true;
			this.b_back_upravl.Click += new System.EventHandler(this.b_back_upravl_Click);
			// 
			// Менеджер
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(961, 533);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.b_exit);
			this.Controls.Add(this.b_back_upravl);
			this.Name = "Менеджер";
			this.Text = "Менеджер";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button b_Entire_Menej;
		private System.Windows.Forms.TextBox textBoxMenejPass;
		private System.Windows.Forms.TextBox textBoxMenejLogin;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button b_exit;
		private System.Windows.Forms.Button b_back_upravl;
	}
}