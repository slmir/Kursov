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
	public partial class Отчет_абонементы : Form
	{
		public Отчет_абонементы()
		{
			InitializeComponent();
			this.Text = "Отчет с ифнормацией об абонементах";
		}

		private void Close_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void Отчет_абонементы_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_Kurs_WORKDataSet3._Отчет_абонемент_клиент_общий". При необходимости она может быть перемещена или удалена.
			this.отчет_абонемент_клиент_общийTableAdapter.Fill(this._Kurs_WORKDataSet3._Отчет_абонемент_клиент_общий);

		}
	}
}
