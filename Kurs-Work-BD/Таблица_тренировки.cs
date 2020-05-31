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
	public partial class Таблица_тренировки : Form
	{

		string conStr = "Data Source=DESKTOP-6LJM1LE\\SQLEXPRESS;Initial Catalog=Kurs-WORK;Integrated Security=True";
		string ForUpdate = "SELECT * FROM [Тренировки]";//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

	
		public Таблица_тренировки()
		{
			InitializeComponent();
			this.Text = "Редактирование данных о тренировках";//!!!!!!!!!!!!!!!!!!
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
				adapter.Update(_Kurs_WORKDataSet3.Тренировки);///!!!!!!!!!!!!!!!!!!!!!!!!
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
				DataRow newAb = _Kurs_WORKDataSet3.Тренировки.NewRow();//!!!!!!!!!!!!
				newAb.ItemArray = new object[] { "ТР999", "07:00:00",99, "AA001", 1 };///!!!!!!!!!!!!
				_Kurs_WORKDataSet3.Тренировки.Rows.Add(newAb);////!!!!!!!!!!!

				тренировкиTableAdapter.Update(_Kurs_WORKDataSet3);//!!!!!!!!!!!!!!!!!
				this.Validate();
				this.тренировкиBindingSource.EndEdit();//!!!!!!!!!!!!!!!!!!!!!!!!
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

		private void Таблица_тренировки_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_Kurs_WORKDataSet3.Тренировки". При необходимости она может быть перемещена или удалена.
			this.тренировкиTableAdapter.Fill(this._Kurs_WORKDataSet3.Тренировки);

		}
	}
}
