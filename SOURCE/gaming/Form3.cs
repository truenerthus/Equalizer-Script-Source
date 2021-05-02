using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace gaming
{
	// Token: 0x0200000E RID: 14
	public partial class Form3 : Form
	{
		// Token: 0x0600000D RID: 13 RVA: 0x00002058 File Offset: 0x00000258
		public Form3()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002066 File Offset: 0x00000266
		private void Form3_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002068 File Offset: 0x00000268
		private void button2_Click(object sender, EventArgs e)
		{
			new Form4().Show();
			base.Hide();
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000207A File Offset: 0x0000027A
		private void exitbutton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000207A File Offset: 0x0000027A
		private void Form3_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002066 File Offset: 0x00000266
		private void label4_Click(object sender, EventArgs e)
		{
		}
	}
}
