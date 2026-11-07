using Il2CppDummyDll;
using UnityEngine;

namespace CameraStack
{
	[Token(Token = "0x2001114")]
	public abstract class CameraBehaviorOrthographic : CameraBehavior
	{
		[Token(Token = "0x4005A6A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected float orthographicSize;

		[Token(Token = "0x6004CD0")]
		[Address(RVA = "0x17DFF18", Offset = "0x17DFF18", VA = "0x17DFF18", Slot = "4")]
		public override void Init()
		{
		}

		[Token(Token = "0x6004CD1")]
		[Address(RVA = "0x17DFC4C", Offset = "0x17DFC4C", VA = "0x17DFC4C")]
		protected CameraBehaviorOrthographic()
		{
		}
	}
}
