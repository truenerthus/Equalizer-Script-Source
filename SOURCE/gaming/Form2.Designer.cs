namespace gaming
{
	// Token: 0x02000010 RID: 16
	public partial class Form2 : global::MetroFramework.Forms.MetroForm
	{
		// Token: 0x0600002C RID: 44 RVA: 0x0000212C File Offset: 0x0000032C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003FAC File Offset: 0x000021AC
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::gaming.Form2));
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.metroButton1 = new global::MetroFramework.Controls.MetroButton();
			this.metroButton2 = new global::MetroFramework.Controls.MetroButton();
			this.username = new global::MetroFramework.Controls.MetroTextBox();
			this.password = new global::MetroFramework.Controls.MetroTextBox();
			this.license = new global::MetroFramework.Controls.MetroTextBox();
			this.email = new global::MetroFramework.Controls.MetroTextBox();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f);
			this.label1.ForeColor = global::System.Drawing.SystemColors.Control;
			this.label1.Location = new global::System.Drawing.Point(20, 233);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(108, 17);
			this.label1.TabIndex = 7;
			this.label1.Text = "LICENSE CODE";
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f);
			this.label2.ForeColor = global::System.Drawing.SystemColors.Control;
			this.label2.Location = new global::System.Drawing.Point(20, 179);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(48, 17);
			this.label2.TabIndex = 9;
			this.label2.Text = "EMAIL";
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f);
			this.label3.ForeColor = global::System.Drawing.SystemColors.Control;
			this.label3.Location = new global::System.Drawing.Point(20, 125);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(88, 17);
			this.label3.TabIndex = 11;
			this.label3.Text = "PASSWORD";
			this.label3.Click += new global::System.EventHandler(this.label3_Click);
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f);
			this.label4.ForeColor = global::System.Drawing.SystemColors.Control;
			this.label4.Location = new global::System.Drawing.Point(20, 71);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(85, 17);
			this.label4.TabIndex = 13;
			this.label4.Text = "USERNAME";
			this.label4.Click += new global::System.EventHandler(this.label4_Click);
			this.metroButton1.FontSize = global::MetroFramework.MetroButtonSize.Tall;
			this.metroButton1.Location = new global::System.Drawing.Point(101, 287);
			this.metroButton1.Name = "metroButton1";
			this.metroButton1.Size = new global::System.Drawing.Size(140, 80);
			this.metroButton1.TabIndex = 16;
			this.metroButton1.Text = "REGISTER";
			this.metroButton1.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.metroButton1.UseSelectable = true;
			this.metroButton1.Click += new global::System.EventHandler(this.metroButton1_Click);
			this.metroButton2.FontSize = global::MetroFramework.MetroButtonSize.Tall;
			this.metroButton2.Location = new global::System.Drawing.Point(101, 383);
			this.metroButton2.Name = "metroButton2";
			this.metroButton2.Size = new global::System.Drawing.Size(140, 80);
			this.metroButton2.TabIndex = 17;
			this.metroButton2.Text = "BACK TO LOGIN";
			this.metroButton2.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.metroButton2.UseSelectable = true;
			this.metroButton2.Click += new global::System.EventHandler(this.metroButton2_Click);
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
			this.username.Location = new global::System.Drawing.Point(23, 91);
			this.username.MaxLength = 32767;
			this.username.Name = "username";
			this.username.PasswordChar = '\0';
			this.username.ScrollBars = global::System.Windows.Forms.ScrollBars.None;
			this.username.SelectedText = "";
			this.username.SelectionLength = 0;
			this.username.SelectionStart = 0;
			this.username.ShortcutsEnabled = true;
			this.username.Size = new global::System.Drawing.Size(296, 16);
			this.username.TabIndex = 18;
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
			this.password.Location = new global::System.Drawing.Point(23, 145);
			this.password.MaxLength = 32767;
			this.password.Name = "password";
			this.password.PasswordChar = '\0';
			this.password.ScrollBars = global::System.Windows.Forms.ScrollBars.None;
			this.password.SelectedText = "";
			this.password.SelectionLength = 0;
			this.password.SelectionStart = 0;
			this.password.ShortcutsEnabled = true;
			this.password.Size = new global::System.Drawing.Size(296, 16);
			this.password.TabIndex = 19;
			this.password.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.password.UseSelectable = true;
			this.password.WaterMarkColor = global::System.Drawing.Color.FromArgb(109, 109, 109);
			this.password.WaterMarkFont = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Pixel);
			this.license.CustomButton.Image = null;
			this.license.CustomButton.Location = new global::System.Drawing.Point(282, 2);
			this.license.CustomButton.Name = "";
			this.license.CustomButton.Size = new global::System.Drawing.Size(11, 11);
			this.license.CustomButton.Style = global::MetroFramework.MetroColorStyle.Blue;
			this.license.CustomButton.TabIndex = 1;
			this.license.CustomButton.Theme = global::MetroFramework.MetroThemeStyle.Light;
			this.license.CustomButton.UseSelectable = true;
			this.license.CustomButton.Visible = false;
			this.license.Lines = new string[0];
			this.license.Location = new global::System.Drawing.Point(23, 253);
			this.license.MaxLength = 32767;
			this.license.Name = "license";
			this.license.PasswordChar = '\0';
			this.license.ScrollBars = global::System.Windows.Forms.ScrollBars.None;
			this.license.SelectedText = "";
			this.license.SelectionLength = 0;
			this.license.SelectionStart = 0;
			this.license.ShortcutsEnabled = true;
			this.license.Size = new global::System.Drawing.Size(296, 16);
			this.license.TabIndex = 20;
			this.license.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.license.UseSelectable = true;
			this.license.WaterMarkColor = global::System.Drawing.Color.FromArgb(109, 109, 109);
			this.license.WaterMarkFont = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Pixel);
			this.email.CustomButton.Image = null;
			this.email.CustomButton.Location = new global::System.Drawing.Point(282, 2);
			this.email.CustomButton.Name = "";
			this.email.CustomButton.Size = new global::System.Drawing.Size(11, 11);
			this.email.CustomButton.Style = global::MetroFramework.MetroColorStyle.Blue;
			this.email.CustomButton.TabIndex = 1;
			this.email.CustomButton.Theme = global::MetroFramework.MetroThemeStyle.Light;
			this.email.CustomButton.UseSelectable = true;
			this.email.CustomButton.Visible = false;
			this.email.Lines = new string[0];
			this.email.Location = new global::System.Drawing.Point(23, 199);
			this.email.MaxLength = 32767;
			this.email.Name = "email";
			this.email.PasswordChar = '\0';
			this.email.ScrollBars = global::System.Windows.Forms.ScrollBars.None;
			this.email.SelectedText = "";
			this.email.SelectionLength = 0;
			this.email.SelectionStart = 0;
			this.email.ShortcutsEnabled = true;
			this.email.Size = new global::System.Drawing.Size(296, 16);
			this.email.TabIndex = 21;
			this.email.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.email.UseSelectable = true;
			this.email.WaterMarkColor = global::System.Drawing.Color.FromArgb(109, 109, 109);
			this.email.WaterMarkFont = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Pixel);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(340, 517);
			base.Controls.Add(this.email);
			base.Controls.Add(this.license);
			base.Controls.Add(this.password);
			base.Controls.Add(this.username);
			base.Controls.Add(this.metroButton2);
			base.Controls.Add(this.metroButton1);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Form2";
			base.Resizable = false;
			base.Style = global::MetroFramework.MetroColorStyle.Red;
			this.Text = "Equalizer";
			base.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
			base.Load += new global::System.EventHandler(this.Form2_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000022 RID: 34
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000027 RID: 39
		private global::MetroFramework.Controls.MetroButton metroButton1;

		// Token: 0x04000028 RID: 40
		private global::MetroFramework.Controls.MetroButton metroButton2;

		// Token: 0x04000029 RID: 41
		private global::MetroFramework.Controls.MetroTextBox username;

		// Token: 0x0400002A RID: 42
		private global::MetroFramework.Controls.MetroTextBox password;

		// Token: 0x0400002B RID: 43
		private global::MetroFramework.Controls.MetroTextBox license;

		// Token: 0x0400002C RID: 44
		private global::MetroFramework.Controls.MetroTextBox email;
	}
}
