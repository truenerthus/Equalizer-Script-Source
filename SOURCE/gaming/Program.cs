using System;
using System.Windows.Forms;

namespace gaming
{
	// Token: 0x02000013 RID: 19
	internal class Program
	{
		// Token: 0x0600005A RID: 90 RVA: 0x00002225 File Offset: 0x00000425
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
