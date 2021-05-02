using System;
using System.Collections.Generic;

namespace Auth.GG_Winform_Example
{
	// Token: 0x02000017 RID: 23
	internal class App
	{
		// Token: 0x06000070 RID: 112 RVA: 0x0000B76C File Offset: 0x0000996C
		public static string GrabVariable(string name)
		{
			string result;
			try
			{
				if (User.ID != null || User.HWID != null || User.IP != null || !Constants.Breached)
				{
					result = App.Variables[name];
				}
				else
				{
					Constants.Breached = true;
					result = "User is not logged in, possible breach detected!";
				}
			}
			catch
			{
				result = "N/A";
			}
			return result;
		}

		// Token: 0x04000079 RID: 121
		public static string Error = null;

		// Token: 0x0400007A RID: 122
		public static Dictionary<string, string> Variables = new Dictionary<string, string>();
	}
}
