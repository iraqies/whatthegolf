using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x200023C")]
	public class PlanetaryGravity : MonoBehaviour
	{
		[Token(Token = "0x4000E97")]
		[FieldOffset(Offset = "0x18")]
		public Planet planet;

		[Token(Token = "0x4000E98")]
		private const float G = 6.672E-11f;

		[Token(Token = "0x4000E99")]
		[FieldOffset(Offset = "0x20")]
		private Rigidbody _r;

		[Token(Token = "0x170001D7")]
		private Rigidbody r
		{
			[Token(Token = "0x6000EF5")]
			[Address(RVA = "0x13C00EC", Offset = "0x13C00EC", VA = "0x13C00EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000EF6")]
		[Address(RVA = "0x13C0198", Offset = "0x13C0198", VA = "0x13C0198")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000EF7")]
		[Address(RVA = "0x13C0280", Offset = "0x13C0280", VA = "0x13C0280")]
		private void ApplyGravity(Rigidbody r)
		{
		}

		[Token(Token = "0x6000EF8")]
		[Address(RVA = "0x13C03A0", Offset = "0x13C03A0", VA = "0x13C03A0")]
		public PlanetaryGravity()
		{
		}
	}
}
