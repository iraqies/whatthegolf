using System.Collections.Generic;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x2000022")]
	public class DisableEnhancedMonitoringResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x28")]
		private List<string> _currentShardLevelMetrics;

		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x30")]
		private List<string> _desiredShardLevelMetrics;

		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x38")]
		private string _streamName;

		[Token(Token = "0x17000027")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2ECE8", Offset = "0x2ECE8")]
		public List<string> CurrentShardLevelMetrics
		{
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x12AD33C", Offset = "0x12AD33C", VA = "0x12AD33C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000109")]
			[Address(RVA = "0x12AD344", Offset = "0x12AD344", VA = "0x12AD344")]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2ED30", Offset = "0x2ED30")]
		public List<string> DesiredShardLevelMetrics
		{
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x12AD3A4", Offset = "0x12AD3A4", VA = "0x12AD3A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x12AD3AC", Offset = "0x12AD3AC", VA = "0x12AD3AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2ED78", Offset = "0x2ED78")]
		public string StreamName
		{
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x12AD40C", Offset = "0x12AD40C", VA = "0x12AD40C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x12AD414", Offset = "0x12AD414", VA = "0x12AD414")]
			set
			{
			}
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x12AD34C", Offset = "0x12AD34C", VA = "0x12AD34C")]
		internal bool IsSetCurrentShardLevelMetrics()
		{
			return default;
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x12AD3B4", Offset = "0x12AD3B4", VA = "0x12AD3B4")]
		internal bool IsSetDesiredShardLevelMetrics()
		{
			return default;
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x12AD41C", Offset = "0x12AD41C", VA = "0x12AD41C")]
		internal bool IsSetStreamName()
		{
			return default;
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x12AD42C", Offset = "0x12AD42C", VA = "0x12AD42C")]
		public DisableEnhancedMonitoringResponse()
		{
		}
	}
}
