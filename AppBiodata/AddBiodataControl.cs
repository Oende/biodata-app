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
	public partial class AddBiodataControl : UserControl
	{
		DBConnect db = new DBConnect();
		public AddBiodataControl()
		{
			InitializeComponent();
			tbPhone.MaxLength = 14;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			String[] data = new String[5];
			String[] props = new String[5];

			

			props[0] = tbName.Text;
			var gender = panel1.Controls.OfType<RadioButton>()
						.FirstOrDefault(r => r.Checked);
			props[1] = gender.Text;
			props[2] = datepickerDob.Text;
			props[3] = "+62"+tbPhone.Text;
			props[4] = tbAddress.Text;

			for(int i = 0; i < data.Length; i++)
			{
				data[i] = props[i];
			}

			if(db.Create(data)) {
				MessageBox.Show("New Biodata has been successfully saved.", "Data Saved", 
					MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				resetColumn();
			} else {
				MessageBox.Show("Biodata failed Saved", "Data Saved Failed", 
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
		{
			/* if(!char.IsNumber(e.KeyChar)) {
				e.Handled = e.KeyChar != (char)Keys.Back;
			} */
			if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
			(e.KeyChar != '.'))
			{
				e.Handled = true;
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("Are sure want to cancel and reset the data?", "Biodata Application",
					MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
			{
				resetColumn();
			}
		}

		void resetColumn()
		{
			tbAddress.Text = "";
			tbName.Text = "";
			tbPhone.Text = "";
			datepickerDob.Value = DateTime.Now;
			rbFemale.Checked = false;
			rbMale.Checked = false;
		}
	}
}
