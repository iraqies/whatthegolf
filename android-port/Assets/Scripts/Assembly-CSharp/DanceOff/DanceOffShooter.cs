using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace DanceOff
{
	[Token(Token = "0x20011F3")]
	public class DanceOffShooter : ShooterBase
	{
		[Token(Token = "0x400608A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sequencer sequencer;

		[Token(Token = "0x400608B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Matrix4x4 inputToDanceDirMapping;

		[Token(Token = "0x400608C")]
		[FieldOffset(Offset = "0x68")]
		private Vector2[] possibleDirections;

		[Token(Token = "0x6005275")]
		[Address(RVA = "0x18D42D8", Offset = "0x18D42D8", VA = "0x18D42D8", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6005276")]
		[Address(RVA = "0x18D431C", Offset = "0x18D431C", VA = "0x18D431C")]
		private Vector2 GetBestMatch(Vector2 rawDir)
		{
			return default;
		}

		[Token(Token = "0x6005277")]
		[Address(RVA = "0x18D43F4", Offset = "0x18D43F4", VA = "0x18D43F4")]
		public DanceOffShooter()
		{
		}
	}
}
