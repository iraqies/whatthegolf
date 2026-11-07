using System.Collections.Generic;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x200002D")]
	public class ListRecordsResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x24")]
		private int? _count;

		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x2C")]
		private bool? _datasetDeletedAfterRequestedSyncCount;

		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x2E")]
		private bool? _datasetExists;

		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x30")]
		private long? _datasetSyncCount;

		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x40")]
		private string _lastModifiedBy;

		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x48")]
		private List<string> _mergedDatasetNames;

		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x50")]
		private string _nextToken;

		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x58")]
		private List<Record> _records;

		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x60")]
		private string _syncSessionToken;

		[Token(Token = "0x17000047")]
		public int Count
		{
			[Token(Token = "0x6000171")]
			[Address(RVA = "0x11A24DC", Offset = "0x11A24DC", VA = "0x11A24DC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000172")]
			[Address(RVA = "0x11A251C", Offset = "0x11A251C", VA = "0x11A251C")]
			set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public bool DatasetDeletedAfterRequestedSyncCount
		{
			[Token(Token = "0x6000174")]
			[Address(RVA = "0x11A25D0", Offset = "0x11A25D0", VA = "0x11A25D0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000175")]
			[Address(RVA = "0x11A2610", Offset = "0x11A2610", VA = "0x11A2610")]
			set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public bool DatasetExists
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x11A26C4", Offset = "0x11A26C4", VA = "0x11A26C4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x11A2704", Offset = "0x11A2704", VA = "0x11A2704")]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public long DatasetSyncCount
		{
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x11A27B8", Offset = "0x11A27B8", VA = "0x11A27B8")]
			get
			{
				return default;
			}
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x11A27F8", Offset = "0x11A27F8", VA = "0x11A27F8")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public string LastModifiedBy
		{
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x11A28AC", Offset = "0x11A28AC", VA = "0x11A28AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x11A28B4", Offset = "0x11A28B4", VA = "0x11A28B4")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public List<string> MergedDatasetNames
		{
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x11A28CC", Offset = "0x11A28CC", VA = "0x11A28CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000181")]
			[Address(RVA = "0x11A28D4", Offset = "0x11A28D4", VA = "0x11A28D4")]
			set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public string NextToken
		{
			[Token(Token = "0x6000183")]
			[Address(RVA = "0x11A2934", Offset = "0x11A2934", VA = "0x11A2934")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000184")]
			[Address(RVA = "0x11A293C", Offset = "0x11A293C", VA = "0x11A293C")]
			set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public List<Record> Records
		{
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x11A2954", Offset = "0x11A2954", VA = "0x11A2954")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000187")]
			[Address(RVA = "0x11A295C", Offset = "0x11A295C", VA = "0x11A295C")]
			set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public string SyncSessionToken
		{
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x11A29BC", Offset = "0x11A29BC", VA = "0x11A29BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x11A29C4", Offset = "0x11A29C4", VA = "0x11A29C4")]
			set
			{
			}
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x11A2590", Offset = "0x11A2590", VA = "0x11A2590")]
		internal bool IsSetCount()
		{
			return default;
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x11A2684", Offset = "0x11A2684", VA = "0x11A2684")]
		internal bool IsSetDatasetDeletedAfterRequestedSyncCount()
		{
			return default;
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x11A2778", Offset = "0x11A2778", VA = "0x11A2778")]
		internal bool IsSetDatasetExists()
		{
			return default;
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x11A286C", Offset = "0x11A286C", VA = "0x11A286C")]
		internal bool IsSetDatasetSyncCount()
		{
			return default;
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x11A28BC", Offset = "0x11A28BC", VA = "0x11A28BC")]
		internal bool IsSetLastModifiedBy()
		{
			return default;
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x11A28DC", Offset = "0x11A28DC", VA = "0x11A28DC")]
		internal bool IsSetMergedDatasetNames()
		{
			return default;
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x11A2944", Offset = "0x11A2944", VA = "0x11A2944")]
		internal bool IsSetNextToken()
		{
			return default;
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x11A2964", Offset = "0x11A2964", VA = "0x11A2964")]
		internal bool IsSetRecords()
		{
			return default;
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x11A29CC", Offset = "0x11A29CC", VA = "0x11A29CC")]
		internal bool IsSetSyncSessionToken()
		{
			return default;
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x11A29DC", Offset = "0x11A29DC", VA = "0x11A29DC")]
		public ListRecordsResponse()
		{
		}
	}
}
