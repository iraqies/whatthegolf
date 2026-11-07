using System;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x20001DC")]
	public class TimingEvent : IDisposable
	{
		[Token(Token = "0x4000737")]
		[FieldOffset(Offset = "0x10")]
		private Metric metric;

		[Token(Token = "0x4000738")]
		[FieldOffset(Offset = "0x18")]
		private RequestMetrics metrics;

		[Token(Token = "0x4000739")]
		[FieldOffset(Offset = "0x20")]
		private bool disposed;

		[Token(Token = "0x6000EAA")]
		[Address(RVA = "0x127CEF4", Offset = "0x127CEF4", VA = "0x127CEF4")]
		internal TimingEvent(RequestMetrics metrics, Metric metric)
		{
		}

		[Token(Token = "0x6000EAB")]
		[Address(RVA = "0x127CF30", Offset = "0x127CF30", VA = "0x127CF30", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000EAC")]
		[Address(RVA = "0x127CF80", Offset = "0x127CF80", VA = "0x127CF80", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000EAD")]
		[Address(RVA = "0x127D000", Offset = "0x127D000", VA = "0x127D000", Slot = "1")]
		~TimingEvent()
		{
		}
	}
}
