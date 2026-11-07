using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.Util
{
	[Token(Token = "0x200006C")]
	public class NetworkInterfaceMetadata
	{
		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0x10")]
		private string _path;

		[Token(Token = "0x4000238")]
		[FieldOffset(Offset = "0x18")]
		private string _mac;

		[Token(Token = "0x4000239")]
		[FieldOffset(Offset = "0x20")]
		private IEnumerable<string> _availableKeys;

		[Token(Token = "0x400023A")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, string> _data;

		[Token(Token = "0x170000E8")]
		public string MacAddress
		{
			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x12429D0", Offset = "0x12429D0", VA = "0x12429D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E9")]
		public string OwnerId
		{
			[Token(Token = "0x60003EF")]
			[Address(RVA = "0x12429D8", Offset = "0x12429D8", VA = "0x12429D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EA")]
		public string Profile
		{
			[Token(Token = "0x60003F0")]
			[Address(RVA = "0x1242BC0", Offset = "0x1242BC0", VA = "0x1242BC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EB")]
		public string LocalHostname
		{
			[Token(Token = "0x60003F1")]
			[Address(RVA = "0x1242C18", Offset = "0x1242C18", VA = "0x1242C18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EC")]
		public IEnumerable<string> LocalIPv4s
		{
			[Token(Token = "0x60003F2")]
			[Address(RVA = "0x1242C70", Offset = "0x1242C70", VA = "0x1242C70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000ED")]
		public string PublicHostname
		{
			[Token(Token = "0x60003F3")]
			[Address(RVA = "0x1242E10", Offset = "0x1242E10", VA = "0x1242E10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EE")]
		public IEnumerable<string> PublicIPv4s
		{
			[Token(Token = "0x60003F4")]
			[Address(RVA = "0x1242E68", Offset = "0x1242E68", VA = "0x1242E68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EF")]
		public IEnumerable<string> SecurityGroups
		{
			[Token(Token = "0x60003F5")]
			[Address(RVA = "0x1242EC0", Offset = "0x1242EC0", VA = "0x1242EC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F0")]
		public IEnumerable<string> SecurityGroupIds
		{
			[Token(Token = "0x60003F6")]
			[Address(RVA = "0x1242F18", Offset = "0x1242F18", VA = "0x1242F18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F1")]
		public string SubnetId
		{
			[Token(Token = "0x60003F7")]
			[Address(RVA = "0x1242F70", Offset = "0x1242F70", VA = "0x1242F70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F2")]
		public string SubnetIPv4CidrBlock
		{
			[Token(Token = "0x60003F8")]
			[Address(RVA = "0x1242FC8", Offset = "0x1242FC8", VA = "0x1242FC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F3")]
		public string VpcId
		{
			[Token(Token = "0x60003F9")]
			[Address(RVA = "0x1243020", Offset = "0x1243020", VA = "0x1243020")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x1242860", Offset = "0x1242860", VA = "0x1242860")]
		private NetworkInterfaceMetadata()
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x12428E0", Offset = "0x12428E0", VA = "0x12428E0")]
		public NetworkInterfaceMetadata(string macAddress)
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x1243078", Offset = "0x1243078", VA = "0x1243078")]
		public IEnumerable<string> GetIpV4Association(string publicIp)
		{
			return null;
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x1242A30", Offset = "0x1242A30", VA = "0x1242A30")]
		private string GetData(string key)
		{
			return null;
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x1242CC8", Offset = "0x1242CC8", VA = "0x1242CC8")]
		private IEnumerable<string> GetItems(string key)
		{
			return null;
		}
	}
}
