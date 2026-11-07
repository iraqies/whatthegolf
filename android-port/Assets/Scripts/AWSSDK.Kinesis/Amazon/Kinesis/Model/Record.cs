using System;
using System.IO;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x2000048")]
	public class Record
	{
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x10")]
		private DateTime? _approximateArrivalTimestamp;

		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x20")]
		private MemoryStream _data;

		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x28")]
		private EncryptionType _encryptionType;

		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x30")]
		private string _partitionKey;

		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x38")]
		private string _sequenceNumber;

		[Token(Token = "0x1700006C")]
		public DateTime ApproximateArrivalTimestamp
		{
			[Token(Token = "0x6000229")]
			[Address(RVA = "0x12C2944", Offset = "0x12C2944", VA = "0x12C2944")]
			get
			{
				return default;
			}
			[Token(Token = "0x600022A")]
			[Address(RVA = "0x12C2984", Offset = "0x12C2984", VA = "0x12C2984")]
			set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x2FC54", Offset = "0x2FC54")]
		public MemoryStream Data
		{
			[Token(Token = "0x600022C")]
			[Address(RVA = "0x12C2A38", Offset = "0x12C2A38", VA = "0x12C2A38")]
			get
			{
				return null;
			}
			[Token(Token = "0x600022D")]
			[Address(RVA = "0x12C2A40", Offset = "0x12C2A40", VA = "0x12C2A40")]
			set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public EncryptionType EncryptionType
		{
			[Token(Token = "0x600022F")]
			[Address(RVA = "0x12C2A58", Offset = "0x12C2A58", VA = "0x12C2A58")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000230")]
			[Address(RVA = "0x12C2A60", Offset = "0x12C2A60", VA = "0x12C2A60")]
			set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x2FCA4", Offset = "0x2FCA4")]
		public string PartitionKey
		{
			[Token(Token = "0x6000232")]
			[Address(RVA = "0x12C2AE4", Offset = "0x12C2AE4", VA = "0x12C2AE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000233")]
			[Address(RVA = "0x12C2AEC", Offset = "0x12C2AEC", VA = "0x12C2AEC")]
			set
			{
			}
		}

		[Token(Token = "0x17000070")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x2FCF4", Offset = "0x2FCF4")]
		public string SequenceNumber
		{
			[Token(Token = "0x6000235")]
			[Address(RVA = "0x12C2B04", Offset = "0x12C2B04", VA = "0x12C2B04")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000236")]
			[Address(RVA = "0x12C2B0C", Offset = "0x12C2B0C", VA = "0x12C2B0C")]
			set
			{
			}
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x12C29F8", Offset = "0x12C29F8", VA = "0x12C29F8")]
		internal bool IsSetApproximateArrivalTimestamp()
		{
			return default;
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x12C2A48", Offset = "0x12C2A48", VA = "0x12C2A48")]
		internal bool IsSetData()
		{
			return default;
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x12C2A68", Offset = "0x12C2A68", VA = "0x12C2A68")]
		internal bool IsSetEncryptionType()
		{
			return default;
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x12C2AF4", Offset = "0x12C2AF4", VA = "0x12C2AF4")]
		internal bool IsSetPartitionKey()
		{
			return default;
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x12C2B14", Offset = "0x12C2B14", VA = "0x12C2B14")]
		internal bool IsSetSequenceNumber()
		{
			return default;
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x12C2B24", Offset = "0x12C2B24", VA = "0x12C2B24")]
		public Record()
		{
		}
	}
}
