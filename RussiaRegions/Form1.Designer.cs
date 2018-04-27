namespace RussiaRegions
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
			this.lblFedDistrict = new System.Windows.Forms.Label();
			this.cbFedDistrict = new System.Windows.Forms.ComboBox();
			this.lblCapital = new System.Windows.Forms.Label();
			this.tbCapital = new System.Windows.Forms.TextBox();
			this.tbRegionalCenter = new System.Windows.Forms.TextBox();
			this.lblRegionalCenter = new System.Windows.Forms.Label();
			this.cbRegion = new System.Windows.Forms.ComboBox();
			this.lblRegion = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblFedDistrict
			// 
			this.lblFedDistrict.AutoSize = true;
			this.lblFedDistrict.Location = new System.Drawing.Point(13, 34);
			this.lblFedDistrict.Name = "lblFedDistrict";
			this.lblFedDistrict.Size = new System.Drawing.Size(114, 13);
			this.lblFedDistrict.TabIndex = 0;
			this.lblFedDistrict.Text = "Федеральный округ:";
			// 
			// cbFedDistrict
			// 
			this.cbFedDistrict.FormattingEnabled = true;
			this.cbFedDistrict.Location = new System.Drawing.Point(133, 31);
			this.cbFedDistrict.Name = "cbFedDistrict";
			this.cbFedDistrict.Size = new System.Drawing.Size(187, 21);
			this.cbFedDistrict.TabIndex = 1;
			this.cbFedDistrict.TextChanged += new System.EventHandler(this.cbFedDistrict_TextChanged);
			// 
			// lblCapital
			// 
			this.lblCapital.AutoSize = true;
			this.lblCapital.Location = new System.Drawing.Point(338, 34);
			this.lblCapital.Name = "lblCapital";
			this.lblCapital.Size = new System.Drawing.Size(52, 13);
			this.lblCapital.TabIndex = 2;
			this.lblCapital.Text = "Столица:";
			// 
			// tbCapital
			// 
			this.tbCapital.Location = new System.Drawing.Point(396, 31);
			this.tbCapital.Name = "tbCapital";
			this.tbCapital.ReadOnly = true;
			this.tbCapital.Size = new System.Drawing.Size(176, 20);
			this.tbCapital.TabIndex = 3;
			// 
			// tbRegionalCenter
			// 
			this.tbRegionalCenter.Location = new System.Drawing.Point(396, 80);
			this.tbRegionalCenter.Name = "tbRegionalCenter";
			this.tbRegionalCenter.ReadOnly = true;
			this.tbRegionalCenter.Size = new System.Drawing.Size(176, 20);
			this.tbRegionalCenter.TabIndex = 7;
			// 
			// lblRegionalCenter
			// 
			this.lblRegionalCenter.AutoSize = true;
			this.lblRegionalCenter.Location = new System.Drawing.Point(338, 83);
			this.lblRegionalCenter.Name = "lblRegionalCenter";
			this.lblRegionalCenter.Size = new System.Drawing.Size(41, 13);
			this.lblRegionalCenter.TabIndex = 6;
			this.lblRegionalCenter.Text = "Центр:";
			// 
			// cbRegion
			// 
			this.cbRegion.FormattingEnabled = true;
			this.cbRegion.Location = new System.Drawing.Point(92, 80);
			this.cbRegion.Name = "cbRegion";
			this.cbRegion.Size = new System.Drawing.Size(228, 21);
			this.cbRegion.TabIndex = 5;
			this.cbRegion.TextChanged += new System.EventHandler(this.cbRegion_TextChanged);
			// 
			// lblRegion
			// 
			this.lblRegion.AutoSize = true;
			this.lblRegion.Location = new System.Drawing.Point(13, 83);
			this.lblRegion.Name = "lblRegion";
			this.lblRegion.Size = new System.Drawing.Size(73, 13);
			this.lblRegion.TabIndex = 4;
			this.lblRegion.Text = "Субъект РФ:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 141);
			this.Controls.Add(this.tbRegionalCenter);
			this.Controls.Add(this.lblRegionalCenter);
			this.Controls.Add(this.cbRegion);
			this.Controls.Add(this.lblRegion);
			this.Controls.Add(this.tbCapital);
			this.Controls.Add(this.lblCapital);
			this.Controls.Add(this.cbFedDistrict);
			this.Controls.Add(this.lblFedDistrict);
			this.Name = "MainForm";
			this.Text = "Субъекты и регионы РФ";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblFedDistrict;
		private System.Windows.Forms.ComboBox cbFedDistrict;
		private System.Windows.Forms.Label lblCapital;
		private System.Windows.Forms.TextBox tbCapital;
		private System.Windows.Forms.TextBox tbRegionalCenter;
		private System.Windows.Forms.Label lblRegionalCenter;
		private System.Windows.Forms.ComboBox cbRegion;
		private System.Windows.Forms.Label lblRegion;
	}
}

