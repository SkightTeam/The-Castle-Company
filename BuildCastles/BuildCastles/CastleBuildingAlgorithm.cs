using System.Collections.Generic;
using System.Linq;

namespace BuildCastles
{
    public static class CastleBuildingAlgorithm
    {
       

        public static IEnumerable<Trend>to_trends(this IEnumerable<int> source)
        {
            int? previous;
            int? current=null;
            foreach (var item in source)
            {
                previous = current;
                current = item;
                if (previous.HasValue && current.HasValue)
                {
                    if(current > previous)
                        yield return Trend.Up;
                    if(current < previous)
                        yield return Trend.Down;
                }
            }
        }
        public static int count_castles(this IEnumerable<int> source)
        {
            var result = 0;
           
            return result;
        }
    }
    public enum Trend
    {
        Up,
        Down
    }
}