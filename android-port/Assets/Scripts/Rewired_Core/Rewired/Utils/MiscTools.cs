using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired.Utils.Interfaces;

namespace Rewired.Utils
{
	[Token(Token = "0x200033D")]
	internal static class MiscTools
	{
		[Token(Token = "0x4001090")]
		[FieldOffset(Offset = "0x0")]
		private static uint XZlzXqLyvxgaufeaWuWImsKyCQMJ;

		[Token(Token = "0x4001091")]
		[FieldOffset(Offset = "0x4")]
		private static uint CPFpEXDiCzKnVdTPkYWaohANgmed;

		[Token(Token = "0x4001092")]
		[FieldOffset(Offset = "0x8")]
		private static uint sbMjeMbrBQXUIlGTrpNeWkGucHbtA;

		[Token(Token = "0x4001093")]
		[FieldOffset(Offset = "0xC")]
		private static int AdXBJgPfcOyGikQevpXsRcULbtWg;

		[Token(Token = "0x4001094")]
		[FieldOffset(Offset = "0x10")]
		private static int QITAqHdWCZXpFQIjQrkxBmmrdpFw;

		[Token(Token = "0x4001095")]
		[FieldOffset(Offset = "0x14")]
		private static int uFxfBTgRidXjPEgqgoEMQiGwieV;

		[Token(Token = "0x60018E2")]
		[Address(RVA = "0x23EBF64", Offset = "0x23EBF64", VA = "0x23EBF64")]
		public static object Clone(object obj)
		{
			return null;
		}

		[Token(Token = "0x60018E3")]
		public static T Clone<T>(T obj) where T : class, ICloneable
		{
			return null;
		}

		[Token(Token = "0x60018E4")]
		public static T DeepClone<T>(T obj) where T : class, IDeepCloneable
		{
			return null;
		}

		[Token(Token = "0x60018E5")]
		public static T DeepClone<T>(T obj, bool createIfNull) where T : class, IDeepCloneable, new()
		{
			return null;
		}

		[Token(Token = "0x60018E6")]
		public static T[] DeepClone<T>(T[] obj) where T : class, IDeepCloneable
		{
			return null;
		}

		[Token(Token = "0x60018E7")]
		public static List<T> DeepClone<T>(List<T> obj) where T : class, IDeepCloneable
		{
			return null;
		}

		[Token(Token = "0x60018E8")]
		public static Dictionary<TKey, TValue> DeepClone<TKey, TValue>(Dictionary<TKey, TValue> dictionary) where TValue : class, IDeepCloneable
		{
			return null;
		}

		[Token(Token = "0x60018E9")]
		[Address(RVA = "0x23E7A44", Offset = "0x23E7A44", VA = "0x23E7A44")]
		public static Guid CreateGuidHashSHA1(string text)
		{
			return default;
		}

		[Token(Token = "0x60018EA")]
		[Address(RVA = "0x23EC058", Offset = "0x23EC058", VA = "0x23EC058")]
		public static Guid CreateHIDProductGuid(int vendorId, int productId)
		{
			return default;
		}

		[Token(Token = "0x60018EB")]
		[Address(RVA = "0x23EC124", Offset = "0x23EC124", VA = "0x23EC124")]
		public static uint Tick(uint counter)
		{
			return default;
		}

		[Token(Token = "0x60018EC")]
		public static void Swap<T>(ref T a, ref T b)
		{
		}

		[Token(Token = "0x60018ED")]
		[Address(RVA = "0x23EC1C4", Offset = "0x23EC1C4", VA = "0x23EC1C4")]
		public static long ToLongUnchecked(object value)
		{
			return default;
		}
	}
}
