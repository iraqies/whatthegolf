using System;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x2000021")]
	public class IdentityUsage
	{
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x10")]
		private int? _datasetCount;

		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x18")]
		private long? _dataStorage;

		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x28")]
		private string _identityId;

		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x30")]
		private string _identityPoolId;

		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x38")]
		private DateTime? _lastModifiedDate;

		[Token(Token = "0x1700002E")]
		public int DatasetCount
		{
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x119D0B4", Offset = "0x119D0B4", VA = "0x119D0B4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000103")]
			[Address(RVA = "0x119D0F4", Offset = "0x119D0F4", VA = "0x119D0F4")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public long DataStorage
		{
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x119D1A8", Offset = "0x119D1A8", VA = "0x119D1A8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000106")]
			[Address(RVA = "0x119D1E8", Offset = "0x119D1E8", VA = "0x119D1E8")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x248F4", Offset = "0x248F4")]
		public string IdentityId
		{
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x119D29C", Offset = "0x119D29C", VA = "0x119D29C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000109")]
			[Address(RVA = "0x119D2A4", Offset = "0x119D2A4", VA = "0x119D2A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x2493C", Offset = "0x2493C")]
		public string IdentityPoolId
		{
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x119D2BC", Offset = "0x119D2BC", VA = "0x119D2BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x119D2C4", Offset = "0x119D2C4", VA = "0x119D2C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public DateTime LastModifiedDate
		{
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x119D2DC", Offset = "0x119D2DC", VA = "0x119D2DC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x119D31C", Offset = "0x119D31C", VA = "0x119D31C")]
			set
			{
			}
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x119D168", Offset = "0x119D168", VA = "0x119D168")]
		internal bool IsSetDatasetCount()
		{
			return default;
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x119D25C", Offset = "0x119D25C", VA = "0x119D25C")]
		internal bool IsSetDataStorage()
		{
			return default;
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x119D2AC", Offset = "0x119D2AC", VA = "0x119D2AC")]
		internal bool IsSetIdentityId()
		{
			return default;
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x119D2CC", Offset = "0x119D2CC", VA = "0x119D2CC")]
		internal bool IsSetIdentityPoolId()
		{
			return default;
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x119D390", Offset = "0x119D390", VA = "0x119D390")]
		internal bool IsSetLastModifiedDate()
		{
			return default;
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x119D3D0", Offset = "0x119D3D0", VA = "0x119D3D0")]
		public IdentityUsage()
		{
		}
	}
}
