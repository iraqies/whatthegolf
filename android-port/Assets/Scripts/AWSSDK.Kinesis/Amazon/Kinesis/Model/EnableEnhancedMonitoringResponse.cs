using System.Collections.Generic;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x2000024")]
	public class EnableEnhancedMonitoringResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x28")]
		private List<string> _currentShardLevelMetrics;

		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x30")]
		private List<string> _desiredShardLevelMetrics;

		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x38")]
		private string _streamName;

		[Token(Token = "0x1700002C")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2EE60", Offset = "0x2EE60")]
		public List<string> CurrentShardLevelMetrics
		{
			[Token(Token = "0x6000119")]
			[Address(RVA = "0x12AECE8", Offset = "0x12AECE8", VA = "0x12AECE8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600011A")]
			[Address(RVA = "0x12AECF0", Offset = "0x12AECF0", VA = "0x12AECF0")]
			set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2EEA8", Offset = "0x2EEA8")]
		public List<string> DesiredShardLevelMetrics
		{
			[Token(Token = "0x600011C")]
			[Address(RVA = "0x12AED50", Offset = "0x12AED50", VA = "0x12AED50")]
			get
			{
				return null;
			}
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x12AED58", Offset = "0x12AED58", VA = "0x12AED58")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2EEF0", Offset = "0x2EEF0")]
		public string StreamName
		{
			[Token(Token = "0x600011F")]
			[Address(RVA = "0x12AEDB8", Offset = "0x12AEDB8", VA = "0x12AEDB8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x12AEDC0", Offset = "0x12AEDC0", VA = "0x12AEDC0")]
			set
			{
			}
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x12AECF8", Offset = "0x12AECF8", VA = "0x12AECF8")]
		internal bool IsSetCurrentShardLevelMetrics()
		{
			return default;
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x12AED60", Offset = "0x12AED60", VA = "0x12AED60")]
		internal bool IsSetDesiredShardLevelMetrics()
		{
			return default;
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x12AEDC8", Offset = "0x12AEDC8", VA = "0x12AEDC8")]
		internal bool IsSetStreamName()
		{
			return default;
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x12AEDD8", Offset = "0x12AEDD8", VA = "0x12AEDD8")]
		public EnableEnhancedMonitoringResponse()
		{
		}
	}
}
