using System;
using System.Threading;
using System.Windows.Forms;

namespace ImgONE
{
	internal sealed class Program
	{
		static Mutex mutex;
		
		static Boolean Single_Instance()
	    {
			try
			{
			    Mutex.OpenExisting("ImgONE");
			}
			catch
			{
			    Program.mutex = new Mutex(true, "ImgONE");
			    return true;
			}
			return false;
    	}
		
		[STAThread]
		private static void Main(string[] args)
		{
			if(!Program.Single_Instance()) {
				MessageBox.Show("ImgONE is already running!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new frm_Main());
		}
		
	}
}
