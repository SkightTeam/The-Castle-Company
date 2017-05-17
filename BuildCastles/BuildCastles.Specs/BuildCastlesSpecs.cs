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
}