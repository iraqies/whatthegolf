using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x200005B")]
	public class UpdateShardCountResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x24")]
		private int? _currentShardCount;

		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x30")]
		private string _streamName;

		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x38")]
		private int? _targetShardCount;

		[Token(Token = "0x1700009F")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x308B8", Offset = "0x308B8")]
		public int CurrentShardCount
		{
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x12CE85C", Offset = "0x12CE85C", VA = "0x12CE85C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x12CE89C", Offset = "0x12CE89C", VA = "0x12CE89C")]
			set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x30904", Offset = "0x30904")]
		public string StreamName
		{
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0x12CE950", Offset = "0x12CE950", VA = "0x12CE950")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0x12CE958", Offset = "0x12CE958", VA = "0x12CE958")]
			set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x3094C", Offset = "0x3094C")]
		public int TargetShardCount
		{
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0x12CE970", Offset = "0x12CE970", VA = "0x12CE970")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002E4")]
			[Address(RVA = "0x12CE9B0", Offset = "0x12CE9B0", VA = "0x12CE9B0")]
			set
			{
			}
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x12CE910", Offset = "0x12CE910", VA = "0x12CE910")]
		internal bool IsSetCurrentShardCount()
		{
			return default;
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x12CE960", Offset = "0x12CE960", VA = "0x12CE960")]
		internal bool IsSetStreamName()
		{
			return default;
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x12CEA24", Offset = "0x12CEA24", VA = "0x12CEA24")]
		internal bool IsSetTargetShardCount()
		{
			return default;
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x12CEA64", Offset = "0x12CEA64", VA = "0x12CEA64")]
		public UpdateShardCountResponse()
		{
		}
	}
}
