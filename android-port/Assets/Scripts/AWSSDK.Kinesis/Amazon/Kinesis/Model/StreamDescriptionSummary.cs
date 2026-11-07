using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x2000058")]
	public class StreamDescriptionSummary
	{
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x10")]
		private int? _consumerCount;

		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x18")]
		private EncryptionType _encryptionType;

		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x20")]
		private List<EnhancedMetrics> _enhancedMonitoring;

		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x28")]
		private string _keyId;

		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x30")]
		private int? _openShardCount;

		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x38")]
		private int? _retentionPeriodHours;

		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x40")]
		private string _streamARN;

		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x48")]
		private DateTime? _streamCreationTimestamp;

		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x58")]
		private string _streamName;

		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x60")]
		private StreamStatus _streamStatus;

		[Token(Token = "0x17000090")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x304D0", Offset = "0x304D0")]
		public int ConsumerCount
		{
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x12CB6D0", Offset = "0x12CB6D0", VA = "0x12CB6D0")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x12CB710", Offset = "0x12CB710", VA = "0x12CB710")]
			set
			{
			}
		}

		[Token(Token = "0x17000091")]
		public EncryptionType EncryptionType
		{
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x12CB7C4", Offset = "0x12CB7C4", VA = "0x12CB7C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x12CB7CC", Offset = "0x12CB7CC", VA = "0x12CB7CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000092")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x3051C", Offset = "0x3051C")]
		public List<EnhancedMetrics> EnhancedMonitoring
		{
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x12CB850", Offset = "0x12CB850", VA = "0x12CB850")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x12CB858", Offset = "0x12CB858", VA = "0x12CB858")]
			set
			{
			}
		}

		[Token(Token = "0x17000093")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x30550", Offset = "0x30550")]
		public string KeyId
		{
			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x12CB8B8", Offset = "0x12CB8B8", VA = "0x12CB8B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B7")]
			[Address(RVA = "0x12CB8C0", Offset = "0x12CB8C0", VA = "0x12CB8C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000094")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x30598", Offset = "0x30598")]
		public int OpenShardCount
		{
			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x12CB8D8", Offset = "0x12CB8D8", VA = "0x12CB8D8")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002BA")]
			[Address(RVA = "0x12CB918", Offset = "0x12CB918", VA = "0x12CB918")]
			set
			{
			}
		}

		[Token(Token = "0x17000095")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x305EC", Offset = "0x305EC")]
		public int RetentionPeriodHours
		{
			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x12CB9CC", Offset = "0x12CB9CC", VA = "0x12CB9CC")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x12CBA0C", Offset = "0x12CBA0C", VA = "0x12CBA0C")]
			set
			{
			}
		}

		[Token(Token = "0x17000096")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x30640", Offset = "0x30640")]
		public string StreamARN
		{
			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x12CBAC0", Offset = "0x12CBAC0", VA = "0x12CBAC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x12CBAC8", Offset = "0x12CBAC8", VA = "0x12CBAC8")]
			set
			{
			}
		}

		[Token(Token = "0x17000097")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x30690", Offset = "0x30690")]
		public DateTime StreamCreationTimestamp
		{
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x12CBAE0", Offset = "0x12CBAE0", VA = "0x12CBAE0")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x12CBB20", Offset = "0x12CBB20", VA = "0x12CBB20")]
			set
			{
			}
		}

		[Token(Token = "0x17000098")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x306C4", Offset = "0x306C4")]
		public string StreamName
		{
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x12CBBD4", Offset = "0x12CBBD4", VA = "0x12CBBD4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x12CBBDC", Offset = "0x12CBBDC", VA = "0x12CBBDC")]
			set
			{
			}
		}

		[Token(Token = "0x17000099")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x30714", Offset = "0x30714")]
		public StreamStatus StreamStatus
		{
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x12CBBF4", Offset = "0x12CBBF4", VA = "0x12CBBF4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x12CBBFC", Offset = "0x12CBBFC", VA = "0x12CBBFC")]
			set
			{
			}
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x12CB784", Offset = "0x12CB784", VA = "0x12CB784")]
		internal bool IsSetConsumerCount()
		{
			return default;
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x12CB7D4", Offset = "0x12CB7D4", VA = "0x12CB7D4")]
		internal bool IsSetEncryptionType()
		{
			return default;
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x12CB860", Offset = "0x12CB860", VA = "0x12CB860")]
		internal bool IsSetEnhancedMonitoring()
		{
			return default;
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x12CB8C8", Offset = "0x12CB8C8", VA = "0x12CB8C8")]
		internal bool IsSetKeyId()
		{
			return default;
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x12CB98C", Offset = "0x12CB98C", VA = "0x12CB98C")]
		internal bool IsSetOpenShardCount()
		{
			return default;
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x12CBA80", Offset = "0x12CBA80", VA = "0x12CBA80")]
		internal bool IsSetRetentionPeriodHours()
		{
			return default;
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x12CBAD0", Offset = "0x12CBAD0", VA = "0x12CBAD0")]
		internal bool IsSetStreamARN()
		{
			return default;
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x12CBB94", Offset = "0x12CBB94", VA = "0x12CBB94")]
		internal bool IsSetStreamCreationTimestamp()
		{
			return default;
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x12CBBE4", Offset = "0x12CBBE4", VA = "0x12CBBE4")]
		internal bool IsSetStreamName()
		{
			return default;
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x12CBC04", Offset = "0x12CBC04", VA = "0x12CBC04")]
		internal bool IsSetStreamStatus()
		{
			return default;
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x12CBC80", Offset = "0x12CBC80", VA = "0x12CBC80")]
		public StreamDescriptionSummary()
		{
		}
	}
}
