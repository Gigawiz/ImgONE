using System;
using System.Windows.Forms;
using System.IO;

namespace ImgONE
{
	public partial class frm_Preferences : Form
	{
		
		public frm_Preferences()
		{
			InitializeComponent();
		}
		
		void Frm_PreferencesLoad(object sender, EventArgs e)
		{
			check_save_screenshots.Checked 		= Settings.save_screenshots;
			txt_save_folder.Text 				= Settings.save_folder;
			drop_save_format.Text 				= Settings.save_format;
			drop_save_quality.Text 				= Settings.save_quality.ToString();
			
			drop_upload_method.Text 			= Settings.upload_method;
			drop_upload_format.Text 			= Settings.upload_format;

            if (Settings.upload_method == "FTP Server")
            {
                try
                {
                    textBox4.Text = Settings.ftp_website_url;
                    textBox8.Text = Settings.ftp_server;
                    textBox5.Text = Settings.ftp_username;
                    textBox6.Text = CryptorEngine.Decrypt(Settings.ftp_password);
                    textBox7.Text = Settings.ftp_path;
                }
                catch
                {
                }
            }

			check_run_at_startup.Checked 		= Global_Func.reg_key.GetValue("Hyperdesktop2") != null;
			check_copy_links.Checked 			= Settings.copy_links_to_clipboard;
			check_sound_effects.Checked			= Settings.sound_effects;
			check_show_cursor.Checked			= Settings.show_cursor;
			check_balloon.Checked 				= Settings.balloon_messages;
			check_launch_browser.Checked 		= Settings.launch_browser;
			check_edit_screenshot.Checked 		= Settings.edit_screenshot;
		
			numeric_top.Minimum = -50000;
			numeric_left.Minimum = -50000;
			numeric_width.Minimum = -50000;
			numeric_height.Minimum = -50000;
			
			try {
                String[] screen_res = Settings.screen_res.Split(',');
				numeric_left.Value = Convert.ToDecimal(screen_res[0]);
				numeric_top.Value = Convert.ToDecimal(screen_res[1]);
				numeric_width.Value = Convert.ToDecimal(screen_res[2]);
				numeric_height.Value = Convert.ToDecimal(screen_res[3]);
			} catch {
				btn_reset_screen.PerformClick();
			}
		}
		
		#region Save & Cancel
		void Btn_saveClick(object sender, EventArgs e)
		{
			// Screen resolution
			Settings.screen_res 				= Settings.screen_res = String.Format(
				"{0},{1},{2},{3}",
				numeric_left.Value,
				numeric_top.Value,
				numeric_width.Value,
				numeric_height.Value
			);

            Screen_Bounds.load();
			
			Settings.save_screenshots 			= check_save_screenshots.Checked;
			Settings.save_folder 				= txt_save_folder.Text;
			Settings.save_format 				= drop_save_format.Text;
			Settings.save_quality 				= Convert.ToInt16(drop_save_quality.Text);
			
			Settings.upload_method 				= drop_upload_method.Text;
			Settings.upload_format 				= drop_upload_format.Text;

            Settings.ftp_website_url = textBox4.Text.TrimEnd(Path.DirectorySeparatorChar);
            Settings.ftp_server = textBox8.Text;
            Settings.ftp_username = textBox5.Text;
            Settings.ftp_password = CryptorEngine.Encrypt(textBox6.Text);
            Settings.ftp_path = textBox7.Text.TrimEnd(Path.DirectorySeparatorChar);

			
			Settings.copy_links_to_clipboard 	= check_copy_links.Checked;
			Settings.sound_effects 				= check_sound_effects.Checked;
			Settings.show_cursor 				= check_show_cursor.Checked;
			Settings.balloon_messages 			= check_balloon.Checked;
			Settings.launch_browser 			= check_launch_browser.Checked;
			Settings.edit_screenshot 			= check_edit_screenshot.Checked;
			
			Settings.write_settings();
			Global_Func.run_at_startup(check_run_at_startup.Checked);
			Dispose();
		}
		void Btn_cancelClick(object sender, EventArgs e)
		{
			Dispose();
		}
		#endregion
		
		#region General
		void Check_save_screenshotsCheckedChanged(object sender, EventArgs e)
		{
			txt_save_folder.Enabled 		= check_save_screenshots.Checked;
			btn_browse_save_folder.Enabled 	= check_save_screenshots.Checked;
			drop_save_format.Enabled 		= check_save_screenshots.Checked;
			drop_save_quality.Enabled 		= check_save_screenshots.Checked;
		}
		void Btn_browse_save_folderClick(object sender, EventArgs e)
		{
			var browse_folder = new FolderBrowserDialog();
			if (browse_folder.ShowDialog() == DialogResult.OK)
			    txt_save_folder.Text = browse_folder.SelectedPath;
		}
		void Btn_reset_screenClick(object sender, System.EventArgs e)
		{
            String[] screen_res = Screen_Bounds.reset().Split(',');
            numeric_left.Value = Convert.ToDecimal(screen_res[0]);
			numeric_top.Value = Convert.ToDecimal(screen_res[1]);
			numeric_width.Value = Convert.ToDecimal(screen_res[2]);
			numeric_height.Value = Convert.ToDecimal(screen_res[3]);
		}
		#endregion

        private void drop_upload_method_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drop_upload_method.Text == "FTP Server")
            {
                label1.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
            }
            else
            {
                label1.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
                textBox8.Visible = false;
            }
        }
	}
}
