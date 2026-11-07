using System.Collections.Generic;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200004A")]
	public class AdminListDevicesResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x28")]
		private List<DeviceType> _devices;

		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x30")]
		private string _paginationToken;

		[Token(Token = "0x17000051")]
		public List<DeviceType> Devices
		{
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x10B1E40", Offset = "0x10B1E40", VA = "0x10B1E40")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x10B1E48", Offset = "0x10B1E48", VA = "0x10B1E48")]
			set
			{
			}
		}

		[Token(Token = "0x17000052")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1B938", Offset = "0x1B938")]
		public string PaginationToken
		{
			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x10B1EA8", Offset = "0x10B1EA8", VA = "0x10B1EA8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002D7")]
			[Address(RVA = "0x10B1EB0", Offset = "0x10B1EB0", VA = "0x10B1EB0")]
			set
			{
			}
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x10B1E50", Offset = "0x10B1E50", VA = "0x10B1E50")]
		internal bool IsSetDevices()
		{
			return default;
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x10B1EB8", Offset = "0x10B1EB8", VA = "0x10B1EB8")]
		internal bool IsSetPaginationToken()
		{
			return default;
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x10B1EC8", Offset = "0x10B1EC8", VA = "0x10B1EC8")]
		public AdminListDevicesResponse()
		{
		}
	}
}
