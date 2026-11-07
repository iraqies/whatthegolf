using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio.Rumble
{
	[Token(Token = "0x20013F3")]
	public class GenericImpactRumble : MonoBehaviour
	{
		[Token(Token = "0x4006B39")]
		[FieldOffset(Offset = "0x18")]
		private float minVelocity;

		[Token(Token = "0x4006B3A")]
		[FieldOffset(Offset = "0x1C")]
		private float maxVelocity;

		[Token(Token = "0x4006B3B")]
		[FieldOffset(Offset = "0x20")]
		private float nextPlayTime;

		[Token(Token = "0x4006B3C")]
		[FieldOffset(Offset = "0x28")]
		private GolfBallController ballController;

		[Token(Token = "0x6005CEC")]
		[Address(RVA = "0x14846D0", Offset = "0x14846D0", VA = "0x14846D0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005CED")]
		[Address(RVA = "0x148472C", Offset = "0x148472C", VA = "0x148472C")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6005CEE")]
		[Address(RVA = "0x1484988", Offset = "0x1484988", VA = "0x1484988")]
		private void OnCollisionEnter2D(Collision2D collision)
		{
		}

		[Token(Token = "0x6005CEF")]
		[Address(RVA = "0x1484808", Offset = "0x1484808", VA = "0x1484808")]
		private void HandleHit(float velocityMagnitude)
		{
		}

		[Token(Token = "0x6005CF0")]
		[Address(RVA = "0x1484A5C", Offset = "0x1484A5C", VA = "0x1484A5C")]
		public GenericImpactRumble()
		{
		}
	}
}
