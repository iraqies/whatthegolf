using Il2CppDummyDll;
using UnityEngine.Networking;

namespace UnityEngine.ResourceManagement.Util
{
	[Token(Token = "0x200003F")]
	public class UnityWebRequestResult
	{
		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B7F44", Offset = "0x1B7F44")]
		private string Error__BackingField;

		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B7F54", Offset = "0x1B7F54")]
		private readonly long ResponseCode__BackingField;

		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B7F64", Offset = "0x1B7F64")]
		private readonly UnityWebRequest.Result Result__BackingField;

		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B7F74", Offset = "0x1B7F74")]
		private readonly string Method__BackingField;

		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B7F84", Offset = "0x1B7F84")]
		private readonly string Url__BackingField;

		[Token(Token = "0x17000035")]
		public string Error
		{
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x2A71A78", Offset = "0x2A71A78", VA = "0x2A71A78")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B84A4", Offset = "0x1B84A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x2A71A80", Offset = "0x2A71A80", VA = "0x2A71A80")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B84B4", Offset = "0x1B84B4")]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public long ResponseCode
		{
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x2A71A88", Offset = "0x2A71A88", VA = "0x2A71A88")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B84C4", Offset = "0x1B84C4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000037")]
		public UnityWebRequest.Result Result
		{
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x2A71A90", Offset = "0x2A71A90", VA = "0x2A71A90")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B84D4", Offset = "0x1B84D4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000038")]
		public string Method
		{
			[Token(Token = "0x6000171")]
			[Address(RVA = "0x2A71A98", Offset = "0x2A71A98", VA = "0x2A71A98")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B84E4", Offset = "0x1B84E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		public string Url
		{
			[Token(Token = "0x6000172")]
			[Address(RVA = "0x2A71AA0", Offset = "0x2A71AA0", VA = "0x2A71AA0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B84F4", Offset = "0x1B84F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x2A60480", Offset = "0x2A60480", VA = "0x2A60480")]
		public UnityWebRequestResult(UnityWebRequest request)
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x2A718F4", Offset = "0x2A718F4", VA = "0x2A718F4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x2A6058C", Offset = "0x2A6058C", VA = "0x2A6058C")]
		public bool ShouldRetryDownloadError()
		{
			return default;
		}
	}
}
