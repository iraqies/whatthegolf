using Il2CppDummyDll;
using RootMotion.Dynamics;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x2000238")]
	public class Killing : MonoBehaviour
	{
		[Token(Token = "0x4000E86")]
		[FieldOffset(Offset = "0x18")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000E87")]
		[FieldOffset(Offset = "0x20")]
		public PuppetMaster.StateSettings stateSettings;

		[Token(Token = "0x6000EEB")]
		[Address(RVA = "0x13A7D14", Offset = "0x13A7D14", VA = "0x13A7D14")]
		private void Update()
		{
		}

		[Token(Token = "0x6000EEC")]
		[Address(RVA = "0x13A7DC4", Offset = "0x13A7DC4", VA = "0x13A7DC4")]
		public Killing()
		{
		}
	}
}
