using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace AppStoreConnectPlayTogether.Models
{
	[Token(Token = "0x2001480")]
	public class ChallengeJson
	{
		[Token(Token = "0x400713B")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CDAC", Offset = "0x5CDAC")]
		private string referenceName__BackingField;

		[Token(Token = "0x400713C")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CDBC", Offset = "0x5CDBC")]
		private string vendorIdentifier__BackingField;

		[Token(Token = "0x400713D")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CDCC", Offset = "0x5CDCC")]
		private List<string> allowedAttemptLimits__BackingField;

		[Token(Token = "0x400713E")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CDDC", Offset = "0x5CDDC")]
		private List<string> allowedDurations__BackingField;

		[Token(Token = "0x400713F")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CDEC", Offset = "0x5CDEC")]
		private string leaderboardID__BackingField;

		[Token(Token = "0x4007140")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CDFC", Offset = "0x5CDFC")]
		private string activityIdentifier__BackingField;

		[Token(Token = "0x4007141")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CE0C", Offset = "0x5CE0C")]
		private Uri fallbackURL__BackingField;

		[Token(Token = "0x17000AF9")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x73A3C", Offset = "0x73A3C")]
		public string referenceName
		{
			[Token(Token = "0x6006080")]
			[Address(RVA = "0x1894270", Offset = "0x1894270", VA = "0x1894270")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72FD4", Offset = "0x72FD4")]
			set
			{
			}
		}

		[Token(Token = "0x17000AFA")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x73A74", Offset = "0x73A74")]
		public string vendorIdentifier
		{
			[Token(Token = "0x6006081")]
			[Address(RVA = "0x1894278", Offset = "0x1894278", VA = "0x1894278")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72FE4", Offset = "0x72FE4")]
			set
			{
			}
		}

		[Token(Token = "0x17000AFB")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x73AAC", Offset = "0x73AAC")]
		public List<string> allowedAttemptLimits
		{
			[Token(Token = "0x6006082")]
			[Address(RVA = "0x1894280", Offset = "0x1894280", VA = "0x1894280")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72FF4", Offset = "0x72FF4")]
			set
			{
			}
		}

		[Token(Token = "0x17000AFC")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x73AE4", Offset = "0x73AE4")]
		public List<string> allowedDurations
		{
			[Token(Token = "0x6006083")]
			[Address(RVA = "0x1894288", Offset = "0x1894288", VA = "0x1894288")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73004", Offset = "0x73004")]
			set
			{
			}
		}

		[Token(Token = "0x17000AFD")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x73B1C", Offset = "0x73B1C")]
		public string leaderboardID
		{
			[Token(Token = "0x6006084")]
			[Address(RVA = "0x1894290", Offset = "0x1894290", VA = "0x1894290")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73014", Offset = "0x73014")]
			set
			{
			}
		}

		[Token(Token = "0x17000AFE")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x73B54", Offset = "0x73B54")]
		public string activityIdentifier
		{
			[Token(Token = "0x6006085")]
			[Address(RVA = "0x1894298", Offset = "0x1894298", VA = "0x1894298")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73024", Offset = "0x73024")]
			set
			{
			}
		}

		[Token(Token = "0x17000AFF")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x73B8C", Offset = "0x73B8C")]
		public Uri fallbackURL
		{
			[Token(Token = "0x6006086")]
			[Address(RVA = "0x18942A0", Offset = "0x18942A0", VA = "0x18942A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73034", Offset = "0x73034")]
			set
			{
			}
		}

		[Token(Token = "0x6006087")]
		[Address(RVA = "0x18942A8", Offset = "0x18942A8", VA = "0x18942A8")]
		public ChallengeJson(string referenceName, string vendorIdentifier, List<string> allowedAttemptLimits, List<string> allowedDurations, string leaderboardID, string activityIdentifier, Uri fallbackURL)
		{
		}
	}
}
