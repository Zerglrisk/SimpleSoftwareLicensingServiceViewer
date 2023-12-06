using SimpleSoftwareLicensingServiceViewer.Core;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleSoftwareLicensingServiceViewer
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			MainForm mainForm = new MainForm();

			IntPtr activeWindow = Win32Api.GetForegroundWindow();
			if (activeWindow != IntPtr.Zero)
			{
				Win32Api.GetWindowRect(activeWindow, out Win32Api.RECT rect);
				Screen activeScreen = Screen.FromRectangle(new Rectangle(rect.Left, rect.Top, rect.Right - rect.Left, rect.Bottom - rect.Top));

				SetFormPosition(mainForm, activeScreen);
			}
			else
			{
				Screen currentScreen = Screen.FromPoint(Cursor.Position);
				SetFormPosition(mainForm, currentScreen);
			}

			Application.Run(mainForm);
		}

		private static void SetFormPosition(Form form, Screen screen)
		{
			form.StartPosition = FormStartPosition.Manual;
			form.Location = new Point(screen.WorkingArea.Left + (screen.WorkingArea.Width - form.Width) / 2, screen.WorkingArea.Top + (screen.WorkingArea.Height - form.Height) / 2);
		}
	}
}