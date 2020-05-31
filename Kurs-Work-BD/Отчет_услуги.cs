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
	public partial class Отчет_услуги : Form
	{
		public Отчет_услуги()
		{
			InitializeComponent();
			this.Text = "Отчет с информацией об услугах";

		}

		private void Отчет_услуги_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_Kurs_WORKDataSet3.Отчет_услуги". При необходимости она может быть перемещена или удалена.
			this.отчет_услугиTableAdapter.Fill(this._Kurs_WORKDataSet3.Отчет_услуги);

		}

		private void Close_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
