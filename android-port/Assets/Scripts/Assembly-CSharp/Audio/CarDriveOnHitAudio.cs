using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x200135C")]
	public class CarDriveOnHitAudio : MonoBehaviour
	{
		[Token(Token = "0x40067A6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ClipSettingsCollection clipOnHit;

		[Token(Token = "0x40067A7")]
		[FieldOffset(Offset = "0x20")]
		private AudioSource source;

		[Token(Token = "0x6005A4F")]
		[Address(RVA = "0x1888D3C", Offset = "0x1888D3C", VA = "0x1888D3C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005A50")]
		[Address(RVA = "0x1888D98", Offset = "0x1888D98", VA = "0x1888D98")]
		public void OnHit()
		{
		}

		[Token(Token = "0x6005A51")]
		[Address(RVA = "0x1888E10", Offset = "0x1888E10", VA = "0x1888E10")]
		public CarDriveOnHitAudio()
		{
		}
	}
}
