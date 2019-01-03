using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Windows.Forms;
using AppBiodataDbConnect;

namespace AppBiodata
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			SidePanel.Height = btnHome.Height;
			homeControl1.BringToFront();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			SidePanel.Top = btnHome.Top;
			homeControl1.BringToFront();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			SidePanel.Top = btnAdd.Top;
			addBiodataControl1.BringToFront();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			SidePanel.Top = btnView.Top;
			viewBiodataControl1.viewData();
			viewBiodataControl1.BringToFront();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			SidePanel.Top = btnAbout.Top;
			aboutControl1.BringToFront();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			SidePanel.Top = btnQuit.Top;
			Close();
		}

		private void btnMinimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void btnMaximize_Click(object sender, EventArgs e)
		{
			if(WindowState.ToString() == "Normal")
			{
				this.WindowState = FormWindowState.Maximized;
			} else
			{
				this.WindowState = FormWindowState.Normal;
			}
		}

		private void btnQuit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if(MessageBox.Show("Are you really want to quit?", "Quitting Application",
				MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
			{
				e.Cancel = true;
			}
		}

		private void btnGithub_Click(object sender, EventArgs e)
		{
			Process.Start("https://git.io/permanar");
		}

		private void btnFacebook_Click(object sender, EventArgs e)
		{
			Process.Start("https://fb.me/richiepermana41");
		}

		private void btnLinkedin_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.linkedin.com/in/permanar");
		}

		private void btnInstagram_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.instagr.am/permanar_");
		}
	}
}
