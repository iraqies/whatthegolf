using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace BustAMoveGolf
{
	[Token(Token = "0x20010E0")]
	public class BustAMoveGolfShooter : GolfBallShooterBase
	{
		[Token(Token = "0x40058EB")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject ballPrefab;

		[Token(Token = "0x40058EC")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float speed;

		[Token(Token = "0x40058ED")]
		[FieldOffset(Offset = "0x70")]
		public List<AudioClip> ShootSounds;

		[Token(Token = "0x40058EE")]
		[FieldOffset(Offset = "0x78")]
		private BustAMoveColor nextColor;

		[Token(Token = "0x40058EF")]
		[FieldOffset(Offset = "0x80")]
		private SimplexGridManager simplexGridManager;

		[Token(Token = "0x40058F0")]
		[FieldOffset(Offset = "0x88")]
		private Renderer renderer;

		[Token(Token = "0x6004B94")]
		[Address(RVA = "0x17D9938", Offset = "0x17D9938", VA = "0x17D9938", Slot = "11")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004B95")]
		[Address(RVA = "0x17D9A88", Offset = "0x17D9A88", VA = "0x17D9A88", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6004B96")]
		[Address(RVA = "0x17D9A2C", Offset = "0x17D9A2C", VA = "0x17D9A2C")]
		private void SetNextColor()
		{
		}

		[Token(Token = "0x6004B97")]
		[Address(RVA = "0x17D9CCC", Offset = "0x17D9CCC", VA = "0x17D9CCC")]
		public BustAMoveGolfShooter()
		{
		}
	}
}
