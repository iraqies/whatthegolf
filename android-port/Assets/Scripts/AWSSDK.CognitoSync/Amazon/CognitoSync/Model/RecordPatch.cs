using System;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x2000031")]
	public class RecordPatch
	{
		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x10")]
		private DateTime? _deviceLastModifiedDate;

		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x20")]
		private string _key;

		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x28")]
		private Operation _op;

		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x30")]
		private long? _syncCount;

		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x40")]
		private string _value;

		[Token(Token = "0x17000058")]
		public DateTime DeviceLastModifiedDate
		{
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0x11A4BCC", Offset = "0x11A4BCC", VA = "0x11A4BCC")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0x11A4C0C", Offset = "0x11A4C0C", VA = "0x11A4C0C")]
			set
			{
			}
		}

		[Token(Token = "0x17000059")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x24BDC", Offset = "0x24BDC")]
		public string Key
		{
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x11A4CC0", Offset = "0x11A4CC0", VA = "0x11A4CC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x11A4CC8", Offset = "0x11A4CC8", VA = "0x11A4CC8")]
			set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x24C2C", Offset = "0x24C2C")]
		public Operation Op
		{
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x11A4CE0", Offset = "0x11A4CE0", VA = "0x11A4CE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x11A4CE8", Offset = "0x11A4CE8", VA = "0x11A4CE8")]
			set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x24C60", Offset = "0x24C60")]
		public long SyncCount
		{
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x11A4D6C", Offset = "0x11A4D6C", VA = "0x11A4D6C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x11A4DAC", Offset = "0x11A4DAC", VA = "0x11A4DAC")]
			set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x24C94", Offset = "0x24C94")]
		public string Value
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x11A4E60", Offset = "0x11A4E60", VA = "0x11A4E60")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x11A4E68", Offset = "0x11A4E68", VA = "0x11A4E68")]
			set
			{
			}
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x11A4C80", Offset = "0x11A4C80", VA = "0x11A4C80")]
		internal bool IsSetDeviceLastModifiedDate()
		{
			return default;
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x11A4CD0", Offset = "0x11A4CD0", VA = "0x11A4CD0")]
		internal bool IsSetKey()
		{
			return default;
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x11A4CF0", Offset = "0x11A4CF0", VA = "0x11A4CF0")]
		internal bool IsSetOp()
		{
			return default;
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x11A4E20", Offset = "0x11A4E20", VA = "0x11A4E20")]
		internal bool IsSetSyncCount()
		{
			return default;
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x11A4E70", Offset = "0x11A4E70", VA = "0x11A4E70")]
		internal bool IsSetValue()
		{
			return default;
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x11A4E80", Offset = "0x11A4E80", VA = "0x11A4E80")]
		public RecordPatch()
		{
		}
	}
}
