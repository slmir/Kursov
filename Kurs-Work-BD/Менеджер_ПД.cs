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
	public partial class Менеджер_ПД : Form
	{
		public Менеджер_ПД()
		{
			InitializeComponent();
			this.Text = "Работа с данными. Менеджер";
		}

		private void Менеджер_ПД_Load(object sender, EventArgs e)
		{

		}

		private void b_Back_Menej_Click(object sender, EventArgs e)
		{
			Доступ_к_системе FM = new Доступ_к_системе();
			FM.Show();
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

		private void buttonAboniments_Click(object sender, EventArgs e)
		{
			Отчет_оформленные_абонементы f = new Отчет_оформленные_абонементы();
			f.Show();
		}

		private void button_Tovars_Click(object sender, EventArgs e)
		{
			Отчет_закупленные_товары f = new Отчет_закупленные_товары();
			f.Show();
		}

		private void buttonSalesTovars_Click(object sender, EventArgs e)
		{
			Отчет_продажа_товаров f = new Отчет_продажа_товаров();
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

		private void buttonTablePosesheniaTrenirovok_Click(object sender, EventArgs e)
		{
			Таблица_клиенты f = new Таблица_клиенты();
			f.Show();
		}

		private void buttonTableOformlAbonement_Click(object sender, EventArgs e)//продажа товаров
		{
			Таблица_продажа_товаров f = new Таблица_продажа_товаров();
			f.Show();
		}

		private void buttonTableTrenirovki_Click(object sender, EventArgs e)//карты в черном списке
		{
			Таблица_карты_в_черном_списке f = new Таблица_карты_в_черном_списке();
			f.Show();
		}

		private void buttonOtchetCHS_Click(object sender, EventArgs e)
		{
			Отчет_ЧС_карт f = new Отчет_ЧС_карт();
			f.Show();
		}
	}
}
