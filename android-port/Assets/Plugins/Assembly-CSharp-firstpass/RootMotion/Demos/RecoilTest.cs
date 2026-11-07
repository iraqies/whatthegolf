using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x200020F")]
	[Attribute(Name = "RequireComponent", RVA = "0x33CCC", Offset = "0x33CCC")]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x4000DCD")]
		[FieldOffset(Offset = "0x18")]
		public float magnitude;

		[Token(Token = "0x4000DCE")]
		[FieldOffset(Offset = "0x20")]
		private Recoil recoil;

		[Token(Token = "0x6000E41")]
		[Address(RVA = "0x13DA154", Offset = "0x13DA154", VA = "0x13DA154")]
		private void Start()
		{
		}

		[Token(Token = "0x6000E42")]
		[Address(RVA = "0x13DA1B0", Offset = "0x13DA1B0", VA = "0x13DA1B0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000E43")]
		[Address(RVA = "0x13DA208", Offset = "0x13DA208", VA = "0x13DA208")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000E44")]
		[Address(RVA = "0x13DA2F0", Offset = "0x13DA2F0", VA = "0x13DA2F0")]
		public RecoilTest()
		{
		}
	}
}
