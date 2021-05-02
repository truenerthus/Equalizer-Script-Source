using System;
using System.Linq;
using System.Security.Principal;

namespace Auth.GG_Winform_Example
{
	// Token: 0x02000018 RID: 24
	internal class Constants
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00002324 File Offset: 0x00000524
		// (set) Token: 0x06000074 RID: 116 RVA: 0x0000232B File Offset: 0x0000052B
		public static string Token { get; set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00002333 File Offset: 0x00000533
		// (set) Token: 0x06000076 RID: 118 RVA: 0x0000233A File Offset: 0x0000053A
		public static string Date { get; set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00002342 File Offset: 0x00000542
		// (set) Token: 0x06000078 RID: 120 RVA: 0x00002349 File Offset: 0x00000549
		public static string APIENCRYPTKEY { get; set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00002351 File Offset: 0x00000551
		// (set) Token: 0x0600007A RID: 122 RVA: 0x00002358 File Offset: 0x00000558
		public static string APIENCRYPTSALT { get; set; }

		// Token: 0x0600007B RID: 123 RVA: 0x00002360 File Offset: 0x00000560
		public static string RandomString(int length)
		{
			return new string((from s in Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789", length)
			select s[Constants.random.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000239B File Offset: 0x0000059B
		public static string HWID()
		{
			return WindowsIdentity.GetCurrent().User.Value;
		}

		// Token: 0x0400007F RID: 127
		public static bool Breached = false;

		// Token: 0x04000080 RID: 128
		public static bool Started = false;

		// Token: 0x04000081 RID: 129
		public static string IV = null;

		// Token: 0x04000082 RID: 130
		public static string Key = null;

		// Token: 0x04000083 RID: 131
		public static string ApiUrl = "https://api.auth.gg/csharp/";

		// Token: 0x04000084 RID: 132
		public static bool Initialized = false;

		// Token: 0x04000085 RID: 133
		public static Random random = new Random();
	}
}
