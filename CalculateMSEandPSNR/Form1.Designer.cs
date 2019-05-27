namespace CalculateMSEandPSNR
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.btnOpenFirstImage = new System.Windows.Forms.Button();
			this.btnOpenSecondImage = new System.Windows.Forms.Button();
			this.btnCompareImage = new System.Windows.Forms.Button();
			this.rtbMetrics = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(358, 210);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(417, 12);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(371, 210);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// btnOpenFirstImage
			// 
			this.btnOpenFirstImage.Location = new System.Drawing.Point(12, 228);
			this.btnOpenFirstImage.Name = "btnOpenFirstImage";
			this.btnOpenFirstImage.Size = new System.Drawing.Size(93, 23);
			this.btnOpenFirstImage.TabIndex = 2;
			this.btnOpenFirstImage.Text = "Open 1st Image";
			this.btnOpenFirstImage.UseVisualStyleBackColor = true;
			this.btnOpenFirstImage.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnOpenSecondImage
			// 
			this.btnOpenSecondImage.Location = new System.Drawing.Point(417, 228);
			this.btnOpenSecondImage.Name = "btnOpenSecondImage";
			this.btnOpenSecondImage.Size = new System.Drawing.Size(94, 23);
			this.btnOpenSecondImage.TabIndex = 3;
			this.btnOpenSecondImage.Text = "Open 2nd Image";
			this.btnOpenSecondImage.UseVisualStyleBackColor = true;
			this.btnOpenSecondImage.Click += new System.EventHandler(this.button2_Click);
			// 
			// btnCompareImage
			// 
			this.btnCompareImage.Location = new System.Drawing.Point(12, 307);
			this.btnCompareImage.Name = "btnCompareImage";
			this.btnCompareImage.Size = new System.Drawing.Size(93, 23);
			this.btnCompareImage.TabIndex = 4;
			this.btnCompareImage.Text = "Compare Image";
			this.btnCompareImage.UseVisualStyleBackColor = true;
			this.btnCompareImage.Click += new System.EventHandler(this.button3_Click);
			// 
			// rtbMetrics
			// 
			this.rtbMetrics.Location = new System.Drawing.Point(161, 307);
			this.rtbMetrics.Name = "rtbMetrics";
			this.rtbMetrics.Size = new System.Drawing.Size(162, 101);
			this.rtbMetrics.TabIndex = 10;
			this.rtbMetrics.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.rtbMetrics);
			this.Controls.Add(this.btnCompareImage);
			this.Controls.Add(this.btnOpenSecondImage);
			this.Controls.Add(this.btnOpenFirstImage);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Form1";
			this.Text = "Metrics";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button btnOpenFirstImage;
		private System.Windows.Forms.Button btnOpenSecondImage;
		private System.Windows.Forms.Button btnCompareImage;
		private System.Windows.Forms.RichTextBox rtbMetrics;
	}
}

