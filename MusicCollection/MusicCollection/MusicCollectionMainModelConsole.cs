using MusicCollection.Main.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCollection
{
	class MusicCollectionMainModelConsole
	{
		public MusicCollectionModel MainModel { get; }

		public MusicCollectionMainModelConsole(IMusicCollectionModelBuilder musicCollectionModelBuilder)
		{
			MainModel = musicCollectionModelBuilder.BuildMusicCollectionModel();
		}
	}
}
