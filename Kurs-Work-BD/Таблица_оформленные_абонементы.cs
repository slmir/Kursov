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
	public partial class Таблица_оформленные_абонементы : Form
	{
		string conStr = "Data Source=DESKTOP-6LJM1LE\\SQLEXPRESS;Initial Catalog=Kurs-WORK;Integrated Security=True";
		string ForUpdate = "SELECT * FROM [Оформление_абонементов]";//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

		public Таблица_оформленные_абонементы()
		{
			InitializeComponent();
			this.Text = "Редактирование данных об оформленных абонементах";//!!!!!!!!!!!!!!!!!!
		}

		private void Таблица_оформленные_абонементы_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_Kurs_WORKDataSet3.Оформление_абонементов". При необходимости она может быть перемещена или удалена.
			this.оформление_абонементовTableAdapter.Fill(this._Kurs_WORKDataSet3.Оформление_абонементов);

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
				adapter.Update(_Kurs_WORKDataSet3.Оформление_абонементов);///!!!!!!!!!!!!!!!!!!!!!!!!
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
				DataRow newAb = _Kurs_WORKDataSet3.Оформление_абонементов.NewRow();//!!!!!!!!!!!!
				newAb.ItemArray = new object[] { "AA99999",2,"А0001", "9999-01-01",99,"Да"};///!!!!!!!!!!!!
				_Kurs_WORKDataSet3.Оформление_абонементов.Rows.Add(newAb);////!!!!!!!!!!!

				оформление_абонементовTableAdapter.Update(_Kurs_WORKDataSet3);//!!!!!!!!!!!!!!!!!
				this.Validate();
				this.оформлениеабонементовBindingSource.EndEdit();//!!!!!!!!!!!!!!!!!!!!!!!!
				_Kurs_WORKDataSet3.AcceptChanges();
			}
			MessageBox.Show("Добавлена новая строка где\nНомер_карты = 'AA99999' и значения по умолчанию.\nОбязательна к редактированию!", "Редактируйте добавленную строку!", MessageBoxButtons.OK, MessageBoxIcon.Information);

		}
		private void buttonDelete_Click_1(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dataGridView1.SelectedRows)
			{
				dataGridView1.Rows.Remove(row);
				MessageBox.Show("Строка удалена!", "Удаление строки", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
		}
	}
}