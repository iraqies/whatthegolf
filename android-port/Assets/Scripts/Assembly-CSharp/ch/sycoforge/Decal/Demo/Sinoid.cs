using Il2CppDummyDll;
using UnityEngine;

namespace ch.sycoforge.Decal.Demo
{
	[Token(Token = "0x2000F4B")]
	public class Sinoid : MonoBehaviour
	{
		[Token(Token = "0x4005296")]
		[FieldOffset(Offset = "0x18")]
		public float AngularVelocity;

		[Token(Token = "0x4005297")]
		[FieldOffset(Offset = "0x1C")]
		public float SineFreq;

		[Token(Token = "0x4005298")]
		[FieldOffset(Offset = "0x20")]
		public float Amplitude;

		[Token(Token = "0x4005299")]
		[FieldOffset(Offset = "0x24")]
		private float accuTime;

		[Token(Token = "0x400529A")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 startPos;

		[Token(Token = "0x6004772")]
		[Address(RVA = "0x16B33C0", Offset = "0x16B33C0", VA = "0x16B33C0")]
		private void Start()
		{
		}

		[Token(Token = "0x6004773")]
		[Address(RVA = "0x16B33FC", Offset = "0x16B33FC", VA = "0x16B33FC")]
		private void Update()
		{
		}

		[Token(Token = "0x6004774")]
		[Address(RVA = "0x16B3544", Offset = "0x16B3544", VA = "0x16B3544")]
		public Sinoid()
		{
		}
	}
}
