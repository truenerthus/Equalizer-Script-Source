using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Auth.GG_Winform_Example
{
	// Token: 0x0200001B RID: 27
	internal class OnProgramStart
	{
		// Token: 0x060000A9 RID: 169 RVA: 0x0000B7CC File Offset: 0x000099CC
		public static void Initialize(string name, string aid, string secret, string version)
		{
			if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(aid) || string.IsNullOrWhiteSpace(secret) || string.IsNullOrWhiteSpace(version))
			{
				MessageBox.Show("Invalid application information!");
				Process.GetCurrentProcess().Kill();
			}
			OnProgramStart.AID = aid;
			OnProgramStart.Secret = secret;
			OnProgramStart.Version = version;
			OnProgramStart.Name = name;
			string[] array = new string[0];
			using (WebClient webClient = new WebClient())
			{
				try
				{
					webClient.Proxy = null;
					Security.Start();
					Encoding @default = Encoding.Default;
					WebClient webClient2 = webClient;
					string apiUrl = Constants.ApiUrl;
					NameValueCollection nameValueCollection = new NameValueCollection();
					nameValueCollection["token"] = Encryption.EncryptService(Constants.Token);
					nameValueCollection["timestamp"] = Encryption.EncryptService(DateTime.Now.ToString());
					nameValueCollection["aid"] = Encryption.APIService(OnProgramStart.AID);
					nameValueCollection["session_id"] = Constants.IV;
					nameValueCollection["api_id"] = Constants.APIENCRYPTSALT;
					nameValueCollection["api_key"] = Constants.APIENCRYPTKEY;
					nameValueCollection["session_key"] = Constants.Key;
					nameValueCollection["secret"] = Encryption.APIService(OnProgramStart.Secret);
					nameValueCollection["type"] = Encryption.APIService("start");
					array = Encryption.DecryptService(@default.GetString(webClient2.UploadValues(apiUrl, nameValueCollection))).Split("|".ToCharArray());
					if (Security.MaliciousCheck(array[1]))
					{
						MessageBox.Show("Possible malicious activity detected!", OnProgramStart.Name);
						Process.GetCurrentProcess().Kill();
					}
					if (Constants.Breached)
					{
						MessageBox.Show("Possible malicious activity detected!", OnProgramStart.Name);
						Process.GetCurrentProcess().Kill();
					}
					if (array[0] != Constants.Token)
					{
						MessageBox.Show("Security error has been triggered!");
						Process.GetCurrentProcess().Kill();
					}
					string a = array[2];
					if (!(a == "success"))
					{
						if (a == "binderror")
						{
							MessageBox.Show(Encryption.Decode("RmFpbGVkIHRvIGJpbmQgdG8gc2VydmVyLCBjaGVjayB5b3VyIEFJRCAmIFNlY3JldCBpbiB5b3VyIGNvZGUh"));
							Process.GetCurrentProcess().Kill();
							return;
						}
						if (a == "banned")
						{
							MessageBox.Show("This application has been banned for violating the TOS" + Environment.NewLine + "Contact us at support@auth.gg");
							Process.GetCurrentProcess().Kill();
							return;
						}
					}
					else
					{
						Constants.Initialized = true;
						if (array[3] == "Enabled")
						{
							ApplicationSettings.Status = true;
						}
						if (array[4] == "Enabled")
						{
							ApplicationSettings.DeveloperMode = true;
						}
						ApplicationSettings.Hash = array[5];
						ApplicationSettings.Version = array[6];
						ApplicationSettings.Update_Link = array[7];
						if (array[8] == "Enabled")
						{
							ApplicationSettings.Freemode = true;
						}
						if (array[9] == "Enabled")
						{
							ApplicationSettings.Login = true;
						}
						ApplicationSettings.Name = array[10];
						if (array[11] == "Enabled")
						{
							ApplicationSettings.Register = true;
						}
						if (ApplicationSettings.DeveloperMode)
						{
							MessageBox.Show("Application is in Developer Mode, bypassing integrity and update check!");
							File.Create(Environment.CurrentDirectory + "/integrity.log").Close();
							string contents = Security.Integrity(Process.GetCurrentProcess().MainModule.FileName);
							File.WriteAllText(Environment.CurrentDirectory + "/integrity.log", contents);
							MessageBox.Show("Your applications hash has been saved to integrity.txt, please refer to this when your application is ready for release!");
						}
						else
						{
							if (array[12] == "Enabled" && ApplicationSettings.Hash != Security.Integrity(Process.GetCurrentProcess().MainModule.FileName))
							{
								MessageBox.Show("File has been tampered with, couldn't verify integrity!");
								Process.GetCurrentProcess().Kill();
							}
							if (ApplicationSettings.Version != OnProgramStart.Version)
							{
								MessageBox.Show("Update " + ApplicationSettings.Version + " available, redirecting to update!");
								Process.Start(ApplicationSettings.Update_Link);
								Process.GetCurrentProcess().Kill();
							}
						}
						if (!ApplicationSettings.Status)
						{
							MessageBox.Show("Looks like this application is disabled, please try again later!");
							Process.GetCurrentProcess().Kill();
						}
					}
					Security.End();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
					Process.GetCurrentProcess().Kill();
				}
			}
		}

		// Token: 0x0400009A RID: 154
		public static string AID;

		// Token: 0x0400009B RID: 155
		public static string Secret;

		// Token: 0x0400009C RID: 156
		public static string Version;

		// Token: 0x0400009D RID: 157
		public static string Name;

		// Token: 0x0400009E RID: 158
		public static string Salt;
	}
}
