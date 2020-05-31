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
	public partial class Отчет_клиенты : Form
	{
		public Отчет_клиенты()
		{
			InitializeComponent();
			this.Text = "Отчет с информацией о клиентах";
		}

		private void Отчет_клиенты_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_Kurs_WORKDataSet3.Отчет_о_клиенте". При необходимости она может быть перемещена или удалена.
			this.отчет_о_клиентеTableAdapter.Fill(this._Kurs_WORKDataSet3.Отчет_о_клиенте);

		}

		private void Close_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
