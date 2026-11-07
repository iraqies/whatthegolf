using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x2000225")]
	public class BoardController : MonoBehaviour
	{
		[Token(Token = "0x4000E32")]
		[FieldOffset(Offset = "0x18")]
		public int groundLayer;

		[Token(Token = "0x4000E33")]
		[FieldOffset(Offset = "0x20")]
		public Transform rotationTarget;

		[Token(Token = "0x4000E34")]
		[FieldOffset(Offset = "0x28")]
		public float torque;

		[Token(Token = "0x4000E35")]
		[FieldOffset(Offset = "0x2C")]
		public float skidDrag;

		[Token(Token = "0x4000E36")]
		[FieldOffset(Offset = "0x30")]
		public float turnSensitivity;

		[Token(Token = "0x4000E37")]
		[FieldOffset(Offset = "0x38")]
		private Rigidbody r;

		[Token(Token = "0x4000E38")]
		[FieldOffset(Offset = "0x40")]
		private bool isGrounded;

		[Token(Token = "0x6000E95")]
		[Address(RVA = "0x130C078", Offset = "0x130C078", VA = "0x130C078")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000E96")]
		[Address(RVA = "0x130C0D4", Offset = "0x130C0D4", VA = "0x130C0D4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000E97")]
		[Address(RVA = "0x130C238", Offset = "0x130C238", VA = "0x130C238")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000E98")]
		[Address(RVA = "0x130C47C", Offset = "0x130C47C", VA = "0x130C47C")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x6000E99")]
		[Address(RVA = "0x130C4D8", Offset = "0x130C4D8", VA = "0x130C4D8")]
		private void OnCollisionStay(Collision c)
		{
		}

		[Token(Token = "0x6000E9A")]
		[Address(RVA = "0x130C534", Offset = "0x130C534", VA = "0x130C534")]
		private void OnCollisionExit(Collision c)
		{
		}

		[Token(Token = "0x6000E9B")]
		[Address(RVA = "0x130C58C", Offset = "0x130C58C", VA = "0x130C58C")]
		public BoardController()
		{
		}
	}
}
