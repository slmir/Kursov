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
	public partial class Таблица_специализация : Form
	{
		string conStr = "Data Source=DESKTOP-6LJM1LE\\SQLEXPRESS;Initial Catalog=Kurs-WORK;Integrated Security=True";
		string ForUpdate = "SELECT * FROM [Специализация]";//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
		public Таблица_специализация()
		{
			InitializeComponent();
			this.Text = "Редактирование данных о специализации тренеров";//!!!!!!!!!!!!!!!!!!
		}

		private void Таблица_специализация_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_Kurs_WORKDataSet3.Специализация". При необходимости она может быть перемещена или удалена.
			this.специализацияTableAdapter.Fill(this._Kurs_WORKDataSet3.Специализация);

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
				SqlDataAdapter adapter = new SqlDataAdapter(ForUpdate, sqlConnection);
				adapter = new SqlDataAdapter(ForUpdate, sqlConnection);
				SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
				adapter.InsertCommand = new SqlCommand("sp_Update", sqlConnection);
				adapter.Update(_Kurs_WORKDataSet3.Специализация);///!!!!!!!!!!!!!!!!!!!!!!!!
				MessageBox.Show("Изменения успешно сохранены!", "Редактирование", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void buttonDobav_Click(object sender, EventArgs e)
		{
			using (SqlConnection sqlConnection = new SqlConnection(conStr))
			{
				sqlConnection.Open();
				SqlDataAdapter ad = new SqlDataAdapter(ForUpdate, sqlConnection);
				ad = new SqlDataAdapter(ForUpdate, sqlConnection);
				DataRow newAb = _Kurs_WORKDataSet3.Специализация.NewRow();//!!!!!!!!!!!!
				newAb.ItemArray = new object[] { "СП999Я", 7, "Заполнить", "Одиночные", "Заполнить", "Заполнить" };///!!!!!!!!!!!!
				_Kurs_WORKDataSet3.Специализация.Rows.Add(newAb);////!!!!!!!!!!!

				специализацияTableAdapter.Update(_Kurs_WORKDataSet3);//!!!!!!!!!!!!!!!!!
				this.Validate();
				this.специализацияBindingSource.EndEdit();//!!!!!!!!!!!!!!!!!!!!!!!!
				_Kurs_WORKDataSet3.AcceptChanges();
			}
			MessageBox.Show("Добавлена новая строка где\nКод_специализации = 'СП999Я' и значения по умолчанию.\nОбязательна к редактированию!", "Редактируйте добавленную строку!", MessageBoxButtons.OK, MessageBoxIcon.Information);

		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dataGridView1.SelectedRows)
			{
				dataGridView1.Rows.Remove(row);
				MessageBox.Show("Строка удалена!", "Удаление строки", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
		}
	}
}
