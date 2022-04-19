using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompleteQuote
{
	public partial class MainForm : Form
	{
		string availableMaterial;
		public MainForm()
		{
			InitializeComponent();
		}

		private void chkNewSpool_CheckedChanged(object sender, EventArgs e)
		{
			cboSpoolSize.Enabled = chkNewSpool.Checked;
			txtAvailMaterial.Text = "Select a Spool Size";
		}

		private void cboSpoolSize_SelectedIndexChanged(object sender, EventArgs e)
		{
			txtAvailMaterial.Text = cboSpoolSize.Text;
			availableMaterial = txtAvailMaterial.Text;
		}

		private void txtMaterialUsed_TextChanged(object sender, EventArgs e)
		{
			if (txtMaterialUsed.Text != "" && txtAvailMaterial.Text != "")
				txtAvailMaterial.Text = (Convert.ToDouble(txtAvailMaterial.Text) - Convert.ToDouble(txtMaterialUsed.Text)).ToString();

			if (txtMaterialUsed.Text == "" && txtAvailMaterial.Text != "")
				txtAvailMaterial.Text = availableMaterial;
		}
	}
}
