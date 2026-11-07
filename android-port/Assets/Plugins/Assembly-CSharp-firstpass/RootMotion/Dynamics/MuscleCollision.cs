using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Dynamics
{
	[Token(Token = "0x2000111")]
	public struct MuscleCollision
	{
		[Token(Token = "0x400065A")]
		[FieldOffset(Offset = "0x0")]
		public int muscleIndex;

		[Token(Token = "0x400065B")]
		[FieldOffset(Offset = "0x8")]
		public Collision collision;

		[Token(Token = "0x400065C")]
		[FieldOffset(Offset = "0x10")]
		public bool isStay;

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x13B97B8", Offset = "0x13B97B8", VA = "0x13B97B8")]
		public MuscleCollision(int muscleIndex, Collision collision, bool isStay = false)
		{
		}
	}
}
