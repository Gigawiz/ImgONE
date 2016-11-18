using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ImgONE
{
	/// <summary>
	/// Description of frm_About.
	/// </summary>
	public partial class frm_About : Form
	{
		public frm_About()
		{
			InitializeComponent();
		}
		void Btn_githubClick(object sender, System.EventArgs e)
		{
            Process.Start("http://imgone.co");
		}
		void Btn_reportClick(object sender, System.EventArgs e)
		{
            Process.Start("http://webmasterone.com/");
		}
		void Frm_AboutLoad(object sender, System.EventArgs e)
		{
			label_build.Text = "Build: " + Settings.newbuild;
		}
	}
}
