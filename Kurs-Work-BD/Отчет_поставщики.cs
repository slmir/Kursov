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
	public partial class Отчет_поставщики : Form
	{
		public Отчет_поставщики()
		{
			InitializeComponent();
			this.Text = "Отчет с информацией о поставщиках товаров";

		}

		private void Отчет_поставщики_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_Kurs_WORKDataSet3.Отчет_поставщики". При необходимости она может быть перемещена или удалена.
			this.отчет_поставщикиTableAdapter.Fill(this._Kurs_WORKDataSet3.Отчет_поставщики);

		}

		private void Close_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
