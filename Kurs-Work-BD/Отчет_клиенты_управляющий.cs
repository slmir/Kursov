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
	public partial class Отчет_клиенты_управляющий : Form
	{
		public Отчет_клиенты_управляющий()
		{
			InitializeComponent();
			this.Text = "Отчет с информацией об основных данных клиентов";
		}

		private void Отчет_клиенты_управляющий_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_Kurs_WORKDataSet3.Отчет_клиенты_управляющий". При необходимости она может быть перемещена или удалена.
			this.отчет_клиенты_управляющийTableAdapter.Fill(this._Kurs_WORKDataSet3.Отчет_клиенты_управляющий);

		}

		private void Close_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
