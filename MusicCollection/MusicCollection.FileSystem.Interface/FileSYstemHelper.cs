using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MusicCollection.FileSystem.Interface
{
	public class FileSystemHelper
	{
		public static IReadOnlyList<string> FileFormats { get; private set; } = new List<string>
		{
			".mp4",
			".avi",

			".mp3",
			".flac",
		};
	}
}