using System;
namespace Sorting
{
    public delegate void SortingDelegate(ref int[][] array, bool reverse);
    public class Context
    {
        private SortingDelegate sortingDelegate;
        public Context(SortingDelegate sortDelegate)
        {
            this.sortingDelegate = sortDelegate;
        }

        public void Sort(ref int[][] array, bool reverse)
        {
            sortingDelegate(ref array, reverse);
        }
    }
    public abstract class AbstractSortingStrategy
    {
        public void Sort(ref int[][] array, bool reverse)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = i; j < array.GetLength(0); j++)
                {
                    if ((compare(array[i], array[j]) == 0) ^ reverse)
                    {
                        int[] temp = new int[array[j].Length];
                        copyArray(array[j], temp);
                        copyArray(array[i], array[j]);
                        array[i] = temp;
                    }
                }
            }
        }

        private void copyArray(int[] source, int[] target)
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }

        public abstract int compare(int[] array1, int[] array2);

    }
    public class SumSortingStrategy : AbstractSortingStrategy
    {
        public override int compare(int[] first, int[] second)
        {
            int s1 = 0;
            foreach (int i in first)
                s1 += i;
            int s2 = 0;
            foreach (int i in second)
                s2 += i;

            return s1 <= s2 ? 1 : 0;
        }

    }
    public class MaxSortingStrategy : AbstractSortingStrategy
    {
        public override int compare(int[] first, int[] second)
        {
            int maxS1 = int.MinValue;
            foreach (int i in first)
                if (maxS1 < i)
                {
                    maxS1 = i;
                }

            int maxS2 = int.MinValue;
            foreach (int i in second)
                if (maxS2 < i)
                {
                    maxS2 = i;
                }

            return maxS1 <= maxS2 ? 1 : 0;
        }
    }

    public class MinSortingStrategy : AbstractSortingStrategy
    {
        public override int compare(int[] first, int[] second)
        {
            int minS1 = int.MaxValue;
            foreach (int i in first)
                if (minS1 > i)
                {
                    minS1 = i;
                }

            int minS2 = int.MaxValue;
            foreach (int i in second)
                if (minS2 > i)
                {
                    minS2 = i;
                }
            return minS1 <= minS2 ? 1 : 0;
        }

    }
}