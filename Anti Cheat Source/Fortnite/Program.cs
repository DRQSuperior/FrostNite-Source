using System;
using System.Diagnostics;

namespace Fortnite
{
	// Token: 0x02000002 RID: 2
	internal class Program
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002048 File Offset: 0x00000248
		private static void Main(string[] args)
		{
			Console.Title = "FrostNite Hybrid";
			string str = string.Empty;
			string text = string.Empty;
			foreach (string text2 in args)
			{
				bool flag = text2.Contains("-epicusername=");
				bool flag2 = flag;
				bool flag3 = flag2;
				bool flag4 = flag3;
				if (flag4)
				{
					str = text2.Replace("-epicusername=", "");
				}
				text = text + text2 + " ";
			}
			Console.WriteLine("Loading FrostNite" + str);
			Console.WriteLine("Finding A Slot At FrostNite Servers");
			Console.WriteLine("Slot Found!");
			Console.WriteLine("FrostNite Has Been Loaded");
			Process.Start("FortniteClient-Win64-Shipping.exe", text);
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				bool flag5 = process.ProcessName.Contains("FortniteClient-Win64-Shipping");
				bool flag6 = flag5;
				bool flag7 = flag6;
				bool flag8 = flag7;
				if (flag8)
				{
					Console.WriteLine("FrostNite Has Been Launched");
					break;
				}
			}
			Console.Read();
		}
	}
}
