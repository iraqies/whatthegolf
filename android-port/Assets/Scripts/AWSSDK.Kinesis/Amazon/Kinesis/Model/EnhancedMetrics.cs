using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x2000025")]
	public class EnhancedMetrics
	{
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x10")]
		private List<string> _shardLevelMetrics;

		[Token(Token = "0x1700002F")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2EF38", Offset = "0x2EF38")]
		public List<string> ShardLevelMetrics
		{
			[Token(Token = "0x6000123")]
			[Address(RVA = "0x12AFC50", Offset = "0x12AFC50", VA = "0x12AFC50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x12AFC58", Offset = "0x12AFC58", VA = "0x12AFC58")]
			set
			{
			}
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x12AFC60", Offset = "0x12AFC60", VA = "0x12AFC60")]
		internal bool IsSetShardLevelMetrics()
		{
			return default;
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x12AFCB8", Offset = "0x12AFCB8", VA = "0x12AFCB8")]
		public EnhancedMetrics()
		{
		}
	}
}
