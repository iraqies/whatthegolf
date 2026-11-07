using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Dynamics
{
	[Token(Token = "0x2000130")]
	public class InitialVelocity : MonoBehaviour
	{
		[Token(Token = "0x4000754")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 initialVelocity;

		[Token(Token = "0x6000858")]
		[Address(RVA = "0x139D610", Offset = "0x139D610", VA = "0x139D610")]
		private void Start()
		{
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0x139D67C", Offset = "0x139D67C", VA = "0x139D67C")]
		public InitialVelocity()
		{
		}
	}
}
