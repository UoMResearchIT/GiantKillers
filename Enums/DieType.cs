using System;

namespace GiantKillers.Enums
{
    // Use own category for home fixtures, category higher for away fixtures
    // If cat 6 team gets an away fixture then they use the cat 7 die
    public enum DieType
    {
        [DieNumbers(new int[] { 4, 3, 3, 2, 1, 0 })]
        Cat1,
        [DieNumbers(new int[] { 4, 3, 2, 2, 1, 0 })]
        Cat2,
        [DieNumbers(new int[] { 3, 3, 2, 1, 1, 0 })]
        Cat3,
        [DieNumbers(new int[] { 3, 2, 2, 1, 1, 0 })]
        Cat4,
        [DieNumbers(new int[] { 3, 2, 1, 1, 0, 0 })]
        Cat5,
        [DieNumbers(new int[] { 2, 2, 1, 1, 0, 0 })]
        Cat6,
        [DieNumbers(new int[] { 2, 1, 1, 1, 0, 0 })]
        Cat7,
        [DieNumbers(new int[] { 2, 1, 0, 0, 0, 0 })]
        ExtraTime,
        [DieNumbers(new int[] { 2, 1, 0, 0, 0, 0 })]
        Penalty
    }

    public class DieNumbersAttribute : Attribute
    {
        public int[] Numbers { get; }
        public DieNumbersAttribute(int[] numbers)
        {
            Numbers = numbers;
        }
    }

    public static class DieTypeExtensions
    {
        private static T GetAttribute<T>(this DieType type) where T : Attribute
        {
            return (type.GetType().GetMember(Enum.GetName(type.GetType(), type))[0].GetCustomAttributes(typeof(T), inherit: false)[0] as T);
        }

        public static int[] GetFaceValues(this DieType type)
        {
            return type.GetAttribute<DieNumbersAttribute>().Numbers;
        }
    }
}