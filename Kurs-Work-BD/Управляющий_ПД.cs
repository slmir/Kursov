using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs_Work_BD
{
	public partial class Управляющий_ПД : Form
	{
		public Управляющий_ПД()
		{
			InitializeComponent();
			this.Text = "Работа с данными. Управляющий";
		}

		private void Управляющий_ПД_Load(object sender, EventArgs e)
		{

		}

		private void b_back_upravl_Click_1(object sender, EventArgs e)
		{
			Доступ_к_системе FDKS = new Доступ_к_системе();
			FDKS.Show();
			this.Hide();
		}

		private void buttonClient_Click(object sender, EventArgs e)
		{
			Отчет_клиенты_управляющий f = new Отчет_клиенты_управляющий();
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

		private void buttonTabel_Click(object sender, EventArgs e)
		{
			Отчет_табель f = new Отчет_табель();
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

		private void buttonSpecialisation_Click(object sender, EventArgs e)
		{
			Отчет_сотрудники_специализация f = new Отчет_сотрудники_специализация();
			f.Show();
		}

		private void buttonTableAbonem_Click(object sender, EventArgs e)
		{
			Таблица_абонементы f = new Таблица_абонементы();
			f.Show();
		}

		private void buttonTableUslugi_Click(object sender, EventArgs e)
		{
			Таблица_услуги f = new Таблица_услуги();
			f.Show();
		}

		private void buttonTablePostavshiki_Click(object sender, EventArgs e)
		{
			Таблица_поставщики f = new Таблица_поставщики();
			f.Show();
		}

		private void buttonTableTovari_Click(object sender, EventArgs e)
		{
			Таблица_товары f = new Таблица_товары();
			f.Show();
		}
	}
}
