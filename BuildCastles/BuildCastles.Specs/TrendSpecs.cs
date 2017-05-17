using System.Linq;
using Machine.Specifications;

namespace BuildCastles
{
    public class TrendSpecs
    {
        It all_increase_height_should_lead_up_trends= ()
            =>new[] {1, 2, 3, 4}.to_trends().SequenceEqual(new[] {Trend.Up, Trend.Up, Trend.Up}).ShouldBeTrue();

        It all_decrease_height_should_lead_down_trends = ()
            => new[] { 4,3,2,1 }.to_trends().SequenceEqual(new[] { Trend.Down, Trend.Down, Trend.Down }).ShouldBeTrue();

        It increase_and_decrease_should_lead_up_and_down_trends = ()
            => new[] { 1,2,3,2,1 }.to_trends().SequenceEqual(
                new[] { Trend.Up, Trend.Up, Trend.Down,Trend.Down }).ShouldBeTrue();

        It decrease_and_increase_should_lead_down_and_up_trends = ()
            => new[] { 3,2,1,2,3 }.to_trends().SequenceEqual(
                new[] { Trend.Down, Trend.Down, Trend.Up, Trend.Up }).ShouldBeTrue();

        It same_height_should_keep_previous_up_trend = ()
            => new[] { 1, 2, 2, 2, 3 }.to_trends().SequenceEqual(
                new[] { Trend.Up, Trend.Up, Trend.Up, Trend.Up }).ShouldBeTrue();

        It same_height_should_keep_previous_down_trend = ()
          => new[] { 3,2,2,2,1 }.to_trends().SequenceEqual(
              new[] { Trend.Down, Trend.Down, Trend.Down, Trend.Down }).ShouldBeTrue();
    }
}