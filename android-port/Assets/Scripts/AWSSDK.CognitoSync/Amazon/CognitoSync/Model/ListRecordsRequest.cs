using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x200002C")]
	public class ListRecordsRequest : AmazonCognitoSyncRequest
	{
		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x30")]
		private string _datasetName;

		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x38")]
		private string _identityId;

		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x40")]
		private string _identityPoolId;

		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x48")]
		private long? _lastSyncCount;

		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x58")]
		private int? _maxResults;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x60")]
		private string _nextToken;

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x68")]
		private string _syncSessionToken;

		[Token(Token = "0x17000040")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x24A24", Offset = "0x24A24")]
		public string DatasetName
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x11A1468", Offset = "0x11A1468", VA = "0x11A1468")]
			get
			{
				return null;
			}
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x11A1470", Offset = "0x11A1470", VA = "0x11A1470")]
			set
			{
			}
		}

		[Token(Token = "0x17000041")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x24A74", Offset = "0x24A74")]
		public string IdentityId
		{
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x11A1488", Offset = "0x11A1488", VA = "0x11A1488")]
			get
			{
				return null;
			}
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x11A1490", Offset = "0x11A1490", VA = "0x11A1490")]
			set
			{
			}
		}

		[Token(Token = "0x17000042")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x24AC4", Offset = "0x24AC4")]
		public string IdentityPoolId
		{
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x11A14A8", Offset = "0x11A14A8", VA = "0x11A14A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000162")]
			[Address(RVA = "0x11A14B0", Offset = "0x11A14B0", VA = "0x11A14B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public long LastSyncCount
		{
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x11A14C8", Offset = "0x11A14C8", VA = "0x11A14C8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x11A1508", Offset = "0x11A1508", VA = "0x11A1508")]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public int MaxResults
		{
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x11A15BC", Offset = "0x11A15BC", VA = "0x11A15BC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x11A15FC", Offset = "0x11A15FC", VA = "0x11A15FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public string NextToken
		{
			[Token(Token = "0x600016A")]
			[Address(RVA = "0x11A16B0", Offset = "0x11A16B0", VA = "0x11A16B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x11A16B8", Offset = "0x11A16B8", VA = "0x11A16B8")]
			set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public string SyncSessionToken
		{
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x11A16D0", Offset = "0x11A16D0", VA = "0x11A16D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x11A16D8", Offset = "0x11A16D8", VA = "0x11A16D8")]
			set
			{
			}
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x11A1478", Offset = "0x11A1478", VA = "0x11A1478")]
		internal bool IsSetDatasetName()
		{
			return default;
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x11A1498", Offset = "0x11A1498", VA = "0x11A1498")]
		internal bool IsSetIdentityId()
		{
			return default;
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x11A14B8", Offset = "0x11A14B8", VA = "0x11A14B8")]
		internal bool IsSetIdentityPoolId()
		{
			return default;
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x11A157C", Offset = "0x11A157C", VA = "0x11A157C")]
		internal bool IsSetLastSyncCount()
		{
			return default;
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x11A1670", Offset = "0x11A1670", VA = "0x11A1670")]
		internal bool IsSetMaxResults()
		{
			return default;
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x11A16C0", Offset = "0x11A16C0", VA = "0x11A16C0")]
		internal bool IsSetNextToken()
		{
			return default;
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x11A16E0", Offset = "0x11A16E0", VA = "0x11A16E0")]
		internal bool IsSetSyncSessionToken()
		{
			return default;
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x11A16F0", Offset = "0x11A16F0", VA = "0x11A16F0")]
		public ListRecordsRequest()
		{
		}
	}
}
