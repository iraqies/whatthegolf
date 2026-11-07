using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.Demos
{
	[Token(Token = "0x200115F")]
	public class CustomControllersTiltDemo : MonoBehaviour
	{
		[Token(Token = "0x4005BD0")]
		[FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4005BD1")]
		[FieldOffset(Offset = "0x20")]
		public float speed;

		[Token(Token = "0x4005BD2")]
		[FieldOffset(Offset = "0x28")]
		private CustomController controller;

		[Token(Token = "0x4005BD3")]
		[FieldOffset(Offset = "0x30")]
		private Player player;

		[Token(Token = "0x6004F41")]
		[Address(RVA = "0x18C6EF8", Offset = "0x18C6EF8", VA = "0x18C6EF8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6004F42")]
		[Address(RVA = "0x18C7044", Offset = "0x18C7044", VA = "0x18C7044")]
		private void Update()
		{
		}

		[Token(Token = "0x6004F43")]
		[Address(RVA = "0x18C71BC", Offset = "0x18C71BC", VA = "0x18C71BC")]
		private void OnInputUpdate()
		{
		}

		[Token(Token = "0x6004F44")]
		[Address(RVA = "0x18C7234", Offset = "0x18C7234", VA = "0x18C7234")]
		public CustomControllersTiltDemo()
		{
		}
	}
}
