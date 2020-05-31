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
	public partial class Администратор_ПД : Form
	{
		public Администратор_ПД()
		{
			InitializeComponent();
			this.Text = "Работа с данными. Администратора";
		}

		private void b_back_upravl_Click(object sender, EventArgs e)
		{
			Доступ_к_системе FDKS = new Доступ_к_системе();
			FDKS.Show();
			this.Hide();
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

		private void buttonSotrudniki_Click(object sender, EventArgs e)
		{
			Отчет_сотрудники_должности f = new Отчет_сотрудники_должности();
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

		private void buttonTabel_Click(object sender, EventArgs e)
		{
			Отчет_табель f = new Отчет_табель();
			f.Show();
		}

		private void buttonSpecialisation_Click(object sender, EventArgs e)
		{
			Отчет_сотрудники_специализация f = new Отчет_сотрудники_специализация();
			f.Show();
		}

		private void buttonCHSCart_Click(object sender, EventArgs e)
		{
			Отчет_ЧС_карт f = new Отчет_ЧС_карт();
			f.Show();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void buttonTableOformlAbonement_Click(object sender, EventArgs e)
		{
			Таблица_оформленные_абонементы f = new Таблица_оформленные_абонементы();
			f.Show();
		}

		private void buttonTablePosesheniaTrenirovok_Click(object sender, EventArgs e)
		{
			Таблица_посещения f = new Таблица_посещения();
			f.Show();
		}

		private void buttonTableTrenirovki_Click(object sender, EventArgs e)
		{
			Таблица_тренировки f = new Таблица_тренировки();
			f.Show();
		}

		private void buttonTableSotrudniki_Click(object sender, EventArgs e)
		{
			Таблица_сотрудники f = new Таблица_сотрудники();
			f.Show();
		}

		private void buttonTableSPTrenerov_Click(object sender, EventArgs e)
		{
			Таблица_специализация f = new Таблица_специализация();
			f.Show();
		}

		private void buttonTableTabelTrenerov_Click(object sender, EventArgs e)
		{
			Таблица_табель f = new Таблица_табель();
			f.Show();
		}
	}
}
