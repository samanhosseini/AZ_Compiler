namespace AZ_kampayler
{
	public partial class Form1 : System.Windows.Forms.Form
	{
		public Form1()
		{
			InitializeComponent();
		}


		public void button_Click_TahlilLoghavi(object sender, System.EventArgs e)
		{

			//string path = @"C:\Users\Saman\Desktop\AZ kampayler\Notepad files\lexical analyzer.txt";
			//textBox1.Text = System.IO.File.ReadAllText(path);
			textBox1.Text = Properties.Resources.lexical_analyzer;
		}

		private void button_Click_TahlilNahvi(object sender, System.EventArgs e)
		{
			//string path = @"C:\Users\Saman\Desktop\AZ kampayler\Notepad files\Tahlil nahvii.txt";
			//textBox1.Text = System.IO.File.ReadAllText(path);
			textBox1.Text = Properties.Resources.Tahlil_nahvii;

			System.Windows.Forms.Button btnSender = (System.Windows.Forms.Button)sender;
			System.Drawing.Point ptLowerLeft = new System.Drawing.Point(-94, btnSender.Height);
			ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
			contextMenuStrip1.Show(ptLowerLeft);
		}

		private void button_Click_TahlilManaii(object sender, System.EventArgs e)
		{
			textBox1.Clear();

			System.Windows.Forms.Button btnSender = (System.Windows.Forms.Button)sender;
			System.Drawing.Point ptLowerLeft = new System.Drawing.Point(-67, btnSender.Height);
			ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
			contextMenuStrip2.Show(ptLowerLeft);
		}

		private void button_Click_Tolid_Code_Miani(object sender, System.EventArgs e)
		{
			//string path = @"C:\Users\Saman\Desktop\AZ kampayler\Notepad files\Tolid code mianii.txt";
			//textBox1.Text = System.IO.File.ReadAllText(path);
			textBox1.Text = Properties.Resources.Tolid_code_mianii;
		}

		private void button_Click_Behinesazi_Code_Miani(object sender, System.EventArgs e)
		{
			//string path = @"C:\Users\Saman\Desktop\AZ kampayler\Notepad files\optimization.txt";
			//textBox1.Text = System.IO.File.ReadAllText(path);
			textBox1.Text = Properties.Resources.optimization;
		}

		private void button_Click_Tolid_Code_Nahai(object sender, System.EventArgs e)
		{
			//string path = @"C:\Users\Saman\Desktop\AZ kampayler\Notepad files\Tolid code nahaii.txt";
			//textBox1.Text = System.IO.File.ReadAllText(path);
			textBox1.Text = Properties.Resources.Tolid_code_nahaii;
		}

		private void button_Click_Exit(object sender, System.EventArgs e)
		{
			Form3 frm = new Form3();
			frm.ShowDialog();
		}

		#region DerakhtTajzie(TahlilNahvi)
		private void elseIfToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			Form2 frm2 = new Form2();
			frm2.DisplayImage1();
			frm2.ShowDialog();
		}

		private void eachToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			Form2 frm2 = new Form2();
			frm2.DisplayImage2();
			frm2.ShowDialog();
		}

		private void intMainToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			Form2 frm2 = new Form2();
			frm2.DisplayImage3();
			frm2.ShowDialog();
		}

		private void intAbcToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			Form2 frm2 = new Form2();
			frm2.DisplayImage4();
			frm2.ShowDialog();
		}

		private void coutenterNumberAToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			Form2 frm2 = new Form2();
			frm2.DisplayImage5();
			frm2.ShowDialog();
		}

		private void cinAToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			Form2 frm2 = new Form2();
			frm2.DisplayImage6();
			frm2.ShowDialog();
		}

		private void coutenterNumberBToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			Form2 frm2 = new Form2();
			frm2.DisplayImage7();
			frm2.ShowDialog();
		}

		private void cinBToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			Form2 frm2 = new Form2();
			frm2.DisplayImage8();
			frm2.ShowDialog();
		}

		private void coutenterNuToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			Form2 frm2 = new Form2();
			frm2.DisplayImage9();
			frm2.ShowDialog();
		}

		private void cinCToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			Form2 frm2 = new Form2();
			frm2.DisplayImage10();
			frm2.ShowDialog();
		}

		private void ifaaBbCcToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			Form2 frm2 = new Form2();
			frm2.DisplayImage11();
			frm2.ShowDialog();
		}

		private void coutrightAngleToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			Form2 frm2 = new Form2();
			frm2.DisplayImage13();
			frm2.ShowDialog();
		}

		private void elseIfbbAaCcToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			Form2 frm2 = new Form2();
			frm2.DisplayImage14();
			frm2.ShowDialog();
		}

		private void toolStripMenuItem1_Click(object sender, System.EventArgs e)
		{
			Form2 frm2 = new Form2();
			frm2.DisplayImage13();
			frm2.ShowDialog();
		}

		private void elseIfccAaBbToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			Form2 frm2 = new Form2();
			frm2.DisplayImage14();
			frm2.ShowDialog();
		}

		private void coutrightAngleToolStripMenuItem1_Click(object sender, System.EventArgs e)
		{
			Form2 frm2 = new Form2();
			frm2.DisplayImage13();
			frm2.ShowDialog();
		}

		private void elseCoutnotRightAngleToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			Form2 frm2 = new Form2();
			frm2.DisplayImage17();
			frm2.ShowDialog();
		}

		private void getchToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			Form2 frm2 = new Form2();
			frm2.DisplayImage18();
			frm2.ShowDialog();
		}

		private void return0ToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			Form2 frm2 = new Form2();
			frm2.DisplayImage19();
			frm2.ShowDialog();
		}
		#endregion

		#region DerakhtTajzie(TahlilManai)
		private void toolStripMenuItem12_Click(object sender, System.EventArgs e)
		{
			Form2 frm2 = new Form2();
			frm2.DisplayImage20();
			frm2.ShowDialog();
		}

		private void toolStripMenuItem14_Click(object sender, System.EventArgs e)
		{
			Form2 frm2 = new Form2();
			frm2.DisplayImage21();
			frm2.ShowDialog();
		}

		private void toolStripMenuItem16_Click(object sender, System.EventArgs e)
		{
			Form2 frm2 = new Form2();
			frm2.DisplayImage22();
			frm2.ShowDialog();
		}
		#endregion

		
	}

}
