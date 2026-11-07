using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x200000E")]
	public class CognitoStreams
	{
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x10")]
		private string _roleArn;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x18")]
		private StreamingStatus _streamingStatus;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x20")]
		private string _streamName;

		[Token(Token = "0x17000007")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x24304", Offset = "0x24304")]
		public string RoleArn
		{
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x11924EC", Offset = "0x11924EC", VA = "0x11924EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000073")]
			[Address(RVA = "0x11924F4", Offset = "0x11924F4", VA = "0x11924F4")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public StreamingStatus StreamingStatus
		{
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x119250C", Offset = "0x119250C", VA = "0x119250C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000076")]
			[Address(RVA = "0x1192514", Offset = "0x1192514", VA = "0x1192514")]
			set
			{
			}
		}

		[Token(Token = "0x17000009")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2434C", Offset = "0x2434C")]
		public string StreamName
		{
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x1192598", Offset = "0x1192598", VA = "0x1192598")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000079")]
			[Address(RVA = "0x11925A0", Offset = "0x11925A0", VA = "0x11925A0")]
			set
			{
			}
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x11924FC", Offset = "0x11924FC", VA = "0x11924FC")]
		internal bool IsSetRoleArn()
		{
			return default;
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x119251C", Offset = "0x119251C", VA = "0x119251C")]
		internal bool IsSetStreamingStatus()
		{
			return default;
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x11925A8", Offset = "0x11925A8", VA = "0x11925A8")]
		internal bool IsSetStreamName()
		{
			return default;
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x11925B8", Offset = "0x11925B8", VA = "0x11925B8")]
		public CognitoStreams()
		{
		}
	}
}
