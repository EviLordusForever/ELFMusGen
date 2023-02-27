namespace ELFMusGen
{
	public static class FormsManager
	{
		public static Form _mainForm;

		public static Form _showForm;

		public static void ShowImage(Image img)
		{
			ShowImage((Bitmap)img);
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
