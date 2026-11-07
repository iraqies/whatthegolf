using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x20013D8")]
	public class AudioValueSpringJoint : BaseAudioValue
	{
		[Token(Token = "0x20013D9")]
		public enum SpringJointValueListenType
		{
			[Token(Token = "0x4006AB6")]
			SPRING = 0,
			[Token(Token = "0x4006AB7")]
			SPRING_DELTA = 1,
			[Token(Token = "0x4006AB8")]
			CURRENT_FORCE = 2,
			[Token(Token = "0x4006AB9")]
			CURRENT_TORQUE = 3
		}

		[Token(Token = "0x4006AB2")]
		[FieldOffset(Offset = "0x38")]
		public SpringJoint component3D;

		[Token(Token = "0x4006AB3")]
		[FieldOffset(Offset = "0x40")]
		public SpringJoint2D component2D;

		[Token(Token = "0x4006AB4")]
		[FieldOffset(Offset = "0x48")]
		public SpringJointValueListenType listenType;

		[Token(Token = "0x17000A7A")]
		protected override bool Use2D
		{
			[Token(Token = "0x6005C98")]
			[Address(RVA = "0x1512214", Offset = "0x1512214", VA = "0x1512214", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005C99")]
		[Address(RVA = "0x1512290", Offset = "0x1512290", VA = "0x1512290")]
		private void Update()
		{
		}

		[Token(Token = "0x6005C9A")]
		[Address(RVA = "0x1512368", Offset = "0x1512368", VA = "0x1512368", Slot = "7")]
		protected override void SetValue()
		{
		}

		[Token(Token = "0x6005C9B")]
		[Address(RVA = "0x15124F0", Offset = "0x15124F0", VA = "0x15124F0")]
		public AudioValueSpringJoint()
		{
		}
	}
}
