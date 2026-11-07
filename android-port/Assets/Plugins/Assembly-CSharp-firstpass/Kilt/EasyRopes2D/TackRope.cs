using Il2CppDummyDll;
using UnityEngine;

namespace Kilt.EasyRopes2D
{
	[Token(Token = "0x20000B4")]
	public class TackRope : Rope2D
	{
		[Token(Token = "0x4000375")]
		[FieldOffset(Offset = "0x16C")]
		[SerializeField]
		private int m_tackAIndex;

		[Token(Token = "0x4000376")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private int m_tackBIndex;

		[Token(Token = "0x4000377")]
		[FieldOffset(Offset = "0x174")]
		private bool _tackUpdated;

		[Token(Token = "0x170000C0")]
		public int TackAIndex
		{
			[Token(Token = "0x60004B6")]
			[Address(RVA = "0x1318734", Offset = "0x1318734", VA = "0x1318734")]
			get
			{
				return default;
			}
			[Token(Token = "0x60004B7")]
			[Address(RVA = "0x131873C", Offset = "0x131873C", VA = "0x131873C")]
			set
			{
			}
		}

		[Token(Token = "0x170000C1")]
		public int TackBIndex
		{
			[Token(Token = "0x60004B8")]
			[Address(RVA = "0x131878C", Offset = "0x131878C", VA = "0x131878C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60004B9")]
			[Address(RVA = "0x1318794", Offset = "0x1318794", VA = "0x1318794")]
			set
			{
			}
		}

		[Token(Token = "0x170000C2")]
		public override GameObject ObjectA
		{
			[Token(Token = "0x60004BA")]
			[Address(RVA = "0x13187E4", Offset = "0x13187E4", VA = "0x13187E4", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004BB")]
			[Address(RVA = "0x13187EC", Offset = "0x13187EC", VA = "0x13187EC", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x170000C3")]
		public override GameObject ObjectB
		{
			[Token(Token = "0x60004BC")]
			[Address(RVA = "0x131891C", Offset = "0x131891C", VA = "0x131891C", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004BD")]
			[Address(RVA = "0x1318924", Offset = "0x1318924", VA = "0x1318924", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x1318A54", Offset = "0x1318A54", VA = "0x1318A54", Slot = "35")]
		protected override void CorrectValues()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x1318AA0", Offset = "0x1318AA0", VA = "0x1318AA0", Slot = "18")]
		public override void CreateRope(bool p_clearNodes = true)
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x1318ADC", Offset = "0x1318ADC", VA = "0x1318ADC", Slot = "39")]
		protected virtual void UpdateTackObjectsBeforeRopeCreated()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x1318DA8", Offset = "0x1318DA8", VA = "0x1318DA8")]
		public TackRope()
		{
		}
	}
}
