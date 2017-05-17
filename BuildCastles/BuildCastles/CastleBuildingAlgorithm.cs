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
            Trend? previous_trend = null;
            foreach (var item in source)
            {
                previous = current;
                current = item;
                if (previous.HasValue && current.HasValue)
                {
                    if (current > previous)
                    {
                        previous_trend=Trend.Up;
                        yield return Trend.Up;
                    }else if (current < previous)
                    {
                        previous_trend = Trend.Down;
                        yield return Trend.Down;
                    }else if (previous_trend.HasValue)
                    {
                        yield return previous_trend.Value;
                    }
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