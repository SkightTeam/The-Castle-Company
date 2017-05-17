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

    public class When_only_1_peak_with_multiple_peak_heights : BuildCastlesSpecs
    {
        Establish context = () => subject = new int[] { 1, 2, 3,3,3,3, 2, 1 };

        It should_count_1 = () => result.ShouldEqual(1);

    }

    public class When_only_1_vally : BuildCastlesSpecs
    {
        Establish context = () => subject = new int[] { 3,2,1,2,3 };

        It should_count_1 = () => result.ShouldEqual(1);

    }

    public class When_only_1_vally_with_multiple_vally_heights : BuildCastlesSpecs
    {
        Establish context = () => subject = new int[] { 3, 2, 1,1,1, 2, 3 };

        It should_count_1 = () => result.ShouldEqual(1);

    }

    public class When_only_1_peak_and_1_vally : BuildCastlesSpecs
    {
        Establish context = () => subject = new int[] {1,2,3,2,1,2,3};

        It should_count_2 = () => result.ShouldEqual(2);

    }



    public class When_only_1_peak_and_1_vally_with_some_not_change_height : BuildCastlesSpecs
    {
        Establish context = () => subject = new int[] { 1, 2,2,2, 3, 2, 1, 2,2, 3 };

        It should_count_2 = () => result.ShouldEqual(2);

    }
}   