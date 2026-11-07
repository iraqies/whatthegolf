using System;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Auth
{
	[Token(Token = "0x200024F")]
	public class AWS4SigningResult
	{
		[Token(Token = "0x400086D")]
		[FieldOffset(Offset = "0x10")]
		private readonly string _awsAccessKeyId;

		[Token(Token = "0x400086E")]
		[FieldOffset(Offset = "0x18")]
		private readonly DateTime _originalDateTime;

		[Token(Token = "0x400086F")]
		[FieldOffset(Offset = "0x20")]
		private readonly string _signedHeaders;

		[Token(Token = "0x4000870")]
		[FieldOffset(Offset = "0x28")]
		private readonly string _scope;

		[Token(Token = "0x4000871")]
		[FieldOffset(Offset = "0x30")]
		private readonly byte[] _signingKey;

		[Token(Token = "0x4000872")]
		[FieldOffset(Offset = "0x38")]
		private readonly byte[] _signature;

		[Token(Token = "0x17000453")]
		public string AccessKeyId
		{
			[Token(Token = "0x600118D")]
			[Address(RVA = "0x11BB988", Offset = "0x11BB988", VA = "0x11BB988")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000454")]
		public string ISO8601DateTime
		{
			[Token(Token = "0x600118E")]
			[Address(RVA = "0x11BB990", Offset = "0x11BB990", VA = "0x11BB990")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000455")]
		public string ISO8601Date
		{
			[Token(Token = "0x600118F")]
			[Address(RVA = "0x11BBA1C", Offset = "0x11BBA1C", VA = "0x11BBA1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000456")]
		public string SignedHeaders
		{
			[Token(Token = "0x6001190")]
			[Address(RVA = "0x11BBAA8", Offset = "0x11BBAA8", VA = "0x11BBAA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000457")]
		public string Scope
		{
			[Token(Token = "0x6001191")]
			[Address(RVA = "0x11BBAB0", Offset = "0x11BBAB0", VA = "0x11BBAB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000458")]
		public byte[] SigningKey
		{
			[Token(Token = "0x6001192")]
			[Address(RVA = "0x11BBAB8", Offset = "0x11BBAB8", VA = "0x11BBAB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000459")]
		public string Signature
		{
			[Token(Token = "0x6001193")]
			[Address(RVA = "0x11BBB34", Offset = "0x11BBB34", VA = "0x11BBB34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700045A")]
		public byte[] SignatureBytes
		{
			[Token(Token = "0x6001194")]
			[Address(RVA = "0x11BBBAC", Offset = "0x11BBBAC", VA = "0x11BBBAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700045B")]
		public string ForAuthorizationHeader
		{
			[Token(Token = "0x6001195")]
			[Address(RVA = "0x11B6B68", Offset = "0x11B6B68", VA = "0x11B6B68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700045C")]
		public string ForQueryParameters
		{
			[Token(Token = "0x6001196")]
			[Address(RVA = "0x11BBC28", Offset = "0x11BBC28", VA = "0x11BBC28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600118C")]
		[Address(RVA = "0x11B8B40", Offset = "0x11B8B40", VA = "0x11B8B40")]
		public AWS4SigningResult(string awsAccessKeyId, DateTime signedAt, string signedHeaders, string scope, byte[] signingKey, byte[] signature)
		{
		}
	}
}
