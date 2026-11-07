using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x20013A1")]
	public class BoilingEggRTPC : MonoBehaviour
	{
		[Token(Token = "0x4006982")]
		[FieldOffset(Offset = "0x18")]
		public Transform egg;

		[Token(Token = "0x4006983")]
		[FieldOffset(Offset = "0x20")]
		public Transform flag;

		[Token(Token = "0x4006984")]
		[FieldOffset(Offset = "0x28")]
		public BoilEgg boilEggBehaviour;

		[Token(Token = "0x4006985")]
		[FieldOffset(Offset = "0x30")]
		private bool boiled;

		[Token(Token = "0x4006986")]
		[FieldOffset(Offset = "0x34")]
		private float baseRTPCValue;

		[Token(Token = "0x4006987")]
		[FieldOffset(Offset = "0x38")]
		private float m_lastRTPCTime;

		[Token(Token = "0x4006988")]
		[FieldOffset(Offset = "0x3C")]
		private float maxDistance;

		[Token(Token = "0x6005BA8")]
		[Address(RVA = "0x16176C4", Offset = "0x16176C4", VA = "0x16176C4")]
		private void Start()
		{
		}

		[Token(Token = "0x6005BA9")]
		[Address(RVA = "0x161781C", Offset = "0x161781C", VA = "0x161781C")]
		private void OnBoilStart()
		{
		}

		[Token(Token = "0x6005BAA")]
		[Address(RVA = "0x161788C", Offset = "0x161788C", VA = "0x161788C")]
		private void OnBoilEnd()
		{
		}

		[Token(Token = "0x6005BAB")]
		[Address(RVA = "0x1617920", Offset = "0x1617920", VA = "0x1617920")]
		private void Update()
		{
		}

		[Token(Token = "0x6005BAC")]
		[Address(RVA = "0x1617A34", Offset = "0x1617A34", VA = "0x1617A34")]
		public BoilingEggRTPC()
		{
		}
	}
}
