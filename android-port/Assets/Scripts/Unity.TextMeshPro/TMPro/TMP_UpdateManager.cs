using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Profiling;

namespace TMPro
{
	[Token(Token = "0x2000076")]
	public class TMP_UpdateManager
	{
		[Token(Token = "0x40004A3")]
		[FieldOffset(Offset = "0x0")]
		private static TMP_UpdateManager s_Instance;

		[Token(Token = "0x40004A4")]
		[FieldOffset(Offset = "0x10")]
		private readonly HashSet<int> m_LayoutQueueLookup;

		[Token(Token = "0x40004A5")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<TMP_Text> m_LayoutRebuildQueue;

		[Token(Token = "0x40004A6")]
		[FieldOffset(Offset = "0x20")]
		private readonly HashSet<int> m_GraphicQueueLookup;

		[Token(Token = "0x40004A7")]
		[FieldOffset(Offset = "0x28")]
		private readonly List<TMP_Text> m_GraphicRebuildQueue;

		[Token(Token = "0x40004A8")]
		[FieldOffset(Offset = "0x30")]
		private readonly HashSet<int> m_InternalUpdateLookup;

		[Token(Token = "0x40004A9")]
		[FieldOffset(Offset = "0x38")]
		private readonly List<TMP_Text> m_InternalUpdateQueue;

		[Token(Token = "0x40004AA")]
		[FieldOffset(Offset = "0x40")]
		private readonly HashSet<int> m_CullingUpdateLookup;

		[Token(Token = "0x40004AB")]
		[FieldOffset(Offset = "0x48")]
		private readonly List<TMP_Text> m_CullingUpdateQueue;

		[Token(Token = "0x40004AC")]
		[FieldOffset(Offset = "0x8")]
		private static ProfilerMarker k_RegisterTextObjectForUpdateMarker;

		[Token(Token = "0x40004AD")]
		[FieldOffset(Offset = "0x10")]
		private static ProfilerMarker k_RegisterTextElementForGraphicRebuildMarker;

		[Token(Token = "0x40004AE")]
		[FieldOffset(Offset = "0x18")]
		private static ProfilerMarker k_RegisterTextElementForCullingUpdateMarker;

		[Token(Token = "0x40004AF")]
		[FieldOffset(Offset = "0x20")]
		private static ProfilerMarker k_UnregisterTextObjectForUpdateMarker;

		[Token(Token = "0x40004B0")]
		[FieldOffset(Offset = "0x28")]
		private static ProfilerMarker k_UnregisterTextElementForGraphicRebuildMarker;

		[Token(Token = "0x1700013C")]
		private static TMP_UpdateManager instance
		{
			[Token(Token = "0x6000483")]
			[Address(RVA = "0x2ABB84C", Offset = "0x2ABB84C", VA = "0x2ABB84C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x2ABB908", Offset = "0x2ABB908", VA = "0x2ABB908")]
		private TMP_UpdateManager()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x2ABBAB8", Offset = "0x2ABBAB8", VA = "0x2ABBAB8")]
		internal static void RegisterTextObjectForUpdate(TMP_Text textObject)
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x2ABBB2C", Offset = "0x2ABBB2C", VA = "0x2ABBB2C")]
		private void InternalRegisterTextObjectForUpdate(TMP_Text textObject)
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x2ABBC08", Offset = "0x2ABBC08", VA = "0x2ABBC08")]
		public static void RegisterTextElementForLayoutRebuild(TMP_Text element)
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x2ABBC7C", Offset = "0x2ABBC7C", VA = "0x2ABBC7C")]
		private void InternalRegisterTextElementForLayoutRebuild(TMP_Text element)
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x2ABBD58", Offset = "0x2ABBD58", VA = "0x2ABBD58")]
		public static void RegisterTextElementForGraphicRebuild(TMP_Text element)
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x2ABBDCC", Offset = "0x2ABBDCC", VA = "0x2ABBDCC")]
		private void InternalRegisterTextElementForGraphicRebuild(TMP_Text element)
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x2ABBEA8", Offset = "0x2ABBEA8", VA = "0x2ABBEA8")]
		public static void RegisterTextElementForCullingUpdate(TMP_Text element)
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x2ABBF1C", Offset = "0x2ABBF1C", VA = "0x2ABBF1C")]
		private void InternalRegisterTextElementForCullingUpdate(TMP_Text element)
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x2ABBFF8", Offset = "0x2ABBFF8", VA = "0x2ABBFF8")]
		private void DoRebuilds()
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x2ABC24C", Offset = "0x2ABC24C", VA = "0x2ABC24C")]
		internal static void UnRegisterTextObjectForUpdate(TMP_Text textObject)
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x2ABC360", Offset = "0x2ABC360", VA = "0x2ABC360")]
		public static void UnRegisterTextElementForRebuild(TMP_Text element)
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x2ABC3F4", Offset = "0x2ABC3F4", VA = "0x2ABC3F4")]
		private void InternalUnRegisterTextElementForGraphicRebuild(TMP_Text element)
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x2ABC494", Offset = "0x2ABC494", VA = "0x2ABC494")]
		private void InternalUnRegisterTextElementForLayoutRebuild(TMP_Text element)
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x2ABC2C0", Offset = "0x2ABC2C0", VA = "0x2ABC2C0")]
		private void InternalUnRegisterTextObjectForUpdate(TMP_Text textObject)
		{
		}
	}
}
