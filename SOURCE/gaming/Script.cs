using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Speech.Synthesis;
using System.Threading;
using Weapons;

namespace gaming
{
	// Token: 0x02000014 RID: 20
	public class Script
	{
		// Token: 0x0600005C RID: 92
		[DllImport("User32.dll")]
		public static extern short GetAsyncKeyState(int VK);

		// Token: 0x0600005D RID: 93 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public void scriptRun(int playerfov, int randomizer, float playersens)
		{
			ak ak = new ak();
			thompson thompson = new thompson();
			smg smg = new smg();
			lr lr = new lr();
			mp5 mp = new mp5();
			semi semi = new semi();
			m249 m = new m249();
			python python = new python();
			m39 m2 = new m39();
			m92 m3 = new m92();
			int num = 0;
			int currentscope = 0;
			int currentbarrel = 0;
			bool flag = false;
			while (!Script.kill)
			{
				int vk;
				int vk2;
				int vk3;
				int vk4;
				int vk5;
				int vk6;
				int vk7;
				int vk8;
				int vk9;
				int vk10;
				int vk11;
				int vk12;
				int vk13;
				int vk14;
				int vk15;
				int vk16;
				int vk17;
				int vk18;
				int vk19;
				int vk20;
				int vk21;
				int vk22;
				if (!Script.keyless)
				{
					vk = 1;
					vk2 = 2;
					vk3 = 45;
					vk4 = 97;
					vk5 = 98;
					vk6 = 99;
					vk7 = 100;
					vk8 = 101;
					vk9 = 102;
					vk10 = 103;
					vk11 = 104;
					vk12 = 105;
					vk13 = 96;
					vk14 = 37;
					vk15 = 38;
					vk16 = 39;
					vk17 = 40;
					vk18 = 35;
					vk19 = 36;
					vk20 = 33;
					vk21 = 34;
					vk22 = 17;
				}
				else
				{
					vk = 1;
					vk2 = 2;
					vk3 = 45;
					vk4 = 112;
					vk5 = 113;
					vk6 = 114;
					vk7 = 115;
					vk8 = 116;
					vk9 = 117;
					vk10 = 118;
					vk11 = 119;
					vk12 = 120;
					vk13 = 121;
					vk14 = 37;
					vk15 = 38;
					vk16 = 39;
					vk17 = 40;
					vk18 = 35;
					vk19 = 36;
					vk20 = 33;
					vk21 = 34;
					vk22 = 17;
				}
				if (BitConverter.GetBytes(Script.GetAsyncKeyState(vk4))[0] == 1)
				{
					this.TTS("AK");
					this.currentwep = 0;
				}
				if (BitConverter.GetBytes(Script.GetAsyncKeyState(vk5))[0] == 1)
				{
					this.TTS("Thompson");
					this.currentwep = 4;
				}
				if (BitConverter.GetBytes(Script.GetAsyncKeyState(vk6))[0] == 1)
				{
					this.TTS("SMG");
					this.currentwep = 2;
				}
				if (BitConverter.GetBytes(Script.GetAsyncKeyState(vk7))[0] == 1)
				{
					this.TTS("Lr300");
					this.currentwep = 3;
				}
				if (BitConverter.GetBytes(Script.GetAsyncKeyState(vk8))[0] == 1)
				{
					this.TTS("Semi automatic rifle");
					this.currentwep = 5;
				}
				if (BitConverter.GetBytes(Script.GetAsyncKeyState(vk9))[0] == 1)
				{
					this.TTS("M249");
					this.currentwep = 6;
				}
				if (BitConverter.GetBytes(Script.GetAsyncKeyState(vk10))[0] == 1)
				{
					this.TTS("MP5");
					this.currentwep = 1;
				}
				if (BitConverter.GetBytes(Script.GetAsyncKeyState(vk11))[0] == 1)
				{
					this.TTS("Python");
					this.currentwep = 7;
				}
				if (BitConverter.GetBytes(Script.GetAsyncKeyState(vk12))[0] == 1)
				{
					this.TTS("M39");
					this.currentwep = 8;
				}
				if (BitConverter.GetBytes(Script.GetAsyncKeyState(vk13))[0] == 1)
				{
					this.TTS("M92");
					this.currentwep = 9;
				}
				if (BitConverter.GetBytes(Script.GetAsyncKeyState(vk14))[0] == 1)
				{
					this.TTS("No Scope");
					currentscope = 0;
				}
				if (BitConverter.GetBytes(Script.GetAsyncKeyState(vk15))[0] == 1)
				{
					this.TTS("Holo sight");
					currentscope = 1;
				}
				if (BitConverter.GetBytes(Script.GetAsyncKeyState(vk16))[0] == 1)
				{
					this.TTS("Handmade sight");
					currentscope = 2;
				}
				if (BitConverter.GetBytes(Script.GetAsyncKeyState(vk17))[0] == 1)
				{
					this.TTS("8x zoom");
					currentscope = 3;
				}
				if (BitConverter.GetBytes(Script.GetAsyncKeyState(vk18))[0] == 1)
				{
					this.TTS("No barrel");
					currentbarrel = 0;
				}
				if (BitConverter.GetBytes(Script.GetAsyncKeyState(vk19))[0] == 1)
				{
					this.TTS("Suppressor");
					currentbarrel = 2;
				}
				if (BitConverter.GetBytes(Script.GetAsyncKeyState(vk20))[0] == 1)
				{
					randomizer++;
					this.TTS(randomizer.ToString());
				}
				if (BitConverter.GetBytes(Script.GetAsyncKeyState(vk21))[0] == 1)
				{
					if (randomizer > 0)
					{
						randomizer--;
					}
					this.TTS(randomizer.ToString());
				}
				if (BitConverter.GetBytes(Script.GetAsyncKeyState(vk22))[1] == 128)
				{
					this.crouched = true;
				}
				else
				{
					this.crouched = false;
				}
				if (BitConverter.GetBytes(Script.GetAsyncKeyState(vk3))[0] == 1)
				{
					flag = !flag;
					if (flag)
					{
						this.TTS("Enabled");
					}
					else
					{
						this.TTS("Disabled");
					}
				}
				byte[] bytes = BitConverter.GetBytes(Script.GetAsyncKeyState(vk));
				byte[] bytes2 = BitConverter.GetBytes(Script.GetAsyncKeyState(vk2));
				if (flag)
				{
					if (bytes[1] == 128 && bytes2[1] == 128)
					{
						if (num < ak.pattern.Length && this.currentwep == 0)
						{
							this.Smoothing((double)ak.delay, (double)ak.delay, this.Randomize(this.tofovandsens(playersens, playerfov, (float)ak.pattern[num].x, currentscope, currentbarrel), randomizer), this.Randomize(this.tofovandsens(playersens, playerfov, (float)ak.pattern[num].y, currentscope, currentbarrel), randomizer));
							num++;
						}
						else if (num < thompson.pattern.Length && this.currentwep == 4)
						{
							this.Smoothing((double)thompson.delay, (double)thompson.delay, this.Randomize(this.tofovandsens(playersens, playerfov, (float)thompson.pattern[num].x, currentscope, currentbarrel), randomizer), this.Randomize(this.tofovandsens(playersens, playerfov, (float)thompson.pattern[num].y, currentscope, currentbarrel), randomizer));
							num++;
						}
						else if (num < smg.pattern.Length && this.currentwep == 2)
						{
							this.Smoothing((double)smg.delay, (double)smg.delay, this.Randomize(this.tofovandsens(playersens, playerfov, (float)smg.pattern[num].x, currentscope, currentbarrel), randomizer), this.Randomize(this.tofovandsens(playersens, playerfov, (float)smg.pattern[num].y, currentscope, currentbarrel), randomizer));
							num++;
						}
						else if (num < lr.pattern.Length && this.currentwep == 3)
						{
							this.Smoothing((double)lr.delay, (double)lr.delay, this.Randomize(this.tofovandsens(playersens, playerfov, (float)lr.pattern[num].x, currentscope, currentbarrel), randomizer), this.Randomize(this.tofovandsens(playersens, playerfov, (float)lr.pattern[num].y, currentscope, currentbarrel), randomizer));
							num++;
						}
						else if (num < mp.pattern.Length && this.currentwep == 1)
						{
							this.Smoothing((double)mp.delay, (double)mp.delay, this.Randomize(this.tofovandsens(playersens, playerfov, (float)mp.pattern[num].x, currentscope, currentbarrel), randomizer), this.Randomize(this.tofovandsens(playersens, playerfov, (float)mp.pattern[num].y, currentscope, currentbarrel), randomizer));
							num++;
						}
						else if (num < semi.pattern.Length && this.currentwep == 5)
						{
							this.Smoothing((double)semi.delay, (double)semi.delay, this.Randomize(this.tofovandsens(playersens, playerfov, (float)semi.pattern[num].x, currentscope, currentbarrel), randomizer), this.Randomize(this.tofovandsens(playersens, playerfov, (float)semi.pattern[num].y, currentscope, currentbarrel), randomizer));
						}
						else if (num < m.pattern.Length && this.currentwep == 6)
						{
							this.Smoothing((double)m.delay, (double)m.delay, this.Randomize(this.tofovandsens(playersens, playerfov, (float)m.pattern[num].x, currentscope, currentbarrel), randomizer), this.Randomize(this.tofovandsens(playersens, playerfov, (float)m.pattern[num].y, currentscope, currentbarrel), randomizer));
						}
						else if (num < python.pattern.Length && this.currentwep == 7)
						{
							this.Smoothing((double)python.delay, (double)python.delay, this.Randomize(this.tofovandsens(playersens, playerfov, (float)python.pattern[num].x, currentscope, currentbarrel), randomizer), this.Randomize(this.tofovandsens(playersens, playerfov, (float)python.pattern[num].y, currentscope, currentbarrel), randomizer));
						}
						else if (num < m2.pattern.Length && this.currentwep == 8)
						{
							this.Smoothing((double)m2.delay, (double)m2.delay, this.Randomize(this.tofovandsens(playersens, playerfov, (float)m2.pattern[num].x, currentscope, currentbarrel), randomizer), this.Randomize(this.tofovandsens(playersens, playerfov, (float)m2.pattern[num].y, currentscope, currentbarrel), randomizer));
						}
						else if (num < m3.pattern.Length && this.currentwep == 9)
						{
							this.Smoothing((double)m3.delay, (double)m3.delay, this.Randomize(this.tofovandsens(playersens, playerfov, (float)m3.pattern[num].x, currentscope, currentbarrel), randomizer), this.Randomize(this.tofovandsens(playersens, playerfov, (float)m3.pattern[num].y, currentscope, currentbarrel), randomizer));
						}
					}
					else
					{
						num = 0;
					}
				}
			}
			Script.kill = false;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000B5C4 File Offset: 0x000097C4
		private float tofovandsens(float sens, int fov, float val, int currentscope, int currentbarrel)
		{
			if (this.crouched && (this.currentwep == 5 || this.currentwep == 6 || this.currentwep == 7 || this.currentwep == 8 || this.currentwep == 9))
			{
				sens *= 2f;
			}
			float val2 = 0.5f * (float)fov * val / (sens * 90f);
			return this.getScope(val2, currentscope, currentbarrel);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002241 File Offset: 0x00000441
		private float getScope(float val, int currentscope, int currentbarrel)
		{
			if (currentscope == 1)
			{
				if (currentbarrel == 2)
				{
					return val * 1.2f * 0.8f;
				}
				return val * 1.2f;
			}
			else
			{
				if (currentscope == 3)
				{
					return val * 3.84f;
				}
				if (currentbarrel == 2)
				{
					return val * 0.8f;
				}
				return val;
			}
		}

		// Token: 0x06000060 RID: 96
		[DllImport("Kernel32.dll")]
		private static extern bool QueryPerformanceCounter(out long lpPerformanceCount);

		// Token: 0x06000061 RID: 97
		[DllImport("Kernel32.dll")]
		private static extern bool QueryPerformanceFrequency(out long lpFrequency);

		// Token: 0x06000062 RID: 98 RVA: 0x0000B630 File Offset: 0x00009830
		private void QuerySleep(int ms)
		{
			long num;
			Script.QueryPerformanceFrequency(out num);
			num /= 1000L;
			long num2;
			Script.QueryPerformanceCounter(out num2);
			long num3 = num2 / num + (long)ms;
			for (num2 = 0L; num2 < num3; num2 /= num)
			{
				Script.QueryPerformanceCounter(out num2);
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000B674 File Offset: 0x00009874
		private float Randomize(float val, int randomnes)
		{
			RNGCryptoServiceProvider rngcryptoServiceProvider = new RNGCryptoServiceProvider();
			byte[] array = new byte[4];
			if (randomnes == 0)
			{
				return val;
			}
			rngcryptoServiceProvider.GetBytes(array);
			return (float)((int)Math.Round((double)((float)((BitConverter.ToInt32(array, 0) - 1073741823) / 100000000 * randomnes / 16)))) + val;
		}

		// Token: 0x06000064 RID: 100
		[DllImport("user32.dll")]
		public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

		// Token: 0x06000065 RID: 101 RVA: 0x0000B6C0 File Offset: 0x000098C0
		private void Smoothing(double delay, double control_time, float x, float y)
		{
			int num = (int)delay - (int)control_time;
			control_time += (double)num;
			int num2 = 0;
			int num3 = 0;
			double num4 = 0.0;
			for (int i = 1; i <= (int)Math.Round(control_time); i++)
			{
				int num5 = i * (int)Math.Round((double)x) / (int)Math.Round(control_time);
				int num6 = i * (int)Math.Round((double)y) / (int)Math.Round(control_time);
				double num7 = (double)i * control_time / control_time;
				Script.mouse_event(1, num5 - num2, num6 - num3, 0, 0);
				this.QuerySleep((int)Math.Floor(num7 - num4));
				num2 = num5;
				num3 = num6;
				num4 = num7;
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000227A File Offset: 0x0000047A
		private void TTS(string toSpeak)
		{
			new Thread(delegate()
			{
				Thread.CurrentThread.IsBackground = true;
				using (SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer())
				{
					speechSynthesizer.Volume = Script.Volume;
					speechSynthesizer.Speak(toSpeak);
					speechSynthesizer.Dispose();
				}
			}).Start();
		}

		// Token: 0x04000071 RID: 113
		public static bool keyless = false;

		// Token: 0x04000072 RID: 114
		public static bool kill = false;

		// Token: 0x04000073 RID: 115
		public static int Volume = 50;

		// Token: 0x04000074 RID: 116
		private bool crouched;

		// Token: 0x04000075 RID: 117
		private int currentwep;
	}
}
