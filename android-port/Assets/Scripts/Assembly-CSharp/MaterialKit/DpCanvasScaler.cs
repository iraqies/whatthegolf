using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace MaterialKit
{
	[Token(Token = "0x2001071")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x47834", Offset = "0x47834")]
	[ExecuteInEditMode]
	public class DpCanvasScaler : UIBehaviour
	{
		[Token(Token = "0x400569D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected float m_ReferencePixelsPerUnit;

		[Token(Token = "0x400569E")]
		private const float kLogBase = 2f;

		[Token(Token = "0x400569F")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		protected float m_FallbackScreenDPI;

		[Token(Token = "0x40056A0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected float m_DefaultSpriteDPI;

		[Token(Token = "0x40056A1")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected float m_DynamicPixelsPerUnit;

		[Token(Token = "0x40056A2")]
		[FieldOffset(Offset = "0x28")]
		private Canvas m_Canvas;

		[NonSerialized]
		[Token(Token = "0x40056A3")]
		[FieldOffset(Offset = "0x30")]
		private float m_PrevScaleFactor;

		[NonSerialized]
		[Token(Token = "0x40056A4")]
		[FieldOffset(Offset = "0x34")]
		private float m_PrevReferencePixelsPerUnit;

		[Token(Token = "0x170007C2")]
		public float referencePixelsPerUnit
		{
			[Token(Token = "0x60049BB")]
			[Address(RVA = "0x14343E0", Offset = "0x14343E0", VA = "0x14343E0")]
			get
			{
				return default;
			}
			[Token(Token = "0x60049BC")]
			[Address(RVA = "0x14343E8", Offset = "0x14343E8", VA = "0x14343E8")]
			set
			{
			}
		}

		[Token(Token = "0x170007C3")]
		public float fallbackScreenDPI
		{
			[Token(Token = "0x60049BD")]
			[Address(RVA = "0x14343F0", Offset = "0x14343F0", VA = "0x14343F0")]
			get
			{
				return default;
			}
			[Token(Token = "0x60049BE")]
			[Address(RVA = "0x14343F8", Offset = "0x14343F8", VA = "0x14343F8")]
			set
			{
			}
		}

		[Token(Token = "0x170007C4")]
		public float defaultSpriteDPI
		{
			[Token(Token = "0x60049BF")]
			[Address(RVA = "0x1434400", Offset = "0x1434400", VA = "0x1434400")]
			get
			{
				return default;
			}
			[Token(Token = "0x60049C0")]
			[Address(RVA = "0x1434408", Offset = "0x1434408", VA = "0x1434408")]
			set
			{
			}
		}

		[Token(Token = "0x170007C5")]
		public float dynamicPixelsPerUnit
		{
			[Token(Token = "0x60049C1")]
			[Address(RVA = "0x1434410", Offset = "0x1434410", VA = "0x1434410")]
			get
			{
				return default;
			}
			[Token(Token = "0x60049C2")]
			[Address(RVA = "0x1434418", Offset = "0x1434418", VA = "0x1434418")]
			set
			{
			}
		}

		[Token(Token = "0x60049C3")]
		[Address(RVA = "0x1434420", Offset = "0x1434420", VA = "0x1434420")]
		protected DpCanvasScaler()
		{
		}

		[Token(Token = "0x60049C4")]
		[Address(RVA = "0x1434448", Offset = "0x1434448", VA = "0x1434448", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60049C5")]
		[Address(RVA = "0x14344C0", Offset = "0x14344C0", VA = "0x14344C0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60049C6")]
		[Address(RVA = "0x14345E4", Offset = "0x14345E4", VA = "0x14345E4", Slot = "17")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60049C7")]
		[Address(RVA = "0x14345F4", Offset = "0x14345F4", VA = "0x14345F4", Slot = "18")]
		protected virtual void Handle()
		{
		}

		[Token(Token = "0x60049C8")]
		[Address(RVA = "0x14346DC", Offset = "0x14346DC", VA = "0x14346DC", Slot = "19")]
		protected virtual void HandleWorldCanvas()
		{
		}

		[Token(Token = "0x60049C9")]
		[Address(RVA = "0x1434754", Offset = "0x1434754", VA = "0x1434754", Slot = "20")]
		protected virtual void HandleConstantPhysicalSize()
		{
		}

		[Token(Token = "0x60049CA")]
		[Address(RVA = "0x143454C", Offset = "0x143454C", VA = "0x143454C")]
		protected void SetScaleFactor(float scaleFactor)
		{
		}

		[Token(Token = "0x60049CB")]
		[Address(RVA = "0x1434598", Offset = "0x1434598", VA = "0x1434598")]
		protected void SetReferencePixelsPerUnit(float referencePixelsPerUnit)
		{
		}
	}
}
