using Xunit;
using TechReturners.Tasks;
using System.Collections.Generic;

// Scenario
// Several people are standing in a row divided into two teams. The first person goes into team 1, the second goes into team 2, the third goes into team 1, and so on.

// Task
// Given an array of positive integers (the weights of the people), return a new array of two integers, where the first one is the total weight of team 1, and the second one is the total weight of team 2.

// Notes
// Array size is at least 1.
// All numbers will be positive.

// Input >> Output Examples
// rowWeights([13, 27, 49])  ==>  return (62, 27)
// Explanation:
// The first element 62 is the total weight of team 1, and the second element 27 is the total weight of team 2.

// rowWeights([50, 60, 70, 80])  ==>  return (120, 140)
// Explanation:
// The first element 120 is the total weight of team 1, and the second element 140 is the total weight of team 2.

// rowWeights([80])  ==>  return (80, 0)
// Explanation:
// The first element 80 is the total weight of team 1, and the second element 0 is the total weight of team 2.

namespace TechReturners.Tasks.UnitTests
{
    public class Exercise003Test
    {
        [Fact]
        public void CheckOnePerson()
        {
            Assert.Equal(new int[]{80, 0}, Exercise003.RowWeights(new int[]{80}));
        }

        [Fact]
        public void CheckMultipleCombinations()
        {
            Assert.Equal(new int[]{100, 50}, Exercise003.RowWeights(new int[]{100, 50}));
            Assert.Equal(new int[]{120, 140}, Exercise003.RowWeights(new int[]{50, 60, 70, 80}));
            Assert.Equal(new int[]{62, 27}, Exercise003.RowWeights(new int[]{13, 27, 49}));
            Assert.Equal(new int[]{236, 92}, Exercise003.RowWeights(new int[]{70, 58, 75, 34, 91}));
            Assert.Equal(new int[]{211, 164}, Exercise003.RowWeights(new int[]{29, 83, 67, 53, 19, 28, 96}));
            Assert.Equal(new int[]{0, 1}, Exercise003.RowWeights(new int[]{0, 1, 0}));
        }

        [Fact]
        public void CheckWithZero()
        {
            Assert.Equal(new int[]{0, 0}, Exercise003.RowWeights(new int[]{0}));
        }
    }
}