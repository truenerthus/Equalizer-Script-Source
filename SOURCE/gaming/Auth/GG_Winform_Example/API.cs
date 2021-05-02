using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Auth.GG_Winform_Example
{
	// Token: 0x0200001C RID: 28
	internal class API
	{
		// Token: 0x060000AB RID: 171 RVA: 0x0000BBF8 File Offset: 0x00009DF8
		public static void Log(string username, string action)
		{
			if (!Constants.Initialized)
			{
				MessageBox.Show("Please initialize your application first!", OnProgramStart.Name);
				Process.GetCurrentProcess().Kill();
			}
			if (string.IsNullOrWhiteSpace(action))
			{
				MessageBox.Show("Missing log information!", ApplicationSettings.Name);
				Process.GetCurrentProcess().Kill();
			}
			new string[0];
			using (WebClient webClient = new WebClient())
			{
				try
				{
					Security.Start();
					webClient.Proxy = null;
					Encoding @default = Encoding.Default;
					WebClient webClient2 = webClient;
					string apiUrl = Constants.ApiUrl;
					NameValueCollection nameValueCollection = new NameValueCollection();
					nameValueCollection["token"] = Encryption.EncryptService(Constants.Token);
					nameValueCollection["aid"] = Encryption.APIService(OnProgramStart.AID);
					nameValueCollection["username"] = Encryption.APIService(username);
					nameValueCollection["pcuser"] = Encryption.APIService(Environment.UserName);
					nameValueCollection["session_id"] = Constants.IV;
					nameValueCollection["api_id"] = Constants.APIENCRYPTSALT;
					nameValueCollection["api_key"] = Constants.APIENCRYPTKEY;
					nameValueCollection["data"] = Encryption.APIService(action);
					nameValueCollection["session_key"] = Constants.Key;
					nameValueCollection["secret"] = Encryption.APIService(OnProgramStart.Secret);
					nameValueCollection["type"] = Encryption.APIService("log");
					Encryption.DecryptService(@default.GetString(webClient2.UploadValues(apiUrl, nameValueCollection))).Split("|".ToCharArray());
					Security.End();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, OnProgramStart.Name);
					Process.GetCurrentProcess().Kill();
				}
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000250C File Offset: 0x0000070C
		public static bool AIO(string AIO)
		{
			return API.AIOLogin(AIO) || API.AIORegister(AIO);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000BDBC File Offset: 0x00009FBC
		public static bool AIOLogin(string AIO)
		{
			if (!Constants.Initialized)
			{
				MessageBox.Show("Please initialize your application first!", OnProgramStart.Name);
				Process.GetCurrentProcess().Kill();
			}
			if (string.IsNullOrWhiteSpace(AIO))
			{
				MessageBox.Show("Missing user login information!", ApplicationSettings.Name);
				Process.GetCurrentProcess().Kill();
			}
			string[] array = new string[0];
			bool result;
			using (WebClient webClient = new WebClient())
			{
				try
				{
					Security.Start();
					webClient.Proxy = null;
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
					nameValueCollection["username"] = Encryption.APIService(AIO);
					nameValueCollection["password"] = Encryption.APIService(AIO);
					nameValueCollection["hwid"] = Encryption.APIService(Constants.HWID());
					nameValueCollection["session_key"] = Constants.Key;
					nameValueCollection["secret"] = Encryption.APIService(OnProgramStart.Secret);
					nameValueCollection["type"] = Encryption.APIService("login");
					array = Encryption.DecryptService(@default.GetString(webClient2.UploadValues(apiUrl, nameValueCollection))).Split("|".ToCharArray());
					if (array[0] != Constants.Token)
					{
						MessageBox.Show("Security error has been triggered!", OnProgramStart.Name);
						Process.GetCurrentProcess().Kill();
					}
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
					string a = array[2];
					if (a == "success")
					{
						Security.End();
						User.ID = array[3];
						User.Username = array[4];
						User.Password = array[5];
						User.Email = array[6];
						User.HWID = array[7];
						User.UserVariable = array[8];
						User.Rank = array[9];
						User.IP = array[10];
						User.Expiry = array[11];
						User.LastLogin = array[12];
						User.RegisterDate = array[13];
						string[] array2 = array[14].Split(new char[]
						{
							'~'
						});
						for (int i = 0; i < array2.Length; i++)
						{
							string[] array3 = array2[i].Split(new char[]
							{
								'^'
							});
							try
							{
								App.Variables.Add(array3[0], array3[1]);
							}
							catch
							{
							}
						}
						return true;
					}
					if (a == "invalid_details")
					{
						Security.End();
						return false;
					}
					if (a == "time_expired")
					{
						MessageBox.Show("Your subscription has expired!", ApplicationSettings.Name);
						Security.End();
						return false;
					}
					if (a == "hwid_updated")
					{
						MessageBox.Show("New machine has been binded, re-open the application!", ApplicationSettings.Name);
						Security.End();
						return false;
					}
					if (a == "invalid_hwid")
					{
						MessageBox.Show("This user is binded to another computer, please contact support!(HWID ERROR)", ApplicationSettings.Name);
						Security.End();
						return false;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, ApplicationSettings.Name);
					Security.End();
					Process.GetCurrentProcess().Kill();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000C19C File Offset: 0x0000A39C
		public static bool AIORegister(string AIO)
		{
			if (!Constants.Initialized)
			{
				MessageBox.Show("Please initialize your application first!", OnProgramStart.Name);
				Security.End();
				Process.GetCurrentProcess().Kill();
			}
			if (string.IsNullOrWhiteSpace(AIO))
			{
				MessageBox.Show("Invalid registrar information!", ApplicationSettings.Name);
				Process.GetCurrentProcess().Kill();
			}
			new string[0];
			bool result;
			using (WebClient webClient = new WebClient())
			{
				try
				{
					Security.Start();
					webClient.Proxy = null;
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
					nameValueCollection["type"] = Encryption.APIService("register");
					nameValueCollection["username"] = Encryption.APIService(AIO);
					nameValueCollection["password"] = Encryption.APIService(AIO);
					nameValueCollection["email"] = Encryption.APIService(AIO);
					nameValueCollection["license"] = Encryption.APIService(AIO);
					nameValueCollection["hwid"] = Encryption.APIService(Constants.HWID());
					string[] array = Encryption.DecryptService(@default.GetString(webClient2.UploadValues(apiUrl, nameValueCollection))).Split("|".ToCharArray());
					if (array[0] != Constants.Token)
					{
						MessageBox.Show("Security error has been triggered!", OnProgramStart.Name);
						Security.End();
						Process.GetCurrentProcess().Kill();
					}
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
					Security.End();
					string a = array[2];
					if (a == "success")
					{
						return true;
					}
					if (a == "error")
					{
						return false;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, ApplicationSettings.Name);
					Process.GetCurrentProcess().Kill();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000C444 File Offset: 0x0000A644
		public static bool Login(string username, string password)
		{
			if (!Constants.Initialized)
			{
				MessageBox.Show("Please initialize your application first!", OnProgramStart.Name);
				Process.GetCurrentProcess().Kill();
			}
			if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
			{
				MessageBox.Show("Missing user login information!", ApplicationSettings.Name);
				Process.GetCurrentProcess().Kill();
			}
			string[] array = new string[0];
			bool result;
			using (WebClient webClient = new WebClient())
			{
				try
				{
					Security.Start();
					webClient.Proxy = null;
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
					nameValueCollection["username"] = Encryption.APIService(username);
					nameValueCollection["password"] = Encryption.APIService(password);
					nameValueCollection["hwid"] = Encryption.APIService(Constants.HWID());
					nameValueCollection["session_key"] = Constants.Key;
					nameValueCollection["secret"] = Encryption.APIService(OnProgramStart.Secret);
					nameValueCollection["type"] = Encryption.APIService("login");
					array = Encryption.DecryptService(@default.GetString(webClient2.UploadValues(apiUrl, nameValueCollection))).Split("|".ToCharArray());
					if (array[0] != Constants.Token)
					{
						MessageBox.Show("Security error has been triggered!", OnProgramStart.Name);
						Process.GetCurrentProcess().Kill();
					}
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
					string a = array[2];
					if (a == "success")
					{
						User.ID = array[3];
						User.Username = array[4];
						User.Password = array[5];
						User.Email = array[6];
						User.HWID = array[7];
						User.UserVariable = array[8];
						User.Rank = array[9];
						User.IP = array[10];
						User.Expiry = array[11];
						User.LastLogin = array[12];
						User.RegisterDate = array[13];
						string[] array2 = array[14].Split(new char[]
						{
							'~'
						});
						for (int i = 0; i < array2.Length; i++)
						{
							string[] array3 = array2[i].Split(new char[]
							{
								'^'
							});
							try
							{
								App.Variables.Add(array3[0], array3[1]);
							}
							catch
							{
							}
						}
						Security.End();
						return true;
					}
					if (a == "invalid_details")
					{
						MessageBox.Show("Sorry, your username/password does not match!", ApplicationSettings.Name);
						Security.End();
						return false;
					}
					if (a == "time_expired")
					{
						MessageBox.Show("Your subscription has expired!", ApplicationSettings.Name);
						Security.End();
						return false;
					}
					if (a == "hwid_updated")
					{
						MessageBox.Show("New machine has been binded, re-open the application!", ApplicationSettings.Name);
						Security.End();
						return false;
					}
					if (a == "invalid_hwid")
					{
						MessageBox.Show("This user is binded to another computer, please contact support!", ApplicationSettings.Name);
						Security.End();
						return false;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, ApplicationSettings.Name);
					Security.End();
					Process.GetCurrentProcess().Kill();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000C83C File Offset: 0x0000AA3C
		public static bool Register(string username, string password, string email, string license)
		{
			if (!Constants.Initialized)
			{
				MessageBox.Show("Please initialize your application first!", OnProgramStart.Name);
				Security.End();
				Process.GetCurrentProcess().Kill();
			}
			if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(license))
			{
				MessageBox.Show("Invalid registrar information!", ApplicationSettings.Name);
				Process.GetCurrentProcess().Kill();
			}
			new string[0];
			bool result;
			using (WebClient webClient = new WebClient())
			{
				try
				{
					Security.Start();
					webClient.Proxy = null;
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
					nameValueCollection["type"] = Encryption.APIService("register");
					nameValueCollection["username"] = Encryption.APIService(username);
					nameValueCollection["password"] = Encryption.APIService(password);
					nameValueCollection["email"] = Encryption.APIService(email);
					nameValueCollection["license"] = Encryption.APIService(license);
					nameValueCollection["hwid"] = Encryption.APIService(Constants.HWID());
					string[] array = Encryption.DecryptService(@default.GetString(webClient2.UploadValues(apiUrl, nameValueCollection))).Split("|".ToCharArray());
					if (array[0] != Constants.Token)
					{
						MessageBox.Show("Security error has been triggered!", OnProgramStart.Name);
						Security.End();
						Process.GetCurrentProcess().Kill();
					}
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
					string a = array[2];
					if (a == "success")
					{
						Security.End();
						return true;
					}
					if (a == "invalid_license")
					{
						MessageBox.Show("License does not exist!", ApplicationSettings.Name);
						Security.End();
						return false;
					}
					if (a == "email_used")
					{
						MessageBox.Show("Email has already been used!", ApplicationSettings.Name);
						Security.End();
						return false;
					}
					if (a == "invalid_username")
					{
						MessageBox.Show("You entered an invalid/used username!", ApplicationSettings.Name);
						Security.End();
						return false;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, ApplicationSettings.Name);
					Process.GetCurrentProcess().Kill();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000CB5C File Offset: 0x0000AD5C
		public static bool ExtendSubscription(string username, string password, string license)
		{
			if (!Constants.Initialized)
			{
				MessageBox.Show("Please initialize your application first!", OnProgramStart.Name);
				Security.End();
				Process.GetCurrentProcess().Kill();
			}
			if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(license))
			{
				MessageBox.Show("Invalid registrar information!", ApplicationSettings.Name);
				Process.GetCurrentProcess().Kill();
			}
			new string[0];
			bool result;
			using (WebClient webClient = new WebClient())
			{
				try
				{
					Security.Start();
					webClient.Proxy = null;
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
					nameValueCollection["type"] = Encryption.APIService("extend");
					nameValueCollection["username"] = Encryption.APIService(username);
					nameValueCollection["password"] = Encryption.APIService(password);
					nameValueCollection["license"] = Encryption.APIService(license);
					string[] array = Encryption.DecryptService(@default.GetString(webClient2.UploadValues(apiUrl, nameValueCollection))).Split("|".ToCharArray());
					if (array[0] != Constants.Token)
					{
						MessageBox.Show("Security error has been triggered!", OnProgramStart.Name);
						Security.End();
						Process.GetCurrentProcess().Kill();
					}
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
					string a = array[2];
					if (a == "success")
					{
						Security.End();
						return true;
					}
					if (a == "invalid_token")
					{
						MessageBox.Show("Token does not exist!", ApplicationSettings.Name);
						Security.End();
						return false;
					}
					if (a == "invalid_details")
					{
						MessageBox.Show("Your user details are invalid!", ApplicationSettings.Name);
						Security.End();
						return false;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, ApplicationSettings.Name);
					Process.GetCurrentProcess().Kill();
				}
				result = false;
			}
			return result;
		}
	}
}
