using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x20001FC")]
	[Attribute(Name = "RequireComponent", RVA = "0x33B60", Offset = "0x33B60")]
	[Attribute(Name = "RequireComponent", RVA = "0x33B60", Offset = "0x33B60")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x4000D67")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "RangeAttribute", RVA = "0x36CF8", Offset = "0x36CF8")]
		public float walkSpeed;

		[Token(Token = "0x4000D68")]
		[FieldOffset(Offset = "0x1C")]
		private float sVel;

		[Token(Token = "0x4000D69")]
		[FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x4000D6A")]
		[FieldOffset(Offset = "0x28")]
		private FPSAiming FPSAiming;

		[Token(Token = "0x6000E00")]
		[Address(RVA = "0x1370680", Offset = "0x1370680", VA = "0x1370680")]
		private void Start()
		{
		}

		[Token(Token = "0x6000E01")]
		[Address(RVA = "0x1370700", Offset = "0x1370700", VA = "0x1370700")]
		private void Update()
		{
		}

		[Token(Token = "0x6000E02")]
		[Address(RVA = "0x13707F0", Offset = "0x13707F0", VA = "0x13707F0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000E03")]
		[Address(RVA = "0x13708A8", Offset = "0x13708A8", VA = "0x13708A8")]
		public FPSCharacter()
		{
		}
	}
}
