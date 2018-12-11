using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MusicCollection.Main.Tag;
using System.Threading.Tasks;

namespace MusicCollection.Main.Collection
{
	class TrackElement
	{
		public IReadOnlyList<BasicTag> Tags { get; set; }
		public string Name { get; set; }
	}
}
