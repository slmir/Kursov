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
	public partial class Информация_о_фитнес_центре : Form
	{
		public Информация_о_фитнес_центре()
		{
			InitializeComponent();
			this.Text = "Информация о фитнес-центре";
		}

		private void button_Uslugi_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Images f = new Images();
			f.Show();
		}

		private void button_Uslugi_Click_1(object sender, EventArgs e)
		{
			Отчет_услуги f = new Отчет_услуги();
			f.Show();
		}

		private void button_Abonement_Click(object sender, EventArgs e)
		{
			Отчет_абонементы f = new Отчет_абонементы();
			f.Show();
		}

		private void button_Tovars_Click(object sender, EventArgs e)
		{
			Отчет_товары_клиент f = new Отчет_товары_клиент();
			f.Show();
		}

		private void button_Trener_Click(object sender, EventArgs e)
		{
			Отчет_сотрудники_клиент f1 = new Отчет_сотрудники_клиент();
			f1.Show();
		}

		private void b_back_Client_Click(object sender, EventArgs e)
		{
			Начальная_форма f = new Начальная_форма();
			f.Show();
			this.Hide();
		}
	}
}
