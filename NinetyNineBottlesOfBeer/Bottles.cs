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
			if (num == 0)
			{
				return GetNoBottlesVerse();
			}
			if (num == 1)
			{
				return GetOneBottleVerse();
			}
			if (num == 2)
			{
				return GetTwoBottlesVerse();
			}
			return GetVerse(num);
		}

		public string GetVerse(int num)
		{
			return new SeveralBottles(num).GetVerse();
		}

		public string GetTwoBottlesVerse()
		{
			return new TwoBottles().GetVerse();
		}

		public string GetOneBottleVerse()
		{
			return new OneBottle().GetVerse();
		}

		public string GetNoBottlesVerse()
		{
			return new NoBottle().GetVerse();
		}
	}
}

public class SeveralBottles
{
	private readonly int _num;

	public SeveralBottles(int num)
	{
		_num = num;
	}

	public string GetVerse()
	{
		return string.Format(@"{0} bottles of beer on the wall, {0} bottles of beer.
Take one down and pass it around, {1} bottles of beer on the wall.", _num, _num - 1);
	}
}

public class TwoBottles
{
	public string GetVerse()
	{
		return @"2 bottles of beer on the wall, 2 bottles of beer.
Take one down and pass it around, 1 bottle of beer on the wall.";
	}
}

public class OneBottle
{
	public string GetVerse()
	{
		return @"1 bottle of beer on the wall, 1 bottle of beer.
Take it down and pass it around, no more bottles of beer on the wall.";
	}
}

public class NoBottle
{
	public string GetVerse()
	{
		return @"No more bottles of beer on the wall, no more bottles of beer.
Go to the store and buy some more, 99 bottles of beer on the wall.";
	}
}
