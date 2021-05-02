namespace gaming
{
	// Token: 0x0200000F RID: 15
	public partial class Form1 : global::MetroFramework.Forms.MetroForm
	{
		// Token: 0x06000020 RID: 32 RVA: 0x000020ED File Offset: 0x000002ED
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000037EC File Offset: 0x000019EC
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::gaming.Form1));
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.metroButton1 = new global::MetroFramework.Controls.MetroButton();
			this.metroButton2 = new global::MetroFramework.Controls.MetroButton();
			this.username = new global::MetroFramework.Controls.MetroTextBox();
			this.password = new global::MetroFramework.Controls.MetroTextBox();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f);
			this.label1.ForeColor = global::System.Drawing.SystemColors.Control;
			this.label1.Location = new global::System.Drawing.Point(20, 93);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(85, 17);
			this.label1.TabIndex = 5;
			this.label1.Text = "USERNAME";
			this.label1.Click += new global::System.EventHandler(this.label1_Click);
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f);
			this.label2.ForeColor = global::System.Drawing.SystemColors.Control;
			this.label2.Location = new global::System.Drawing.Point(20, 166);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(88, 17);
			this.label2.TabIndex = 6;
			this.label2.Text = "PASSWORD";
			this.label2.Click += new global::System.EventHandler(this.label2_Click);
			this.metroButton1.FontSize = global::MetroFramework.MetroButtonSize.Tall;
			this.metroButton1.Location = new global::System.Drawing.Point(103, 358);
			this.metroButton1.Name = "metroButton1";
			this.metroButton1.Size = new global::System.Drawing.Size(140, 80);
			this.metroButton1.TabIndex = 7;
			this.metroButton1.Text = "REGISTER";
			this.metroButton1.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.metroButton1.UseSelectable = true;
			this.metroButton1.Click += new global::System.EventHandler(this.metroButton1_Click);
			this.metroButton2.FontSize = global::MetroFramework.MetroButtonSize.Tall;
			this.metroButton2.Location = new global::System.Drawing.Point(103, 250);
			this.metroButton2.Name = "metroButton2";
			this.metroButton2.Size = new global::System.Drawing.Size(140, 80);
			this.metroButton2.TabIndex = 8;
			this.metroButton2.Text = "LOGIN";
			this.metroButton2.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.metroButton2.UseSelectable = true;
			this.metroButton2.Click += new global::System.EventHandler(this.metroButton2_Click);
			this.username.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.username.CustomButton.Image = null;
			this.username.CustomButton.Location = new global::System.Drawing.Point(282, 2);
			this.username.CustomButton.Name = "";
			this.username.CustomButton.Size = new global::System.Drawing.Size(11, 11);
			this.username.CustomButton.Style = global::MetroFramework.MetroColorStyle.Blue;
			this.username.CustomButton.TabIndex = 1;
			this.username.CustomButton.Theme = global::MetroFramework.MetroThemeStyle.Light;
			this.username.CustomButton.UseSelectable = true;
			this.username.CustomButton.Visible = false;
			this.username.Lines = new string[0];
			this.username.Location = new global::System.Drawing.Point(23, 113);
			this.username.MaxLength = 32767;
			this.username.Name = "username";
			this.username.PasswordChar = '\0';
			this.username.ScrollBars = global::System.Windows.Forms.ScrollBars.None;
			this.username.SelectedText = "";
			this.username.SelectionLength = 0;
			this.username.SelectionStart = 0;
			this.username.ShortcutsEnabled = true;
			this.username.Size = new global::System.Drawing.Size(296, 16);
			this.username.TabIndex = 9;
			this.username.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.username.UseSelectable = true;
			this.username.WaterMarkColor = global::System.Drawing.Color.FromArgb(109, 109, 109);
			this.username.WaterMarkFont = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Pixel);
			this.password.CustomButton.Image = null;
			this.password.CustomButton.Location = new global::System.Drawing.Point(282, 2);
			this.password.CustomButton.Name = "";
			this.password.CustomButton.Size = new global::System.Drawing.Size(11, 11);
			this.password.CustomButton.Style = global::MetroFramework.MetroColorStyle.Blue;
			this.password.CustomButton.TabIndex = 1;
			this.password.CustomButton.Theme = global::MetroFramework.MetroThemeStyle.Light;
			this.password.CustomButton.UseSelectable = true;
			this.password.CustomButton.Visible = false;
			this.password.Lines = new string[0];
			this.password.Location = new global::System.Drawing.Point(23, 186);
			this.password.MaxLength = 32767;
			this.password.Name = "password";
			this.password.PasswordChar = '●';
			this.password.ScrollBars = global::System.Windows.Forms.ScrollBars.None;
			this.password.SelectedText = "";
			this.password.SelectionLength = 0;
			this.password.SelectionStart = 0;
			this.password.ShortcutsEnabled = true;
			this.password.Size = new global::System.Drawing.Size(296, 16);
			this.password.TabIndex = 10;
			this.password.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.password.UseSelectable = true;
			this.password.UseSystemPasswordChar = true;
			this.password.WaterMarkColor = global::System.Drawing.Color.FromArgb(109, 109, 109);
			this.password.WaterMarkFont = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Pixel);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(340, 517);
			base.Controls.Add(this.password);
			base.Controls.Add(this.username);
			base.Controls.Add(this.metroButton2);
			base.Controls.Add(this.metroButton1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Form1";
			base.Resizable = false;
			base.Style = global::MetroFramework.MetroColorStyle.Red;
			this.Text = "Equalizer";
			base.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			base.TransparencyKey = global::System.Drawing.Color.FromArgb(40, 40, 40);
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			base.Load += new global::System.EventHandler(this.Form1_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400001B RID: 27
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400001E RID: 30
		private global::MetroFramework.Controls.MetroButton metroButton1;

		// Token: 0x0400001F RID: 31
		private global::MetroFramework.Controls.MetroButton metroButton2;

		// Token: 0x04000020 RID: 32
		private global::MetroFramework.Controls.MetroTextBox username;

		// Token: 0x04000021 RID: 33
		private global::MetroFramework.Controls.MetroTextBox password;
	}
}
