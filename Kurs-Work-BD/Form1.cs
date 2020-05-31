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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			this.Text = "Просмотр информации о карте";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int a = 0;
			string s = textBox1.Text;
			string conStr = "Data Source=DESKTOP-6LJM1LE\\SQLEXPRESS;Initial Catalog=Kurs-WORK;Integrated Security=True";
			string sqlExpression = "EXEC findClient " + s + "";
			using (SqlConnection sqlConnection = new SqlConnection(conStr))
			{
				sqlConnection.Open();
				SqlCommand command = sqlConnection.CreateCommand();
				command.CommandType = CommandType.Text;
				command.CommandText = "EXEC findClient" + " 5";
				//SqlDataReader reader = command.ExecuteReader();
				SqlDataAdapter da = new SqlDataAdapter(sqlExpression, sqlConnection);
				SqlCommandBuilder cb = new SqlCommandBuilder(da);
				DataSet ds = new DataSet();
				da.Fill(ds, sqlExpression);
				dataGridView1.DataSource = ds.Tables[0];
				sqlConnection.Close();
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_Kurs_WORKDataSet7.Оформление_абонементов". При необходимости она может быть перемещена или удалена.
			//this.оформление_абонементовTableAdapter.Fill(this._Kurs_WORKDataSet7.Оформление_абонементов);

		}

		private void button2_Click(object sender, EventArgs e)
		{
			string conStr = "Data Source=DESKTOP-6LJM1LE\\SQLEXPRESS;Initial Catalog=Kurs-WORK;Integrated Security=True";
			using (SqlConnection sqlConnection = new SqlConnection(conStr))
			{
				sqlConnection.Open();
				SqlCommand command = sqlConnection.CreateCommand();
				command.CommandType = CommandType.Text;
				command.CommandText = "EXEC findClientPhone " + textBox2.Text;
				int s = (int)command.ExecuteScalar();
				if (s > 0)
				{
					textBox1.Text = s.ToString();
					MessageBox.Show("Ваш номер занесен в соответсвующее поле.", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
					MessageBox.Show("Номер телефона не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void bindingSource2_CurrentChanged(object sender, EventArgs e)
		{

		}

		private void b_back_Client_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
