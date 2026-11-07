using System;
using Il2CppDummyDll;
using PlayFab.SharedModels;

namespace PlayFab.EventsModels
{
	[Serializable]
	[Token(Token = "0x20011B1")]
	public class EventContents : PlayFabBaseModel
	{
		[Token(Token = "0x4005F2D")]
		[FieldOffset(Offset = "0x10")]
		public EntityKey Entity;

		[Token(Token = "0x4005F2E")]
		[FieldOffset(Offset = "0x18")]
		public string EventNamespace;

		[Token(Token = "0x4005F2F")]
		[FieldOffset(Offset = "0x20")]
		public string Name;

		[Token(Token = "0x4005F30")]
		[FieldOffset(Offset = "0x28")]
		public DateTime? OriginalTimestamp;

		[Token(Token = "0x4005F31")]
		[FieldOffset(Offset = "0x38")]
		public object Payload;

		[Token(Token = "0x60050DD")]
		[Address(RVA = "0x1446C88", Offset = "0x1446C88", VA = "0x1446C88")]
		public EventContents()
		{
		}
	}
}
