using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.Demos
{
	[Token(Token = "0x200116D")]
	[Attribute(Name = "RequireComponent", RVA = "0x47F4C", Offset = "0x47F4C")]
	public class PressAnyButtonToJoinExample_GamePlayer : MonoBehaviour
	{
		[Token(Token = "0x4005C20")]
		[FieldOffset(Offset = "0x18")]
		public int playerId;

		[Token(Token = "0x4005C21")]
		[FieldOffset(Offset = "0x1C")]
		public float moveSpeed;

		[Token(Token = "0x4005C22")]
		[FieldOffset(Offset = "0x20")]
		public float bulletSpeed;

		[Token(Token = "0x4005C23")]
		[FieldOffset(Offset = "0x28")]
		public GameObject bulletPrefab;

		[Token(Token = "0x4005C24")]
		[FieldOffset(Offset = "0x30")]
		private CharacterController cc;

		[Token(Token = "0x4005C25")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 moveVector;

		[Token(Token = "0x4005C26")]
		[FieldOffset(Offset = "0x44")]
		private bool fire;

		[Token(Token = "0x1700088F")]
		private Player player
		{
			[Token(Token = "0x6004FA7")]
			[Address(RVA = "0x161E474", Offset = "0x161E474", VA = "0x161E474")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004FA8")]
		[Address(RVA = "0x161E564", Offset = "0x161E564", VA = "0x161E564")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6004FA9")]
		[Address(RVA = "0x161E5C0", Offset = "0x161E5C0", VA = "0x161E5C0")]
		private void Update()
		{
		}

		[Token(Token = "0x6004FAA")]
		[Address(RVA = "0x161E698", Offset = "0x161E698", VA = "0x161E698")]
		private void GetInput()
		{
		}

		[Token(Token = "0x6004FAB")]
		[Address(RVA = "0x161E75C", Offset = "0x161E75C", VA = "0x161E75C")]
		private void ProcessInput()
		{
		}

		[Token(Token = "0x6004FAC")]
		[Address(RVA = "0x161E970", Offset = "0x161E970", VA = "0x161E970")]
		public PressAnyButtonToJoinExample_GamePlayer()
		{
		}
	}
}
