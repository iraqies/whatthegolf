using Il2CppDummyDll;
using UnityEngine;

namespace ch.sycoforge.Decal.Demo
{
	[Token(Token = "0x2000F46")]
	public class AdvancedBulletHoles : MonoBehaviour
	{
		[Token(Token = "0x4005284")]
		[FieldOffset(Offset = "0x18")]
		public EasyDecal DecalPrefab;

		[Token(Token = "0x4005285")]
		[FieldOffset(Offset = "0x20")]
		public GameObject ImpactParticles;

		[Token(Token = "0x4005286")]
		[FieldOffset(Offset = "0x28")]
		public float CastRadius;

		[Token(Token = "0x6004763")]
		[Address(RVA = "0x1409050", Offset = "0x1409050", VA = "0x1409050")]
		private void Start()
		{
		}

		[Token(Token = "0x6004764")]
		[Address(RVA = "0x1409158", Offset = "0x1409158", VA = "0x1409158")]
		private void Update()
		{
		}

		[Token(Token = "0x6004765")]
		[Address(RVA = "0x1409570", Offset = "0x1409570", VA = "0x1409570")]
		public AdvancedBulletHoles()
		{
		}
	}
}
