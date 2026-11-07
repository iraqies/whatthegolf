using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Dynamics
{
	[Token(Token = "0x2000112")]
	public struct MuscleHit
	{
		[Token(Token = "0x400065D")]
		[FieldOffset(Offset = "0x0")]
		public int muscleIndex;

		[Token(Token = "0x400065E")]
		[FieldOffset(Offset = "0x4")]
		public float unPin;

		[Token(Token = "0x400065F")]
		[FieldOffset(Offset = "0x8")]
		public Vector3 force;

		[Token(Token = "0x4000660")]
		[FieldOffset(Offset = "0x14")]
		public Vector3 position;

		[Token(Token = "0x600072B")]
		[Address(RVA = "0x13B98B4", Offset = "0x13B98B4", VA = "0x13B98B4")]
		public MuscleHit(int muscleIndex, float unPin, Vector3 force, Vector3 position)
		{
		}
	}
}
