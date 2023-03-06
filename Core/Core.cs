using Melanchall.DryWetMidi;
using Melanchall.DryWetMidi.Common;
using Melanchall.DryWetMidi.Multimedia;
using Melanchall.DryWetMidi.Core;
using Library;

namespace ELFMusGen
{
	public static class Core
	{
		public static void Process()
		{
			string[] files = Disk2.GetFilesFromProgramFiles("MIDIS");
			for (int i = 0; i < files.Length; i++)
			{
				var m = MidiManager.Read(files[i]);
			}
		}
	}
}
