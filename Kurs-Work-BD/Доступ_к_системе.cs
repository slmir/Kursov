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
	public partial class Доступ_к_системе : Form
	{
		public Доступ_к_системе()
		{
			InitializeComponent();
			this.Text = "Авторизация в системе";
		}

		private void bindingSource1_CurrentChanged(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_Kurs_WORKDataSet1.testView1". При необходимости она может быть перемещена или удалена.
			this.testView1TableAdapter.Fill(this._Kurs_WORKDataSet1.testView1);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_Kurs_WORKDataSet.Доступ". При необходимости она может быть перемещена или удалена.
			this.доступTableAdapter.Fill(this._Kurs_WORKDataSet.Доступ);

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Начальная_форма f = new Начальная_форма();
			f.Show();
			this.Hide();
		}

		private void b_Entire_Obshie_Click(object sender, EventArgs e)
		{
			string conStr = "Data Source=DESKTOP-6LJM1LE\\SQLEXPRESS;Initial Catalog=Kurs-WORK;Integrated Security=True";
			string loginDirector = "select Логин from Доступ where Код_доступа = 1";
			string passwordDirector = "select Пароль from Доступ where Код_доступа = 1";

			string loginUpravl = "select Логин from Доступ where Код_доступа = 2";
			string passwordUpravl = "select Пароль from Доступ where Код_доступа = 2";

			string loginAdmin = "select Логин from Доступ where Код_доступа = 3";
			string passwordAdmin = "select Пароль from Доступ where Код_доступа = 3";

			string loginMenejr = "select Логин from Доступ where Код_доступа = 4";
			string passwordMenejr = "select Пароль from Доступ where Код_доступа = 4";

			string loginClient = "select Логин from Доступ where Код_доступа = 5";
			string passwordClient = "select Пароль from Доступ where Код_доступа = 5";

			using (SqlConnection connection = new SqlConnection(conStr))
			{
				connection.Open();
				SqlCommand LD = connection.CreateCommand();
				SqlCommand PD = connection.CreateCommand();
				LD.CommandType = CommandType.Text;
				LD.CommandText = loginDirector;
				PD.CommandType = CommandType.Text;
				PD.CommandText = passwordDirector;

				SqlCommand LU = connection.CreateCommand();
				SqlCommand PU = connection.CreateCommand();
				LU.CommandType = CommandType.Text;
				LU.CommandText = loginUpravl;
				PU.CommandType = CommandType.Text;
				PU.CommandText = passwordUpravl;

				SqlCommand LA = connection.CreateCommand();
				SqlCommand PA = connection.CreateCommand();
				LA.CommandType = CommandType.Text;
				LA.CommandText = loginAdmin;
				PA.CommandType = CommandType.Text;
				PA.CommandText = passwordAdmin;

				SqlCommand LM = connection.CreateCommand();
				SqlCommand PM = connection.CreateCommand();
				LM.CommandType = CommandType.Text;
				LM.CommandText = loginMenejr;
				PM.CommandType = CommandType.Text;
				PM.CommandText = passwordMenejr;

				SqlCommand LC = connection.CreateCommand();
				SqlCommand PC = connection.CreateCommand();
				LC.CommandType = CommandType.Text;
				LC.CommandText = loginClient;
				PC.CommandType = CommandType.Text;
				PC.CommandText = passwordClient;
				if (textBoxLogin.Text != "" && textBoxPassword.Text != "" &&
					((textBoxLogin.Text == LD.ExecuteScalar().ToString()) && (textBoxPassword.Text == PD.ExecuteScalar().ToString()) ||
					(textBoxLogin.Text == LU.ExecuteScalar().ToString()) && (textBoxPassword.Text == PU.ExecuteScalar().ToString()) ||
					(textBoxLogin.Text == LA.ExecuteScalar().ToString()) && (textBoxPassword.Text == PA.ExecuteScalar().ToString()) ||
					(textBoxLogin.Text == LM.ExecuteScalar().ToString()) && (textBoxPassword.Text == PM.ExecuteScalar().ToString()) ||
					(textBoxLogin.Text == LC.ExecuteScalar().ToString()) && (textBoxPassword.Text == PC.ExecuteScalar().ToString())))
				{
					if (textBoxLogin.Text.Contains("D"))
					{
						if ((textBoxLogin.Text == LD.ExecuteScalar().ToString()) && (textBoxPassword.Text == PD.ExecuteScalar().ToString()) )
						{
							MessageBox.Show("Вы вошли в систему как директор", "Вход разрешен", MessageBoxButtons.OK, MessageBoxIcon.Information);
							Директор_ПД FDDW = new Директор_ПД();
							FDDW.Show();
							this.Hide();

						}
						else if ((textBoxLogin.Text != LD.ExecuteScalar().ToString() || textBoxPassword.Text != PD.ExecuteScalar().ToString()) )
						{
							//textBoxYpravlLogin.Text = "";
							//textBoxYpravlPass.Text = "";
							MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}

					if (textBoxLogin.Text.Contains("U"))
					{
						if ((textBoxLogin.Text == LU.ExecuteScalar().ToString()) && (textBoxPassword.Text == PU.ExecuteScalar().ToString()))
						{
							MessageBox.Show("Вы вошли в систему как управляющий", "Вход разрешен", MessageBoxButtons.OK, MessageBoxIcon.Information);
							Управляющий_ПД FUDW = new Управляющий_ПД();
							FUDW.Show();
							this.Hide();

						}
						else if ((textBoxLogin.Text != LU.ExecuteScalar().ToString() || textBoxPassword.Text != PU.ExecuteScalar().ToString()) )
						{
							//textBoxYpravlLogin.Text = "";
							//textBoxYpravlPass.Text = "";
							MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}

					if (textBoxLogin.Text.Contains("A"))
					{
						if ((textBoxLogin.Text == LA.ExecuteScalar().ToString()) && (textBoxPassword.Text == PA.ExecuteScalar().ToString()))
						{
							MessageBox.Show("Вы вошли в систему как администратор", "Вход разрешен", MessageBoxButtons.OK, MessageBoxIcon.Information);
							Администратор_ПД FDW = new Администратор_ПД();
							FDW.Show();
							this.Hide();
						}
						else if ((textBoxLogin.Text != LA.ExecuteScalar().ToString() || textBoxPassword.Text != PA.ExecuteScalar().ToString()))
						{
							//textBoxYpravlLogin.Text = "";
							//textBoxYpravlPass.Text = "";
							MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}

					if (textBoxLogin.Text.Contains("M"))
					{
						if ((textBoxLogin.Text == LM.ExecuteScalar().ToString()) && (textBoxPassword.Text == PM.ExecuteScalar().ToString()))
						{
							MessageBox.Show("Вы вошли в систему как менеджер", "Вход разрешен", MessageBoxButtons.OK, MessageBoxIcon.Information);
							Менеджер_ПД FMDW = new Менеджер_ПД();
							FMDW.Show();
							this.Hide();

						}
						else if ((textBoxLogin.Text != LM.ExecuteScalar().ToString() || textBoxPassword.Text != PM.ExecuteScalar().ToString()))
						{
							//textBoxYpravlLogin.Text = "";
							//textBoxYpravlPass.Text = "";
							MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}

					if (textBoxLogin.Text.Contains("C"))
					{
						if ((textBoxLogin.Text == LC.ExecuteScalar().ToString()) && (textBoxPassword.Text == PC.ExecuteScalar().ToString()))
						{
							MessageBox.Show("Вы вошли в систему как клиент", "Вход разрешен", MessageBoxButtons.OK, MessageBoxIcon.Information);
							Клиент_ПД FDW = new Клиент_ПД();
							FDW.Show();
							this.Hide();
						}
						else if ((textBoxLogin.Text != LC.ExecuteScalar().ToString() || textBoxPassword.Text != PC.ExecuteScalar().ToString()))
						{
							//textBoxYpravlLogin.Text = "";
							//textBoxYpravlPass.Text = "";
							MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
				else if ((textBoxLogin.Text != LD.ExecuteScalar().ToString()) || (textBoxPassword.Text != PD.ExecuteScalar().ToString())
					|| (textBoxLogin.Text != LU.ExecuteScalar().ToString()) || (textBoxPassword.Text != PU.ExecuteScalar().ToString())
					|| (textBoxLogin.Text != LA.ExecuteScalar().ToString()) || (textBoxPassword.Text != PA.ExecuteScalar().ToString())
					|| (textBoxLogin.Text != LM.ExecuteScalar().ToString()) || (textBoxPassword.Text != PM.ExecuteScalar().ToString())
					|| (textBoxLogin.Text != LC.ExecuteScalar().ToString()) || (textBoxPassword.Text != PC.ExecuteScalar().ToString()))
				{
					MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					MessageBox.Show("Пустые логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

	}
}
