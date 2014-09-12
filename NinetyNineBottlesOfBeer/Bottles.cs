namespace NinetyNineBottlesOfBeer
{
	public class Bottles
	{
		private const string VerseSeparator = "\r\n\r\n";

		public string Verse(int upperBound, int lowerBound)
		{
			if (upperBound == 2)
			{
				return Verse(2) + VerseSeparator + Verse(1) + VerseSeparator + Verse(0) + VerseSeparator;
			}

			return Verse(99) + VerseSeparator + Verse(98) + VerseSeparator;
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
			return string.Format(@"{0} bottles of beer on the wall, {0} bottles of beer.
Take one down and pass it around, {1} bottles of beer on the wall.", num, num - 1);
		}

		public string GetOneBottleVerse()
		{
			return @"1 bottle of beer on the wall, 1 bottle of beer.
Take it down and pass it around, no more bottles of beer on the wall.";
		}

		public string GetTwoBottlesVerse()
		{
			return @"2 bottles of beer on the wall, 2 bottles of beer.
Take one down and pass it around, 1 bottle of beer on the wall.";
		}

		public string GetNoBottlesVerse()
		{
			return @"No more bottles of beer on the wall, no more bottles of beer.
Go to the store and buy some more, 99 bottles of beer on the wall.";
		}
	}
}
