using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000AA")]
	public class DeviceType
	{
		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0x10")]
		private List<AttributeType> _deviceAttributes;

		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x18")]
		private DateTime? _deviceCreateDate;

		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0x28")]
		private string _deviceKey;

		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x30")]
		private DateTime? _deviceLastAuthenticatedDate;

		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x40")]
		private DateTime? _deviceLastModifiedDate;

		[Token(Token = "0x1700012F")]
		public List<AttributeType> DeviceAttributes
		{
			[Token(Token = "0x60005E2")]
			[Address(RVA = "0x110F178", Offset = "0x110F178", VA = "0x110F178")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005E3")]
			[Address(RVA = "0x110F180", Offset = "0x110F180", VA = "0x110F180")]
			set
			{
			}
		}

		[Token(Token = "0x17000130")]
		public DateTime DeviceCreateDate
		{
			[Token(Token = "0x60005E5")]
			[Address(RVA = "0x110F1E0", Offset = "0x110F1E0", VA = "0x110F1E0")]
			get
			{
				return default;
			}
			[Token(Token = "0x60005E6")]
			[Address(RVA = "0x110F220", Offset = "0x110F220", VA = "0x110F220")]
			set
			{
			}
		}

		[Token(Token = "0x17000131")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x1DFA0", Offset = "0x1DFA0")]
		public string DeviceKey
		{
			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x110F2D4", Offset = "0x110F2D4", VA = "0x110F2D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005E9")]
			[Address(RVA = "0x110F2DC", Offset = "0x110F2DC", VA = "0x110F2DC")]
			set
			{
			}
		}

		[Token(Token = "0x17000132")]
		public DateTime DeviceLastAuthenticatedDate
		{
			[Token(Token = "0x60005EB")]
			[Address(RVA = "0x110F2F4", Offset = "0x110F2F4", VA = "0x110F2F4")]
			get
			{
				return default;
			}
			[Token(Token = "0x60005EC")]
			[Address(RVA = "0x110F334", Offset = "0x110F334", VA = "0x110F334")]
			set
			{
			}
		}

		[Token(Token = "0x17000133")]
		public DateTime DeviceLastModifiedDate
		{
			[Token(Token = "0x60005EE")]
			[Address(RVA = "0x110F3E8", Offset = "0x110F3E8", VA = "0x110F3E8")]
			get
			{
				return default;
			}
			[Token(Token = "0x60005EF")]
			[Address(RVA = "0x110F428", Offset = "0x110F428", VA = "0x110F428")]
			set
			{
			}
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x110F188", Offset = "0x110F188", VA = "0x110F188")]
		internal bool IsSetDeviceAttributes()
		{
			return default;
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x110F294", Offset = "0x110F294", VA = "0x110F294")]
		internal bool IsSetDeviceCreateDate()
		{
			return default;
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x110F2E4", Offset = "0x110F2E4", VA = "0x110F2E4")]
		internal bool IsSetDeviceKey()
		{
			return default;
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x110F3A8", Offset = "0x110F3A8", VA = "0x110F3A8")]
		internal bool IsSetDeviceLastAuthenticatedDate()
		{
			return default;
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x110F49C", Offset = "0x110F49C", VA = "0x110F49C")]
		internal bool IsSetDeviceLastModifiedDate()
		{
			return default;
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x110F4DC", Offset = "0x110F4DC", VA = "0x110F4DC")]
		public DeviceType()
		{
		}
	}
}
