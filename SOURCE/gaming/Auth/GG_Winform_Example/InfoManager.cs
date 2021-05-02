using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace Auth.GG_Winform_Example
{
	// Token: 0x0200001F RID: 31
	internal class InfoManager
	{
		// Token: 0x060000C3 RID: 195 RVA: 0x0000253A File Offset: 0x0000073A
		public InfoManager()
		{
			this.lastGateway = this.GetGatewayMAC();
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000254E File Offset: 0x0000074E
		public void StartListener()
		{
			this.timer = new System.Threading.Timer(delegate(object _)
			{
				this.OnCallBack();
			}, null, 5000, -1);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000D470 File Offset: 0x0000B670
		private void OnCallBack()
		{
			this.timer.Dispose();
			if (!(this.GetGatewayMAC() == this.lastGateway))
			{
				Constants.Breached = true;
				MessageBox.Show("ARP Cache poisoning has been detected!", OnProgramStart.Name);
				Process.GetCurrentProcess().Kill();
			}
			else
			{
				this.lastGateway = this.GetGatewayMAC();
			}
			this.timer = new System.Threading.Timer(delegate(object _)
			{
				this.OnCallBack();
			}, null, 5000, -1);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000D4E8 File Offset: 0x0000B6E8
		public static IPAddress GetDefaultGateway()
		{
			return (from a in (from n in NetworkInterface.GetAllNetworkInterfaces()
			where n.OperationalStatus == OperationalStatus.Up
			where n.NetworkInterfaceType != NetworkInterfaceType.Loopback
			select n).SelectMany(delegate(NetworkInterface n)
			{
				IPInterfaceProperties ipproperties = n.GetIPProperties();
				if (ipproperties == null)
				{
					return null;
				}
				return ipproperties.GatewayAddresses;
			}).Select(delegate(GatewayIPAddressInformation g)
			{
				if (g == null)
				{
					return null;
				}
				return g.Address;
			})
			where a != null
			select a).FirstOrDefault<IPAddress>();
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000D5B4 File Offset: 0x0000B7B4
		private string GetArpTable()
		{
			string pathRoot = Path.GetPathRoot(Environment.SystemDirectory);
			string result;
			using (Process process = Process.Start(new ProcessStartInfo
			{
				FileName = pathRoot + "Windows\\System32\\arp.exe",
				Arguments = "-a",
				UseShellExecute = false,
				RedirectStandardOutput = true,
				CreateNoWindow = true
			}))
			{
				using (StreamReader standardOutput = process.StandardOutput)
				{
					result = standardOutput.ReadToEnd();
				}
			}
			return result;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0000D64C File Offset: 0x0000B84C
		private string GetGatewayMAC()
		{
			string arg = InfoManager.GetDefaultGateway().ToString();
			return new Regex(string.Format("({0} [\\W]*) ([a-z0-9-]*)", arg)).Match(this.GetArpTable()).Groups[2].ToString();
		}

		// Token: 0x040000A0 RID: 160
		private System.Threading.Timer timer;

		// Token: 0x040000A1 RID: 161
		private string lastGateway;
	}
}
