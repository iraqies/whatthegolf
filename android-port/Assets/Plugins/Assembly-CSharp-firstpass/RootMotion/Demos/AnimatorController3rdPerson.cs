using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x20001F0")]
	[Attribute(Name = "RequireComponent", RVA = "0x3398C", Offset = "0x3398C")]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x4000D12")]
		[FieldOffset(Offset = "0x18")]
		public float rotateSpeed;

		[Token(Token = "0x4000D13")]
		[FieldOffset(Offset = "0x1C")]
		public float blendSpeed;

		[Token(Token = "0x4000D14")]
		[FieldOffset(Offset = "0x20")]
		public float maxAngle;

		[Token(Token = "0x4000D15")]
		[FieldOffset(Offset = "0x24")]
		public float moveSpeed;

		[Token(Token = "0x4000D16")]
		[FieldOffset(Offset = "0x28")]
		public float rootMotionWeight;

		[Token(Token = "0x4000D17")]
		[FieldOffset(Offset = "0x30")]
		protected Animator animator;

		[Token(Token = "0x4000D18")]
		[FieldOffset(Offset = "0x38")]
		protected Vector3 moveBlend;

		[Token(Token = "0x4000D19")]
		[FieldOffset(Offset = "0x44")]
		protected Vector3 moveInput;

		[Token(Token = "0x4000D1A")]
		[FieldOffset(Offset = "0x50")]
		protected Vector3 velocity;

		[Token(Token = "0x6000DCC")]
		[Address(RVA = "0x12EEA84", Offset = "0x12EEA84", VA = "0x12EEA84", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000DCD")]
		[Address(RVA = "0x12EEAE0", Offset = "0x12EEAE0", VA = "0x12EEAE0")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000DCE")]
		[Address(RVA = "0x12EEC88", Offset = "0x12EEC88", VA = "0x12EEC88", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x6000DCF")]
		[Address(RVA = "0x12EEE94", Offset = "0x12EEE94", VA = "0x12EEE94")]
		public AnimatorController3rdPerson()
		{
		}
	}
}
