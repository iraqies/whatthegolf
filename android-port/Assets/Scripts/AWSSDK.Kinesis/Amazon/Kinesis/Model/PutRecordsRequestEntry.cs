using System.IO;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x2000045")]
	public class PutRecordsRequestEntry
	{
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x10")]
		private MemoryStream _data;

		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x18")]
		private string _explicitHashKey;

		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x20")]
		private string _partitionKey;

		[Token(Token = "0x17000062")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2FAD0", Offset = "0x2FAD0")]
		public MemoryStream Data
		{
			[Token(Token = "0x6000208")]
			[Address(RVA = "0x12C02DC", Offset = "0x12C02DC", VA = "0x12C02DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000209")]
			[Address(RVA = "0x12C02E4", Offset = "0x12C02E4", VA = "0x12C02E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public string ExplicitHashKey
		{
			[Token(Token = "0x600020B")]
			[Address(RVA = "0x12C02FC", Offset = "0x12C02FC", VA = "0x12C02FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600020C")]
			[Address(RVA = "0x12C0304", Offset = "0x12C0304", VA = "0x12C0304")]
			set
			{
			}
		}

		[Token(Token = "0x17000064")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2FB20", Offset = "0x2FB20")]
		public string PartitionKey
		{
			[Token(Token = "0x600020E")]
			[Address(RVA = "0x12C031C", Offset = "0x12C031C", VA = "0x12C031C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600020F")]
			[Address(RVA = "0x12C0324", Offset = "0x12C0324", VA = "0x12C0324")]
			set
			{
			}
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x12C02EC", Offset = "0x12C02EC", VA = "0x12C02EC")]
		internal bool IsSetData()
		{
			return default;
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x12C030C", Offset = "0x12C030C", VA = "0x12C030C")]
		internal bool IsSetExplicitHashKey()
		{
			return default;
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x12C032C", Offset = "0x12C032C", VA = "0x12C032C")]
		internal bool IsSetPartitionKey()
		{
			return default;
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x12C033C", Offset = "0x12C033C", VA = "0x12C033C")]
		public PutRecordsRequestEntry()
		{
		}
	}
}
