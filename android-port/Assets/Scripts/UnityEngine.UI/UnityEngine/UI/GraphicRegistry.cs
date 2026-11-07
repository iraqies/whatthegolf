using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.UI.Collections;

namespace UnityEngine.UI
{
	[Token(Token = "0x200001C")]
	public class GraphicRegistry
	{
		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x0")]
		private static GraphicRegistry s_Instance;

		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<Canvas, IndexedSet<Graphic>> m_Graphics;

		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x18")]
		private readonly Dictionary<Canvas, IndexedSet<Graphic>> m_RaycastableGraphics;

		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x8")]
		private static readonly List<Graphic> s_EmptyList;

		[Token(Token = "0x17000048")]
		public static GraphicRegistry instance
		{
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x2C0AEC8", Offset = "0x2C0AEC8", VA = "0x2C0AEC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x2C0AD14", Offset = "0x2C0AD14", VA = "0x2C0AD14")]
		protected GraphicRegistry()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x2C06340", Offset = "0x2C06340", VA = "0x2C06340")]
		public static void RegisterGraphicForCanvas(Canvas c, Graphic graphic)
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x2C053DC", Offset = "0x2C053DC", VA = "0x2C053DC")]
		public static void RegisterRaycastGraphicForCanvas(Canvas c, Graphic graphic)
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x2C05E90", Offset = "0x2C05E90", VA = "0x2C05E90")]
		public static void UnregisterGraphicForCanvas(Canvas c, Graphic graphic)
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x2C05234", Offset = "0x2C05234", VA = "0x2C05234")]
		public static void UnregisterRaycastGraphicForCanvas(Canvas c, Graphic graphic)
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x2C06E40", Offset = "0x2C06E40", VA = "0x2C06E40")]
		public static void DisableGraphicForCanvas(Canvas c, Graphic graphic)
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x2C0AF84", Offset = "0x2C0AF84", VA = "0x2C0AF84")]
		public static void DisableRaycastGraphicForCanvas(Canvas c, Graphic graphic)
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x2C0A4A4", Offset = "0x2C0A4A4", VA = "0x2C0A4A4")]
		public static IList<Graphic> GetRaycastableGraphicsForCanvas(Canvas canvas)
		{
			return null;
		}
	}
}
