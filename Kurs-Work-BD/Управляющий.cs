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
	public partial class Управляющий : Form
	{
		public Управляющий()
		{
			InitializeComponent();
		}

		private void b_back_upravl_Click(object sender, EventArgs e)
		{
			Доступ_к_системе FDKS = new Доступ_к_системе();
			FDKS.Show();
			this.Hide();
		}

		private void b_exit_Click(object sender, EventArgs e)
		{
			this.Close();
			Application.Exit();
		}

		private void b_Entire_Upravl_Click(object sender, EventArgs e)
		{
			
		}
	}
}
