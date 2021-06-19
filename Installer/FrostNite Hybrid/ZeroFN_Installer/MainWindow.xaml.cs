using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Markup;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;

namespace ZeroFN_Installer
{
	// Token: 0x02000007 RID: 7
	[DesignerGenerated]
	public partial class MainWindow : Window
	{
		// Token: 0x0600000F RID: 15 RVA: 0x00002191 File Offset: 0x00000391
		public MainWindow()
		{
			this.win64 = "/FortniteGame/Binaries/Win64/";
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000021A8 File Offset: 0x000003A8
		private void Closefn(object sender, RoutedEventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName("Fortnitelauncher");
			int num = 0;
			checked
			{
				do
				{
					processesByName[num].Kill();
					num++;
				}
				while (num < processesByName.Length);
				processesByName = Process.GetProcessesByName("FortniteClient-Win64-Shipping_EAC");
				num = 0;
				do
				{
					processesByName[num].Kill();
					num++;
				}
				while (num < processesByName.Length);
				processesByName = Process.GetProcessesByName("FortniteClient-Win64-Shipping");
				num = 0;
				do
				{
					processesByName[num].Kill();
					num++;
				}
				while (num < processesByName.Length);
				processesByName = Process.GetProcessesByName("FortniteClient-Win64-Shipping_BE");
				num = 0;
				do
				{
					processesByName[num].Kill();
					num++;
				}
				while (num < processesByName.Length);
				System.Windows.MessageBox.Show("Fortnite was killed!", "FrostNite Hybrid");
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002262 File Offset: 0x00000462
		private void Discord(object sender, RoutedEventArgs e)
		{
			Process.Start("https://dsc.gg/daardev");
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002270 File Offset: 0x00000470
		private void Find(object sender, RoutedEventArgs e)
		{
			try
			{
				System.Windows.Controls.TextBox crpt = this.crpt;
				MainWindow.Installation installation = MainWindow.GetEpicInstallLocations().FirstOrDefault((MainWindow._Closure$__.$I7-0 == null) ? (MainWindow._Closure$__.$I7-0 = ((MainWindow.Installation i) => Operators.CompareString(i.AppName, "Fortnite", false) == 0)) : MainWindow._Closure$__.$I7-0);
				bool flag = installation != null;
				string text;
				if (flag)
				{
					text = installation.InstallLocation;
				}
				else
				{
					text = null;
				}
				crpt.Text = text;
				MainWindow.Installation installation2 = MainWindow.GetEpicInstallLocations().FirstOrDefault((MainWindow._Closure$__.$I7-1 == null) ? (MainWindow._Closure$__.$I7-1 = ((MainWindow.Installation i) => Operators.CompareString(i.AppName, "Fortnite", false) == 0)) : MainWindow._Closure$__.$I7-1);
				bool flag2 = installation2 != null;
				string text2;
				if (flag2)
				{
					text2 = installation2.InstallLocation;
				}
				else
				{
					text2 = null;
				}
				MainWindow.fnpath = text2;
			}
			catch (Exception ex)
			{
				System.Windows.MessageBox.Show("You need to have Fortnite Installed using Epic Games to auto find Path!", "FrostNite Hybrid");
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002358 File Offset: 0x00000558
		public static List<MainWindow.Installation> GetEpicInstallLocations()
		{
			string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Epic\\UnrealEngineLauncher\\LauncherInstalled.dat");
			bool flag = !Directory.Exists(Path.GetDirectoryName(path)) || !File.Exists(path);
			List<MainWindow.Installation> result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = JsonConvert.DeserializeObject<MainWindow.EpicInstallLocations>(File.ReadAllText(path)).InstallationList;
			}
			return result;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000023B0 File Offset: 0x000005B0
		private void Install(object sender, RoutedEventArgs e)
		{
			WebClient webClient = new WebClient();
			try
			{
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/853354403317678120/854464930080882700/FortniteClient-Win64-Shipping_BE.exe", MainWindow.fnpath + this.win64 + "FortniteClient-Win64-Shipping_BE.exe");
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/853354403317678120/854464931310600203/FortniteClient-Win64-Shipping_EAC.exe", MainWindow.fnpath + this.win64 + "FortniteClient-Win64-Shipping_EAC.exe");
				System.Windows.MessageBox.Show("FrostNite Hybrid was Installed!", "FrostNite Hybrid");
			}
			catch (Exception ex)
			{
				Process[] processesByName = Process.GetProcessesByName("FortniteClient-Win64-Shipping_BE");
				bool flag = Process.GetProcessesByName("FortniteClient-Win64-Shipping_EAC").Length != 0 || processesByName.Length != 0;
				if (flag)
				{
					System.Windows.MessageBox.Show("Please kill Fortnite before Installing!", "FrostNite Hybrid");
				}
				else
				{
					System.Windows.MessageBox.Show("Please choose your correct Fortnite Path!", "FrostNite Hybrid");
				}
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002484 File Offset: 0x00000684
		private void Launch(object sender, RoutedEventArgs e)
		{
			try
			{
				Process.Start("com.epicgames.launcher://apps/Fortnite?action=launch&silent=true");
			}
			catch (Exception ex)
			{
				System.Windows.MessageBox.Show("You need to have Fortnite Installed using Epic Games to use FrostNite Hybrid", "FrostNite Hybrid");
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000024D0 File Offset: 0x000006D0
		private void Selectpath(object sender, RoutedEventArgs e)
		{
			try
			{
				FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
				bool flag = folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK;
				if (flag)
				{
					MainWindow.fnpath = folderBrowserDialog.SelectedPath;
					this.crpt.Text = MainWindow.fnpath;
				}
			}
			catch (Exception ex)
			{
				System.Windows.MessageBox.Show("Uhm... you do not seem to have Windows Explorer installed.", "FrostNite Hybrid");
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002540 File Offset: 0x00000740
		private void Uninstall(object sender, RoutedEventArgs e)
		{
			Process.Start("FrostNiteInjector.bat");
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002550 File Offset: 0x00000750
		private void Update(object sender, RoutedEventArgs e)
		{
			WebClient webClient = new WebClient();
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/850285134229012530/850389885289365544/Zero.rar", Path.GetTempPath() + "Zero.rar");
			ZipFile.ExtractToDirectory(Path.GetTempPath() + "Zero.rar", Path.GetTempPath());
			File.Move(Path.GetTempPath() + "FrostNite Hybrid.exe", Directory.GetCurrentDirectory() + "newInstaller.exe");
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000019 RID: 25 RVA: 0x000025BD File Offset: 0x000007BD
		// (set) Token: 0x0600001A RID: 26 RVA: 0x000025C7 File Offset: 0x000007C7
		internal virtual System.Windows.Controls.TextBox crpt { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x04000006 RID: 6
		public static string fnpath = "E";

		// Token: 0x04000007 RID: 7
		private string win64;

		// Token: 0x04000008 RID: 8
		public static string fnconfig = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "/FortniteGame/Saved/Config/WindowsClient/GameUserSettings.ini";

		// Token: 0x0200000B RID: 11
		public class EpicInstallLocations
		{
			// Token: 0x1700000A RID: 10
			// (get) Token: 0x0600002A RID: 42 RVA: 0x00002882 File Offset: 0x00000A82
			// (set) Token: 0x0600002B RID: 43 RVA: 0x0000288C File Offset: 0x00000A8C
			[JsonProperty("InstallationList")]
			public List<MainWindow.Installation> InstallationList { get; set; }
		}

		// Token: 0x0200000C RID: 12
		public class Installation
		{
			// Token: 0x1700000B RID: 11
			// (get) Token: 0x0600002D RID: 45 RVA: 0x00002895 File Offset: 0x00000A95
			// (set) Token: 0x0600002E RID: 46 RVA: 0x0000289F File Offset: 0x00000A9F
			[JsonProperty("AppName")]
			public string AppName { get; set; }

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x0600002F RID: 47 RVA: 0x000028A8 File Offset: 0x00000AA8
			// (set) Token: 0x06000030 RID: 48 RVA: 0x000028B2 File Offset: 0x00000AB2
			[JsonProperty("InstallLocation")]
			public string InstallLocation { get; set; }
		}
	}
}
