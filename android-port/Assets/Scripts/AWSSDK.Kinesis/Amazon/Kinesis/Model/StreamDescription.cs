using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x2000057")]
	public class StreamDescription
	{
		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x10")]
		private EncryptionType _encryptionType;

		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x18")]
		private List<EnhancedMetrics> _enhancedMonitoring;

		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x20")]
		private bool? _hasMoreShards;

		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x28")]
		private string _keyId;

		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x30")]
		private int? _retentionPeriodHours;

		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x38")]
		private List<Shard> _shards;

		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x40")]
		private string _streamARN;

		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x48")]
		private DateTime? _streamCreationTimestamp;

		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x58")]
		private string _streamName;

		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x60")]
		private StreamStatus _streamStatus;

		[Token(Token = "0x17000086")]
		public EncryptionType EncryptionType
		{
			[Token(Token = "0x600028E")]
			[Address(RVA = "0x12CB0E4", Offset = "0x12CB0E4", VA = "0x12CB0E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600028F")]
			[Address(RVA = "0x12CB0EC", Offset = "0x12CB0EC", VA = "0x12CB0EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000087")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x30294", Offset = "0x30294")]
		public List<EnhancedMetrics> EnhancedMonitoring
		{
			[Token(Token = "0x6000291")]
			[Address(RVA = "0x12CB170", Offset = "0x12CB170", VA = "0x12CB170")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000292")]
			[Address(RVA = "0x12CB178", Offset = "0x12CB178", VA = "0x12CB178")]
			set
			{
			}
		}

		[Token(Token = "0x17000088")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x302C8", Offset = "0x302C8")]
		public bool HasMoreShards
		{
			[Token(Token = "0x6000294")]
			[Address(RVA = "0x12CB1D8", Offset = "0x12CB1D8", VA = "0x12CB1D8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000295")]
			[Address(RVA = "0x12CB218", Offset = "0x12CB218", VA = "0x12CB218")]
			set
			{
			}
		}

		[Token(Token = "0x17000089")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x302FC", Offset = "0x302FC")]
		public string KeyId
		{
			[Token(Token = "0x6000297")]
			[Address(RVA = "0x12CB2CC", Offset = "0x12CB2CC", VA = "0x12CB2CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000298")]
			[Address(RVA = "0x12CB2D4", Offset = "0x12CB2D4", VA = "0x12CB2D4")]
			set
			{
			}
		}

		[Token(Token = "0x1700008A")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x30344", Offset = "0x30344")]
		public int RetentionPeriodHours
		{
			[Token(Token = "0x600029A")]
			[Address(RVA = "0x12CB2EC", Offset = "0x12CB2EC", VA = "0x12CB2EC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600029B")]
			[Address(RVA = "0x12CB32C", Offset = "0x12CB32C", VA = "0x12CB32C")]
			set
			{
			}
		}

		[Token(Token = "0x1700008B")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x30394", Offset = "0x30394")]
		public List<Shard> Shards
		{
			[Token(Token = "0x600029D")]
			[Address(RVA = "0x12CB3E0", Offset = "0x12CB3E0", VA = "0x12CB3E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600029E")]
			[Address(RVA = "0x12CB3E8", Offset = "0x12CB3E8", VA = "0x12CB3E8")]
			set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x303C8", Offset = "0x303C8")]
		public string StreamARN
		{
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x12CB448", Offset = "0x12CB448", VA = "0x12CB448")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x12CB450", Offset = "0x12CB450", VA = "0x12CB450")]
			set
			{
			}
		}

		[Token(Token = "0x1700008D")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x30418", Offset = "0x30418")]
		public DateTime StreamCreationTimestamp
		{
			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x12CB468", Offset = "0x12CB468", VA = "0x12CB468")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002A4")]
			[Address(RVA = "0x12CB4A8", Offset = "0x12CB4A8", VA = "0x12CB4A8")]
			set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x3044C", Offset = "0x3044C")]
		public string StreamName
		{
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x12CB55C", Offset = "0x12CB55C", VA = "0x12CB55C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x12CB564", Offset = "0x12CB564", VA = "0x12CB564")]
			set
			{
			}
		}

		[Token(Token = "0x1700008F")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x3049C", Offset = "0x3049C")]
		public StreamStatus StreamStatus
		{
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x12CB57C", Offset = "0x12CB57C", VA = "0x12CB57C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x12CB584", Offset = "0x12CB584", VA = "0x12CB584")]
			set
			{
			}
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x12CB0F4", Offset = "0x12CB0F4", VA = "0x12CB0F4")]
		internal bool IsSetEncryptionType()
		{
			return default;
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x12CB180", Offset = "0x12CB180", VA = "0x12CB180")]
		internal bool IsSetEnhancedMonitoring()
		{
			return default;
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x12CB28C", Offset = "0x12CB28C", VA = "0x12CB28C")]
		internal bool IsSetHasMoreShards()
		{
			return default;
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x12CB2DC", Offset = "0x12CB2DC", VA = "0x12CB2DC")]
		internal bool IsSetKeyId()
		{
			return default;
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x12CB3A0", Offset = "0x12CB3A0", VA = "0x12CB3A0")]
		internal bool IsSetRetentionPeriodHours()
		{
			return default;
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x12CB3F0", Offset = "0x12CB3F0", VA = "0x12CB3F0")]
		internal bool IsSetShards()
		{
			return default;
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x12CB458", Offset = "0x12CB458", VA = "0x12CB458")]
		internal bool IsSetStreamARN()
		{
			return default;
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x12CB51C", Offset = "0x12CB51C", VA = "0x12CB51C")]
		internal bool IsSetStreamCreationTimestamp()
		{
			return default;
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x12CB56C", Offset = "0x12CB56C", VA = "0x12CB56C")]
		internal bool IsSetStreamName()
		{
			return default;
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x12CB58C", Offset = "0x12CB58C", VA = "0x12CB58C")]
		internal bool IsSetStreamStatus()
		{
			return default;
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x12CB608", Offset = "0x12CB608", VA = "0x12CB608")]
		public StreamDescription()
		{
		}
	}
}
