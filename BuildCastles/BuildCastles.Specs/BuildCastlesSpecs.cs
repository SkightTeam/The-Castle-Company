using System.Linq;
using BuildCastles;
using Machine.Specifications;

namespace BuildCastles
{
    public class BuildCastlesSpecs
    {
        private Because of = () => result = subject.count_castles();
        protected static int[] subject;
        protected static int result;
    }
    public class When_only_1_peak: BuildCastlesSpecs
    {
        Establish context = () => subject = new int[] {1, 2, 3, 2, 1};

        It should_count_1 = () => result.ShouldEqual(1);

    }

    public class TransformTrendSpecs
    {
        It all_increase_height_lead_up_trends= ()
            =>new[] {1, 2, 3, 4}.to_trends().SequenceEqual(new[] {Trend.Up, Trend.Up, Trend.Up}).ShouldBeTrue();

        It all_decrease_height_lead_down_trends = ()
             => new[] { 4,3,2,1 }.to_trends().SequenceEqual(new[] { Trend.Down, Trend.Down, Trend.Down }).ShouldBeTrue();

        It increase_and_decrease_case = ()
            => new[] { 1,2,3,2,1 }.to_trends().SequenceEqual(
                new[] { Trend.Up, Trend.Up, Trend.Down,Trend.Down }).ShouldBeTrue();

        It decrease_and_increase_case = ()
           => new[] { 3,2,1,2,3 }.to_trends().SequenceEqual(
               new[] { Trend.Down, Trend.Down, Trend.Up, Trend.Up }).ShouldBeTrue();

    }

   
}