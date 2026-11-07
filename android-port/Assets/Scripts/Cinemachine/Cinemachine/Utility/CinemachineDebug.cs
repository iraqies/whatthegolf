using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine.Utility
{
	[Token(Token = "0x200008F")]
	public class CinemachineDebug
	{
		[Token(Token = "0x2000090")]
		public delegate void OnGUIDelegate();

		[Token(Token = "0x400030E")]
		[FieldOffset(Offset = "0x0")]
		private static HashSet<Object> mClients;

		[Token(Token = "0x400030F")]
		[FieldOffset(Offset = "0x8")]
		public static OnGUIDelegate OnGUIHandlers;

		[Token(Token = "0x4000310")]
		[FieldOffset(Offset = "0x10")]
		private static List<StringBuilder> mAvailableStringBuilders;

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x18E3380", Offset = "0x18E3380", VA = "0x18E3380")]
		public static void ReleaseScreenPos(Object client)
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x18E3440", Offset = "0x18E3440", VA = "0x18E3440")]
		public static Rect GetScreenPos(Object client, string text, GUIStyle style)
		{
			return default;
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x18E16DC", Offset = "0x18E16DC", VA = "0x18E16DC")]
		public static StringBuilder SBFromPool()
		{
			return null;
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x18E17C0", Offset = "0x18E17C0", VA = "0x18E17C0")]
		public static void ReturnToPool(StringBuilder sb)
		{
		}
	}
}
