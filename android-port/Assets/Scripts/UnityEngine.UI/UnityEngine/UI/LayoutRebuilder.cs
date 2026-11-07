using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Events;

namespace UnityEngine.UI
{
	[Token(Token = "0x2000042")]
	public class LayoutRebuilder : ICanvasElement
	{
		[Serializable]
		[Token(Token = "0x2000043")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F65AC", Offset = "0x1F65AC")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4000159")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x400015A")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<Component> _003C_003E9__10_0;

			[Token(Token = "0x400015B")]
			[FieldOffset(Offset = "0x10")]
			public static UnityAction<Component> _003C_003E9__12_0;

			[Token(Token = "0x400015C")]
			[FieldOffset(Offset = "0x18")]
			public static UnityAction<Component> _003C_003E9__12_1;

			[Token(Token = "0x400015D")]
			[FieldOffset(Offset = "0x20")]
			public static UnityAction<Component> _003C_003E9__12_2;

			[Token(Token = "0x400015E")]
			[FieldOffset(Offset = "0x28")]
			public static UnityAction<Component> _003C_003E9__12_3;

			[Token(Token = "0x60002E2")]
			[Address(RVA = "0x2C45DCC", Offset = "0x2C45DCC", VA = "0x2C45DCC")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60002E3")]
			[Address(RVA = "0x2C45DD4", Offset = "0x2C45DD4", VA = "0x2C45DD4")]
			internal void _003C_002Ecctor_003Eb__5_0(LayoutRebuilder x)
			{
			}

			[Token(Token = "0x60002E4")]
			[Address(RVA = "0x2C45DF0", Offset = "0x2C45DF0", VA = "0x2C45DF0")]
			internal bool _003CStripDisabledBehavioursFromList_003Eb__10_0(Component e)
			{
				return default;
			}

			[Token(Token = "0x60002E5")]
			[Address(RVA = "0x2C45E7C", Offset = "0x2C45E7C", VA = "0x2C45E7C")]
			internal void _003CRebuild_003Eb__12_0(Component e)
			{
			}

			[Token(Token = "0x60002E6")]
			[Address(RVA = "0x2C45F50", Offset = "0x2C45F50", VA = "0x2C45F50")]
			internal void _003CRebuild_003Eb__12_1(Component e)
			{
			}

			[Token(Token = "0x60002E7")]
			[Address(RVA = "0x2C46024", Offset = "0x2C46024", VA = "0x2C46024")]
			internal void _003CRebuild_003Eb__12_2(Component e)
			{
			}

			[Token(Token = "0x60002E8")]
			[Address(RVA = "0x2C460FC", Offset = "0x2C460FC", VA = "0x2C460FC")]
			internal void _003CRebuild_003Eb__12_3(Component e)
			{
			}
		}

		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x10")]
		private RectTransform m_ToRebuild;

		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x18")]
		private int m_CachedHashFromTransform;

		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x0")]
		private static ObjectPool<LayoutRebuilder> s_Rebuilders;

		[Token(Token = "0x170000D0")]
		public Transform transform
		{
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x2C25544", Offset = "0x2C25544", VA = "0x2C25544", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x2C252F4", Offset = "0x2C252F4", VA = "0x2C252F4")]
		private void Initialize(RectTransform controller)
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x2C25334", Offset = "0x2C25334", VA = "0x2C25334")]
		private void Clear()
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x2C25340", Offset = "0x2C25340", VA = "0x2C25340")]
		static LayoutRebuilder()
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x2C254CC", Offset = "0x2C254CC", VA = "0x2C254CC")]
		private static void ReapplyDrivenProperties(RectTransform driven)
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x2C2554C", Offset = "0x2C2554C", VA = "0x2C2554C", Slot = "8")]
		public bool IsDestroyed()
		{
			return default;
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x2C255C8", Offset = "0x2C255C8", VA = "0x2C255C8")]
		private static void StripDisabledBehavioursFromList(List<Component> components)
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x2C256F8", Offset = "0x2C256F8", VA = "0x2C256F8")]
		public static void ForceRebuildLayoutImmediate(RectTransform layoutRoot)
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x2C257E8", Offset = "0x2C257E8", VA = "0x2C257E8", Slot = "4")]
		public void Rebuild(CanvasUpdate executing)
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x2C25EEC", Offset = "0x2C25EEC", VA = "0x2C25EEC")]
		private void PerformLayoutControl(RectTransform rect, UnityAction<Component> action)
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x2C25B90", Offset = "0x2C25B90", VA = "0x2C25B90")]
		private void PerformLayoutCalculation(RectTransform rect, UnityAction<Component> action)
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x2C23D2C", Offset = "0x2C23D2C", VA = "0x2C23D2C")]
		public static void MarkLayoutForRebuild(RectTransform rect)
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x2C26370", Offset = "0x2C26370", VA = "0x2C26370")]
		private static bool ValidController(RectTransform layoutRoot, List<Component> comps)
		{
			return default;
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x2C26590", Offset = "0x2C26590", VA = "0x2C26590")]
		private static void MarkLayoutRootForRebuild(RectTransform controller)
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x2C26718", Offset = "0x2C26718", VA = "0x2C26718", Slot = "6")]
		public void LayoutComplete()
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x2C267AC", Offset = "0x2C267AC", VA = "0x2C267AC", Slot = "7")]
		public void GraphicUpdateComplete()
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x2C267B0", Offset = "0x2C267B0", VA = "0x2C267B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x2C267B8", Offset = "0x2C267B8", VA = "0x2C267B8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default;
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x2C2680C", Offset = "0x2C2680C", VA = "0x2C2680C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x2C26884", Offset = "0x2C26884", VA = "0x2C26884")]
		public LayoutRebuilder()
		{
		}
	}
}
