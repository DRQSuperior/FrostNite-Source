using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

// Token: 0x02000008 RID: 8
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class Resources
{
	// Token: 0x0600001D RID: 29 RVA: 0x0000273E File Offset: 0x0000093E
	internal Resources()
	{
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x0600001E RID: 30 RVA: 0x00002748 File Offset: 0x00000948
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			bool flag = object.ReferenceEquals(Resources.resourceMan, null);
			if (flag)
			{
				ResourceManager resourceManager = new ResourceManager("Resources", typeof(Resources).Assembly);
				Resources.resourceMan = resourceManager;
			}
			return Resources.resourceMan;
		}
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x0600001F RID: 31 RVA: 0x00002790 File Offset: 0x00000990
	// (set) Token: 0x06000020 RID: 32 RVA: 0x000027A7 File Offset: 0x000009A7
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

	// Token: 0x0400000B RID: 11
	private static ResourceManager resourceMan;

	// Token: 0x0400000C RID: 12
	private static CultureInfo resourceCulture;
}
