using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Dynamics
{
	[Token(Token = "0x200010A")]
	public class JointBreakBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x40005E8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x40005E9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public int muscleIndex;

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x13A7794", Offset = "0x13A7794", VA = "0x13A7794")]
		private void OnJointBreak()
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x13A7818", Offset = "0x13A7818", VA = "0x13A7818")]
		public JointBreakBroadcaster()
		{
		}
	}
}
