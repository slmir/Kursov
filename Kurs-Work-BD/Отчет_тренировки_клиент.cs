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
	public partial class Отчет_тренировки_клиент : Form
	{
		public Отчет_тренировки_клиент()
		{
			InitializeComponent();
			this.Text = "Отчет с информацией о тренировках";

		}

		private void Отчет_тренировки_клиент_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_Kurs_WORKDataSet3.Отчет_тренировки_клиент". При необходимости она может быть перемещена или удалена.
			this.отчет_тренировки_клиентTableAdapter.Fill(this._Kurs_WORKDataSet3.Отчет_тренировки_клиент);

		}

		private void Close_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
