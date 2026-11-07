using System;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000148")]
	public class UserPoolDescriptionType
	{
		[Token(Token = "0x400032E")]
		[FieldOffset(Offset = "0x10")]
		private DateTime? _creationDate;

		[Token(Token = "0x400032F")]
		[FieldOffset(Offset = "0x20")]
		private string _id;

		[Token(Token = "0x4000330")]
		[FieldOffset(Offset = "0x28")]
		private LambdaConfigType _lambdaConfig;

		[Token(Token = "0x4000331")]
		[FieldOffset(Offset = "0x30")]
		private DateTime? _lastModifiedDate;

		[Token(Token = "0x4000332")]
		[FieldOffset(Offset = "0x40")]
		private string _name;

		[Token(Token = "0x4000333")]
		[FieldOffset(Offset = "0x48")]
		private StatusType _status;

		[Token(Token = "0x170002BB")]
		public DateTime CreationDate
		{
			[Token(Token = "0x6000BAD")]
			[Address(RVA = "0x1174990", Offset = "0x1174990", VA = "0x1174990")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000BAE")]
			[Address(RVA = "0x11749D0", Offset = "0x11749D0", VA = "0x11749D0")]
			set
			{
			}
		}

		[Token(Token = "0x170002BC")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x21A8C", Offset = "0x21A8C")]
		public string Id
		{
			[Token(Token = "0x6000BB0")]
			[Address(RVA = "0x1174A84", Offset = "0x1174A84", VA = "0x1174A84")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BB1")]
			[Address(RVA = "0x1174A8C", Offset = "0x1174A8C", VA = "0x1174A8C")]
			set
			{
			}
		}

		[Token(Token = "0x170002BD")]
		public LambdaConfigType LambdaConfig
		{
			[Token(Token = "0x6000BB3")]
			[Address(RVA = "0x1174AA4", Offset = "0x1174AA4", VA = "0x1174AA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BB4")]
			[Address(RVA = "0x1174AAC", Offset = "0x1174AAC", VA = "0x1174AAC")]
			set
			{
			}
		}

		[Token(Token = "0x170002BE")]
		public DateTime LastModifiedDate
		{
			[Token(Token = "0x6000BB6")]
			[Address(RVA = "0x1174AC4", Offset = "0x1174AC4", VA = "0x1174AC4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000BB7")]
			[Address(RVA = "0x1174B04", Offset = "0x1174B04", VA = "0x1174B04")]
			set
			{
			}
		}

		[Token(Token = "0x170002BF")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x21AD4", Offset = "0x21AD4")]
		public string Name
		{
			[Token(Token = "0x6000BB9")]
			[Address(RVA = "0x1174BB8", Offset = "0x1174BB8", VA = "0x1174BB8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BBA")]
			[Address(RVA = "0x1174BC0", Offset = "0x1174BC0", VA = "0x1174BC0")]
			set
			{
			}
		}

		[Token(Token = "0x170002C0")]
		public StatusType Status
		{
			[Token(Token = "0x6000BBC")]
			[Address(RVA = "0x1174BD8", Offset = "0x1174BD8", VA = "0x1174BD8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BBD")]
			[Address(RVA = "0x1174BE0", Offset = "0x1174BE0", VA = "0x1174BE0")]
			set
			{
			}
		}

		[Token(Token = "0x6000BAF")]
		[Address(RVA = "0x1174A44", Offset = "0x1174A44", VA = "0x1174A44")]
		internal bool IsSetCreationDate()
		{
			return default;
		}

		[Token(Token = "0x6000BB2")]
		[Address(RVA = "0x1174A94", Offset = "0x1174A94", VA = "0x1174A94")]
		internal bool IsSetId()
		{
			return default;
		}

		[Token(Token = "0x6000BB5")]
		[Address(RVA = "0x1174AB4", Offset = "0x1174AB4", VA = "0x1174AB4")]
		internal bool IsSetLambdaConfig()
		{
			return default;
		}

		[Token(Token = "0x6000BB8")]
		[Address(RVA = "0x1174B78", Offset = "0x1174B78", VA = "0x1174B78")]
		internal bool IsSetLastModifiedDate()
		{
			return default;
		}

		[Token(Token = "0x6000BBB")]
		[Address(RVA = "0x1174BC8", Offset = "0x1174BC8", VA = "0x1174BC8")]
		internal bool IsSetName()
		{
			return default;
		}

		[Token(Token = "0x6000BBE")]
		[Address(RVA = "0x1174BE8", Offset = "0x1174BE8", VA = "0x1174BE8")]
		internal bool IsSetStatus()
		{
			return default;
		}

		[Token(Token = "0x6000BBF")]
		[Address(RVA = "0x1174C64", Offset = "0x1174C64", VA = "0x1174C64")]
		public UserPoolDescriptionType()
		{
		}
	}
}
