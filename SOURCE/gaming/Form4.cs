using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Auth.GG_Winform_Example;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using Microsoft.Win32;

namespace gaming
{
	// Token: 0x02000011 RID: 17
	public partial class Form4 : MetroForm
	{
		// Token: 0x0600002E RID: 46 RVA: 0x0000214B File Offset: 0x0000034B
		public Form4()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002159 File Offset: 0x00000359
		public void Form4_Load(object sender, EventArgs e)
		{
			expiry.Text = "License expiry date: " + User.Expiry;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000207A File Offset: 0x0000027A
		private void exitbutton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0000207A File Offset: 0x0000027A
		private void Form4_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002066 File Offset: 0x00000266
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002066 File Offset: 0x00000266
		private void label2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002066 File Offset: 0x00000266
		private void label3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000216F File Offset: 0x0000036F
		public void textBox1_TextChanged(object sender, EventArgs e)
		{
			this.sensitivityS = this.textBox1.Text;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002182 File Offset: 0x00000382
		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			this.fovS = this.textBox2.Text;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002066 File Offset: 0x00000266
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002066 File Offset: 0x00000266
		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002066 File Offset: 0x00000266
		private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002066 File Offset: 0x00000266
		private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002066 File Offset: 0x00000266
		private void label5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002195 File Offset: 0x00000395
		private void button1_Click(object sender, EventArgs e)
		{
			new Form5().Show();
			base.Hide();
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000021A7 File Offset: 0x000003A7
		private void textBox3_TextChanged(object sender, EventArgs e)
		{
			this.randomnesS = this.textBox3.Text;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00004BD8 File Offset: 0x00002DD8
		private void Apply_Click(object sender, EventArgs e)
		{
			this.sensitivityS = this.sensitivityS.Replace(",", ".");
			this.fovS = this.fovS.Replace(",", ".");
			this.randomnesS = this.randomnesS.Replace(",", ".");
			float sens = float.Parse(this.sensitivityS);
			float fovP = float.Parse(this.fovS);
			float randomnes = float.Parse(this.randomnesS);
			if (!this.enabled)
			{
				Script script = new Script();
				new Thread(delegate()
				{
					Thread.CurrentThread.IsBackground = true;
					script.scriptRun((int)Math.Round((double)fovP), (int)Math.Round((double)randomnes), sens);
				}).Start();
				this.Apply.Text = "RUNNING";
				this.enabled = true;
				return;
			}
			this.Apply.Text = "APPLY and RUN";
			Script.kill = true;
			this.enabled = false;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000021BA File Offset: 0x000003BA
		private void metroButton1_Click(object sender, EventArgs e)
		{
			MessageBox.Show(expiry.Text);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002066 File Offset: 0x00000266
		private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00004CD0 File Offset: 0x00002ED0
		private void metroButton2_Click(object sender, EventArgs e)
		{
			float sens = float.Parse(this.sensitivityS);
			int fovP = int.Parse(this.fovS);
			int randomnes = int.Parse(this.randomnesS);
			if (!this.enabled)
			{
				Script script = new Script();
				new Thread(delegate()
				{
					Thread.CurrentThread.IsBackground = true;
					script.scriptRun(fovP, randomnes, sens);
				}).Start();
				this.Apply.Text = "RUNNING";
				this.enabled = true;
				return;
			}
			this.Apply.Text = "APPLY and RUN";
			Script.kill = true;
			this.enabled = false;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00004D74 File Offset: 0x00002F74
		private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			Script.keyless = !Script.keyless;
			if (Script.keyless)
			{
				this.fkeys.Show();
				this.numpad.Hide();
				return;
			}
			this.fkeys.Hide();
			this.numpad.Show();
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002066 File Offset: 0x00000266
		private void tenkeylesslist_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002066 File Offset: 0x00000266
		private void numpad_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000021C7 File Offset: 0x000003C7
		private void metroTrackBar1_Scroll(object sender, ScrollEventArgs e)
		{
			Script.Volume = this.metroTrackBar1.Value;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00004DC4 File Offset: 0x00002FC4
		private void metroButton2_Click_1(object sender, EventArgs e)
		{
			string text = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\Steam App 252490";
			string text2 = "InstallLocation";
			string str;
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
			{
				using (RegistryKey registryKey2 = registryKey.OpenSubKey(text))
				{
					if (registryKey2 == null)
					{
						throw new KeyNotFoundException(string.Format("Key not found: {0}", text));
					}
					object value = registryKey2.GetValue(text2);
					if (value == null)
					{
						throw new IndexOutOfRangeException(string.Format("Index Not Found: {0}", text2));
					}
					str = value.ToString();
				}
			}
			string[] array;
			try
			{
				array = File.ReadAllLines(str + "\\cfg\\client.cfg");
			}
			catch (Exception value2)
			{
				Console.WriteLine(value2);
			}
			finally
			{
				array = File.ReadAllLines("C:\\Program Files (x86)\\Steam\\steamapps\\common\\Rust\\cfg\\client.cfg");
			}
			string pattern = "input.sensitivity";
			string pattern2 = "graphics.fov";
			foreach (string text3 in array)
			{
				if (Regex.IsMatch(text3, pattern))
				{
					string text4 = text3.ToString().Replace("input.sensitivity", "").Replace('"', ' ').Replace(".", ".");
					this.sensitivityS = text4.Replace(" ", "");
					this.textBox1.Text = this.sensitivityS;
				}
				if (Regex.IsMatch(text3, pattern2))
				{
					string text5 = text3.ToString().Replace("graphics.fov", "").Replace('"', ' ').Replace(".", ",");
					this.fovS = text5.Replace(" ", "");
					this.textBox2.Text = this.fovS;
				}
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002066 File Offset: 0x00000266
		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002066 File Offset: 0x00000266
		private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0400002D RID: 45
		private bool enabled;

		// Token: 0x0400002E RID: 46
		public string sensitivityS;

		// Token: 0x0400002F RID: 47
		public string fovS;

		// Token: 0x04000030 RID: 48
		public string randomnesS;
	}
}
