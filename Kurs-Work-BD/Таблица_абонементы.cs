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
	public partial class Таблица_абонементы : Form
	{
		DataSet ds;
		SqlDataAdapter adapter;
		string conStr = "Data Source=DESKTOP-6LJM1LE\\SQLEXPRESS;Initial Catalog=Kurs-WORK;Integrated Security=True";
		string ForUpdate = "SELECT * FROM [Абонементы]";//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
		public Таблица_абонементы()
		{
			InitializeComponent();
			this.Text = "Редактирование данных об абонементах";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			using (SqlConnection sqlConnection = new SqlConnection(conStr))
			{
				sqlConnection.Open();
				SqlDataAdapter adapter = new SqlDataAdapter(ForUpdate, sqlConnection);
				adapter = new SqlDataAdapter(ForUpdate, sqlConnection);
				SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
				adapter.InsertCommand = new SqlCommand("sp_Update", sqlConnection);
				//adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
				//adapter.InsertCommand.Parameters.Add(new SqlParameter("@Vid", SqlDbType.NVarChar, 100, "Вид_тренировки"));
				//adapter.InsertCommand.Parameters.Add(new SqlParameter("@Stoim", SqlDbType.Money, 0, "[Стоимость]"));
				//adapter.InsertCommand.Parameters.Add(new SqlParameter("@Time", SqlDbType.SmallInt, 0, "[Время_действия_месяцы]"));
				//adapter.InsertCommand.Parameters.Add(new SqlParameter("@Colvo", SqlDbType.Int, 0, "[Количество_посещений]"));
				//adapter.InsertCommand.Parameters.Add(new SqlParameter("@Zmor", SqlDbType.Char, 4, "[Возможность_заморозки]"));
				//SqlParameter parameter = adapter.InsertCommand.Parameters.Add("@[Код_абонемента]", SqlDbType.Char, 5, "[Код_абонемента]");

				adapter.Update(_Kurs_WORKDataSet3.Абонементы);
				MessageBox.Show("Изменения успешно сохранены!","Редактирование", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void buttonDobav_Click(object sender, EventArgs e)
		{
			using (SqlConnection sqlConnection = new SqlConnection(conStr))
			{
				sqlConnection.Open();
				SqlDataAdapter ad = new SqlDataAdapter(ForUpdate, sqlConnection);
				ad = new SqlDataAdapter(ForUpdate, sqlConnection);
				DataRow newAb = _Kurs_WORKDataSet3.Абонементы.NewRow();
				newAb.ItemArray = new object[] {"А9999","Заполнить",0,1,1,"Нет"};
				_Kurs_WORKDataSet3.Абонементы.Rows.Add(newAb);

				абонементыTableAdapter.Update(_Kurs_WORKDataSet3);
				this.Validate();
				this.абонементыBindingSource.EndEdit();
				_Kurs_WORKDataSet3.AcceptChanges();
			}
			MessageBox.Show("Добавлена новая строка где\nКод_абонемента = 'А9999' и значения по умолчанию.\nОбязательна к редактированию!", "Редактируйте добавленную строку!", MessageBoxButtons.OK, MessageBoxIcon.Information);
			/*DataRow row = ds.Tables[0].NewRow(); // добавляем новую строку в DataTable
			ds.Tables[0].Rows.Add(row);*/
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dataGridView1.SelectedRows)
			{
				dataGridView1.Rows.Remove(row);
				MessageBox.Show("Строка удалена!","Удаление строки", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
		}

		private void Таблица_абонементы_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_Kurs_WORKDataSet3.Абонементы". При необходимости она может быть перемещена или удалена.
			this.абонементыTableAdapter.Fill(this._Kurs_WORKDataSet3.Абонементы);

		}

		private void back_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}

		private void fillToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				this.абонементыTableAdapter.Fill(this._Kurs_WORKDataSet3.Абонементы);
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}
	}
}
