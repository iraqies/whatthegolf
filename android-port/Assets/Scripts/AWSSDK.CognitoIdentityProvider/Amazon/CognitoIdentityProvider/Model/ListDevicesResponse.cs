using System.Collections.Generic;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000DD")]
	public class ListDevicesResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000210")]
		[FieldOffset(Offset = "0x28")]
		private List<DeviceType> _devices;

		[Token(Token = "0x4000211")]
		[FieldOffset(Offset = "0x30")]
		private string _paginationToken;

		[Token(Token = "0x1700019D")]
		public List<DeviceType> Devices
		{
			[Token(Token = "0x600079B")]
			[Address(RVA = "0x112DA1C", Offset = "0x112DA1C", VA = "0x112DA1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600079C")]
			[Address(RVA = "0x112DA24", Offset = "0x112DA24", VA = "0x112DA24")]
			set
			{
			}
		}

		[Token(Token = "0x1700019E")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1EF14", Offset = "0x1EF14")]
		public string PaginationToken
		{
			[Token(Token = "0x600079E")]
			[Address(RVA = "0x112DA84", Offset = "0x112DA84", VA = "0x112DA84")]
			get
			{
				return null;
			}
			[Token(Token = "0x600079F")]
			[Address(RVA = "0x112DA8C", Offset = "0x112DA8C", VA = "0x112DA8C")]
			set
			{
			}
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x112DA2C", Offset = "0x112DA2C", VA = "0x112DA2C")]
		internal bool IsSetDevices()
		{
			return default;
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x112DA94", Offset = "0x112DA94", VA = "0x112DA94")]
		internal bool IsSetPaginationToken()
		{
			return default;
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x112DAA4", Offset = "0x112DAA4", VA = "0x112DAA4")]
		public ListDevicesResponse()
		{
		}
	}
}
