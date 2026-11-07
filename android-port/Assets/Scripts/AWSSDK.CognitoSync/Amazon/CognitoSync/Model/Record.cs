using System;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x2000030")]
	public class Record
	{
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x10")]
		private DateTime? _deviceLastModifiedDate;

		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x20")]
		private string _key;

		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x28")]
		private string _lastModifiedBy;

		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x30")]
		private DateTime? _lastModifiedDate;

		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x40")]
		private long? _syncCount;

		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x50")]
		private string _value;

		[Token(Token = "0x17000052")]
		public DateTime DeviceLastModifiedDate
		{
			[Token(Token = "0x6000199")]
			[Address(RVA = "0x11A4888", Offset = "0x11A4888", VA = "0x11A4888")]
			get
			{
				return default;
			}
			[Token(Token = "0x600019A")]
			[Address(RVA = "0x11A48C8", Offset = "0x11A48C8", VA = "0x11A48C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000053")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x24B5C", Offset = "0x24B5C")]
		public string Key
		{
			[Token(Token = "0x600019C")]
			[Address(RVA = "0x11A497C", Offset = "0x11A497C", VA = "0x11A497C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600019D")]
			[Address(RVA = "0x11A4984", Offset = "0x11A4984", VA = "0x11A4984")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public string LastModifiedBy
		{
			[Token(Token = "0x600019F")]
			[Address(RVA = "0x11A499C", Offset = "0x11A499C", VA = "0x11A499C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x11A49A4", Offset = "0x11A49A4", VA = "0x11A49A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public DateTime LastModifiedDate
		{
			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x11A49BC", Offset = "0x11A49BC", VA = "0x11A49BC")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001A3")]
			[Address(RVA = "0x11A49FC", Offset = "0x11A49FC", VA = "0x11A49FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public long SyncCount
		{
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x11A4AB0", Offset = "0x11A4AB0", VA = "0x11A4AB0")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001A6")]
			[Address(RVA = "0x11A4AF0", Offset = "0x11A4AF0", VA = "0x11A4AF0")]
			set
			{
			}
		}

		[Token(Token = "0x17000057")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x24BA4", Offset = "0x24BA4")]
		public string Value
		{
			[Token(Token = "0x60001A8")]
			[Address(RVA = "0x11A4BA4", Offset = "0x11A4BA4", VA = "0x11A4BA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0x11A4BAC", Offset = "0x11A4BAC", VA = "0x11A4BAC")]
			set
			{
			}
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x11A493C", Offset = "0x11A493C", VA = "0x11A493C")]
		internal bool IsSetDeviceLastModifiedDate()
		{
			return default;
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x11A498C", Offset = "0x11A498C", VA = "0x11A498C")]
		internal bool IsSetKey()
		{
			return default;
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x11A49AC", Offset = "0x11A49AC", VA = "0x11A49AC")]
		internal bool IsSetLastModifiedBy()
		{
			return default;
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x11A4A70", Offset = "0x11A4A70", VA = "0x11A4A70")]
		internal bool IsSetLastModifiedDate()
		{
			return default;
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x11A4B64", Offset = "0x11A4B64", VA = "0x11A4B64")]
		internal bool IsSetSyncCount()
		{
			return default;
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x11A4BB4", Offset = "0x11A4BB4", VA = "0x11A4BB4")]
		internal bool IsSetValue()
		{
			return default;
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x11A4BC4", Offset = "0x11A4BC4", VA = "0x11A4BC4")]
		public Record()
		{
		}
	}
}
