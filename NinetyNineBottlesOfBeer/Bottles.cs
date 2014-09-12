using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NinetyNineBottlesOfBeer
{
	public class Bottles
	{
		private const string VerseSeparator = "\r\n\r\n";

		public string Verse(int upperBound, int lowerBound)
		{
			var song = new StringBuilder();

			for (var i = upperBound; i >= lowerBound; i--)
			{
				song.Append(Verse(i));
				song.Append(VerseSeparator);
			}

			return song.ToString();
		}

		public string Verse(int num)
		{
			return VerseFactory.Create(num).Get();
		}
	}
}

public static class VerseFactory
{
	public static IVerse Create(int num)
	{
		var ha = new Dictionary<int, Func<IVerse>>
			{
				{3, () => new SeveralBottlesVerse(num)},
				{2, () => new TwoBottlesVerse()},
				{1, () => new OneBottleVerse()},
				{0, () => new NoBottleVerse()}
			};
		return ha.First(item => item.Key <= num).Value();
	}
}

public class SeveralBottlesVerse : IVerse
{
	private readonly int _num;

	public SeveralBottlesVerse(int num)
	{
		_num = num;
	}

	public string Get()
	{
		return string.Format("{0} bottles of beer on the wall, {0} bottles of beer.\r\nTake one down and pass it around, {1} bottles of beer on the wall.", _num, _num - 1);
	}
}

public class TwoBottlesVerse : IVerse
{
	public string Get()
	{
		return "2 bottles of beer on the wall, 2 bottles of beer.\r\nTake one down and pass it around, 1 bottle of beer on the wall.";
	}
}

public class OneBottleVerse : IVerse
{
	public string Get()
	{
		return "1 bottle of beer on the wall, 1 bottle of beer.\r\nTake it down and pass it around, no more bottles of beer on the wall.";
	}
}

public class NoBottleVerse : IVerse
{
	public string Get()
	{
		return "No more bottles of beer on the wall, no more bottles of beer.\r\nGo to the store and buy some more, 99 bottles of beer on the wall.";
	}
}

public interface IVerse
{
	string Get();
}
