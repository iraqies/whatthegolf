using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x20001F3")]
	[Attribute(Name = "RequireComponent", RVA = "0x33AF8", Offset = "0x33AF8")]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x4000D27")]
		[FieldOffset(Offset = "0x18")]
		public CameraController cam;

		[Token(Token = "0x4000D28")]
		[FieldOffset(Offset = "0x20")]
		private AnimatorController3rdPerson animatorController;

		[Token(Token = "0x170001BE")]
		private static Vector3 inputVector
		{
			[Token(Token = "0x6000DDF")]
			[Address(RVA = "0x135D1C8", Offset = "0x135D1C8", VA = "0x135D1C8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001BF")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x6000DE0")]
			[Address(RVA = "0x135D254", Offset = "0x135D254", VA = "0x135D254")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000DDD")]
		[Address(RVA = "0x135CF08", Offset = "0x135CF08", VA = "0x135CF08")]
		private void Start()
		{
		}

		[Token(Token = "0x6000DDE")]
		[Address(RVA = "0x135CF78", Offset = "0x135CF78", VA = "0x135CF78")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000DE1")]
		[Address(RVA = "0x135D2E0", Offset = "0x135D2E0", VA = "0x135D2E0")]
		public CharacterController3rdPerson()
		{
		}
	}
}
