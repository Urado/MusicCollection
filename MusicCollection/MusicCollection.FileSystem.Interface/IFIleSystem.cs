﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCollection.FileSystem.Interface
{
	public interface IFIleSystem
	{
		IReadOnlyList<FileForCollectionModel> FilesForCollectionInFolder(string directoryInfo);
	}
}
