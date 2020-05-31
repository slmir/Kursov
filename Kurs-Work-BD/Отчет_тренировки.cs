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
	public partial class Отчет_тренировки : Form
	{
		public Отчет_тренировки()
		{
			InitializeComponent();
			this.Text = "Отчет с информацией о тренировка";

		}

		private void Close_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void Отчет_тренировки_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_Kurs_WORKDataSet10.Отчет_тренировки". При необходимости она может быть перемещена или удалена.
			this.отчет_тренировкиTableAdapter1.Fill(this._Kurs_WORKDataSet10.Отчет_тренировки);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_Kurs_WORKDataSet3.Отчет_тренировки". При необходимости она может быть перемещена или удалена.
			this.отчет_тренировкиTableAdapter.Fill(this._Kurs_WORKDataSet3.Отчет_тренировки);

		}

		private void bindingSource1_CurrentChanged(object sender, EventArgs e)
		{

		}
	}
}
