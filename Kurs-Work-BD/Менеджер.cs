using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs_Work_BD
{
	public partial class Менеджер : Form
	{
		public Менеджер()
		{
			InitializeComponent();
		}

		private void b_back_upravl_Click(object sender, EventArgs e)
		{
			Доступ_к_системе FDKS = new Доступ_к_системе();
			FDKS.Show();
			this.Hide();
		}

		private void b_exit_Click(object sender, EventArgs e)
		{
			this.Close();
			Application.Exit();
		}

		private void b_Entire_Menej_Click(object sender, EventArgs e)
		{
			string conStr = "Data Source=DESKTOP-6LJM1LE\\SQLEXPRESS;Initial Catalog=Kurs-WORK;Integrated Security=True";
			string login = "select Логин from Доступ where Код_доступа = 4";
			string password = "select Пароль from Доступ where Код_доступа = 4";
			using (SqlConnection connection = new SqlConnection(conStr))
			{
				connection.Open();
				SqlCommand command = connection.CreateCommand();
				SqlCommand command1 = connection.CreateCommand();
				command.CommandType = CommandType.Text;
				command.CommandText = login;
				command1.CommandType = CommandType.Text;
				command1.CommandText = password;
				if ((textBoxMenejLogin.Text == command.ExecuteScalar().ToString()) && (textBoxMenejPass.Text == command1.ExecuteScalar().ToString()))
				{
					MessageBox.Show("Верно", "Вход разрешен");
					Менеджер_ПД FMDW = new Менеджер_ПД();
					FMDW.Show();
					this.Hide();
					//вход в работу клиента
				}
				else
				{
					if (textBoxMenejLogin.Text != command.ExecuteScalar().ToString())
						MessageBox.Show("Ошибка", "Неверный логин", MessageBoxButtons.OK, MessageBoxIcon.Error);
					if (textBoxMenejPass.Text != command1.ExecuteScalar().ToString())
						MessageBox.Show("Ошибка", "Неверный пароль", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
	}
}
