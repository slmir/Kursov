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
using Kurs_Work_BD._Kurs_WORKDataSet7TableAdapters;
using System.Reflection;

namespace Kurs_Work_BD
{
	public partial class Новый_клиент : Form
	{
		DataSet ds;
		SqlDataAdapter adapter;
		string conStr = "Data Source=DESKTOP-6LJM1LE\\SQLEXPRESS;Initial Catalog=Kurs-WORK;Integrated Security=True";
		//string Client = "SELECT dbo.Клиенты.Код_клиента, dbo.Паспортные_данные_клиентов.Фамилия, dbo.Паспортные_данные_клиентов.Имя, dbo.Паспортные_данные_клиентов.Отчество, dbo.Паспортные_данные_клиентов.Паспортные_данные,dbo.Паспортные_данные_клиентов.Дата_рождения, dbo.Паспортные_данные_клиентов.Адрес, dbo.Клиенты.Телефон FROM     dbo.Клиенты INNER JOIN dbo.Паспортные_данные_клиентов ON dbo.Клиенты.Паспортные_данные = dbo.Паспортные_данные_клиентов.Паспортные_данные";
		string Client = "Select top 1 * from Паспортные_данные_клиентов order by Паспортные_данные desc";
		string LastClient = "SELECT top 1 dbo.Клиенты.Код_клиента, dbo.Паспортные_данные_клиентов.Фамилия, dbo.Паспортные_данные_клиентов.Имя, dbo.Паспортные_данные_клиентов.Отчество, dbo.Паспортные_данные_клиентов.Паспортные_данные, dbo.Паспортные_данные_клиентов.Дата_рождения, dbo.Паспортные_данные_клиентов.Адрес, dbo.Клиенты.Телефон FROM dbo.Клиенты INNER JOIN dbo.Паспортные_данные_клиентов ON dbo.Клиенты.Паспортные_данные = dbo.Паспортные_данные_клиентов.Паспортные_данные order by Код_клиента desc; SELECT SCOPE_IDENTITY()";
		//int LC = 
		public Новый_клиент()
		{
			InitializeComponent();
			this.Text = "Новый клиент";
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Информация_о_фитнес_центре f = new Информация_о_фитнес_центре();
			f.Show();
		}

		private void b_Exit2_Click(object sender, EventArgs e)
		{
			Начальная_форма f = new Начальная_форма();
			f.Show();
			this.Hide();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void buttonDobav_Click(object sender, EventArgs e)
		{
			if (checkBox1.CheckState == CheckState.Checked)
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

					SqlDataAdapter adapter = new SqlDataAdapter(Client, sqlConnection);
					adapter = new SqlDataAdapter(Client, sqlConnection);
					DataRow newClientPD = _Kurs_WORKDataSet3.Паспортные_данные_клиентов.NewRow();
					newClientPD.ItemArray = new object[] {textBoxPD.Text , textBoxFamilia.Text, textBoxName.Text,
					textBoxOtchestvo.Text, textBoxDate_rojdenia.Text, textBoxAdr.Text};
					_Kurs_WORKDataSet3.Паспортные_данные_клиентов.Rows.Add(newClientPD);
					//DataRow newClient = _Kurs_WORKDataSet3.Клиенты.NewRow();
					//newClient.ItemArray = new object[] {сount, textBoxPD.Text, textBoxPhone.Text};
					//_Kurs_WORKDataSet3.Клиенты.Rows.Add(newClient);

					паспортные_данные_клиентовTableAdapter.Update(_Kurs_WORKDataSet3);
					this.Validate();
					this.паспортныеданныеклиентовBindingSource1.EndEdit();
					_Kurs_WORKDataSet3.AcceptChanges();

					SqlDataAdapter da1 = new SqlDataAdapter("INSERT INTO Клиенты VALUES(" + сount + ",'" + textBoxPD.Text + "','" + textBoxPhone.Text + "')", sqlConnection);
					SqlCommandBuilder cb1 = new SqlCommandBuilder(da1);
					DataSet ds1 = new DataSet();
					da1.Fill(ds1, "INSERT INTO Клиенты VALUES(" + сount + ",'" + textBoxPD.Text + "','" + textBoxPhone.Text + "')");
					//dataGridView2.DataSource = ds1.Tables[0];

					клиентыTableAdapter.Update(_Kurs_WORKDataSet3);
					this.клиентыBindingSource.EndEdit();
					this.отчетоклиентеBindingSource4.EndEdit();
					_Kurs_WORKDataSet3.AcceptChanges();

					SqlDataAdapter da = new SqlDataAdapter(LastClient, sqlConnection);
					SqlCommandBuilder cb = new SqlCommandBuilder(da);
					DataSet ds = new DataSet();
					da.Fill(ds, LastClient);
					dataGridView1.DataSource = ds.Tables[0];
					this.dataGridView1.EndEdit();

					/*SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
					adapter.InsertCommand = new SqlCommand("sp_Update", sqlConnection);
					adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
					adapter.InsertCommand.Parameters.Add(new SqlParameter(textBoxFamilia.Text, SqlDbType.NVarChar, 50, "Фамилия"));
					adapter.InsertCommand.Parameters.Add(new SqlParameter(textBoxName.Text, SqlDbType.NVarChar, 30, "Имя"));
					adapter.InsertCommand.Parameters.Add(new SqlParameter(textBoxOtchestvo.Text, SqlDbType.NVarChar, 40, "Отчество"));
					adapter.InsertCommand.Parameters.Add(new SqlParameter(textBoxDate_rojdenia.Text, SqlDbType.Date, 0, "[Дата_рождения]"));
					adapter.InsertCommand.Parameters.Add(new SqlParameter(textBoxAdr.Text, SqlDbType.NVarChar, 100, "Адрес"));
					SqlParameter parameter = adapter.InsertCommand.Parameters.Add(textBoxPD.Text, SqlDbType.NChar, 11, "[Паспортные_данные]");

					parameter.Direction = ParameterDirection.Output;
					adapter.Update(_Kurs_WORKDataSet3.Паспортные_данные_клиентов);*/
					//adapter.Update(_Kurs_WORKDataSet7.Клиенты);
					//adapter.Update(_Kurs_WORKDataSet3.Паспортные_данные_клиентов);
					//string sqlExpression = "Select * from Паспортные_данные_клиентов";
					//	SqlDataAdapter da = new SqlDataAdapter(Client, sqlConnection);
					//	SqlCommandBuilder cb = new SqlCommandBuilder(da);
					//	DataSet ds = new DataSet();
					//	da.Fill(ds, sqlExpression);
					//	dataGridView2.DataSource = ds.Tables[0];
					//	sqlConnection.Close();

					MessageBox.Show("Успешно!");
				}
			}
			else
				MessageBox.Show("Вы не подтвердили свое согласие!","Ошибка!",MessageBoxButtons.OK,MessageBoxIcon.Error);
		}

