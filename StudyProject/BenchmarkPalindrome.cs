using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProject;

[RankColumn]
[MemoryDiagnoser]
public class BenchmarkPalindrome
{
    [Benchmark]
    public void IsPalindrome()
    {
        for (int i = 0; i < 1000; i++)
        {
            "rodador".IsPalindrome();
            "abac".IsPalindrome();
        }
    }

    [Benchmark]
    public void IsPalindromeLinq()
    {
        for (int i = 0; i < 1000; i++)
        {
            "rodador".IsPalindromeLinq();
            "abac".IsPalindromeLinq();
        }
    }
}
