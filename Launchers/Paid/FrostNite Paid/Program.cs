using System;
using System.Windows.Forms;

namespace FrostNite_Paid
{
	// Token: 0x02000004 RID: 4
	internal static class Program
	{
		// Token: 0x0600000F RID: 15 RVA: 0x000028F1 File Offset: 0x00000AF1
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FrostNite());
		}
	}
}
