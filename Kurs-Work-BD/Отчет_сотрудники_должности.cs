﻿using System;
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
	public partial class Отчет_сотрудники_должности : Form
	{
		public Отчет_сотрудники_должности()
		{
			InitializeComponent();
			this.Text = "Отчет с информацией о сотрудниках фитнес-центра";

		}

		private void Отчет_сотрудники_должности_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_Kurs_WORKDataSet3.Отчет_сотрудники_должности". При необходимости она может быть перемещена или удалена.
			this.отчет_сотрудники_должностиTableAdapter.Fill(this._Kurs_WORKDataSet3.Отчет_сотрудники_должности);

		}

		private void Close_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
