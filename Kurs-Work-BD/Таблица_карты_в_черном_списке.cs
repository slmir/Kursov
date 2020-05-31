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
	public partial class Таблица_карты_в_черном_списке : Form
	{

		string conStr = "Data Source=DESKTOP-6LJM1LE\\SQLEXPRESS;Initial Catalog=Kurs-WORK;Integrated Security=True";
		string ForUpdate = "SELECT * FROM [Черный_список]";//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
		public Таблица_карты_в_черном_списке()
		{
			InitializeComponent();
			this.Text = "Редактирование данных о картах, находящихся в черном списке";//!!!!!!!!!!!!!!!!!!

		}

		private void Таблица_карты_в_черном_списке_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_Kurs_WORKDataSet3.Черный_список". При необходимости она может быть перемещена или удалена.
			this.черный_списокTableAdapter.Fill(this._Kurs_WORKDataSet3.Черный_список);

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
				adapter.Update(_Kurs_WORKDataSet3.Черный_список);///!!!!!!!!!!!!!!!!!!!!!!!!
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
				DataRow newAb = _Kurs_WORKDataSet3.Черный_список.NewRow();//!!!!!!!!!!!!
				newAb.ItemArray = new object[] { "ЧС99999", "9999-01-01", "AA00005", "9999-01-02","Нет", "НA00009", "Заполнить" };///!!!!!!!!!!!!
				_Kurs_WORKDataSet3.Черный_список.Rows.Add(newAb);////!!!!!!!!!!!

				черный_списокTableAdapter.Update(_Kurs_WORKDataSet3);//!!!!!!!!!!!!!!!!!
				this.Validate();
				this.черныйсписокBindingSource.EndEdit();//!!!!!!!!!!!!!!!!!!!!!!!!
				_Kurs_WORKDataSet3.AcceptChanges();
			}
			MessageBox.Show("Добавлена новая строка где\nКод_ЧС = 'ЧС99999' и значения по умолчанию.\nОбязательна к редактированию!", "Редактируйте добавленную строку!", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
