using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MusicCollection.FileSystem.Interface
{
	public class FileForCollectionModel
	{
		public IReadOnlyList<string> ProtoTegs{ get; set; }
		public FileInfo FileInfo { get; set; }
	}
}