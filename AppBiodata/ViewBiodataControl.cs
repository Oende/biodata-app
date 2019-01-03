using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using AppBiodataDbConnect;

namespace AppBiodata
{
	public partial class ViewBiodataControl : UserControl
	{
		DBConnect db = new DBConnect();
		public ViewBiodataControl()
		{
			InitializeComponent();
			viewData();
		}

		public void viewData() {
			String[,] data;
			data = db.Select();
			int n = 0;
			dataGridView1.Rows.Clear();
			// Displaying data
			for(int i = 0; i < data.GetLength(0); i++)
			{
				n = dataGridView1.Rows.Add();
				dataGridView1.Rows[i].Cells[0].Value = i + 1;
				dataGridView1.Rows[i].Cells[1].Value = data[i, 1];
				dataGridView1.Rows[i].Cells[2].Value = data[i, 2];
				dataGridView1.Rows[i].Cells[3].Value = data[i, 3];
				dataGridView1.Rows[i].Cells[4].Value = data[i, 4];
				dataGridView1.Rows[i].Cells[5].Value = data[i, 5];
			}
		}
	}
}
