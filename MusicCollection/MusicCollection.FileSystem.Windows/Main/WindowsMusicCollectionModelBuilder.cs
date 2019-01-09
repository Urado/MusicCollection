using MusicCollection.FileSystem.Interface;
using MusicCollection.Main.Collection;
using MusicCollection.Main.Model;
using MusicCollection.Main.Tag;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MusicCollection.Windows.FileSystem.Main
{
	public class WindowsMusicCollectionModelBuilder : IMusicCollectionModelBuilder
	{
		public MusicCollectionModel BuildMusicCollectionFromDirectory(IFIleSystem fileSystem, string folder)
		{
			
		}

		public MusicCollectionModel BuildMusicCollectionModel()
		{
			var tagManager = new TagManager { Tags = new List<BasicTag> { } };
			var trackManager = new TrackManager { Tracks = new List<TrackElement> { new TrackElement { Name = "First", Tags = new List<BasicTag>() } } };
			return new MusicCollectionModel { MainTagManager = tagManager, MainTrackManager = trackManager };
		}
	}
}