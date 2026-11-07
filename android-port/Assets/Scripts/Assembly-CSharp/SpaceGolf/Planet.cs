using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace SpaceGolf
{
	[Token(Token = "0x20010AA")]
	public class Planet : MonoBehaviour
	{
		[Token(Token = "0x40057B8")]
		public const float GravityMultiplier = 2000f;

		[Token(Token = "0x40057B9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float gravityMultiplier;

		[Token(Token = "0x40057BA")]
		[FieldOffset(Offset = "0x1C")]
		public float bounceMultiplier;

		[Token(Token = "0x40057BB")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 currentVelocity;

		[Token(Token = "0x40057BC")]
		[FieldOffset(Offset = "0x30")]
		private GolfBallController ball;

		[Token(Token = "0x40057BD")]
		[FieldOffset(Offset = "0x38")]
		private Rigidbody ballRB;

		[Token(Token = "0x40057BE")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 lastposition;

		[Token(Token = "0x170007E4")]
		private float planetRadius
		{
			[Token(Token = "0x6004AB4")]
			[Address(RVA = "0x15E4080", Offset = "0x15E4080", VA = "0x15E4080")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170007E5")]
		private Vector3 Gravity
		{
			[Token(Token = "0x6004AB5")]
			[Address(RVA = "0x15E40B0", Offset = "0x15E40B0", VA = "0x15E40B0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6004AB6")]
		[Address(RVA = "0x15E40F0", Offset = "0x15E40F0", VA = "0x15E40F0")]
		public Vector3 CalcGrav(Vector3 ballPosition)
		{
			return default;
		}

		[Token(Token = "0x6004AB7")]
		[Address(RVA = "0x15E41EC", Offset = "0x15E41EC", VA = "0x15E41EC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6004AB8")]
		[Address(RVA = "0x15E425C", Offset = "0x15E425C", VA = "0x15E425C")]
		private void Update()
		{
		}

		[Token(Token = "0x6004AB9")]
		[Address(RVA = "0x15E4420", Offset = "0x15E4420", VA = "0x15E4420")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6004ABA")]
		[Address(RVA = "0x15E4550", Offset = "0x15E4550", VA = "0x15E4550")]
		public Planet()
		{
		}
	}
}
