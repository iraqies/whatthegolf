using Il2CppDummyDll;
using UnityEngine;

namespace BeatFighter
{
	[Token(Token = "0x20010ED")]
	public class BeatTrackAction : ScriptableObject
	{
		[Token(Token = "0x4005932")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 shootDir;

		[Token(Token = "0x4005933")]
		[FieldOffset(Offset = "0x28")]
		public string animationState;

		[Token(Token = "0x4005934")]
		[FieldOffset(Offset = "0x30")]
		public AttackObject attackObjectPrefab;

		[Token(Token = "0x6004BC5")]
		[Address(RVA = "0x160D874", Offset = "0x160D874", VA = "0x160D874")]
		public BeatTrackAction()
		{
		}
	}
}
