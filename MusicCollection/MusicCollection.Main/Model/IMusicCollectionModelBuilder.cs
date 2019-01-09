using MusicCollection.FileSystem.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCollection.Main.Model
{
	public interface IMusicCollectionModelBuilder
	{
		MusicCollectionModel BuildMusicCollectionModel();
		MusicCollectionModel BuildMusicCollectionFromDirectory(IFIleSystem fileSystem,string folder);
	}
}
