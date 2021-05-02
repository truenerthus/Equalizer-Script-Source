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
	// Token: 0x02000010 RID: 16
	public partial class Form2 : MetroForm
	{
		// Token: 0x06000022 RID: 34 RVA: 0x0000210C File Offset: 0x0000030C
		public Form2()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002066 File Offset: 0x00000266
		private void label4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002066 File Offset: 0x00000266
		private void Form2_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003F58 File Offset: 0x00002158
		private void button2_Click(object sender, EventArgs e)
		{
			if (API.Register(this.username.Text, this.password.Text, this.email.Text, this.license.Text))
			{
				MessageBox.Show("Register has been successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002066 File Offset: 0x00000266
		private void label3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0000211A File Offset: 0x0000031A
		private void button1_Click(object sender, EventArgs e)
		{
			new Form1().Show();
			base.Hide();
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000207A File Offset: 0x0000027A
		private void exitbutton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000207A File Offset: 0x0000027A
		private void Form2_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00003F58 File Offset: 0x00002158
		private void metroButton1_Click(object sender, EventArgs e)
		{
			if (API.Register(this.username.Text, this.password.Text, this.email.Text, this.license.Text))
			{
				MessageBox.Show("Register has been successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000211A File Offset: 0x0000031A
		private void metroButton2_Click(object sender, EventArgs e)
		{
			new Form1().Show();
			base.Hide();
		}
	}
}
