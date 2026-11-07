using System.Collections.Generic;
using System.Net;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000C3")]
	public class AssumeRoleWithWebIdentityCredentialsOptions
	{
		[Token(Token = "0x4000355")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26A58", Offset = "0x26A58")]
		private readonly int? DurationSeconds__BackingField;

		[Token(Token = "0x4000356")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26A68", Offset = "0x26A68")]
		private readonly string ProviderId__BackingField;

		[Token(Token = "0x4000357")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26A78", Offset = "0x26A78")]
		private readonly string Policy__BackingField;

		[Token(Token = "0x4000358")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26A88", Offset = "0x26A88")]
		private readonly List<string> PolicyArns__BackingField;

		[Token(Token = "0x4000359")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26A98", Offset = "0x26A98")]
		private readonly IWebProxy ProxySettings__BackingField;

		[Token(Token = "0x170001C8")]
		public int? DurationSeconds
		{
			[Token(Token = "0x6000723")]
			[Address(RVA = "0x11D3270", Offset = "0x11D3270", VA = "0x11D3270")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2918C", Offset = "0x2918C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C9")]
		public string ProviderId
		{
			[Token(Token = "0x6000724")]
			[Address(RVA = "0x11D3278", Offset = "0x11D3278", VA = "0x11D3278")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2919C", Offset = "0x2919C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001CA")]
		public string Policy
		{
			[Token(Token = "0x6000725")]
			[Address(RVA = "0x11D3280", Offset = "0x11D3280", VA = "0x11D3280")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x291AC", Offset = "0x291AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001CB")]
		public List<string> PolicyArns
		{
			[Token(Token = "0x6000726")]
			[Address(RVA = "0x11D3288", Offset = "0x11D3288", VA = "0x11D3288")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x291BC", Offset = "0x291BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001CC")]
		public IWebProxy ProxySettings
		{
			[Token(Token = "0x6000727")]
			[Address(RVA = "0x11D3290", Offset = "0x11D3290", VA = "0x11D3290")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x291CC", Offset = "0x291CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x11D2054", Offset = "0x11D2054", VA = "0x11D2054")]
		public AssumeRoleWithWebIdentityCredentialsOptions()
		{
		}
	}
}
