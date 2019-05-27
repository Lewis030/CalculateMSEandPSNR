using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateMSEandPSNR
{
	public partial class Form1 : Form
	{
		Bitmap originalPict;
		Bitmap changedPict;

		public Form1()
		{
			InitializeComponent();
		}

		public void GetPSNR(Bitmap originalImage, Bitmap markedImage)
		{
			int width = originalImage.Width, height = originalImage.Height;
			double psnr = 0;
			double mse = 0;
			double mseR = 0;
			double mseG = 0;
			double mseB = 0;
			double rmse = 0;

			for (int x = 0; x < width; x++)
			{
				for (int y = 0; y < height; y++)
				{
					mseR = mseR + ((markedImage.GetPixel(x, y).R - originalImage.GetPixel(x, y).R) * (markedImage.GetPixel(x, y).R - originalImage.GetPixel(x, y).R));
					mseG = mseG + ((markedImage.GetPixel(x, y).G - originalImage.GetPixel(x, y).G) * (markedImage.GetPixel(x, y).G - originalImage.GetPixel(x, y).G));
					mseB = mseB + ((markedImage.GetPixel(x, y).B - originalImage.GetPixel(x, y).B) * (markedImage.GetPixel(x, y).B - originalImage.GetPixel(x, y).B));
				}
			}

			mse = (1.0 / (3 * width * height)) * (mseR + mseG + mseB);
			
			rmse = Math.Sqrt(mse);
			
			psnr = 10 * Math.Log10((Math.Pow(255, 2)) / mse);

			rtbMetrics.Text = "MSE = " + mse.ToString() +"\n" + "RMSE = " + rmse.ToString() + "\n" + "PSNR = " + psnr.ToString(); 

		}

		private void button1_Click(object sender, EventArgs e)
		{
			using (var openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "Images(*.jpg; *.jpeg;)|*.jpg; *jpeg; |All files(*.*)|*.*";

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					try
					{
						originalPict = new Bitmap(openFileDialog.FileName);
						pictureBox1.Image = originalPict;
					}
					catch
					{
						MessageBox.Show("Unable to open file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			using (var openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "Images(*.jpg; *.jpeg;)|*.jpg; *jpeg; |All files(*.*)|*.*";

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					try
					{
						changedPict = new Bitmap(openFileDialog.FileName);
						pictureBox2.Image = changedPict;
					}
					catch
					{
						MessageBox.Show("Невозможно открыть файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			GetPSNR(originalPict, changedPict);
		}
	}
}
