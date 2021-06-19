namespace FrostNite_Paid
{
	// Token: 0x02000002 RID: 2
	public partial class Form2 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000008 RID: 8 RVA: 0x000020A4 File Offset: 0x000002A4
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

		// Token: 0x06000009 RID: 9 RVA: 0x000020E0 File Offset: 0x000002E0
		private void InitializeComponent()
		{
			this.label1 = new global::System.Windows.Forms.Label();
			this.button3 = new global::System.Windows.Forms.Button();
			this.button4 = new global::System.Windows.Forms.Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI", 36f, global::System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(210, 29);
			this.label1.Name = "label1";
			this.label1.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.label1.Size = new global::System.Drawing.Size(238, 65);
			this.label1.TabIndex = 3;
			this.label1.Text = "FrostNite";
			this.button3.BackColor = global::System.Drawing.Color.FromArgb(113, 54, 252);
			this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.button3.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.button3.ForeColor = global::System.Drawing.Color.White;
			this.button3.Location = new global::System.Drawing.Point(329, 183);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(145, 42);
			this.button3.TabIndex = 6;
			this.button3.Text = "Launch";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.button4.BackColor = global::System.Drawing.Color.FromArgb(113, 54, 252);
			this.button4.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.button4.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.button4.ForeColor = global::System.Drawing.Color.White;
			this.button4.Location = new global::System.Drawing.Point(178, 183);
			this.button4.Name = "button4";
			this.button4.Size = new global::System.Drawing.Size(145, 42);
			this.button4.TabIndex = 7;
			this.button4.Text = "Inject";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new global::System.EventHandler(this.button4_Click_1);
			this.pictureBox1.Image = global::FrostNite_Paid.Properties.Resources.discord_icon_png_1;
			this.pictureBox1.Location = new global::System.Drawing.Point(607, 260);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(41, 36);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new global::System.EventHandler(this.pictureBox1_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(10, 24, 74);
			base.ClientSize = new global::System.Drawing.Size(660, 308);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.label1);
			base.MaximizeBox = false;
			base.Name = "Form2";
			this.Text = "FrostNite";
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000001 RID: 1
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000002 RID: 2
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000003 RID: 3
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.Button button4;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.PictureBox pictureBox1;
	}
}
