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
	public partial class Отчет_закупленные_товары : Form
	{
		public Отчет_закупленные_товары()
		{
			InitializeComponent();
			this.Text = "Отчет с информацией о товарах";
		}

		private void Close_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void Отчет_закупленные_товары_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_Kurs_WORKDataSet3.Отчет_закупленные_товары". При необходимости она может быть перемещена или удалена.
			this.отчет_закупленные_товарыTableAdapter.Fill(this._Kurs_WORKDataSet3.Отчет_закупленные_товары);

		}
	}
}
