using System;
using System.Data;
using System.Linq;
using System.Management;
using System.Windows.Forms;

namespace SimpleSoftwareLicensingServiceViewer
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			#region Get Software LicensingService

			ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from SoftwareLicensingService");

			using (ManagementObject obj = searcher.Get().Cast<ManagementObject>().FirstOrDefault())
			{
				if (obj != null)
				{
					foreach (PropertyData prop in obj.Properties)
					{
						if (!string.IsNullOrEmpty(prop.Name))
						{
							string name = prop.Name;
							string value = prop.Value.ToString() ?? "N/A";

							dgvSoftwareLicensingService.Rows.Add(name, value);
						}
					}
				}
				else
				{
					MessageBox.Show("Cannot Find SoftwareLicensingService", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

			GC.Collect();
			Invalidate();

			#endregion Get Software LicensingService
		}

		private void tsmicmsdgvCopyProductKey_Click(object sender, EventArgs e)
		{
			//Search
			foreach (DataGridViewRow row in dgvSoftwareLicensingService.Rows)
			{
				if (row.Cells[0].Value.ToString().Equals("OA3xOriginalProductKey"))
				{
					string productKey = row.Cells[1].Value.ToString();
					Clipboard.SetText(productKey);
					MessageBox.Show($"Product Key [{productKey}] has been copied to the clipboard.");
					GC.Collect();
					return;
				}
			}
			MessageBox.Show("Product Key not found.");
		}
	}
}