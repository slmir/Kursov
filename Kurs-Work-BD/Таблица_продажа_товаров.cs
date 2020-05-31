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
	public partial class Таблица_продажа_товаров : Form
	{

		string conStr = "Data Source=DESKTOP-6LJM1LE\\SQLEXPRESS;Initial Catalog=Kurs-WORK;Integrated Security=True";
		string ForUpdate = "SELECT * FROM [Продажа_товаров]";//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
		public Таблица_продажа_товаров()
		{
			InitializeComponent();
			this.Text = "Редактирование данных о продажах товаров";//!!!!!!!!!!!!!!!!!!
		}

		private void Таблица_продажа_товаров_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_Kurs_WORKDataSet3.Продажа_товаров". При необходимости она может быть перемещена или удалена.
			this.продажа_товаровTableAdapter.Fill(this._Kurs_WORKDataSet3.Продажа_товаров);

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
				adapter.Update(_Kurs_WORKDataSet3.Продажа_товаров);///!!!!!!!!!!!!!!!!!!!!!!!!
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
			DataRow newAb = _Kurs_WORKDataSet3.Продажа_товаров.NewRow();//!!!!!!!!!!!!
			newAb.ItemArray = new object[] { "ТОВ999А", "Т0000", 1,1,1,1};///!!!!!!!!!!!!
			_Kurs_WORKDataSet3.Продажа_товаров.Rows.Add(newAb);////!!!!!!!!!!!

			продажа_товаровTableAdapter.Update(_Kurs_WORKDataSet3);//!!!!!!!!!!!!!!!!!
			this.Validate();
			this.продажатоваровBindingSource.EndEdit();//!!!!!!!!!!!!!!!!!!!!!!!!
			_Kurs_WORKDataSet3.AcceptChanges();
		}
		MessageBox.Show("Добавлена новая строка где\nКод_поставщика = 'АА99' и значения по умолчанию.\nОбязательна к редактированию!", "Редактируйте добавленную строку!", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
