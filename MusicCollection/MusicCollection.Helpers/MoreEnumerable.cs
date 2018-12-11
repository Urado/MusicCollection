using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MusicCollection.Helpers
{
	public static class MoreEnumerable
	{
		public static IReadOnlyList<T> ToReadOnlyList<T>(this IEnumerable<T> value)
		{
			return value.ToList();
		}
	}
}