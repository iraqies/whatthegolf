using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.Demos
{
	[Token(Token = "0x2001171")]
	public class Bullet : MonoBehaviour
	{
		[Token(Token = "0x4005C34")]
		[FieldOffset(Offset = "0x18")]
		public float lifeTime;

		[Token(Token = "0x4005C35")]
		[FieldOffset(Offset = "0x1C")]
		private bool die;

		[Token(Token = "0x4005C36")]
		[FieldOffset(Offset = "0x20")]
		private float deathTime;

		[Token(Token = "0x6004FBA")]
		[Address(RVA = "0x170B5E0", Offset = "0x170B5E0", VA = "0x170B5E0")]
		private void Start()
		{
		}

		[Token(Token = "0x6004FBB")]
		[Address(RVA = "0x170B624", Offset = "0x170B624", VA = "0x170B624")]
		private void Update()
		{
		}

		[Token(Token = "0x6004FBC")]
		[Address(RVA = "0x170B6C8", Offset = "0x170B6C8", VA = "0x170B6C8")]
		public Bullet()
		{
		}
	}
}
