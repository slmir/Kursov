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
	public partial class Таблица_клиенты : Form
	{
		string conStr = "Data Source=DESKTOP-6LJM1LE\\SQLEXPRESS;Initial Catalog=Kurs-WORK;Integrated Security=True";
		string ForUpdateClient = "SELECT * FROM [Клиенты]";
		string ForUpdatePD = "SELECT * FROM [Паспортные_данные_клиентов]";
		public Таблица_клиенты()
		{
			InitializeComponent();
			this.Text = "Редактирование данных о клиентах";
		}

		private void Таблица_клиенты_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_Kurs_WORKDataSet3.Паспортные_данные_клиентов". При необходимости она может быть перемещена или удалена.
			this.паспортные_данные_клиентовTableAdapter.Fill(this._Kurs_WORKDataSet3.Паспортные_данные_клиентов);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_Kurs_WORKDataSet3.Посещения". При необходимости она может быть перемещена или удалена.
			//this.посещенияTableAdapter.Fill(this._Kurs_WORKDataSet3.Посещения);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_Kurs_WORKDataSet3.Клиенты". При необходимости она может быть перемещена или удалена.
			this.клиентыTableAdapter.Fill(this._Kurs_WORKDataSet3.Клиенты);

		}

		private void back_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void buttonRedact_Click(object sender, EventArgs e)
		{
			using (SqlConnection sqlConnection = new SqlConnection(conStr))
			{
				sqlConnection.Open();
				SqlDataAdapter adapter = new SqlDataAdapter(ForUpdateClient, sqlConnection);
				adapter = new SqlDataAdapter(ForUpdateClient, sqlConnection);
				SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
				adapter.InsertCommand = new SqlCommand("sp_Update", sqlConnection);
				adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
				//adapter.InsertCommand.Parameters.Add(new SqlParameter("@PD", SqlDbType.NChar, 11, "[Паспортные_данные]"));
				//adapter.InsertCommand.Parameters.Add(new SqlParameter("@Phone", SqlDbType.NChar, 11, "[Телефон]"));
				//SqlParameter parameter = adapter.InsertCommand.Parameters.Add("@[Код_клиента]", SqlDbType.Int, 0, "[Код_клиента]");
				adapter.Update(_Kurs_WORKDataSet3.Клиенты);
				MessageBox.Show("Изменения успешно сохранены!", "Редактирование", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void buttonSAVEPD_Click(object sender, EventArgs e)
		{
			using (SqlConnection sqlConnection = new SqlConnection(conStr))
			{
				sqlConnection.Open();
				SqlDataAdapter adapter = new SqlDataAdapter(ForUpdatePD, sqlConnection);
				adapter = new SqlDataAdapter(ForUpdatePD, sqlConnection);
				SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
				adapter.InsertCommand = new SqlCommand("sp_Update", sqlConnection);
				adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
				adapter.InsertCommand.Parameters.Add(new SqlParameter("@Fam", SqlDbType.NVarChar, 50, "[Фамилия]"));
				adapter.InsertCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 30, "[Имя]"));
				adapter.InsertCommand.Parameters.Add(new SqlParameter("@Otch", SqlDbType.NVarChar, 40, "[Отчество]"));
				adapter.InsertCommand.Parameters.Add(new SqlParameter("@Date", SqlDbType.Date, 0, "[Дата_рождения]"));
				adapter.InsertCommand.Parameters.Add(new SqlParameter("@Adres", SqlDbType.NVarChar, 100, "[Адрес]"));
				SqlParameter parameter = adapter.InsertCommand.Parameters.Add("@[Паспортные_данные]", SqlDbType.NChar, 11, "[Паспортные_данные]");
				adapter.Update(_Kurs_WORKDataSet3.Паспортные_данные_клиентов);
				MessageBox.Show("Изменения успешно сохранены!", "Редактирование", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void buttonDobav_Click(object sender, EventArgs e)
		{
			using (SqlConnection sqlConnection = new SqlConnection(conStr))
			{
				sqlConnection.Open();
				DataTable dt = _Kurs_WORKDataSet3.Клиенты;
				SqlCommand command = new SqlCommand("count", sqlConnection);
				command.CommandText = "SELECT COUNT([Код_клиента]) FROM Клиенты";
				command.CommandType = CommandType.Text;
				int сount = (int)command.ExecuteScalar();
				сount++;

				SqlDataAdapter ad = new SqlDataAdapter(ForUpdateClient, sqlConnection);
				ad = new SqlDataAdapter(ForUpdateClient, sqlConnection);
				DataRow newAb = _Kurs_WORKDataSet3.Клиенты.NewRow();
				newAb.ItemArray = new object[] { сount, "9999_999999", "99999999999" };
				_Kurs_WORKDataSet3.Клиенты.Rows.Add(newAb);

				клиентыTableAdapter.Update(_Kurs_WORKDataSet3);
				this.Validate();
				this.клиентыBindingSource.EndEdit();
				_Kurs_WORKDataSet3.AcceptChanges();

				MessageBox.Show("Добавлена новая строка где\nКод_клиента = " + сount + " и значения по умолчанию.\nОбязательна к редактированию!", "Редактирутей добавленную строку!", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void buttonDOBAVPD_Click(object sender, EventArgs e)
		{
			using (SqlConnection sqlConnection = new SqlConnection(conStr))
			{
				sqlConnection.Open();
				SqlDataAdapter ad = new SqlDataAdapter(ForUpdatePD, sqlConnection);
				ad = new SqlDataAdapter(ForUpdatePD, sqlConnection);
				DataRow newAb = _Kurs_WORKDataSet3.Паспортные_данные_клиентов.NewRow();
				newAb.ItemArray = new object[] { "9999_999999", "Заполнить", "Заполнить", "Заполнить","9999-01-01", "Заполнить" };
				_Kurs_WORKDataSet3.Паспортные_данные_клиентов.Rows.Add(newAb);

				паспортные_данные_клиентовTableAdapter.Update(_Kurs_WORKDataSet3);
				this.Validate();
				this.паспортныеданныеклиентовBindingSource.EndEdit();
				_Kurs_WORKDataSet3.AcceptChanges();
			}
			MessageBox.Show("Добавлена новая строка где\nПаспортные_данные = '9999_999999' и значения по умолчанию.\nОбязательна к редактированию!", "Редактируйте добавленную строку!", MessageBoxButtons.OK, MessageBoxIcon.Information);

		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dataGridView1.SelectedRows)
			{
				dataGridView1.Rows.Remove(row);
				MessageBox.Show("Строка удалена!", "Удаление строки", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
		}

		private void buttonDELPD_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dataGridView2.SelectedRows)
			{
				dataGridView2.Rows.Remove(row);
				MessageBox.Show("Строка удалена!", "Удаление строки", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

		}

		private void textBoxPD_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
