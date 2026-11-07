using Il2CppDummyDll;
using UnityEngine;

namespace TFHC_ForceShield_Shader_Sample
{
	[Token(Token = "0x2001490")]
	public class ForceShieldShootBall : MonoBehaviour
	{
		[Token(Token = "0x400716A")]
		[FieldOffset(Offset = "0x18")]
		public Rigidbody bullet;

		[Token(Token = "0x400716B")]
		[FieldOffset(Offset = "0x20")]
		public Transform origshoot;

		[Token(Token = "0x400716C")]
		[FieldOffset(Offset = "0x28")]
		public float speed;

		[Token(Token = "0x400716D")]
		[FieldOffset(Offset = "0x2C")]
		private float distance;

		[Token(Token = "0x60060BF")]
		[Address(RVA = "0x1471D14", Offset = "0x1471D14", VA = "0x1471D14")]
		private void Update()
		{
		}

		[Token(Token = "0x60060C0")]
		[Address(RVA = "0x1471F00", Offset = "0x1471F00", VA = "0x1471F00")]
		public ForceShieldShootBall()
		{
		}
	}
}
