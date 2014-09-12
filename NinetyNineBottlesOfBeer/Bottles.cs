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
			return new VerseFactory().CreateVerse(num).GetVerse();
		}
	}
}

public class VerseFactory
{
	public IVerse CreateVerse(int num)
	{
		if (num == 0)
		{
			return new NoBottleVerse();
		}
		if (num == 1)
		{
			return new OneBottleVerse();
		}
		if (num == 2)
		{
			return new TwoBottlesVerse();
		}
		return new SeveralBottlesVerse(num);
	}
}

public class SeveralBottlesVerse : IVerse
{
	private readonly int _num;

	public SeveralBottlesVerse(int num)
	{
		_num = num;
	}

	public string GetVerse()
	{
		return string.Format(@"{0} bottles of beer on the wall, {0} bottles of beer.
Take one down and pass it around, {1} bottles of beer on the wall.", _num, _num - 1);
	}
}

public class TwoBottlesVerse : IVerse
{
	public string GetVerse()
	{
		return @"2 bottles of beer on the wall, 2 bottles of beer.
Take one down and pass it around, 1 bottle of beer on the wall.";
	}
}

public class OneBottleVerse : IVerse
{
	public string GetVerse()
	{
		return @"1 bottle of beer on the wall, 1 bottle of beer.
Take it down and pass it around, no more bottles of beer on the wall.";
	}
}

public class NoBottleVerse : IVerse
{
	public string GetVerse()
	{
		return @"No more bottles of beer on the wall, no more bottles of beer.
Go to the store and buy some more, 99 bottles of beer on the wall.";
	}
}

public interface IVerse
{
	string GetVerse();
}
