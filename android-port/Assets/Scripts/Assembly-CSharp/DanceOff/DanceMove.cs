using Il2CppDummyDll;
using UnityEngine;

namespace DanceOff
{
	[Token(Token = "0x20011F1")]
	public class DanceMove : ScriptableObject
	{
		[Token(Token = "0x4006083")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 dir;

		[Token(Token = "0x4006084")]
		[FieldOffset(Offset = "0x20")]
		public DanceMoveIndicator indicatorPrefab;

		[Token(Token = "0x600526F")]
		[Address(RVA = "0x18D4280", Offset = "0x18D4280", VA = "0x18D4280")]
		public DanceMove()
		{
		}
	}
}
