using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Transform
{
	[Token(Token = "0x2000239")]
	public class HttpClientResponseData : IWebResponseData
	{
		[Token(Token = "0x40007F2")]
		[FieldOffset(Offset = "0x10")]
		private HttpResponseMessageBody _response;

		[Token(Token = "0x40007F3")]
		[FieldOffset(Offset = "0x18")]
		private string[] _headerNames;

		[Token(Token = "0x40007F4")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, string> _headers;

		[Token(Token = "0x40007F5")]
		[FieldOffset(Offset = "0x28")]
		private HashSet<string> _headerNamesSet;

		[Token(Token = "0x40007F6")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27C48", Offset = "0x27C48")]
		private HttpStatusCode StatusCode__BackingField;

		[Token(Token = "0x40007F7")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27C58", Offset = "0x27C58")]
		private bool IsSuccessStatusCode__BackingField;

		[Token(Token = "0x40007F8")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27C68", Offset = "0x27C68")]
		private string ContentType__BackingField;

		[Token(Token = "0x40007F9")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27C78", Offset = "0x27C78")]
		private long ContentLength__BackingField;

		[Token(Token = "0x1700043C")]
		public HttpStatusCode StatusCode
		{
			[Token(Token = "0x60010ED")]
			[Address(RVA = "0x120F48C", Offset = "0x120F48C", VA = "0x120F48C", Slot = "6")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BE80", Offset = "0x2BE80")]
			get
			{
				return default;
			}
			[Token(Token = "0x60010EE")]
			[Address(RVA = "0x120F494", Offset = "0x120F494", VA = "0x120F494")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BE90", Offset = "0x2BE90")]
			private set
			{
			}
		}

		[Token(Token = "0x1700043D")]
		public bool IsSuccessStatusCode
		{
			[Token(Token = "0x60010EF")]
			[Address(RVA = "0x120F49C", Offset = "0x120F49C", VA = "0x120F49C", Slot = "7")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BEA0", Offset = "0x2BEA0")]
			get
			{
				return default;
			}
			[Token(Token = "0x60010F0")]
			[Address(RVA = "0x120F4A4", Offset = "0x120F4A4", VA = "0x120F4A4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BEB0", Offset = "0x2BEB0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700043E")]
		public string ContentType
		{
			[Token(Token = "0x60010F1")]
			[Address(RVA = "0x120F4AC", Offset = "0x120F4AC", VA = "0x120F4AC", Slot = "5")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BEC0", Offset = "0x2BEC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60010F2")]
			[Address(RVA = "0x120F4B4", Offset = "0x120F4B4", VA = "0x120F4B4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BED0", Offset = "0x2BED0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700043F")]
		public long ContentLength
		{
			[Token(Token = "0x60010F3")]
			[Address(RVA = "0x120F4BC", Offset = "0x120F4BC", VA = "0x120F4BC", Slot = "4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BEE0", Offset = "0x2BEE0")]
			get
			{
				return default;
			}
			[Token(Token = "0x60010F4")]
			[Address(RVA = "0x120F4C4", Offset = "0x120F4C4", VA = "0x120F4C4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BEF0", Offset = "0x2BEF0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000440")]
		public IHttpResponseBody ResponseBody
		{
			[Token(Token = "0x60010FA")]
			[Address(RVA = "0x120F684", Offset = "0x120F684", VA = "0x120F684", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60010EB")]
		[Address(RVA = "0x120EA0C", Offset = "0x120EA0C", VA = "0x120EA0C")]
		internal HttpClientResponseData(HttpResponseMessage response)
		{
		}

		[Token(Token = "0x60010EC")]
		[Address(RVA = "0x120EA18", Offset = "0x120EA18", VA = "0x120EA18")]
		internal HttpClientResponseData(HttpResponseMessage response, HttpClient httpClient, bool disposeClient)
		{
		}

		[Token(Token = "0x60010F5")]
		[Address(RVA = "0x120F4CC", Offset = "0x120F4CC", VA = "0x120F4CC", Slot = "10")]
		public string GetHeaderValue(string headerName)
		{
			return null;
		}

		[Token(Token = "0x60010F6")]
		[Address(RVA = "0x120F56C", Offset = "0x120F56C", VA = "0x120F56C", Slot = "9")]
		public bool IsHeaderPresent(string headerName)
		{
			return default;
		}

		[Token(Token = "0x60010F7")]
		[Address(RVA = "0x120F5D0", Offset = "0x120F5D0", VA = "0x120F5D0", Slot = "8")]
		public string[] GetHeaderNames()
		{
			return null;
		}

		[Token(Token = "0x60010F8")]
		[Address(RVA = "0x120EB80", Offset = "0x120EB80", VA = "0x120EB80")]
		private void CopyHeaderValues(HttpResponseMessage response)
		{
		}

		[Token(Token = "0x60010F9")]
		[Address(RVA = "0x120F5D8", Offset = "0x120F5D8", VA = "0x120F5D8")]
		private string GetFirstHeaderValue(HttpHeaders headers, string key)
		{
			return null;
		}
	}
}
