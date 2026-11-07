using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x20013CD")]
	public class AudioValueJoint : BaseAudioValue
	{
		[Token(Token = "0x20013CE")]
		public enum JointValueListenType
		{
			[Token(Token = "0x4006A72")]
			ANCHOR_X = 0,
			[Token(Token = "0x4006A73")]
			ANCHOR_Y = 1,
			[Token(Token = "0x4006A74")]
			ANCHOR_Z = 2,
			[Token(Token = "0x4006A75")]
			ANCHOR_MAGNITUDE = 3
		}

		[Token(Token = "0x4006A6D")]
		[FieldOffset(Offset = "0x38")]
		public Joint component3D;

		[Token(Token = "0x4006A6E")]
		[FieldOffset(Offset = "0x40")]
		public Joint2D component2D;

		[Token(Token = "0x4006A6F")]
		[FieldOffset(Offset = "0x48")]
		public JointValueListenType listenType;

		[Token(Token = "0x4006A70")]
		[FieldOffset(Offset = "0x4C")]
		public bool useDelta;

		[Token(Token = "0x17000A71")]
		protected override bool Use2D
		{
			[Token(Token = "0x6005C62")]
			[Address(RVA = "0x150FD7C", Offset = "0x150FD7C", VA = "0x150FD7C", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005C63")]
		[Address(RVA = "0x150FDF8", Offset = "0x150FDF8", VA = "0x150FDF8")]
		private void Update()
		{
		}

		[Token(Token = "0x6005C64")]
		[Address(RVA = "0x150FED0", Offset = "0x150FED0", VA = "0x150FED0", Slot = "7")]
		protected override void SetValue()
		{
		}

		[Token(Token = "0x6005C65")]
		[Address(RVA = "0x1510054", Offset = "0x1510054", VA = "0x1510054")]
		public AudioValueJoint()
		{
		}
	}
}
