using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs_Work_BD
{
	public partial class Отчет_ЧС_карт : Form
	{
		public Отчет_ЧС_карт()
		{
			InitializeComponent();
			this.Text = "Отчет с ифнормацией о картах, занесенных в черный список карт";

		}

		private void Отчет_ЧС_карт_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_Kurs_WORKDataSet3.Отчет_услуги". При необходимости она может быть перемещена или удалена.
			this.отчет_услугиTableAdapter.Fill(this._Kurs_WORKDataSet3.Отчет_услуги);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_Kurs_WORKDataSet3.Отчет_ЧС_карт". При необходимости она может быть перемещена или удалена.
			this.отчет_ЧС_картTableAdapter.Fill(this._Kurs_WORKDataSet3.Отчет_ЧС_карт);

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void Close_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
