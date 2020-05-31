namespace Kurs_Work_BD
{
	partial class Клиент
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
			this.b_Entire_Client = new System.Windows.Forms.Button();
			this.textBoxClientPass = new System.Windows.Forms.TextBox();
			this.textBoxClientLogin = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.b_exit_Client = new System.Windows.Forms.Button();
			this.b_back_Client = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(237, 19);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(458, 39);
			this.label4.TabIndex = 11;
			this.label4.Text = "Войти в систему как клиент";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.GreenYellow;
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.b_Entire_Client);
			this.panel1.Controls.Add(this.textBoxClientPass);
			this.panel1.Controls.Add(this.textBoxClientLogin);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(267, 119);
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
			// b_Entire_Client
			// 
			this.b_Entire_Client.Location = new System.Drawing.Point(243, 142);
			this.b_Entire_Client.Name = "b_Entire_Client";
			this.b_Entire_Client.Size = new System.Drawing.Size(152, 52);
			this.b_Entire_Client.TabIndex = 4;
			this.b_Entire_Client.Text = "Войти!";
			this.b_Entire_Client.UseVisualStyleBackColor = true;
			this.b_Entire_Client.Click += new System.EventHandler(this.b_Entire_Client_Click);
			// 
			// textBoxClientPass
			// 
			this.textBoxClientPass.Location = new System.Drawing.Point(110, 100);
			this.textBoxClientPass.Name = "textBoxClientPass";
			this.textBoxClientPass.PasswordChar = '*';
			this.textBoxClientPass.Size = new System.Drawing.Size(285, 22);
			this.textBoxClientPass.TabIndex = 3;
			// 
			// textBoxClientLogin
			// 
			this.textBoxClientLogin.Location = new System.Drawing.Point(110, 70);
			this.textBoxClientLogin.Name = "textBoxClientLogin";
			this.textBoxClientLogin.Size = new System.Drawing.Size(285, 22);
			this.textBoxClientLogin.TabIndex = 2;
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
			// b_exit_Client
			// 
			this.b_exit_Client.Location = new System.Drawing.Point(811, 475);
			this.b_exit_Client.Name = "b_exit_Client";
			this.b_exit_Client.Size = new System.Drawing.Size(124, 47);
			this.b_exit_Client.TabIndex = 9;
			this.b_exit_Client.Text = "Выйти из приложения";
			this.b_exit_Client.UseVisualStyleBackColor = true;
			this.b_exit_Client.Click += new System.EventHandler(this.b_exit_Click);
			// 
			// b_back_Client
			// 
			this.b_back_Client.Location = new System.Drawing.Point(12, 475);
			this.b_back_Client.Name = "b_back_Client";
			this.b_back_Client.Size = new System.Drawing.Size(119, 48);
			this.b_back_Client.TabIndex = 8;
			this.b_back_Client.Text = "Назад";
			this.b_back_Client.UseVisualStyleBackColor = true;
			this.b_back_Client.Click += new System.EventHandler(this.b_back_upravl_Click);
			// 
			// Клиент
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(947, 533);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.b_exit_Client);
			this.Controls.Add(this.b_back_Client);
			this.Name = "Клиент";
			this.Text = "Клиент";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button b_Entire_Client;
		private System.Windows.Forms.TextBox textBoxClientPass;
		private System.Windows.Forms.TextBox textBoxClientLogin;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button b_exit_Client;
		private System.Windows.Forms.Button b_back_Client;
	}
}