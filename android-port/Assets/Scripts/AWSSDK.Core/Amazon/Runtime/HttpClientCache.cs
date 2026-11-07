using System;
using System.Net.Http;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000F1")]
	public class HttpClientCache : IDisposable
	{
		[Token(Token = "0x40003C2")]
		[FieldOffset(Offset = "0x10")]
		private HttpClient[] _clients;

		[Token(Token = "0x40003C3")]
		[FieldOffset(Offset = "0x18")]
		private int count;

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x120E72C", Offset = "0x120E72C", VA = "0x120E72C")]
		public HttpClientCache(HttpClient[] clients)
		{
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0x120E758", Offset = "0x120E758", VA = "0x120E758")]
		public HttpClient GetNextClient()
		{
			return null;
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0x120E830", Offset = "0x120E830", VA = "0x120E830", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0x120E8B0", Offset = "0x120E8B0", VA = "0x120E8B0", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}
	}
}
