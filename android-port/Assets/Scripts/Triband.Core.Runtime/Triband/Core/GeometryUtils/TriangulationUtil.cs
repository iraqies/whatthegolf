using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Triband.Core.GeometryUtils
{
	[Token(Token = "0x2000015")]
	public static class TriangulationUtil
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000016")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AF714", Offset = "0x1AF714")]
		private struct _003C_003Ec__DisplayClass0_0
		{
			[Token(Token = "0x400002D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int pointCount;

			[Token(Token = "0x400002E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Vector2[] points;
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x29F8E44", Offset = "0x29F8E44", VA = "0x29F8E44")]
		public static int[] TriangulateSimple(Vector2[] points)
		{
			return null;
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x29F9100", Offset = "0x29F9100", VA = "0x29F9100")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AF948", Offset = "0x1AF948")]
		internal static float _003CTriangulateSimple_003Eg__Area_007C0_0(ref _003C_003Ec__DisplayClass0_0 P_0)
		{
			return default;
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x29F91A0", Offset = "0x29F91A0", VA = "0x29F91A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AF958", Offset = "0x1AF958")]
		internal static bool _003CTriangulateSimple_003Eg__Snip_007C0_1(int lu, int lv, int lw, int localPointCount, int[] lV, ref _003C_003Ec__DisplayClass0_0 P_5)
		{
			return default;
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x29F9398", Offset = "0x29F9398", VA = "0x29F9398")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AF968", Offset = "0x1AF968")]
		internal static bool _003CTriangulateSimple_003Eg__InsideTriangle_007C0_2(Vector2 A, Vector2 B, Vector2 C, Vector2 P)
		{
			return default;
		}
	}
}
