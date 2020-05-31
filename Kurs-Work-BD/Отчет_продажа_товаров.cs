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
	public partial class Отчет_продажа_товаров : Form
	{
		public Отчет_продажа_товаров()
		{
			InitializeComponent();
			this.Text = "Отчет с информацией о продажах товаров";

		}

		private void Отчет_продажа_товаров_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_Kurs_WORKDataSet15.Отчет_продажа_товаров". При необходимости она может быть перемещена или удалена.
			this.отчет_продажа_товаровTableAdapter4.Fill(this._Kurs_WORKDataSet15.Отчет_продажа_товаров);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_Kurs_WORKDataSet15.Отчет_табель". При необходимости она может быть перемещена или удалена.
			///this.отчет_табельTableAdapter.Fill(this._Kurs_WORKDataSet15.Отчет_табель);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_Kurs_WORKDataSet15.Отчет_посещения1". При необходимости она может быть перемещена или удалена.
			//this.отчет_посещения1TableAdapter.Fill(this._Kurs_WORKDataSet15.Отчет_посещения1);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_Kurs_WORKDataSet14.Отчет_продажа_товаров". При необходимости она может быть перемещена или удалена.
			//this.отчет_продажа_товаровTableAdapter3.Fill(this._Kurs_WORKDataSet14.Отчет_продажа_товаров);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_Kurs_WORKDataSet13.Отчет_продажа_товаров". При необходимости она может быть перемещена или удалена.
			//this.отчет_продажа_товаровTableAdapter2.Fill(this._Kurs_WORKDataSet13.Отчет_продажа_товаров);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_Kurs_WORKDataSet12.Отчет_продажа_товаров". При необходимости она может быть перемещена или удалена.
			//this.отчет_продажа_товаровTableAdapter1.Fill(this._Kurs_WORKDataSet12.Отчет_продажа_товаров);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_Kurs_WORKDataSet3.Отчет_продажа_товаров". При необходимости она может быть перемещена или удалена.
			//this.отчет_продажа_товаровTableAdapter.Fill(this._Kurs_WORKDataSet3.Отчет_продажа_товаров);

		}

		private void Close_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
