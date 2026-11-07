using System;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x2000010")]
	public class Dataset
	{
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x10")]
		private DateTime? _creationDate;

		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x20")]
		private string _datasetName;

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x28")]
		private long? _dataStorage;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x38")]
		private string _identityId;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x40")]
		private string _lastModifiedBy;

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x48")]
		private DateTime? _lastModifiedDate;

		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x58")]
		private long? _numRecords;

		[Token(Token = "0x1700000A")]
		public DateTime CreationDate
		{
			[Token(Token = "0x6000081")]
			[Address(RVA = "0x1192F78", Offset = "0x1192F78", VA = "0x1192F78")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x1192FB8", Offset = "0x1192FB8", VA = "0x1192FB8")]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x24394", Offset = "0x24394")]
		public string DatasetName
		{
			[Token(Token = "0x6000084")]
			[Address(RVA = "0x119306C", Offset = "0x119306C", VA = "0x119306C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000085")]
			[Address(RVA = "0x1193074", Offset = "0x1193074", VA = "0x1193074")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public long DataStorage
		{
			[Token(Token = "0x6000087")]
			[Address(RVA = "0x119308C", Offset = "0x119308C", VA = "0x119308C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000088")]
			[Address(RVA = "0x11930CC", Offset = "0x11930CC", VA = "0x11930CC")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x243DC", Offset = "0x243DC")]
		public string IdentityId
		{
			[Token(Token = "0x600008A")]
			[Address(RVA = "0x1193180", Offset = "0x1193180", VA = "0x1193180")]
			get
			{
				return null;
			}
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x1193188", Offset = "0x1193188", VA = "0x1193188")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public string LastModifiedBy
		{
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x11931A0", Offset = "0x11931A0", VA = "0x11931A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x11931A8", Offset = "0x11931A8", VA = "0x11931A8")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public DateTime LastModifiedDate
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x11931C0", Offset = "0x11931C0", VA = "0x11931C0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x1193200", Offset = "0x1193200", VA = "0x1193200")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public long NumRecords
		{
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x11932B4", Offset = "0x11932B4", VA = "0x11932B4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x11932F4", Offset = "0x11932F4", VA = "0x11932F4")]
			set
			{
			}
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x119302C", Offset = "0x119302C", VA = "0x119302C")]
		internal bool IsSetCreationDate()
		{
			return default;
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x119307C", Offset = "0x119307C", VA = "0x119307C")]
		internal bool IsSetDatasetName()
		{
			return default;
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x1193140", Offset = "0x1193140", VA = "0x1193140")]
		internal bool IsSetDataStorage()
		{
			return default;
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x1193190", Offset = "0x1193190", VA = "0x1193190")]
		internal bool IsSetIdentityId()
		{
			return default;
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x11931B0", Offset = "0x11931B0", VA = "0x11931B0")]
		internal bool IsSetLastModifiedBy()
		{
			return default;
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x1193274", Offset = "0x1193274", VA = "0x1193274")]
		internal bool IsSetLastModifiedDate()
		{
			return default;
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x1193368", Offset = "0x1193368", VA = "0x1193368")]
		internal bool IsSetNumRecords()
		{
			return default;
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x11933A8", Offset = "0x11933A8", VA = "0x11933A8")]
		public Dataset()
		{
		}
	}
}
