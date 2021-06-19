using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace FrostNite_Paid
{
	// Token: 0x02000003 RID: 3
	public partial class FrostNite : Form
	{
		// Token: 0x0600000A RID: 10 RVA: 0x000024E1 File Offset: 0x000006E1
		public FrostNite()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000024FC File Offset: 0x000006FC
		private void button1_Click(object sender, EventArgs e)
		{
			string text = new WebClient
			{
				Proxy = null
			}.DownloadString("https://keys.yttutortial69.repl.co");
			string text2 = new WebClient
			{
				Proxy = null
			}.DownloadString("https://pastebin.com/raw/uppw7fDh");
			bool flag = text2.Contains(this.textBox1.Text);
			bool flag2 = flag;
			if (flag2)
			{
				MessageBox.Show("Please Enter A Key!");
				Application.Exit();
			}
			bool flag3 = text.Contains(this.textBox1.Text);
			bool flag4 = flag3;
			if (flag4)
			{
				MessageBox.Show("Welcome To FrostNite!");
				Form2 form = new Form2();
				form.Show();
				base.Hide();
			}
			else
			{
				MessageBox.Show("Key Is Incorrect! Please Get A Key From FrostNite discord.gg/ik , .key To Get A Key");
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002092 File Offset: 0x00000292
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}
	}
}
