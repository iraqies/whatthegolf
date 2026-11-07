using System;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x200001B")]
	public class GetBulkPublishDetailsResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x28")]
		private DateTime? _bulkPublishCompleteTime;

		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x38")]
		private DateTime? _bulkPublishStartTime;

		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x48")]
		private BulkPublishStatus _bulkPublishStatus;

		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x50")]
		private string _failureMessage;

		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x58")]
		private string _identityPoolId;

		[Token(Token = "0x1700001F")]
		public DateTime BulkPublishCompleteTime
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x11996D8", Offset = "0x11996D8", VA = "0x11996D8")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x1199718", Offset = "0x1199718", VA = "0x1199718")]
			set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public DateTime BulkPublishStartTime
		{
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x11997CC", Offset = "0x11997CC", VA = "0x11997CC")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x119980C", Offset = "0x119980C", VA = "0x119980C")]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public BulkPublishStatus BulkPublishStatus
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x11998C0", Offset = "0x11998C0", VA = "0x11998C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x11998C8", Offset = "0x11998C8", VA = "0x11998C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public string FailureMessage
		{
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x119994C", Offset = "0x119994C", VA = "0x119994C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x1199954", Offset = "0x1199954", VA = "0x1199954")]
			set
			{
			}
		}

		[Token(Token = "0x17000023")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x24744", Offset = "0x24744")]
		public string IdentityPoolId
		{
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x119996C", Offset = "0x119996C", VA = "0x119996C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x1199974", Offset = "0x1199974", VA = "0x1199974")]
			set
			{
			}
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x119978C", Offset = "0x119978C", VA = "0x119978C")]
		internal bool IsSetBulkPublishCompleteTime()
		{
			return default;
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x1199880", Offset = "0x1199880", VA = "0x1199880")]
		internal bool IsSetBulkPublishStartTime()
		{
			return default;
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x11998D0", Offset = "0x11998D0", VA = "0x11998D0")]
		internal bool IsSetBulkPublishStatus()
		{
			return default;
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x119995C", Offset = "0x119995C", VA = "0x119995C")]
		internal bool IsSetFailureMessage()
		{
			return default;
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x119997C", Offset = "0x119997C", VA = "0x119997C")]
		internal bool IsSetIdentityPoolId()
		{
			return default;
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x119998C", Offset = "0x119998C", VA = "0x119998C")]
		public GetBulkPublishDetailsResponse()
		{
		}
	}
}
