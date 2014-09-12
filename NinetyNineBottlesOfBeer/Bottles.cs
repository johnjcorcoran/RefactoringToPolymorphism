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
		var verses = new List<IVerse>
			{
				new SeveralBottlesVerse(num),
				new TwoBottlesVerse(),
				new OneBottleVerse(),
				new NoBottleVerse()
			};
		return verses.Single(verse => verse.CanHandleBottles(num));
	}
}

public interface IVerse
{
	string Get();
	bool CanHandleBottles(int number);
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

	public bool CanHandleBottles(int number)
	{
		return number > 2;
	}
}

public class TwoBottlesVerse : IVerse
{
	public string Get()
	{
		return "2 bottles of beer on the wall, 2 bottles of beer.\r\nTake one down and pass it around, 1 bottle of beer on the wall.";
	}

	public bool CanHandleBottles(int number)
	{
		return number == 2;
	}
}

public class OneBottleVerse : IVerse
{
	public string Get()
	{
		return "1 bottle of beer on the wall, 1 bottle of beer.\r\nTake it down and pass it around, no more bottles of beer on the wall.";
	}

	public bool CanHandleBottles(int number)
	{
		return number == 1;
	}
}

public class NoBottleVerse : IVerse
{
	public string Get()
	{
		return "No more bottles of beer on the wall, no more bottles of beer.\r\nGo to the store and buy some more, 99 bottles of beer on the wall.";
	}

	public bool CanHandleBottles(int number)
	{
		return number == 0;
	}
}