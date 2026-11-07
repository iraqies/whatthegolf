using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using PlayFab.EventsModels;

namespace PlayFab.Public
{
	[Token(Token = "0x20011B5")]
	public class ScreenTimeTracker : IScreenTimeTracker
	{
		[Token(Token = "0x4005F33")]
		[FieldOffset(Offset = "0x10")]
		private Guid focusId;

		[Token(Token = "0x4005F34")]
		[FieldOffset(Offset = "0x20")]
		private Guid gameSessionID;

		[Token(Token = "0x4005F35")]
		[FieldOffset(Offset = "0x30")]
		private bool initialFocus;

		[Token(Token = "0x4005F36")]
		[FieldOffset(Offset = "0x31")]
		private bool isSending;

		[Token(Token = "0x4005F37")]
		[FieldOffset(Offset = "0x38")]
		private DateTime focusOffDateTime;

		[Token(Token = "0x4005F38")]
		[FieldOffset(Offset = "0x40")]
		private DateTime focusOnDateTime;

		[Token(Token = "0x4005F39")]
		[FieldOffset(Offset = "0x48")]
		private Queue<EventContents> eventsRequests;

		[Token(Token = "0x4005F3A")]
		[FieldOffset(Offset = "0x50")]
		private EntityKey entityKey;

		[Token(Token = "0x60050E7")]
		[Address(RVA = "0x167D720", Offset = "0x167D720", VA = "0x167D720", Slot = "9")]
		public void ClientSessionStart(string entityId, string entityType, string playFabUserId)
		{
		}

		[Token(Token = "0x60050E8")]
		[Address(RVA = "0x167DA44", Offset = "0x167DA44", VA = "0x167DA44", Slot = "8")]
		public void OnApplicationFocus(bool isFocused)
		{
		}

		[Token(Token = "0x60050E9")]
		[Address(RVA = "0x167DE8C", Offset = "0x167DE8C", VA = "0x167DE8C", Slot = "10")]
		public void Send()
		{
		}

		[Token(Token = "0x60050EA")]
		[Address(RVA = "0x167E0C0", Offset = "0x167E0C0", VA = "0x167E0C0")]
		private void EventSentSuccessfulCallback(WriteEventsResponse response)
		{
		}

		[Token(Token = "0x60050EB")]
		[Address(RVA = "0x167E0C4", Offset = "0x167E0C4", VA = "0x167E0C4")]
		private void EventSentErrorCallback(PlayFabError response)
		{
		}

		[Token(Token = "0x60050EC")]
		[Address(RVA = "0x167E170", Offset = "0x167E170", VA = "0x167E170", Slot = "4")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x60050ED")]
		[Address(RVA = "0x167E174", Offset = "0x167E174", VA = "0x167E174", Slot = "5")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x60050EE")]
		[Address(RVA = "0x167E178", Offset = "0x167E178", VA = "0x167E178", Slot = "6")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x60050EF")]
		[Address(RVA = "0x167E17C", Offset = "0x167E17C", VA = "0x167E17C", Slot = "7")]
		public void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60050F0")]
		[Address(RVA = "0x167E180", Offset = "0x167E180", VA = "0x167E180")]
		public ScreenTimeTracker()
		{
		}
	}
}
