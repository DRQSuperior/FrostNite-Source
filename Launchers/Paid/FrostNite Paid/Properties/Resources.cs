using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace FrostNite_Paid.Properties
{
	// Token: 0x02000005 RID: 5
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000010 RID: 16 RVA: 0x0000290C File Offset: 0x00000B0C
		internal Resources()
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002918 File Offset: 0x00000B18
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				bool flag2 = flag;
				if (flag2)
				{
					ResourceManager resourceManager = new ResourceManager("FrostNite_Paid.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00002960 File Offset: 0x00000B60
		// (set) Token: 0x06000013 RID: 19 RVA: 0x00002977 File Offset: 0x00000B77
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002980 File Offset: 0x00000B80
		internal static Bitmap discord_icon_png_1
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("discord-icon-png-1", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x0400000A RID: 10
		private static ResourceManager resourceMan;

		// Token: 0x0400000B RID: 11
		private static CultureInfo resourceCulture;
	}
}
