using MusicCollection.Windows.FileSystem.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCollection
{
	class Program
	{
		static void Main(string[] args)
		{
			var builder = new WindowsMusicCollectionModelBuilder();
			var consoleModel = new MusicCollectionMainModelConsole(builder);

			Console.WriteLine("Tags");
			foreach(var t in consoleModel.MainModel.MainTagManager.Tags)
			{
				Console.WriteLine($"{t.guid} {t.Name}");
			}

			Console.WriteLine("--------------------------------------------");

			Console.WriteLine("Tracks");
			foreach (var tr in consoleModel.MainModel.MainTrackManager.Tracks)
			{
				Console.WriteLine($"{tr.Name} {string.Concat(tr.Tags.Select(t=>t.Name))}");
			}
		}
	}
}
