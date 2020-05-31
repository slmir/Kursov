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
	public partial class Отчет_посещения : Form
	{
		public Отчет_посещения()
		{
			InitializeComponent();
			this.Text = "Отчет с информацией о посещениях клиентами тринеровок";
		}

		private void Отчет_посещения_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_Kurs_WORKDataSet5.Отчет_посещения1". При необходимости она может быть перемещена или удалена.
			this.отчет_посещения1TableAdapter.Fill(this._Kurs_WORKDataSet5.Отчет_посещения1);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_Kurs_WORKDataSet4.Отчет_посещения". При необходимости она может быть перемещена или удалена.
			this.отчет_посещенияTableAdapter1.Fill(this._Kurs_WORKDataSet4.Отчет_посещения);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_Kurs_WORKDataSet3.Отчет_посещения". При необходимости она может быть перемещена или удалена.
			this.отчет_посещенияTableAdapter.Fill(this._Kurs_WORKDataSet3.Отчет_посещения);

		}

		private void Close_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
