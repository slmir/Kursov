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
	public partial class Таблица_услуги : Form
	{

		string conStr = "Data Source=DESKTOP-6LJM1LE\\SQLEXPRESS;Initial Catalog=Kurs-WORK;Integrated Security=True";
		string ForUpdate = "SELECT * FROM [Услуги]";//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
		public Таблица_услуги()//!!!!!!!!!!!!!!!!!!!!!
		{
			InitializeComponent();
			this.Text = "Редактирование данных об услугах";//!!!!!!!!!!!!!!!!!!
		}
	private void Таблица_услуги_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_Kurs_WORKDataSet3.Услуги". При необходимости она может быть перемещена или удалена.
			this.услугиTableAdapter.Fill(this._Kurs_WORKDataSet3.Услуги);

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
				adapter.Update(_Kurs_WORKDataSet3.Услуги);///!!!!!!!!!!!!!!!!!!!!!!!!
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
				DataRow newAb = _Kurs_WORKDataSet3.Услуги.NewRow();//!!!!!!!!!!!!
				newAb.ItemArray = new object[] { "АА999", "Заполнить", "Заполнить"};///!!!!!!!!!!!!
				_Kurs_WORKDataSet3.Услуги.Rows.Add(newAb);////!!!!!!!!!!!

				услугиTableAdapter.Update(_Kurs_WORKDataSet3);//!!!!!!!!!!!!!!!!!
				this.Validate();
				this.услугиBindingSource.EndEdit();//!!!!!!!!!!!!!!!!!!!!!!!!
				_Kurs_WORKDataSet3.AcceptChanges();
			}
			MessageBox.Show("Добавлена новая строка где\nКод_услуги = 'АА999' и значения по умолчанию.\nОбязательна к редактированию!", "Редактируйте добавленную строку!", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
