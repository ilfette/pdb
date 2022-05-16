using NUnit.Framework;
using Sorting;

namespace TestTask2
{
    public class Tests
    {
        int[][] expectedSum = {
                            new int[4]{1, 2, 3, 4},
                            new int[4]{5, 6, 7, 121},
                            new int[4]{ 0, 100, 110, 120}
                           };
        int[][] expectedSumReversed = {
                            new int[4]{0, 100, 110, 120},
                            new int[4]{5, 6, 7, 121},
                            new int[4]{ 1, 2, 3, 4}
                           };
        int[][] expectedMin = {
                            new int[4]{0, 100, 110, 120},
                            new int[4]{1, 2, 3, 4},
                            new int[4]{5, 6, 7, 121}
                           };
        int[][] expectedMinReversed = {
                            new int[4]{5, 6, 7, 121},
                            new int[4]{1, 2, 3, 4},
                            new int[4]{0, 100, 110, 120}
                           };
        int[][] expectedMax = {
                            new int[4]{1, 2, 3, 4},
                            new int[4]{0, 100, 110, 120},
                            new int[4]{5, 6, 7, 121}
                           };
        int[][] expectedMaxReversed = {
                            new int[4]{5, 6, 7, 121},
                            new int[4]{0, 100, 110, 120},
                            new int[4]{1, 2, 3, 4}
                           };


        public int[][] getInputData()
        {
            int[][] arr = {
                            new int[4]{5, 6, 7, 121},
                            new int[4]{1, 2, 3, 4},
                            new int[4]{0, 100, 110, 120}
                           };
            return arr;
        }

        [Test]
        public void testSumSort()
        {
            int[][] arr = getInputData();
            Context context = new Context(new SumSortingStrategy().Sort);
            
            context.Sort(ref arr, false);
            Assert.AreEqual(arr, expectedSum);
        }

        [Test]
        public void testSumSortReversed()
        {
            int[][] arr = getInputData();
            Context context = new Context(new SumSortingStrategy().Sort);

            context.Sort(ref arr, true);
            Assert.AreEqual(arr, expectedSumReversed);
        }

        [Test]
        public void testMinSort()
        {
            int[][] arr = getInputData();
            Context context = new Context(new MinSortingStrategy().Sort);

            context.Sort(ref arr, false);
            Assert.AreEqual(arr, expectedMin);
        }

        [Test]
        public void testMinSortReversed()
        {
            int[][] arr = getInputData();
            Context context = new Context(new MinSortingStrategy().Sort);

            context.Sort(ref arr, true);
            Assert.AreEqual(arr, expectedMinReversed);
        }

        [Test]
        public void testMaxSort()
        {
            int[][] arr = getInputData();
            Context context = new Context(new MaxSortingStrategy().Sort);

            context.Sort(ref arr, false);
            Assert.AreEqual(arr, expectedMax);
        }

        [Test]
        public void testMaxSortReversed()
        {
            int[][] arr = getInputData();
            Context context = new Context(new MaxSortingStrategy().Sort);

            context.Sort(ref arr, true);
            Assert.AreEqual(arr, expectedMaxReversed);
        }
        [Test]
        public void testAlreadySorted()
        {
            foreach (SortingDelegate myDelegate in new SortingDelegate[3] { new SumSortingStrategy().Sort,
                                                                  new MinSortingStrategy().Sort,
                                                                new MaxSortingStrategy().Sort})
            {
                int[][] arr = {
                            new int[1]{-1},
                            new int[1]{0},
                            new int[1]{2}
                           };
                int[][] true_arr = {
                            new int[1]{-1},
                            new int[1]{0},
                            new int[1]{2}
                           };
                Context context = new Context(new MinSortingStrategy().Sort);
                context.Sort(ref arr, false);
                Assert.AreEqual(arr, true_arr);
            }
        }
            [Test]
            public void testAlreadySortedReversed()
            {
                foreach (SortingDelegate myDelegate in new SortingDelegate[3] { new SumSortingStrategy().Sort,
                                                                  new MinSortingStrategy().Sort,
                                                                new MaxSortingStrategy().Sort})
                {
                    int[][] arr = {
                            new int[1]{-1},
                            new int[1]{0},
                            new int[1]{2}
                           };
                    int[][] true_arr = {
                            new int[1]{2},
                            new int[1]{0},
                            new int[1]{-1}
                           };
                    Context context = new Context(new MinSortingStrategy().Sort);
                    context.Sort(ref arr, true);
                    Assert.AreEqual(arr, true_arr);
                }


            }


    }
}