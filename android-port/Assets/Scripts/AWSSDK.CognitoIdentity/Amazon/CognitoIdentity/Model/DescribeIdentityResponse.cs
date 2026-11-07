using System;
using System.Collections.Generic;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x2000026")]
	public class DescribeIdentityResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x28")]
		private DateTime? _creationDate;

		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x38")]
		private string _identityId;

		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x40")]
		private DateTime? _lastModifiedDate;

		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x50")]
		private List<string> _logins;

		[Token(Token = "0x17000040")]
		public DateTime CreationDate
		{
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x108293C", Offset = "0x108293C", VA = "0x108293C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x108297C", Offset = "0x108297C", VA = "0x108297C")]
			set
			{
			}
		}

		[Token(Token = "0x17000041")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x22A38", Offset = "0x22A38")]
		public string IdentityId
		{
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x1082A30", Offset = "0x1082A30", VA = "0x1082A30")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000162")]
			[Address(RVA = "0x1082A38", Offset = "0x1082A38", VA = "0x1082A38")]
			set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public DateTime LastModifiedDate
		{
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x1082A50", Offset = "0x1082A50", VA = "0x1082A50")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x1082A90", Offset = "0x1082A90", VA = "0x1082A90")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public List<string> Logins
		{
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x1082B44", Offset = "0x1082B44", VA = "0x1082B44")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x1082B4C", Offset = "0x1082B4C", VA = "0x1082B4C")]
			set
			{
			}
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x10829F0", Offset = "0x10829F0", VA = "0x10829F0")]
		internal bool IsSetCreationDate()
		{
			return default;
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x1082A40", Offset = "0x1082A40", VA = "0x1082A40")]
		internal bool IsSetIdentityId()
		{
			return default;
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x1082B04", Offset = "0x1082B04", VA = "0x1082B04")]
		internal bool IsSetLastModifiedDate()
		{
			return default;
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x1082B54", Offset = "0x1082B54", VA = "0x1082B54")]
		internal bool IsSetLogins()
		{
			return default;
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x1082BAC", Offset = "0x1082BAC", VA = "0x1082BAC")]
		public DescribeIdentityResponse()
		{
		}
	}
}
