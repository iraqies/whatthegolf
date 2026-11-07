using System;
using System.Collections.Generic;
using Rewired.Utils.Interfaces;

namespace Rewired.Utils
{
	internal static class MiscTools
	{
		private static uint XZlzXqLyvxgaufeaWuWImsKyCQMJ;

		private static uint CPFpEXDiCzKnVdTPkYWaohANgmed;

		private static uint sbMjeMbrBQXUIlGTrpNeWkGucHbtA;

		private static int AdXBJgPfcOyGikQevpXsRcULbtWg;

		private static int QITAqHdWCZXpFQIjQrkxBmmrdpFw;

		private static int uFxfBTgRidXjPEgqgoEMQiGwieV;

		public static object Clone(object obj)
		{
			return null;
		}

		public static T Clone<T>(T obj) where T : class, ICloneable
		{
			return null;
		}

		public static T DeepClone<T>(T obj) where T : class, IDeepCloneable
		{
			return null;
		}

		public static T DeepClone<T>(T obj, bool createIfNull) where T : class, IDeepCloneable, new()
		{
			return null;
		}

		public static T[] DeepClone<T>(T[] obj) where T : class, IDeepCloneable
		{
			return null;
		}

		public static List<T> DeepClone<T>(List<T> obj) where T : class, IDeepCloneable
		{
			return null;
		}

		public static Dictionary<TKey, TValue> DeepClone<TKey, TValue>(Dictionary<TKey, TValue> dictionary) where TValue : class, IDeepCloneable
		{
			return null;
		}

		public static Guid CreateGuidHashSHA1(string text)
		{
			return default;
		}

		public static Guid CreateHIDProductGuid(int vendorId, int productId)
		{
			return default;
		}

		public static uint Tick(uint counter)
		{
			return 0u;
		}

		public static void Swap<T>(ref T a, ref T b)
		{
		}

		public static long ToLongUnchecked(object value)
		{
			return 0L;
		}
	}
}
