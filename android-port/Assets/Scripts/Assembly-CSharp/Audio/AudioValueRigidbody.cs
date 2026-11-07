using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x20013D3")]
	public class AudioValueRigidbody : BaseAudioValue
	{
		[Token(Token = "0x20013D4")]
		public enum RigidbodyValueListenType
		{
			[Token(Token = "0x4006A93")]
			VELOCITY_MAGNITUDE = 0,
			[Token(Token = "0x4006A94")]
			VELOCITY_X = 1,
			[Token(Token = "0x4006A95")]
			VELOCITY_Y = 2,
			[Token(Token = "0x4006A96")]
			VELOCITY_Z = 3,
			[Token(Token = "0x4006A97")]
			VELOCITY_XY_MAGNITUDE = 4,
			[Token(Token = "0x4006A98")]
			VELOCITY_XZ_MAGNITUDE = 5,
			[Token(Token = "0x4006A99")]
			ANGULAR_VELOCITY = 6,
			[Token(Token = "0x4006A9A")]
			ANGULAR_VELOCITY_X = 7,
			[Token(Token = "0x4006A9B")]
			ANGULAR_VELOCITY_Y = 8,
			[Token(Token = "0x4006A9C")]
			ANGULAR_VELOCITY_Z = 9
		}

		[Token(Token = "0x4006A8F")]
		[FieldOffset(Offset = "0x38")]
		public Rigidbody component3D;

		[Token(Token = "0x4006A90")]
		[FieldOffset(Offset = "0x40")]
		public Rigidbody2D component2D;

		[Token(Token = "0x4006A91")]
		[FieldOffset(Offset = "0x48")]
		public RigidbodyValueListenType listenType;

		[Token(Token = "0x17000A75")]
		protected override bool Use2D
		{
			[Token(Token = "0x6005C7A")]
			[Address(RVA = "0x1510948", Offset = "0x1510948", VA = "0x1510948", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005C7B")]
		[Address(RVA = "0x15109C4", Offset = "0x15109C4", VA = "0x15109C4")]
		private void Update()
		{
		}

		[Token(Token = "0x6005C7C")]
		[Address(RVA = "0x1510A9C", Offset = "0x1510A9C", VA = "0x1510A9C", Slot = "4")]
		public override string ValueInputName()
		{
			return null;
		}

		[Token(Token = "0x6005C7D")]
		[Address(RVA = "0x1510C2C", Offset = "0x1510C2C", VA = "0x1510C2C", Slot = "7")]
		protected override void SetValue()
		{
		}

		[Token(Token = "0x6005C7E")]
		[Address(RVA = "0x1510FA4", Offset = "0x1510FA4", VA = "0x1510FA4")]
		public AudioValueRigidbody()
		{
		}
	}
}
