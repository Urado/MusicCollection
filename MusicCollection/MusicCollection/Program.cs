using MusicCollection.Windows.FileSystem.Main;
using MusicCollection.Windows.FileSystem;
using System;
using System.IO;
using System.Linq;

namespace MusicCollection
{
	class Program
	{
		static readonly string directoryPath = @"D:\torrent";
		static void Main(string[] args)
		{
			//var builder = new WindowsMusicCollectionModelBuilder();
			//var consoleModel = new MusicCollectionMainModelConsole(builder);

			//Console.WriteLine("Tags");
			//foreach(var t in consoleModel.MainModel.MainTagManager.Tags)
			//{
			//	Console.WriteLine($"{t.guid} {t.Name}");
			//}

			//Console.WriteLine("--------------------------------------------");

			//Console.WriteLine("Tracks");
			//foreach (var tr in consoleModel.MainModel.MainTrackManager.Tracks)
			//{
			//	Console.WriteLine($"{tr.Name} {string.Concat(tr.Tags.Select(t=>t.Name))}");
			//}

			var fileSystem = new FileSystemWindows(directoryPath);
			fileSystem.ShowInerDirtectiry();
		}
	}
}
