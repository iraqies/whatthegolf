using Il2CppDummyDll;
using UnityEngine;

namespace CameraStack
{
	[Token(Token = "0x2001107")]
	public class CBOrbit : CameraBehaviorPerspective
	{
		[Token(Token = "0x4005A07")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Vector3 target;

		[Token(Token = "0x4005A08")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float distance;

		[Token(Token = "0x4005A09")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float speed;

		[Token(Token = "0x4005A0A")]
		[FieldOffset(Offset = "0x50")]
		private float angle;

		[Token(Token = "0x6004C74")]
		[Address(RVA = "0x17DF314", Offset = "0x17DF314", VA = "0x17DF314")]
		private void Awake()
		{
		}

		[Token(Token = "0x6004C75")]
		[Address(RVA = "0x17DF3AC", Offset = "0x17DF3AC", VA = "0x17DF3AC", Slot = "7")]
		public override Quaternion CalculateRotation()
		{
			return default;
		}

		[Token(Token = "0x6004C76")]
		[Address(RVA = "0x17DF3FC", Offset = "0x17DF3FC", VA = "0x17DF3FC", Slot = "8")]
		protected override Vector3 CalculatePosition()
		{
			return default;
		}

		[Token(Token = "0x6004C77")]
		[Address(RVA = "0x17DF4C0", Offset = "0x17DF4C0", VA = "0x17DF4C0")]
		public CBOrbit()
		{
		}
	}
}
