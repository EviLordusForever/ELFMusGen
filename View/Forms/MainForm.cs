namespace ELFMusGen
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			openMidiDialog.ShowDialog();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Core.Process();
		}
	}
}