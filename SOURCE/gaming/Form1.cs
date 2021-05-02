using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Auth.GG_Winform_Example;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace gaming
{
	// Token: 0x0200000F RID: 15
	public partial class Form1 : MetroForm
	{
		// Token: 0x06000015 RID: 21 RVA: 0x000020A0 File Offset: 0x000002A0
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000020AE File Offset: 0x000002AE
		private void button1_Click(object sender, EventArgs e)
		{
			new Form2().Show();
			base.Hide();
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002066 File Offset: 0x00000266
		private void textBox2_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002066 File Offset: 0x00000266
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002066 File Offset: 0x00000266
		private void label2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000379C File Offset: 0x0000199C
		private void button2_Click(object sender, EventArgs e)
		{
			if (API.Login(this.username.Text, this.password.Text))
			{
				MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				new Form4().Show();
				base.Hide();
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002066 File Offset: 0x00000266
		private void Form1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000207A File Offset: 0x0000027A
		private void exitbutton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000207A File Offset: 0x0000027A
		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000020AE File Offset: 0x000002AE
		private void metroButton1_Click(object sender, EventArgs e)
		{
			new Form2().Show();
			base.Hide();
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000020C0 File Offset: 0x000002C0
		private void metroButton2_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			new Form4().Show();
			base.Hide();
		}
	}
}
