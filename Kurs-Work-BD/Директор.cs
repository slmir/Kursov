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
	public partial class Директор : Form
	{
		public Директор()
		{
			InitializeComponent();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void b_back_Director_Click(object sender, EventArgs e)
		{
			Доступ_к_системе FDKS = new Доступ_к_системе();
			FDKS.Show();
			this.Hide();
		}
	}
}
