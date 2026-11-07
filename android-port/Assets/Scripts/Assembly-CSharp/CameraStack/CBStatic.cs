using Il2CppDummyDll;
using UnityEngine;

namespace CameraStack
{
	[Token(Token = "0x2001111")]
	public class CBStatic : CameraBehaviorPerspective
	{
		[Token(Token = "0x4005A65")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform trans;

		[Token(Token = "0x6004CB9")]
		[Address(RVA = "0x17E3228", Offset = "0x17E3228", VA = "0x17E3228", Slot = "4")]
		public override void Init()
		{
		}

		[Token(Token = "0x6004CBA")]
		[Address(RVA = "0x17E32C0", Offset = "0x17E32C0", VA = "0x17E32C0", Slot = "8")]
		protected override Vector3 CalculatePosition()
		{
			return default;
		}

		[Token(Token = "0x6004CBB")]
		[Address(RVA = "0x17E3364", Offset = "0x17E3364", VA = "0x17E3364", Slot = "7")]
		public override Quaternion CalculateRotation()
		{
			return default;
		}

		[Token(Token = "0x6004CBC")]
		[Address(RVA = "0x17E3408", Offset = "0x17E3408", VA = "0x17E3408")]
		public CBStatic()
		{
		}
	}
}
