using Xunit;
using TechReturners.Tasks;
using System.Collections.Generic;

// In this Kata, you will be given an array of numbers in which two numbers occur once and the rest occur only twice. 
// Your task will be to return the sum of the numbers that occur only once.
// For example, repeats([4,5,7,5,4,8]) = 15 because only the numbers 7 and 8 occur once, and their sum is 15.
// More examples in the test cases below.

// Good luck!

namespace TechReturners.Tasks.UnitTests
{
    public class Exercise001Test
    {
        [Fact]
        public void CheckSingles()
        {
            Assert.Equal(15, Exercise001.Singles(new List<int> {4, 5, 7, 5, 4, 8}));
            Assert.Equal(19, Exercise001.Singles(new List<int> {9, 10, 19, 13, 19, 13}));
            Assert.Equal(12, Exercise001.Singles(new List<int> {16, 0, 11, 4, 8, 16, 0, 11}));
            Assert.Equal(22, Exercise001.Singles(new List<int> {5, 17, 18, 11, 13, 18, 11, 13}));
            Assert.Equal(24, Exercise001.Singles(new List<int> {5, 10, 19, 13, 10, 13}));
        }

        [Fact]
        public void CheckSinglesAllDuplicates()
        {
            Assert.Equal(0, Exercise001.Singles(new List<int> {6, 6, 8, 8}));
        }
    }
}