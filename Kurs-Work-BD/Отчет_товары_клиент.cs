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
	public partial class Отчет_товары_клиент : Form
	{
		public Отчет_товары_клиент()
		{
			InitializeComponent();
			this.Text = "Отчет с информацией о доступных товарах";

		}

		private void Close_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void Отчет_товары_клиент_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_Kurs_WORKDataSet3.Отчет_товары_клиент". При необходимости она может быть перемещена или удалена.
			this.отчет_товары_клиентTableAdapter.Fill(this._Kurs_WORKDataSet3.Отчет_товары_клиент);

		}
	}
}
