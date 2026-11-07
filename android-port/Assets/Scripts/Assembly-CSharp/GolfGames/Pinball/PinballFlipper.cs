using Il2CppDummyDll;
using UnityEngine;

namespace GolfGames.Pinball
{
	[Token(Token = "0x20010B2")]
	public class PinballFlipper : MonoBehaviour
	{
		[Token(Token = "0x40057EF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public PinballFlipperType Type;

		[Token(Token = "0x40057F0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public HingeJoint2D Joint;

		[Token(Token = "0x40057F1")]
		[FieldOffset(Offset = "0x28")]
		private float startMotorSpeed;

		[Token(Token = "0x6004AD6")]
		[Address(RVA = "0x15E28C4", Offset = "0x15E28C4", VA = "0x15E28C4")]
		private void Start()
		{
		}

		[Token(Token = "0x6004AD7")]
		[Address(RVA = "0x15E2914", Offset = "0x15E2914", VA = "0x15E2914")]
		public void Toggle(bool isFlipped)
		{
		}

		[Token(Token = "0x6004AD8")]
		[Address(RVA = "0x15E2988", Offset = "0x15E2988", VA = "0x15E2988")]
		public PinballFlipper()
		{
		}
	}
}
