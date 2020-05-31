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
	public partial class Директор_ПД : Form
	{
		public Директор_ПД()
		{
			InitializeComponent();
			this.Text = "Работа с данными. Директор";
		}

		private void b_back_Director_Click(object sender, EventArgs e)
		{
			Доступ_к_системе FDKS = new Доступ_к_системе();
			FDKS.Show();
			this.Hide();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			Отчет_сотрудники_специализация f = new Отчет_сотрудники_специализация();
			f.Show();
		}

		private void buttonClient_Click(object sender, EventArgs e)
		{
			Отчет_клиенты f = new Отчет_клиенты();
			f.Show();
		}

		private void buttonTrenirovki_Click(object sender, EventArgs e)
		{
			Отчет_тренировки f = new Отчет_тренировки();
			f.Show();
		}

		private void button_Poseshenia_Click(object sender, EventArgs e)
		{
			Отчет_посещения f = new Отчет_посещения();
			f.Show();
		}

		private void buttonAboniments_Click(object sender, EventArgs e)
		{
			Отчет_оформленные_абонементы f = new Отчет_оформленные_абонементы();
			f.Show();
		}

		private void buttonCHSCart_Click(object sender, EventArgs e)
		{
			Отчет_ЧС_карт f = new Отчет_ЧС_карт();
			f.Show();
		}

		private void buttonPostavshici_Click(object sender, EventArgs e)
		{
			Отчет_поставщики f = new Отчет_поставщики();
			f.Show();
		}

		private void buttonSalesTovars_Click(object sender, EventArgs e)
		{
			Отчет_продажа_товаров f = new Отчет_продажа_товаров();
			f.Show();
		}

		private void button_Tovars_Click(object sender, EventArgs e)
		{
			Отчет_закупленные_товары f = new Отчет_закупленные_товары();
			f.Show();
		}

		private void button_Abonement_Click(object sender, EventArgs e)
		{
			Отчет_абонементы f = new Отчет_абонементы();
			f.Show();
		}

		private void button_Uslugi_Click(object sender, EventArgs e)
		{
			Отчет_услуги f = new Отчет_услуги();
			f.Show();
		}

		private void buttonSotrudniki_Click(object sender, EventArgs e)
		{
			Отчет_сотрудники_должности f = new Отчет_сотрудники_должности();
			f.Show();
		}

		private void buttonTabel_Click(object sender, EventArgs e)
		{
			Отчет_табель f = new Отчет_табель();
			f.Show();
		}

		private void buttonTablePosesheniaTrenirovok_Click(object sender, EventArgs e)
		{
			Таблица_должности f = new Таблица_должности();
			f.Show();
		}
	}
}
