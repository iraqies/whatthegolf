using System;
using Il2CppDummyDll;
using UnityEngine.UI.Collections;

namespace UnityEngine.UI
{
	[Token(Token = "0x2000008")]
	public class CanvasUpdateRegistry
	{
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x0")]
		private static CanvasUpdateRegistry s_Instance;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x10")]
		private bool m_PerformingLayoutUpdate;

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x11")]
		private bool m_PerformingGraphicUpdate;

		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x18")]
		private string[] m_CanvasUpdateProfilerStrings;

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x20")]
		private readonly IndexedSet<ICanvasElement> m_LayoutRebuildQueue;

		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x28")]
		private readonly IndexedSet<ICanvasElement> m_GraphicRebuildQueue;

		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Comparison<ICanvasElement> s_SortLayoutFunction;

		[Token(Token = "0x1700000A")]
		public static CanvasUpdateRegistry instance
		{
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x2BFAA6C", Offset = "0x2BFAA6C", VA = "0x2BFAA6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x2BFA7F0", Offset = "0x2BFA7F0", VA = "0x2BFA7F0")]
		protected CanvasUpdateRegistry()
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x2BFAB28", Offset = "0x2BFAB28", VA = "0x2BFAB28")]
		private bool ObjectValidForUpdate(ICanvasElement element)
		{
			return default;
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x2BFAC00", Offset = "0x2BFAC00", VA = "0x2BFAC00")]
		private void CleanInvalidItems()
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x2BFAF1C", Offset = "0x2BFAF1C", VA = "0x2BFAF1C")]
		private void PerformUpdate()
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x2BFB7D4", Offset = "0x2BFB7D4", VA = "0x2BFB7D4")]
		private static int ParentCount(Transform child)
		{
			return default;
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x2BFB8A8", Offset = "0x2BFB8A8", VA = "0x2BFB8A8")]
		private static int SortLayoutList(ICanvasElement x, ICanvasElement y)
		{
			return default;
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x2BFBA24", Offset = "0x2BFBA24", VA = "0x2BFBA24")]
		public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x2BFBB40", Offset = "0x2BFBB40", VA = "0x2BFBB40")]
		public static bool TryRegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
			return default;
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x2BFBA98", Offset = "0x2BFBA98", VA = "0x2BFBA98")]
		private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
			return default;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x2BFBBB4", Offset = "0x2BFBBB4", VA = "0x2BFBBB4")]
		public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x2BFBC28", Offset = "0x2BFBC28", VA = "0x2BFBC28")]
		private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
			return default;
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x2BFBD10", Offset = "0x2BFBD10", VA = "0x2BFBD10")]
		public static void UnRegisterCanvasElementForRebuild(ICanvasElement element)
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x2BFC0C4", Offset = "0x2BFC0C4", VA = "0x2BFC0C4")]
		public static void DisableCanvasElementForRebuild(ICanvasElement element)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x2BFBD94", Offset = "0x2BFBD94", VA = "0x2BFBD94")]
		private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x2BFBF2C", Offset = "0x2BFBF2C", VA = "0x2BFBF2C")]
		private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x2BFC148", Offset = "0x2BFC148", VA = "0x2BFC148")]
		private void InternalDisableCanvasElementForLayoutRebuild(ICanvasElement element)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x2BFC2E0", Offset = "0x2BFC2E0", VA = "0x2BFC2E0")]
		private void InternalDisableCanvasElementForGraphicRebuild(ICanvasElement element)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x2BFC478", Offset = "0x2BFC478", VA = "0x2BFC478")]
		public static bool IsRebuildingLayout()
		{
			return default;
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x2BFC4E0", Offset = "0x2BFC4E0", VA = "0x2BFC4E0")]
		public static bool IsRebuildingGraphics()
		{
			return default;
		}
	}
}
