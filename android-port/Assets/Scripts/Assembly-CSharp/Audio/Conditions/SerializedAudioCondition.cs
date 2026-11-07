using System;
using Il2CppDummyDll;

namespace Audio.Conditions
{
	[Serializable]
	[Token(Token = "0x20013E9")]
	public class SerializedAudioCondition
	{
		[Token(Token = "0x4006B27")]
		[FieldOffset(Offset = "0x10")]
		public Condition condition;

		[Token(Token = "0x4006B28")]
		[FieldOffset(Offset = "0x18")]
		public AudioCondition ConditionReference;

		[Token(Token = "0x6005CD7")]
		[Address(RVA = "0x168A70C", Offset = "0x168A70C", VA = "0x168A70C")]
		public SerializedAudioCondition()
		{
		}
	}
}
