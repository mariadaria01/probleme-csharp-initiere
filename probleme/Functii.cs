using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace probleme
{
    public class Functii
    {
        public static void AfisareVector(int[] vector)
        {
            for(int i = 0;i < vector.Length; i++)
            {
                Console.Write(vector[i] + " ");
            }
            Console.WriteLine();
        }

        public static int RemoveValue(ref int[] vector, int n)
        {
            List<int> nums = vector.ToList();
            int i = 0;
            int initialCount = nums.Count;

            while (i < nums.Count - 1)
            {
                while (nums.Last() == n)
                {
                    nums.RemoveAt(nums.Count - 1);
                }

                if (nums[i] == n)
                {
                    int retinut = nums[i];
                    nums[i] = nums[nums.Count - 1];
                    nums[nums.Count - 1] = retinut;

                    nums.RemoveAt(nums.Count - 1);
                }

                i++;
            }

            vector = nums.ToArray();
            return initialCount - vector.Length;
        }

        public static int RemoveValueII(ref int[] vector, int n)
        {
            List<int> nums = vector.ToList();
            int initialCount = nums.Count;

            for(int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == n)
                {
                    nums.RemoveAt(i);
                    i--;
                }
            }

            vector = nums.ToArray();
            return initialCount - vector.Length;
        }

        public static bool MaiMareCaToate(int[] vector, int n)
        {
            for(int i = 0; i < vector.Length; i++)
            {
                if (vector[i] >= n)
                {
                    return false;
                }
            }

            return true;
        }

        public static int CateElementeMajorante(int[] x, int[] y)
        {
            int count = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (MaiMareCaToate(y, x[i]))
                {
                    count++;
                }
            }
            return count;
        }

        public static List<int> RemoveDuplicates(List<int> nums)
        {
            List<int> list = new List<int>();
            list.Add(nums[0]);

            for (int i = 1; i < nums.Count; i++)
            {
                if (nums[i] != list.Last())
                {
                    list.Add(nums[i]);
                }
            }

            return list;
        }

        public static void RemoveDuplicatesII(ref List<int> nums)
        {
            for (int i = 0; i < nums.Count - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    nums.RemoveAt(i);
                    i--;
                }
            }
        }
        
        public static bool ContainsDuplicates(int[] nums)
        {
            for(int i=0; i < nums.Length - 1; i++)
            {
                for(int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}