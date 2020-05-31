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
	public partial class Отчет_табель : Form
	{
		public Отчет_табель()
		{
			InitializeComponent();
			this.Text = "Отчет с информацией о рабочем табеле сотрудников";

		}

		private void Отчет_табель_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_Kurs_WORKDataSet15.Отчет_табель". При необходимости она может быть перемещена или удалена.
			this.отчет_табельTableAdapter1.Fill(this._Kurs_WORKDataSet15.Отчет_табель);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_Kurs_WORKDataSet3.Отчет_табель". При необходимости она может быть перемещена или удалена.
			//this.отчет_табельTableAdapter.Fill(this._Kurs_WORKDataSet3.Отчет_табель);

		}

		private void Close_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
