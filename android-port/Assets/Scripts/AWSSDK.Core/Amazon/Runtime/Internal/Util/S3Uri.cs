using System;
using System.Text;
using System.Text.RegularExpressions;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x20001E5")]
	public class S3Uri
	{
		[Token(Token = "0x4000752")]
		private const string S3EndpointPattern = "^(.+\\.)?s3[.-]([a-z0-9-]+)\\.";

		[Token(Token = "0x4000753")]
		private const string S3ControlExlusionPattern = "^(.+\\.)?s3-control\\.";

		[Token(Token = "0x4000754")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Regex S3EndpointRegex;

		[Token(Token = "0x4000755")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Regex S3ControlExlusionRegex;

		[Token(Token = "0x4000756")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27A18", Offset = "0x27A18")]
		private bool IsPathStyle__BackingField;

		[Token(Token = "0x4000757")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27A28", Offset = "0x27A28")]
		private string Bucket__BackingField;

		[Token(Token = "0x4000758")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27A38", Offset = "0x27A38")]
		private string Key__BackingField;

		[Token(Token = "0x4000759")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27A48", Offset = "0x27A48")]
		private RegionEndpoint Region__BackingField;

		[Token(Token = "0x170003CC")]
		public bool IsPathStyle
		{
			[Token(Token = "0x6000EEB")]
			[Address(RVA = "0x126A1D8", Offset = "0x126A1D8", VA = "0x126A1D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B904", Offset = "0x2B904")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000EEC")]
			[Address(RVA = "0x126A1E0", Offset = "0x126A1E0", VA = "0x126A1E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B914", Offset = "0x2B914")]
			private set
			{
			}
		}

		[Token(Token = "0x170003CD")]
		public string Bucket
		{
			[Token(Token = "0x6000EED")]
			[Address(RVA = "0x126A1E8", Offset = "0x126A1E8", VA = "0x126A1E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B924", Offset = "0x2B924")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000EEE")]
			[Address(RVA = "0x126A1F0", Offset = "0x126A1F0", VA = "0x126A1F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B934", Offset = "0x2B934")]
			private set
			{
			}
		}

		[Token(Token = "0x170003CE")]
		public string Key
		{
			[Token(Token = "0x6000EEF")]
			[Address(RVA = "0x126A1F8", Offset = "0x126A1F8", VA = "0x126A1F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B944", Offset = "0x2B944")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000EF0")]
			[Address(RVA = "0x126A200", Offset = "0x126A200", VA = "0x126A200")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B954", Offset = "0x2B954")]
			private set
			{
			}
		}

		[Token(Token = "0x170003CF")]
		public RegionEndpoint Region
		{
			[Token(Token = "0x6000EF1")]
			[Address(RVA = "0x126A208", Offset = "0x126A208", VA = "0x126A208")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B964", Offset = "0x2B964")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000EF2")]
			[Address(RVA = "0x126A210", Offset = "0x126A210", VA = "0x126A210")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B974", Offset = "0x2B974")]
			set
			{
			}
		}

		[Token(Token = "0x6000EF3")]
		[Address(RVA = "0x126A218", Offset = "0x126A218", VA = "0x126A218")]
		public S3Uri(string uri)
		{
		}

		[Token(Token = "0x6000EF4")]
		[Address(RVA = "0x126A288", Offset = "0x126A288", VA = "0x126A288")]
		public S3Uri(Uri uri)
		{
		}

		[Token(Token = "0x6000EF5")]
		[Address(RVA = "0x126A91C", Offset = "0x126A91C", VA = "0x126A91C")]
		public static bool IsS3Uri(Uri uri)
		{
			return default;
		}

		[Token(Token = "0x6000EF6")]
		[Address(RVA = "0x126A86C", Offset = "0x126A86C", VA = "0x126A86C")]
		private static string Decode(string s)
		{
			return null;
		}

		[Token(Token = "0x6000EF7")]
		[Address(RVA = "0x126AA18", Offset = "0x126AA18", VA = "0x126AA18")]
		private static string Decode(string s, int firstPercent)
		{
			return null;
		}

		[Token(Token = "0x6000EF8")]
		[Address(RVA = "0x126AB80", Offset = "0x126AB80", VA = "0x126AB80")]
		private static void AppendDecoded(StringBuilder builder, string s, int index)
		{
		}

		[Token(Token = "0x6000EF9")]
		[Address(RVA = "0x126ACFC", Offset = "0x126ACFC", VA = "0x126ACFC")]
		private static int FromHex(char c)
		{
			return default;
		}
	}
}
