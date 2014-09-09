namespace NinetyNineBottlesOfBeer
{
    public class Bottles
    {
        public string Verse(int num)
        {
            switch (num)
            {   case 99:
                    return  @"99 bottles of beer on the wall, 99 bottles of beer.
Take one down and pass it around, 98 bottles of beer on the wall.";
                case 89:
                    return @"89 bottles of beer on the wall, 89 bottles of beer.
Take one down and pass it around, 88 bottles of beer on the wall.";
                case 2:
                    return @"2 bottles of beer on the wall, 2 bottles of beer.
Take one down and pass it around, 1 bottle of beer on the wall.";
                case 1:
                    return @"1 bottle of beer on the wall, 1 bottle of beer.
Take it down and pass it around, no more bottles of beer on the wall.";
                case 0:
                    return @"No more bottles of beer on the wall, no more bottles of beer.
Go to the store and buy some more, 99 bottles of beer on the wall.";
            }
            return string.Empty;
        }

        public string Verse(int lowerBound, int upperBound)
        {
            throw new System.NotImplementedException();
        }
    }
}
