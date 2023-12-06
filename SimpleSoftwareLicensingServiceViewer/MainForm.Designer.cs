namespace SimpleSoftwareLicensingServiceViewer
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.dgvSoftwareLicensingService = new System.Windows.Forms.DataGridView();
			this.dgvhName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvhValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cmsdgvSoftwareLicensingService = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmicmsdgvCopyProductKey = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dgvSoftwareLicensingService)).BeginInit();
			this.cmsdgvSoftwareLicensingService.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvSoftwareLicensingService
			// 
			this.dgvSoftwareLicensingService.AllowUserToAddRows = false;
			this.dgvSoftwareLicensingService.AllowUserToDeleteRows = false;
			this.dgvSoftwareLicensingService.AllowUserToOrderColumns = true;
			this.dgvSoftwareLicensingService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvSoftwareLicensingService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSoftwareLicensingService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvhName,
            this.dgvhValue});
			this.dgvSoftwareLicensingService.ContextMenuStrip = this.cmsdgvSoftwareLicensingService;
			this.dgvSoftwareLicensingService.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvSoftwareLicensingService.Location = new System.Drawing.Point(0, 0);
			this.dgvSoftwareLicensingService.Name = "dgvSoftwareLicensingService";
			this.dgvSoftwareLicensingService.ReadOnly = true;
			this.dgvSoftwareLicensingService.RowTemplate.Height = 23;
			this.dgvSoftwareLicensingService.Size = new System.Drawing.Size(734, 411);
			this.dgvSoftwareLicensingService.TabIndex = 0;
			// 
			// dgvhName
			// 
			this.dgvhName.HeaderText = "Name";
			this.dgvhName.Name = "dgvhName";
			this.dgvhName.ReadOnly = true;
			this.dgvhName.Width = 64;
			// 
			// dgvhValue
			// 
			this.dgvhValue.HeaderText = "Value";
			this.dgvhValue.Name = "dgvhValue";
			this.dgvhValue.ReadOnly = true;
			this.dgvhValue.Width = 62;
			// 
			// cmsdgvSoftwareLicensingService
			// 
			this.cmsdgvSoftwareLicensingService.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmicmsdgvCopyProductKey});
			this.cmsdgvSoftwareLicensingService.Name = "cmsdgvSoftwareLicensingService";
			this.cmsdgvSoftwareLicensingService.Size = new System.Drawing.Size(172, 26);
			// 
			// tsmicmsdgvCopyProductKey
			// 
			this.tsmicmsdgvCopyProductKey.Name = "tsmicmsdgvCopyProductKey";
			this.tsmicmsdgvCopyProductKey.Size = new System.Drawing.Size(180, 22);
			this.tsmicmsdgvCopyProductKey.Text = "Copy Product Key";
			this.tsmicmsdgvCopyProductKey.Click += new System.EventHandler(this.tsmicmsdgvCopyProductKey_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(734, 411);
			this.Controls.Add(this.dgvSoftwareLicensingService);
			this.Name = "MainForm";
			this.Text = "SimpleSoftwareLicensingServiceViewer";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvSoftwareLicensingService)).EndInit();
			this.cmsdgvSoftwareLicensingService.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvSoftwareLicensingService;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgvhName;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgvhValue;
		private System.Windows.Forms.ContextMenuStrip cmsdgvSoftwareLicensingService;
		private System.Windows.Forms.ToolStripMenuItem tsmicmsdgvCopyProductKey;
	}
}

