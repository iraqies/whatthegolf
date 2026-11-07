using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x20001EC")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Token(Token = "0x4000D03")]
		[FieldOffset(Offset = "0x18")]
		public MechSpiderController mechSpiderController;

		[Token(Token = "0x4000D04")]
		[FieldOffset(Offset = "0x20")]
		private ParticleSystem particles;

		[Token(Token = "0x6000DC4")]
		[Address(RVA = "0x13AD644", Offset = "0x13AD644", VA = "0x13AD644")]
		private void Start()
		{
		}

		[Token(Token = "0x6000DC5")]
		[Address(RVA = "0x13AD71C", Offset = "0x13AD71C", VA = "0x13AD71C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000DC6")]
		[Address(RVA = "0x13AD9BC", Offset = "0x13AD9BC", VA = "0x13AD9BC")]
		public MechSpiderParticles()
		{
		}
	}
}
