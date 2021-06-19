namespace FrostNite_Paid
{
	// Token: 0x02000003 RID: 3
	public partial class FrostNite : global::System.Windows.Forms.Form
	{
		// Token: 0x0600000D RID: 13 RVA: 0x000025B4 File Offset: 0x000007B4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			bool flag2 = flag;
			if (flag2)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000025F0 File Offset: 0x000007F0
		private void InitializeComponent()
		{
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.textBox1.Font = new global::System.Drawing.Font("Segoe UI", 8f, global::System.Drawing.FontStyle.Bold);
			this.textBox1.Location = new global::System.Drawing.Point(24, 246);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(416, 31);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "Key";
			this.textBox1.TextChanged += new global::System.EventHandler(this.textBox1_TextChanged);
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(113, 54, 252);
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Location = new global::System.Drawing.Point(479, 232);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(163, 45);
			this.button1.TabIndex = 1;
			this.button1.Text = "Enter";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI", 36f, global::System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(222, 45);
			this.label1.Name = "label1";
			this.label1.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.label1.Size = new global::System.Drawing.Size(238, 65);
			this.label1.TabIndex = 2;
			this.label1.Text = "FrostNite";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(10, 24, 74);
			base.ClientSize = new global::System.Drawing.Size(667, 302);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.textBox1);
			base.MaximizeBox = false;
			base.Name = "FrostNite";
			this.Text = "FrostNite";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000006 RID: 6
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.Label label1;
	}
}
