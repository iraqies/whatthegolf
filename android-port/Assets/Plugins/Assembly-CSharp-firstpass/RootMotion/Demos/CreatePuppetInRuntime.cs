using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x200022B")]
	public class CreatePuppetInRuntime : MonoBehaviour
	{
		[Token(Token = "0x4000E4A")]
		[FieldOffset(Offset = "0x18")]
		public Transform ragdollPrefab;

		[Token(Token = "0x4000E4B")]
		[FieldOffset(Offset = "0x20")]
		public string instanceName;

		[Token(Token = "0x4000E4C")]
		[FieldOffset(Offset = "0x28")]
		public int characterControllerLayer;

		[Token(Token = "0x4000E4D")]
		[FieldOffset(Offset = "0x2C")]
		public int ragdollLayer;

		[Token(Token = "0x6000EAD")]
		[Address(RVA = "0x1362438", Offset = "0x1362438", VA = "0x1362438")]
		private void Start()
		{
		}

		[Token(Token = "0x6000EAE")]
		[Address(RVA = "0x13625B8", Offset = "0x13625B8", VA = "0x13625B8")]
		public CreatePuppetInRuntime()
		{
		}
	}
}
