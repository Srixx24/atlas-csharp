using NUnit.Framework;
using MyMath;
using System.Collections.Generic;
using System.IO;

namespace MyMath
{
    public class Operations
    {
        public static int Max(List<int> nums)
        {
            if (nums == null || nums.Count == 0)
            {
                return 0;
            }

            return nums.Max();
        }
    }
}
