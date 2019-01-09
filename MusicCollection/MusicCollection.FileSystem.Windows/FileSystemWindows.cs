using MusicCollection.FileSystem.Interface;
using System;
using System.IO;
using System.Linq;
using MoreLinq;
using System.Collections.Generic;

namespace MusicCollection.Windows.FileSystem
{
	public class FileSystemWindows : IFIleSystem
	{
		private readonly string _directoryPath = @"D:\test";
		private DirectoryInfo mainDirectory;
		public FileSystemWindows(string directoryPath)
		{
			_directoryPath = directoryPath;
			mainDirectory = new DirectoryInfo(directoryPath);
		}

		public IReadOnlyList<FileForCollectionModel> FilesForCollectionInFolder(string directoryInfo)
		{
			throw new NotImplementedException();
		}

		private IReadOnlyList<FileForCollectionModel> FilesForCollectionInFolderRec(DirectoryInfo directoryInfo,List<string> protoTegs)
		{
			var ret = new List<FileForCollectionModel>{ };

			protoTegs.Add(directoryInfo.Name);

			directoryInfo.GetDirectories().ForEach(d => ret.AddRange(FilesForCollectionInFolderRec(d, protoTegs)));

			ret.AddRange(directoryInfo.GetFiles()
				.Where(f => FileSystemHelper.FileFormats.Where(format => f.Name.LastIndexOf(format) == f.Name.Length - format.Length).Any())
				.Select(f => new FileForCollectionModel { FileInfo = f, ProtoTegs = new List<string>(protoTegs) }));

			protoTegs.RemoveAt(protoTegs.Count - 1);
			return ret;
		}

		public void ShowInerDirtectiry()
		{
			ShowInerDirtectiryRec(mainDirectory, 0);
		}

		private void ShowInerDirtectiryRec(DirectoryInfo directoryInfo, int index)
		{
			Console.WriteLine($"{string.Concat(MoreEnumerable.Generate("\t", (s) => s).Take(index))}{directoryInfo.Name}");
			directoryInfo.GetDirectories().ForEach(d => ShowInerDirtectiryRec(d, index + 1));

			foreach (var f in directoryInfo.GetFiles())
			{
				if (FileSystemHelper.FileFormats.Where(format => f.Name.LastIndexOf(format) == f.Name.Length - format.Length).Any())
				{
					Console.WriteLine($"{string.Concat(MoreEnumerable.Generate("\t", (s) => s).Take(index))}--f: {f}");
				}
			}
		}
	}
}