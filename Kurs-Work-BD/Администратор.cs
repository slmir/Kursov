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
	public partial class Администратор : Form
	{
		public Администратор()
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

		private void b_Entire_Admin_Click(object sender, EventArgs e)
		{
			string conStr = "Data Source=DESKTOP-6LJM1LE\\SQLEXPRESS;Initial Catalog=Kurs-WORK;Integrated Security=True";
			string loginAdmin = "select Логин from Доступ where Код_доступа = 3";
			string passwordAdmin = "select Пароль from Доступ where Код_доступа = 3";
			using (SqlConnection connection = new SqlConnection(conStr))
			{
				connection.Open();
				SqlCommand LA = connection.CreateCommand();
				SqlCommand PA = connection.CreateCommand();
				LA.CommandType = CommandType.Text;
				LA.CommandText = loginAdmin;
				PA.CommandType = CommandType.Text;
				PA.CommandText = passwordAdmin;
				if ((textBoxAdminLogin.Text == LA.ExecuteScalar().ToString()) && (textBoxAdminPass.Text == PA.ExecuteScalar().ToString()))
				{
					MessageBox.Show("Вы вошли в систему как администратор", "Вход разрешен", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Администратор_ПД FDW = new Администратор_ПД();
					FDW.Show();
					this.Hide();
				}
				else if ((textBoxAdminLogin.Text != LA.ExecuteScalar().ToString() || textBoxAdminPass.Text != PA.ExecuteScalar().ToString()))
				{
					//textBoxYpravlLogin.Text = "";
					//textBoxYpravlPass.Text = "";
					MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}


		}
	}
}
