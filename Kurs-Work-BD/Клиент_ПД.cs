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
	public partial class Клиент_ПД : Form
	{
		public Клиент_ПД()
		{
			InitializeComponent();
			this.Text = "Просмотр данных для клиента";
		}

		private void b_back_Client_Click(object sender, EventArgs e)
		{
			Доступ_к_системе FDKS = new Доступ_к_системе();
			FDKS.Show();
			this.Hide();
		}

		private void button_Tovars_Click(object sender, EventArgs e)
		{
			Отчет_товары_клиент f = new Отчет_товары_клиент();
			f.Show();
		}

		private void button_Trenirovki_Click(object sender, EventArgs e)
		{
			Отчет_тренировки_клиент f1 = new Отчет_тренировки_клиент();
			f1.Show();
		}

		private void button_Abonement_Click(object sender, EventArgs e)
		{
			Отчет_абонементы f2 = new Отчет_абонементы();
			f2.Show();
		}

		private void button_Uslugi_Click(object sender, EventArgs e)
		{
			Отчет_услуги f3 = new Отчет_услуги();
			f3.Show();
		}

		private void button_Trener_Click(object sender, EventArgs e)
		{
			Отчет_сотрудники_клиент f3 = new Отчет_сотрудники_клиент();
			f3.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form1 f = new Form1();
			f.Show();
		}
	}
}
