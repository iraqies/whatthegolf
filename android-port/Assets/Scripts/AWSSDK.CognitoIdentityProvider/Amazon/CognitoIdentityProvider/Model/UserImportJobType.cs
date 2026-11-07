using System;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200013E")]
	public class UserImportJobType
	{
		[Token(Token = "0x4000309")]
		[FieldOffset(Offset = "0x10")]
		private string _cloudWatchLogsRoleArn;

		[Token(Token = "0x400030A")]
		[FieldOffset(Offset = "0x18")]
		private DateTime? _completionDate;

		[Token(Token = "0x400030B")]
		[FieldOffset(Offset = "0x28")]
		private string _completionMessage;

		[Token(Token = "0x400030C")]
		[FieldOffset(Offset = "0x30")]
		private DateTime? _creationDate;

		[Token(Token = "0x400030D")]
		[FieldOffset(Offset = "0x40")]
		private long? _failedUsers;

		[Token(Token = "0x400030E")]
		[FieldOffset(Offset = "0x50")]
		private long? _importedUsers;

		[Token(Token = "0x400030F")]
		[FieldOffset(Offset = "0x60")]
		private string _jobId;

		[Token(Token = "0x4000310")]
		[FieldOffset(Offset = "0x68")]
		private string _jobName;

		[Token(Token = "0x4000311")]
		[FieldOffset(Offset = "0x70")]
		private string _preSignedUrl;

		[Token(Token = "0x4000312")]
		[FieldOffset(Offset = "0x78")]
		private long? _skippedUsers;

		[Token(Token = "0x4000313")]
		[FieldOffset(Offset = "0x88")]
		private DateTime? _startDate;

		[Token(Token = "0x4000314")]
		[FieldOffset(Offset = "0x98")]
		private UserImportJobStatusType _status;

		[Token(Token = "0x4000315")]
		[FieldOffset(Offset = "0xA0")]
		private string _userPoolId;

		[Token(Token = "0x17000296")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x214DC", Offset = "0x214DC")]
		public string CloudWatchLogsRoleArn
		{
			[Token(Token = "0x6000B20")]
			[Address(RVA = "0x117291C", Offset = "0x117291C", VA = "0x117291C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B21")]
			[Address(RVA = "0x1172924", Offset = "0x1172924", VA = "0x1172924")]
			set
			{
			}
		}

		[Token(Token = "0x17000297")]
		public DateTime CompletionDate
		{
			[Token(Token = "0x6000B23")]
			[Address(RVA = "0x117293C", Offset = "0x117293C", VA = "0x117293C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000B24")]
			[Address(RVA = "0x117297C", Offset = "0x117297C", VA = "0x117297C")]
			set
			{
			}
		}

		[Token(Token = "0x17000298")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x21524", Offset = "0x21524")]
		public string CompletionMessage
		{
			[Token(Token = "0x6000B26")]
			[Address(RVA = "0x1172A30", Offset = "0x1172A30", VA = "0x1172A30")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B27")]
			[Address(RVA = "0x1172A38", Offset = "0x1172A38", VA = "0x1172A38")]
			set
			{
			}
		}

		[Token(Token = "0x17000299")]
		public DateTime CreationDate
		{
			[Token(Token = "0x6000B29")]
			[Address(RVA = "0x1172A50", Offset = "0x1172A50", VA = "0x1172A50")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000B2A")]
			[Address(RVA = "0x1172A90", Offset = "0x1172A90", VA = "0x1172A90")]
			set
			{
			}
		}

		[Token(Token = "0x1700029A")]
		public long FailedUsers
		{
			[Token(Token = "0x6000B2C")]
			[Address(RVA = "0x1172B44", Offset = "0x1172B44", VA = "0x1172B44")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000B2D")]
			[Address(RVA = "0x1172B84", Offset = "0x1172B84", VA = "0x1172B84")]
			set
			{
			}
		}

		[Token(Token = "0x1700029B")]
		public long ImportedUsers
		{
			[Token(Token = "0x6000B2F")]
			[Address(RVA = "0x1172C38", Offset = "0x1172C38", VA = "0x1172C38")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000B30")]
			[Address(RVA = "0x1172C78", Offset = "0x1172C78", VA = "0x1172C78")]
			set
			{
			}
		}

		[Token(Token = "0x1700029C")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x2156C", Offset = "0x2156C")]
		public string JobId
		{
			[Token(Token = "0x6000B32")]
			[Address(RVA = "0x1172D2C", Offset = "0x1172D2C", VA = "0x1172D2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B33")]
			[Address(RVA = "0x1172D34", Offset = "0x1172D34", VA = "0x1172D34")]
			set
			{
			}
		}

		[Token(Token = "0x1700029D")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x215B4", Offset = "0x215B4")]
		public string JobName
		{
			[Token(Token = "0x6000B35")]
			[Address(RVA = "0x1172D4C", Offset = "0x1172D4C", VA = "0x1172D4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B36")]
			[Address(RVA = "0x1172D54", Offset = "0x1172D54", VA = "0x1172D54")]
			set
			{
			}
		}

		[Token(Token = "0x1700029E")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x215FC", Offset = "0x215FC")]
		public string PreSignedUrl
		{
			[Token(Token = "0x6000B38")]
			[Address(RVA = "0x1172D6C", Offset = "0x1172D6C", VA = "0x1172D6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B39")]
			[Address(RVA = "0x1172D74", Offset = "0x1172D74", VA = "0x1172D74")]
			set
			{
			}
		}

		[Token(Token = "0x1700029F")]
		public long SkippedUsers
		{
			[Token(Token = "0x6000B3B")]
			[Address(RVA = "0x1172D8C", Offset = "0x1172D8C", VA = "0x1172D8C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000B3C")]
			[Address(RVA = "0x1172DCC", Offset = "0x1172DCC", VA = "0x1172DCC")]
			set
			{
			}
		}

		[Token(Token = "0x170002A0")]
		public DateTime StartDate
		{
			[Token(Token = "0x6000B3E")]
			[Address(RVA = "0x1172E80", Offset = "0x1172E80", VA = "0x1172E80")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000B3F")]
			[Address(RVA = "0x1172EC0", Offset = "0x1172EC0", VA = "0x1172EC0")]
			set
			{
			}
		}

		[Token(Token = "0x170002A1")]
		public UserImportJobStatusType Status
		{
			[Token(Token = "0x6000B41")]
			[Address(RVA = "0x1172F74", Offset = "0x1172F74", VA = "0x1172F74")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B42")]
			[Address(RVA = "0x1172F7C", Offset = "0x1172F7C", VA = "0x1172F7C")]
			set
			{
			}
		}

		[Token(Token = "0x170002A2")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x21644", Offset = "0x21644")]
		public string UserPoolId
		{
			[Token(Token = "0x6000B44")]
			[Address(RVA = "0x1173000", Offset = "0x1173000", VA = "0x1173000")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B45")]
			[Address(RVA = "0x1173008", Offset = "0x1173008", VA = "0x1173008")]
			set
			{
			}
		}

		[Token(Token = "0x6000B22")]
		[Address(RVA = "0x117292C", Offset = "0x117292C", VA = "0x117292C")]
		internal bool IsSetCloudWatchLogsRoleArn()
		{
			return default;
		}

		[Token(Token = "0x6000B25")]
		[Address(RVA = "0x11729F0", Offset = "0x11729F0", VA = "0x11729F0")]
		internal bool IsSetCompletionDate()
		{
			return default;
		}

		[Token(Token = "0x6000B28")]
		[Address(RVA = "0x1172A40", Offset = "0x1172A40", VA = "0x1172A40")]
		internal bool IsSetCompletionMessage()
		{
			return default;
		}

		[Token(Token = "0x6000B2B")]
		[Address(RVA = "0x1172B04", Offset = "0x1172B04", VA = "0x1172B04")]
		internal bool IsSetCreationDate()
		{
			return default;
		}

		[Token(Token = "0x6000B2E")]
		[Address(RVA = "0x1172BF8", Offset = "0x1172BF8", VA = "0x1172BF8")]
		internal bool IsSetFailedUsers()
		{
			return default;
		}

		[Token(Token = "0x6000B31")]
		[Address(RVA = "0x1172CEC", Offset = "0x1172CEC", VA = "0x1172CEC")]
		internal bool IsSetImportedUsers()
		{
			return default;
		}

		[Token(Token = "0x6000B34")]
		[Address(RVA = "0x1172D3C", Offset = "0x1172D3C", VA = "0x1172D3C")]
		internal bool IsSetJobId()
		{
			return default;
		}

		[Token(Token = "0x6000B37")]
		[Address(RVA = "0x1172D5C", Offset = "0x1172D5C", VA = "0x1172D5C")]
		internal bool IsSetJobName()
		{
			return default;
		}

		[Token(Token = "0x6000B3A")]
		[Address(RVA = "0x1172D7C", Offset = "0x1172D7C", VA = "0x1172D7C")]
		internal bool IsSetPreSignedUrl()
		{
			return default;
		}

		[Token(Token = "0x6000B3D")]
		[Address(RVA = "0x1172E40", Offset = "0x1172E40", VA = "0x1172E40")]
		internal bool IsSetSkippedUsers()
		{
			return default;
		}

		[Token(Token = "0x6000B40")]
		[Address(RVA = "0x1172F34", Offset = "0x1172F34", VA = "0x1172F34")]
		internal bool IsSetStartDate()
		{
			return default;
		}

		[Token(Token = "0x6000B43")]
		[Address(RVA = "0x1172F84", Offset = "0x1172F84", VA = "0x1172F84")]
		internal bool IsSetStatus()
		{
			return default;
		}

		[Token(Token = "0x6000B46")]
		[Address(RVA = "0x1173010", Offset = "0x1173010", VA = "0x1173010")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x6000B47")]
		[Address(RVA = "0x1173020", Offset = "0x1173020", VA = "0x1173020")]
		public UserImportJobType()
		{
		}
	}
}
