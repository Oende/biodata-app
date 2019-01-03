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

namespace AppBiodata
{
	public partial class AboutControl : UserControl
	{
		public AboutControl()
		{
			InitializeComponent();
		}

		private void btnWhatsapp_Click(object sender, EventArgs e)
		{
			Process.Start("https://wa.me/6289606403383");
		}

		private void btnTwitter_Click(object sender, EventArgs e)
		{
			Process.Start("https://twitter.com/permanar_");
		}
	}
}
