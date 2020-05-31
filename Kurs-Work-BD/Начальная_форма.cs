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
	public partial class Начальная_форма : Form
	{
		public Начальная_форма()
		{
			InitializeComponent();
			this.Text = "АИС фитнес-центра 'Арисфит'";
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void Начальная_форма_Load(object sender, EventArgs e)
		{

		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Доступ_к_системе f = new Доступ_к_системе();
			f.Show();
			this.Hide();
		}

		private void buttonInfo_Click(object sender, EventArgs e)
		{
			Информация_о_фитнес_центре f = new Информация_о_фитнес_центре();
			f.Show();
			this.Hide();
		}

		private void b_Exit2_Click(object sender, EventArgs e)
		{
			this.Close();
			Application.Exit();
		}

		private void buttonAutorization_Click(object sender, EventArgs e)
		{
			Доступ_к_системе f = new Доступ_к_системе();
			f.Show();
			this.Hide();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Информация_о_фитнес_центре f = new Информация_о_фитнес_центре();
			f.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Новый_клиент f = new Новый_клиент();
			f.Show();
			this.Hide();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Информация_о_фитнес_центре f = new Информация_о_фитнес_центре();
			f.Show();
			this.Hide();
		}
	}
}
