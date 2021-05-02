namespace gaming
{
	// Token: 0x0200000E RID: 14
	public partial class Form3 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000013 RID: 19 RVA: 0x00002081 File Offset: 0x00000281
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00003548 File Offset: 0x00001748
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::gaming.Form3));
			this.button2 = new global::System.Windows.Forms.Button();
			this.label4 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.button2.BackColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
			this.button2.Font = new global::System.Drawing.Font("Arial", 15f);
			this.button2.Location = new global::System.Drawing.Point(76, 209);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(182, 103);
			this.button2.TabIndex = 16;
			this.button2.Text = "LAUNCH SCRIPT";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f);
			this.label4.ForeColor = global::System.Drawing.SystemColors.Control;
			this.label4.Location = new global::System.Drawing.Point(12, 52);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(329, 17);
			this.label4.TabIndex = 18;
			this.label4.Text = "PRESS \"LAUNCH SCRIPT\" TO OPEN THE SCRIPT";
			this.label4.Click += new global::System.EventHandler(this.label4_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
			base.ClientSize = new global::System.Drawing.Size(340, 517);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.button2);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Form3";
			this.Text = "RUST_RECOIL";
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
			base.Load += new global::System.EventHandler(this.Form3_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000018 RID: 24
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.Button button2;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.Label label4;
	}
}
