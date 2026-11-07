using Il2CppDummyDll;
using UnityEngine;

namespace Puzzle
{
	[Token(Token = "0x200103B")]
	public class PuzzlePushableBox : PuzzleObjectBase
	{
		[Token(Token = "0x4005591")]
		[FieldOffset(Offset = "0x34")]
		public float speed;

		[Token(Token = "0x4005592")]
		[FieldOffset(Offset = "0x38")]
		public LayerMask layerMask;

		[Token(Token = "0x4005593")]
		[FieldOffset(Offset = "0x40")]
		private Rigidbody2D rb;

		[Token(Token = "0x4005594")]
		[FieldOffset(Offset = "0x48")]
		private Vector2 newPos;

		[Token(Token = "0x4005595")]
		[FieldOffset(Offset = "0x50")]
		private Vector2 resolveTo;

		[Token(Token = "0x4005596")]
		[FieldOffset(Offset = "0x58")]
		private bool resolveCollision;

		[Token(Token = "0x60048BE")]
		[Address(RVA = "0x162FF3C", Offset = "0x162FF3C", VA = "0x162FF3C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60048BF")]
		[Address(RVA = "0x162FF98", Offset = "0x162FF98", VA = "0x162FF98", Slot = "5")]
		public override void ResetObject()
		{
		}

		[Token(Token = "0x60048C0")]
		[Address(RVA = "0x162FFD8", Offset = "0x162FFD8", VA = "0x162FFD8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60048C1")]
		[Address(RVA = "0x1630038", Offset = "0x1630038", VA = "0x1630038")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60048C2")]
		[Address(RVA = "0x16300D8", Offset = "0x16300D8", VA = "0x16300D8")]
		private bool AnyHit(Vector2 _dir)
		{
			return default;
		}

		[Token(Token = "0x60048C3")]
		[Address(RVA = "0x16303D8", Offset = "0x16303D8", VA = "0x16303D8")]
		private void OnCollisionEnter2D(Collision2D collision)
		{
		}

		[Token(Token = "0x60048C4")]
		[Address(RVA = "0x16306B0", Offset = "0x16306B0", VA = "0x16306B0")]
		public PuzzlePushableBox()
		{
		}
	}
}
