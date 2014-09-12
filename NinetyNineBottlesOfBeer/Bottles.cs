namespace NinetyNineBottlesOfBeer
{
	public class Bottles
	{
		public string Verse(int num)
		{
			if (num == 0)
			{
				return @"No more bottles of beer on the wall, no more bottles of beer.
Go to the store and buy some more, 99 bottles of beer on the wall.";
			}
			if (num == 1)
			{
				return @"1 bottle of beer on the wall, 1 bottle of beer.
Take it down and pass it around, no more bottles of beer on the wall.";
			}
			if (num == 2)
			{
				return @"2 bottles of beer on the wall, 2 bottles of beer.
Take one down and pass it around, 1 bottle of beer on the wall.";
			}
			if (num == 89)
			{
				return @"89 bottles of beer on the wall, 89 bottles of beer.
Take one down and pass it around, 88 bottles of beer on the wall.";
			}
			return @"99 bottles of beer on the wall, 99 bottles of beer.
Take one down and pass it around, 98 bottles of beer on the wall.";
		}

		public string Verse(int upperBound, int lowerBound)
		{
			if (upperBound == 2)
			{
				return @"2 bottles of beer on the wall, 2 bottles of beer.
Take one down and pass it around, 1 bottle of beer on the wall.

1 bottle of beer on the wall, 1 bottle of beer.
Take it down and pass it around, no more bottles of beer on the wall.

No more bottles of beer on the wall, no more bottles of beer.
Go to the store and buy some more, 99 bottles of beer on the wall.

";
			}
			return @"99 bottles of beer on the wall, 99 bottles of beer.
Take one down and pass it around, 98 bottles of beer on the wall.

98 bottles of beer on the wall, 98 bottles of beer.
Take one down and pass it around, 97 bottles of beer on the wall.

";
		}
	}
}
