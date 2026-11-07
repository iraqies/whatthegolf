using Il2CppDummyDll;
using UnityEngine;

namespace TFHC_ForceShield_Shader_Sample
{
	[Token(Token = "0x200148F")]
	public class ForceShieldImpactDetection : MonoBehaviour
	{
		[Token(Token = "0x4007168")]
		[FieldOffset(Offset = "0x18")]
		private float hitTime;

		[Token(Token = "0x4007169")]
		[FieldOffset(Offset = "0x20")]
		private Material mat;

		[Token(Token = "0x60060BB")]
		[Address(RVA = "0x1471A94", Offset = "0x1471A94", VA = "0x1471A94")]
		private void Start()
		{
		}

		[Token(Token = "0x60060BC")]
		[Address(RVA = "0x1471B00", Offset = "0x1471B00", VA = "0x1471B00")]
		private void Update()
		{
		}

		[Token(Token = "0x60060BD")]
		[Address(RVA = "0x1471BA4", Offset = "0x1471BA4", VA = "0x1471BA4")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60060BE")]
		[Address(RVA = "0x1471D0C", Offset = "0x1471D0C", VA = "0x1471D0C")]
		public ForceShieldImpactDetection()
		{
		}
	}
}
