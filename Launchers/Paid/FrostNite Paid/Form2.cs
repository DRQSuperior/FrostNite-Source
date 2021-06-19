using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using FrostNite_Paid.Properties;

namespace FrostNite_Paid
{
	// Token: 0x02000002 RID: 2
	public partial class Form2 : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public Form2()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002068 File Offset: 0x00000268
		private void button1_Click(object sender, EventArgs e)
		{
			Process.Start("run.bat");
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002076 File Offset: 0x00000276
		private void button2_Click(object sender, EventArgs e)
		{
			Process.Start("FrostNiteInjector.exe");
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002084 File Offset: 0x00000284
		private void button3_Click(object sender, EventArgs e)
		{
			Process.Start("Frostniteonlaunch.exe");
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002092 File Offset: 0x00000292
		private void button4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002076 File Offset: 0x00000276
		private void button4_Click_1(object sender, EventArgs e)
		{
			Process.Start("FrostNiteInjector.exe");
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002095 File Offset: 0x00000295
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Process.Start("https://dsc.gg/daardev");
		}
	}
}
