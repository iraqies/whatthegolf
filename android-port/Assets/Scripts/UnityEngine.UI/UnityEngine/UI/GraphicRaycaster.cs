using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	[Token(Token = "0x2000019")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x1F6204", Offset = "0x1F6204")]
	public class GraphicRaycaster : BaseRaycaster
	{
		[Token(Token = "0x200001A")]
		public enum BlockingObjects
		{
			[Token(Token = "0x4000074")]
			None = 0,
			[Token(Token = "0x4000075")]
			TwoD = 1,
			[Token(Token = "0x4000076")]
			ThreeD = 2,
			[Token(Token = "0x4000077")]
			All = 3
		}

		[Serializable]
		[Token(Token = "0x200001B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F626C", Offset = "0x1F626C")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4000078")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4000079")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<Graphic> _003C_003E9__27_0;

			[Token(Token = "0x6000109")]
			[Address(RVA = "0x2C45110", Offset = "0x2C45110", VA = "0x2C45110")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x600010A")]
			[Address(RVA = "0x2C45118", Offset = "0x2C45118", VA = "0x2C45118")]
			internal int _003CRaycast_003Eb__27_0(Graphic g1, Graphic g2)
			{
				return default;
			}
		}

		[Token(Token = "0x400006C")]
		protected const int kNoEventMaskSet = -1;

		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F7380", Offset = "0x1F7380")]
		private bool m_IgnoreReversedGraphics;

		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F73CC", Offset = "0x1F73CC")]
		private BlockingObjects m_BlockingObjects;

		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected LayerMask m_BlockingMask;

		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x30")]
		private Canvas m_Canvas;

		[NonSerialized]
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x38")]
		private List<Graphic> m_RaycastResults;

		[NonSerialized]
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<Graphic> s_SortedGraphics;

		[Token(Token = "0x17000041")]
		public override int sortOrderPriority
		{
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x2C096FC", Offset = "0x2C096FC", VA = "0x2C096FC", Slot = "20")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000042")]
		public override int renderOrderPriority
		{
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x2C09800", Offset = "0x2C09800", VA = "0x2C09800", Slot = "21")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000043")]
		public bool ignoreReversedGraphics
		{
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x2C09860", Offset = "0x2C09860", VA = "0x2C09860")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x2C09868", Offset = "0x2C09868", VA = "0x2C09868")]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public BlockingObjects blockingObjects
		{
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x2C09870", Offset = "0x2C09870", VA = "0x2C09870")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x2C09878", Offset = "0x2C09878", VA = "0x2C09878")]
			set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public LayerMask blockingMask
		{
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x2C09880", Offset = "0x2C09880", VA = "0x2C09880")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x2C09888", Offset = "0x2C09888", VA = "0x2C09888")]
			set
			{
			}
		}

		[Token(Token = "0x17000046")]
		private Canvas canvas
		{
			[Token(Token = "0x6000103")]
			[Address(RVA = "0x2C09750", Offset = "0x2C09750", VA = "0x2C09750")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		public override Camera eventCamera
		{
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x2C0ABB0", Offset = "0x2C0ABB0", VA = "0x2C0ABB0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x2C09890", Offset = "0x2C09890", VA = "0x2C09890")]
		protected GraphicRaycaster()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x2C09928", Offset = "0x2C09928", VA = "0x2C09928", Slot = "17")]
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x2C0A57C", Offset = "0x2C0A57C", VA = "0x2C0A57C")]
		private static void Raycast(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, IList<Graphic> foundGraphics, List<Graphic> results)
		{
		}
	}
}
