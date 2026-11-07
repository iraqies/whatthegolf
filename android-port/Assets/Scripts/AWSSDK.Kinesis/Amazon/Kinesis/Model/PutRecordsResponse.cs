using System.Collections.Generic;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x2000046")]
	public class PutRecordsResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x28")]
		private EncryptionType _encryptionType;

		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x30")]
		private int? _failedRecordCount;

		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x38")]
		private List<PutRecordsResultEntry> _records;

		[Token(Token = "0x17000065")]
		public EncryptionType EncryptionType
		{
			[Token(Token = "0x6000212")]
			[Address(RVA = "0x12C11F4", Offset = "0x12C11F4", VA = "0x12C11F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000213")]
			[Address(RVA = "0x12C11FC", Offset = "0x12C11FC", VA = "0x12C11FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000066")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2FB70", Offset = "0x2FB70")]
		public int FailedRecordCount
		{
			[Token(Token = "0x6000215")]
			[Address(RVA = "0x12C1280", Offset = "0x12C1280", VA = "0x12C1280")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000216")]
			[Address(RVA = "0x12C12C0", Offset = "0x12C12C0", VA = "0x12C12C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000067")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2FBBC", Offset = "0x2FBBC")]
		public List<PutRecordsResultEntry> Records
		{
			[Token(Token = "0x6000218")]
			[Address(RVA = "0x12C1374", Offset = "0x12C1374", VA = "0x12C1374")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000219")]
			[Address(RVA = "0x12C137C", Offset = "0x12C137C", VA = "0x12C137C")]
			set
			{
			}
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x12C1204", Offset = "0x12C1204", VA = "0x12C1204")]
		internal bool IsSetEncryptionType()
		{
			return default;
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x12C1334", Offset = "0x12C1334", VA = "0x12C1334")]
		internal bool IsSetFailedRecordCount()
		{
			return default;
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x12C1384", Offset = "0x12C1384", VA = "0x12C1384")]
		internal bool IsSetRecords()
		{
			return default;
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x12C13DC", Offset = "0x12C13DC", VA = "0x12C13DC")]
		public PutRecordsResponse()
		{
		}
	}
}
