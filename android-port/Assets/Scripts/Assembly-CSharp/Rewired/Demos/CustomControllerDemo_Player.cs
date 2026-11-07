using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.Demos
{
	[Token(Token = "0x2001161")]
	[Attribute(Name = "RequireComponent", RVA = "0x47D34", Offset = "0x47D34")]
	public class CustomControllerDemo_Player : MonoBehaviour
	{
		[Token(Token = "0x4005BDF")]
		[FieldOffset(Offset = "0x18")]
		public int playerId;

		[Token(Token = "0x4005BE0")]
		[FieldOffset(Offset = "0x1C")]
		public float speed;

		[Token(Token = "0x4005BE1")]
		[FieldOffset(Offset = "0x20")]
		public float bulletSpeed;

		[Token(Token = "0x4005BE2")]
		[FieldOffset(Offset = "0x28")]
		public GameObject bulletPrefab;

		[Token(Token = "0x4005BE3")]
		[FieldOffset(Offset = "0x30")]
		private Player _player;

		[Token(Token = "0x4005BE4")]
		[FieldOffset(Offset = "0x38")]
		private CharacterController cc;

		[Token(Token = "0x1700088A")]
		private Player player
		{
			[Token(Token = "0x6004F50")]
			[Address(RVA = "0x18C6A48", Offset = "0x18C6A48", VA = "0x18C6A48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004F51")]
		[Address(RVA = "0x18C6AD0", Offset = "0x18C6AD0", VA = "0x18C6AD0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6004F52")]
		[Address(RVA = "0x18C6B2C", Offset = "0x18C6B2C", VA = "0x18C6B2C")]
		private void Update()
		{
		}

		[Token(Token = "0x6004F53")]
		[Address(RVA = "0x18C6EE4", Offset = "0x18C6EE4", VA = "0x18C6EE4")]
		public CustomControllerDemo_Player()
		{
		}
	}
}
