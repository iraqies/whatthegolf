using Rewired.Utils.Interfaces;

namespace Rewired.Utils
{
	public static class ArrayTools
	{
		public static T[] DeepClone<T>(T[] array) where T : class, IDeepCloneable
		{
			return null;
		}

		public static T[] ShallowCopy<T>(T[] array)
		{
			return null;
		}

		public static bool Contains<T>(T[] array, T item)
		{
			return false;
		}

		public static void Expand<T>(ref T[] array, int length)
		{
		}

		public static int IndexOf(int[] array, int value)
		{
			return 0;
		}

		public static void Fill<T>(T[] array, T value)
		{
		}

		public static void Populate<T>(T[] array, int startIndex, int length) where T : class, new()
		{
		}

		public static void Populate<T>(T[] array) where T : class, new()
		{
		}

		public static bool IsNullOrEmpty<T>(T[] array)
		{
			return false;
		}
	}
}