		private void Новый_клиент_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_Kurs_WORKDataSet3.Отчет_о_клиенте". При необходимости она может быть перемещена или удалена.
			//this.отчет_о_клиентеTableAdapter1.Fill(this._Kurs_WORKDataSet3.Отчет_о_клиенте);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_Kurs_WORKDataSet3.Клиенты". При необходимости она может быть перемещена или удалена.
			this.клиентыTableAdapter.Fill(this._Kurs_WORKDataSet3.Клиенты);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_Kurs_WORKDataSet8.View_1". При необходимости она может быть перемещена или удалена.
			this.view_1TableAdapter.Fill(this._Kurs_WORKDataSet8.View_1);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_Kurs_WORKDataSet3.Паспортные_данные_клиентов". При необходимости она может быть перемещена или удалена.
			this.паспортные_данные_клиентовTableAdapter.Fill(this._Kurs_WORKDataSet3.Паспортные_данные_клиентов);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_Kurs_WORKDataSet7.Отчет_о_клиенте". При необходимости она может быть перемещена или удалена.
			//this.отчет_о_клиентеTableAdapter.Fill(this._Kurs_WORKDataSet7.Отчет_о_клиенте);

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			using (SqlConnection sqlConnection = new SqlConnection(conStr))
			{
				sqlConnection.Open();
				string sqlExpression = "Select * from Паспортные_данные_клиентов";
				SqlDataAdapter da = new SqlDataAdapter(Client, sqlConnection);
				SqlCommandBuilder cb = new SqlCommandBuilder(da);
				DataSet ds = new DataSet();
				da.Fill(ds, sqlExpression);
				//dataGridView2.DataSource = ds.Tables[0];
				sqlConnection.Close();
			}
		}

		private void bindingSource2_CurrentChanged(object sender, EventArgs e)
		{

		}

		private void bindingSource3_CurrentChanged(object sender, EventArgs e)
		{

		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void buttonVerno_Click(object sender, EventArgs e)
		{
			if (dataGridView1.Columns.Count > 0)
			{
				MessageBox.Show("Поздравляем, ваши данные успешно сохранены.\nПожалуйста, запомните или запишите данные для авторизации в системе:\n\n\tЛогин:\tClient\t\n\tПароль:\t111\t\n\nВы будете перенаправлены на форму авторизации в системе.", "Регистрация прошла успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Доступ_к_системе f = new Доступ_к_системе();
				f.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Возможно вы неверно указали данные \nили не выполнили все условия регистрации.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			Доступ_к_системе f = new Доступ_к_системе();
			f.Show();
			this.Hide();
		}
	}
}
