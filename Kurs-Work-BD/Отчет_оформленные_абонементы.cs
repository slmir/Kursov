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
	public partial class Отчет_оформленные_абонементы : Form
	{
		public Отчет_оформленные_абонементы()
		{
			InitializeComponent();
			this.Text = "Отчет с информацией об оформленных абонементах";
		}

		private void Close_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void Отчет_оформленные_абонементы_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_Kurs_WORKDataSet3.Отчет_оформление_абонементов". При необходимости она может быть перемещена или удалена.
			this.отчет_оформление_абонементовTableAdapter.Fill(this._Kurs_WORKDataSet3.Отчет_оформление_абонементов);

		}
	}
}
