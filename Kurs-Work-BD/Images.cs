using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs_Work_BD
{
	public partial class Images : Form
	{
		int kol = 1;
		ArrayList ar = new ArrayList();
		public Images()
		{
			InitializeComponent();
			this.Text = "Окно просмотра изображений";
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			ar.AddRange(Directory.GetFiles(@"C:\Users\Вячеслав\Desktop\Курсовая\Картинки инфо", "*.jpg"));//поместить в событие загрузки формы или конструктор
			pictureBox1.Image = Image.FromFile(ar[kol].ToString());
			if (kol == 8)
			{
				kol = 1;
			}
			kol++;

		}

		private void buttonClose_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void Images_Load(object sender, EventArgs e)
		{
			MessageBox.Show("Для просмотра картинок, кликните по изображению.", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
