namespace ELFMusGen
{
	public static class FormsManager
	{
		public static MainForm _mainForm;
		public static Form _showForm;
		public static LogForm _logForm;

		public static void ShowImage(Image img)
		{
			ShowImage((Bitmap)img);
		}

		public static void OpenLogForm()
		{
			_mainForm.Invoke(new Action(() =>
			{
				if (_logForm == null || _logForm.IsDisposed)
				{
					_logForm = new LogForm();
					_logForm.BringToFront();
					_logForm.Show();
					_logForm.WindowState = FormWindowState.Normal;
					_logForm.Location = new Point(-7, 0);
					_logForm.rtb.ForeColor = Color.FromArgb(0, 255, 0);
				}
			}));
		}

		public static void ShowImage(Bitmap bmp)
		{
/*			if (_showForm == null || _showForm.IsDisposed)
				OpenForm("aboba");*/

			Bitmap bmp0 = Library.Graphics2.RescaleBitmap(bmp, _showForm.ClientSize.Width, _showForm.ClientSize.Height);

			_mainForm.Invoke(new Action(() =>
			{
				_showForm.BackgroundImage = bmp0;
			}));
		}

		public static void SetShowFormSize(int w, int h)
		{
			_mainForm.Invoke(new Action(() =>
			{
				_showForm.Size = new Size(w, h);
			}));
		}

		public static void HideForm(Form form)
		{
			_mainForm.Invoke(new Action(() =>
			{
				form.Hide();
			}));
		}

		public static void CloseForm(Form form)
		{
			_mainForm.Invoke(new Action(() =>
			{
				form.Close();
			}));
		}

		public static void BringToFrontForm(Form form)
		{
			_mainForm.Invoke(new Action(() =>
			{
				form.BringToFront();
			}));
		}

		public static void UnhideForm(Form form)
		{
			_mainForm.Invoke(new Action(() =>
			{
				form.Show();
			}));
		}

		public static void MoveFormToCenter(Form form)
		{
			_mainForm.Invoke(new Action(() =>
			{
				Rectangle bounds = Screen.PrimaryScreen.Bounds;
				form.Location = new Point((bounds.Width - form.Width)/2, (bounds.Height - form.Height) / 2);
			}));
		}

		public static void MoveFormToCenterX(Form form)
		{
			_mainForm.Invoke(new Action(() =>
			{
				Rectangle bounds = Screen.PrimaryScreen.Bounds;
				form.Location = new Point((bounds.Width - form.Width) / 2, 0);
			}));
		}
	}
}