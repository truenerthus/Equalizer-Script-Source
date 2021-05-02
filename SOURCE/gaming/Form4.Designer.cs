namespace gaming
{
	// Token: 0x02000011 RID: 17
	public partial class Form4 : global::MetroFramework.Forms.MetroForm
	{
		// Token: 0x06000049 RID: 73 RVA: 0x000021D9 File Offset: 0x000003D9
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00004FA4 File Offset: 0x000031A4
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::gaming.Form4));
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.textBox3 = new global::System.Windows.Forms.TextBox();
			this.listBox2 = new global::System.Windows.Forms.ListBox();
			this.listBox3 = new global::System.Windows.Forms.ListBox();
			this.metroButton1 = new global::MetroFramework.Controls.MetroButton();
			this.Apply = new global::MetroFramework.Controls.MetroButton();
			this.metroCheckBox1 = new global::MetroFramework.Controls.MetroCheckBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.numpad = new global::System.Windows.Forms.ListBox();
			this.fkeys = new global::System.Windows.Forms.ListBox();
			this.listBox1 = new global::System.Windows.Forms.ListBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.metroTrackBar1 = new global::MetroFramework.Controls.MetroTrackBar();
			this.label7 = new global::System.Windows.Forms.Label();
			this.metroButton2 = new global::MetroFramework.Controls.MetroButton();
			base.SuspendLayout();
			this.textBox1.BackColor = global::System.Drawing.Color.DimGray;
			this.textBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.ForeColor = global::System.Drawing.SystemColors.Menu;
			this.textBox1.Location = new global::System.Drawing.Point(23, 71);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextChanged += new global::System.EventHandler(this.textBox1_TextChanged);
			this.textBox2.BackColor = global::System.Drawing.Color.DimGray;
			this.textBox2.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.ForeColor = global::System.Drawing.SystemColors.Menu;
			this.textBox2.Location = new global::System.Drawing.Point(23, 115);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new global::System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 1;
			this.textBox2.TextChanged += new global::System.EventHandler(this.textBox2_TextChanged);
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f);
			this.label4.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.label4.Location = new global::System.Drawing.Point(33, 224);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(69, 17);
			this.label4.TabIndex = 7;
			this.label4.Text = "WEAPON";
			this.textBox3.BackColor = global::System.Drawing.Color.DimGray;
			this.textBox3.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox3.ForeColor = global::System.Drawing.SystemColors.Menu;
			this.textBox3.Location = new global::System.Drawing.Point(23, 157);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new global::System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 11;
			this.textBox3.TextChanged += new global::System.EventHandler(this.textBox3_TextChanged);
			this.listBox2.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.listBox2.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.listBox2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f);
			this.listBox2.ForeColor = global::System.Drawing.SystemColors.Menu;
			this.listBox2.FormattingEnabled = true;
			this.listBox2.ItemHeight = 15;
			this.listBox2.Items.AddRange(new object[]
			{
				"Assault Rifle",
				"Thompson SMG",
				"Custom SMG ",
				"LR-300 ",
				"Semi-Auto Rifle ",
				"M249 ",
				"MP5A4 ",
				"Python",
				"M39",
				"M92"
			});
			this.listBox2.Location = new global::System.Drawing.Point(36, 251);
			this.listBox2.Name = "listBox2";
			this.listBox2.SelectionMode = global::System.Windows.Forms.SelectionMode.None;
			this.listBox2.Size = new global::System.Drawing.Size(192, 165);
			this.listBox2.TabIndex = 15;
			this.listBox2.SelectedIndexChanged += new global::System.EventHandler(this.listBox2_SelectedIndexChanged);
			this.listBox3.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.listBox3.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.listBox3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f);
			this.listBox3.ForeColor = global::System.Drawing.SystemColors.Menu;
			this.listBox3.FormattingEnabled = true;
			this.listBox3.ItemHeight = 15;
			this.listBox3.Items.AddRange(new object[]
			{
				"No Scope           ",
				"Holographic Sight",
				"Hand-made Sight ",
				"8x Zoom Scope",
				"     ",
				"No Barell                     ",
				"Suppressor",
				"",
				"+1 Randomnes",
				"-1  Randomnes           "
			});
			this.listBox3.Location = new global::System.Drawing.Point(289, 251);
			this.listBox3.Name = "listBox3";
			this.listBox3.SelectionMode = global::System.Windows.Forms.SelectionMode.None;
			this.listBox3.Size = new global::System.Drawing.Size(173, 165);
			this.listBox3.TabIndex = 16;
			this.listBox3.SelectedIndexChanged += new global::System.EventHandler(this.listBox3_SelectedIndexChanged);
			this.metroButton1.Location = new global::System.Drawing.Point(23, 531);
			this.metroButton1.Name = "metroButton1";
			this.metroButton1.Size = new global::System.Drawing.Size(143, 29);
			this.metroButton1.TabIndex = 19;
			this.metroButton1.Text = "check remaining time!";
			this.metroButton1.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.metroButton1.UseSelectable = true;
			this.metroButton1.Click += new global::System.EventHandler(this.metroButton1_Click);
			this.Apply.Location = new global::System.Drawing.Point(399, 465);
			this.Apply.Name = "Apply";
			this.Apply.Size = new global::System.Drawing.Size(95, 95);
			this.Apply.TabIndex = 20;
			this.Apply.Text = "APPLY\r\nAND\r\nRUN";
			this.Apply.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.Apply.UseSelectable = true;
			this.Apply.Click += new global::System.EventHandler(this.metroButton2_Click);
			this.metroCheckBox1.AutoSize = true;
			this.metroCheckBox1.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.metroCheckBox1.Location = new global::System.Drawing.Point(23, 190);
			this.metroCheckBox1.Name = "metroCheckBox1";
			this.metroCheckBox1.Size = new global::System.Drawing.Size(162, 15);
			this.metroCheckBox1.Style = global::MetroFramework.MetroColorStyle.Red;
			this.metroCheckBox1.TabIndex = 24;
			this.metroCheckBox1.Text = "10 Keyless keyboard mode";
			this.metroCheckBox1.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.metroCheckBox1.UseSelectable = true;
			this.metroCheckBox1.CheckedChanged += new global::System.EventHandler(this.metroCheckBox1_CheckedChanged);
			this.label1.AutoSize = true;
			this.label1.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new global::System.Drawing.Point(129, 74);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(189, 13);
			this.label1.TabIndex = 25;
			this.label1.Text = "ENTER YOUR INGAME SENSITIVTY";
			this.label2.AutoSize = true;
			this.label2.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.label2.Location = new global::System.Drawing.Point(129, 117);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(147, 13);
			this.label2.TabIndex = 26;
			this.label2.Text = "ENTER YOUR INGAME FOV";
			this.label6.AutoSize = true;
			this.label6.ForeColor = global::System.Drawing.SystemColors.ButtonShadow;
			this.label6.Location = new global::System.Drawing.Point(129, 159);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(167, 26);
			this.label6.TabIndex = 27;
			this.label6.Text = "                                         (1 - 15)\r\n(MAKES SPRAY MORE HUMAN)\r\n";
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f);
			this.label5.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.label5.Location = new global::System.Drawing.Point(286, 224);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(111, 17);
			this.label5.TabIndex = 8;
			this.label5.Text = "ATTACHMENTS";
			this.label5.Click += new global::System.EventHandler(this.label5_Click);
			this.numpad.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.numpad.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.numpad.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f);
			this.numpad.ForeColor = global::System.Drawing.SystemColors.WindowFrame;
			this.numpad.FormattingEnabled = true;
			this.numpad.ItemHeight = 15;
			this.numpad.Items.AddRange(new object[]
			{
				"Numpad1",
				"Numpad2",
				"Numpad3",
				"Numpad4",
				"Numpad5",
				"Numpad6",
				"Numpad7",
				"Numpad8",
				"Numpad9",
				"Numpad0"
			});
			this.numpad.Location = new global::System.Drawing.Point(170, 251);
			this.numpad.Name = "numpad";
			this.numpad.SelectionMode = global::System.Windows.Forms.SelectionMode.None;
			this.numpad.Size = new global::System.Drawing.Size(58, 150);
			this.numpad.TabIndex = 29;
			this.numpad.SelectedIndexChanged += new global::System.EventHandler(this.numpad_SelectedIndexChanged);
			this.fkeys.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.fkeys.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.fkeys.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f);
			this.fkeys.ForeColor = global::System.Drawing.SystemColors.WindowFrame;
			this.fkeys.FormattingEnabled = true;
			this.fkeys.ItemHeight = 15;
			this.fkeys.Items.AddRange(new object[]
			{
				"F1",
				"F2",
				"F3",
				"F4",
				"F5",
				"F6",
				"F7",
				"F8",
				"F9",
				"F10"
			});
			this.fkeys.Location = new global::System.Drawing.Point(203, 251);
			this.fkeys.Name = "fkeys";
			this.fkeys.SelectionMode = global::System.Windows.Forms.SelectionMode.None;
			this.fkeys.Size = new global::System.Drawing.Size(25, 150);
			this.fkeys.TabIndex = 30;
			this.fkeys.Visible = false;
			this.listBox1.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.listBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.listBox1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f);
			this.listBox1.ForeColor = global::System.Drawing.SystemColors.WindowFrame;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 15;
			this.listBox1.Items.AddRange(new object[]
			{
				"Left",
				"Up",
				"Right",
				"Down",
				"",
				"End",
				"Home",
				"",
				"PgUp",
				"PgDn"
			});
			this.listBox1.Location = new global::System.Drawing.Point(418, 251);
			this.listBox1.Name = "listBox1";
			this.listBox1.SelectionMode = global::System.Windows.Forms.SelectionMode.None;
			this.listBox1.Size = new global::System.Drawing.Size(37, 165);
			this.listBox1.TabIndex = 31;
			this.listBox1.SelectedIndexChanged += new global::System.EventHandler(this.listBox1_SelectedIndexChanged);
			this.label3.AutoSize = true;
			this.label3.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.label3.Location = new global::System.Drawing.Point(129, 159);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(124, 13);
			this.label3.TabIndex = 32;
			this.label3.Text = "ENTER RANDOMNESS";
			this.metroTrackBar1.BackColor = global::System.Drawing.Color.Transparent;
			this.metroTrackBar1.Location = new global::System.Drawing.Point(23, 485);
			this.metroTrackBar1.Name = "metroTrackBar1";
			this.metroTrackBar1.Size = new global::System.Drawing.Size(143, 23);
			this.metroTrackBar1.TabIndex = 33;
			this.metroTrackBar1.Text = "metroTrackBar1";
			this.metroTrackBar1.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.metroTrackBar1.Scroll += new global::System.Windows.Forms.ScrollEventHandler(this.metroTrackBar1_Scroll);
			this.label7.AutoSize = true;
			this.label7.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f);
			this.label7.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.label7.Location = new global::System.Drawing.Point(20, 465);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(66, 17);
			this.label7.TabIndex = 34;
			this.label7.Text = "VOLUME";
			this.metroButton2.Location = new global::System.Drawing.Point(280, 465);
			this.metroButton2.Name = "metroButton2";
			this.metroButton2.Size = new global::System.Drawing.Size(95, 95);
			this.metroButton2.TabIndex = 35;
			this.metroButton2.Text = "\r\nDETECT \r\nSETTINGS\r\n";
			this.metroButton2.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.metroButton2.UseSelectable = true;
			this.metroButton2.Click += new global::System.EventHandler(this.metroButton2_Click_1);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(517, 583);
			base.Controls.Add(this.metroButton2);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.metroTrackBar1);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.listBox1);
			base.Controls.Add(this.fkeys);
			base.Controls.Add(this.numpad);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.metroCheckBox1);
			base.Controls.Add(this.Apply);
			base.Controls.Add(this.metroButton1);
			base.Controls.Add(this.listBox3);
			base.Controls.Add(this.listBox2);
			base.Controls.Add(this.textBox3);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.textBox2);
			base.Controls.Add(this.textBox1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Form4";
			base.Resizable = false;
			base.Style = global::MetroFramework.MetroColorStyle.Red;
			this.Text = "Equalizer";
			base.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			base.TransparencyKey = global::System.Drawing.Color.LightSlateGray;
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
			base.Load += new global::System.EventHandler(this.Form4_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000031 RID: 49
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000032 RID: 50
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000033 RID: 51
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x04000034 RID: 52
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000035 RID: 53
		private global::System.Windows.Forms.TextBox textBox3;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.ListBox listBox2;

		// Token: 0x04000037 RID: 55
		private global::System.Windows.Forms.ListBox listBox3;

		// Token: 0x04000038 RID: 56
		private global::MetroFramework.Controls.MetroButton metroButton1;

		// Token: 0x04000039 RID: 57
		private global::MetroFramework.Controls.MetroButton Apply;

		// Token: 0x0400003A RID: 58
		private global::MetroFramework.Controls.MetroCheckBox metroCheckBox1;

		// Token: 0x0400003B RID: 59
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.Label label6;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.ListBox numpad;

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Forms.ListBox fkeys;

		// Token: 0x04000041 RID: 65
		private global::System.Windows.Forms.ListBox listBox1;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000043 RID: 67
		private global::MetroFramework.Controls.MetroTrackBar metroTrackBar1;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000045 RID: 69
		private global::MetroFramework.Controls.MetroButton metroButton2;
	}
}
