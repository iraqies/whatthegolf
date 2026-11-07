using System;
using System.Collections.Generic;
using System.Net;
using Il2CppDummyDll;

namespace Amazon.Util
{
	[Token(Token = "0x2000068")]
	public static class EC2InstanceMetadata
	{
		[Token(Token = "0x2000069")]
		private class IMDSDisabledException : InvalidOperationException
		{
			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x128A6EC", Offset = "0x128A6EC", VA = "0x128A6EC")]
			public IMDSDisabledException()
			{
			}
		}

		[Token(Token = "0x400021C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string EC2_METADATA_SVC;

		[Token(Token = "0x400021D")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string LATEST;

		[Token(Token = "0x400021E")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string EC2_METADATA_ROOT;

		[Token(Token = "0x400021F")]
		[FieldOffset(Offset = "0x18")]
		public static readonly string EC2_USERDATA_ROOT;

		[Token(Token = "0x4000220")]
		[FieldOffset(Offset = "0x20")]
		public static readonly string EC2_DYNAMICDATA_ROOT;

		[Token(Token = "0x4000221")]
		[FieldOffset(Offset = "0x28")]
		public static readonly string AWS_EC2_METADATA_DISABLED;

		[Token(Token = "0x4000222")]
		[FieldOffset(Offset = "0x30")]
		public static readonly string EC2_APITOKEN_URL;

		[Token(Token = "0x4000223")]
		[FieldOffset(Offset = "0x38")]
		private static int DEFAULT_RETRIES;

		[Token(Token = "0x4000224")]
		[FieldOffset(Offset = "0x3C")]
		private static int MIN_PAUSE_MS;

		[Token(Token = "0x4000225")]
		[FieldOffset(Offset = "0x40")]
		private static int MAX_RETRIES;

		[Token(Token = "0x4000226")]
		[FieldOffset(Offset = "0x44")]
		private static int DEFAULT_APITOKEN_TTL;

		[Token(Token = "0x4000227")]
		[FieldOffset(Offset = "0x48")]
		private static Dictionary<string, string> _cache;

		[Token(Token = "0x4000228")]
		[FieldOffset(Offset = "0x50")]
		private static bool useNullToken;

		[Token(Token = "0x4000229")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26408", Offset = "0x26408")]
		private static IWebProxy Proxy__BackingField;

		[Token(Token = "0x170000BD")]
		public static bool IsIMDSEnabled
		{
			[Token(Token = "0x60003A3")]
			[Address(RVA = "0x11EDB50", Offset = "0x11EDB50", VA = "0x11EDB50")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000BE")]
		public static IWebProxy Proxy
		{
			[Token(Token = "0x60003A4")]
			[Address(RVA = "0x11F4C48", Offset = "0x11F4C48", VA = "0x11F4C48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x283DC", Offset = "0x283DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003A5")]
			[Address(RVA = "0x11F4CAC", Offset = "0x11F4CAC", VA = "0x11F4CAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x283EC", Offset = "0x283EC")]
			set
			{
			}
		}

		[Token(Token = "0x170000BF")]
		public static string AmiId
		{
			[Token(Token = "0x60003A6")]
			[Address(RVA = "0x11F4D1C", Offset = "0x11F4D1C", VA = "0x11F4D1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C0")]
		public static string AmiLaunchIndex
		{
			[Token(Token = "0x60003A7")]
			[Address(RVA = "0x11F4E50", Offset = "0x11F4E50", VA = "0x11F4E50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C1")]
		public static string AmiManifestPath
		{
			[Token(Token = "0x60003A8")]
			[Address(RVA = "0x11F4F08", Offset = "0x11F4F08", VA = "0x11F4F08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C2")]
		public static IEnumerable<string> AncestorAmiIds
		{
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x11F4FC0", Offset = "0x11F4FC0", VA = "0x11F4FC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C3")]
		public static string Hostname
		{
			[Token(Token = "0x60003AA")]
			[Address(RVA = "0x11F50E8", Offset = "0x11F50E8", VA = "0x11F50E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C4")]
		public static string InstanceAction
		{
			[Token(Token = "0x60003AB")]
			[Address(RVA = "0x11F51A0", Offset = "0x11F51A0", VA = "0x11F51A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C5")]
		public static string InstanceId
		{
			[Token(Token = "0x60003AC")]
			[Address(RVA = "0x11F5258", Offset = "0x11F5258", VA = "0x11F5258")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C6")]
		public static string InstanceType
		{
			[Token(Token = "0x60003AD")]
			[Address(RVA = "0x11F5310", Offset = "0x11F5310", VA = "0x11F5310")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C7")]
		public static string KernelId
		{
			[Token(Token = "0x60003AE")]
			[Address(RVA = "0x11F53C8", Offset = "0x11F53C8", VA = "0x11F53C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C8")]
		public static string LocalHostname
		{
			[Token(Token = "0x60003AF")]
			[Address(RVA = "0x11F550C", Offset = "0x11F550C", VA = "0x11F550C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C9")]
		public static string MacAddress
		{
			[Token(Token = "0x60003B0")]
			[Address(RVA = "0x11F55C4", Offset = "0x11F55C4", VA = "0x11F55C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CA")]
		public static string PrivateIpAddress
		{
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0x11F567C", Offset = "0x11F567C", VA = "0x11F567C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CB")]
		public static string AvailabilityZone
		{
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x11F5734", Offset = "0x11F5734", VA = "0x11F5734")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CC")]
		public static IEnumerable<string> ProductCodes
		{
			[Token(Token = "0x60003B3")]
			[Address(RVA = "0x11F57EC", Offset = "0x11F57EC", VA = "0x11F57EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CD")]
		public static string PublicKey
		{
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0x11F585C", Offset = "0x11F585C", VA = "0x11F585C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CE")]
		public static string RamdiskId
		{
			[Token(Token = "0x60003B5")]
			[Address(RVA = "0x11F5914", Offset = "0x11F5914", VA = "0x11F5914")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CF")]
		public static RegionEndpoint Region
		{
			[Token(Token = "0x60003B6")]
			[Address(RVA = "0x11F59CC", Offset = "0x11F59CC", VA = "0x11F59CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D0")]
		public static string ReservationId
		{
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x11F5D6C", Offset = "0x11F5D6C", VA = "0x11F5D6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D1")]
		public static IEnumerable<string> SecurityGroups
		{
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x11F5E24", Offset = "0x11F5E24", VA = "0x11F5E24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D2")]
		public static IAMInstanceProfileMetadata IAMInstanceProfileInfo
		{
			[Token(Token = "0x60003B9")]
			[Address(RVA = "0x11F5E94", Offset = "0x11F5E94", VA = "0x11F5E94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D3")]
		public static IDictionary<string, IAMSecurityCredentialMetadata> IAMSecurityCredentials
		{
			[Token(Token = "0x60003BA")]
			[Address(RVA = "0x11EE5FC", Offset = "0x11EE5FC", VA = "0x11EE5FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D4")]
		public static IDictionary<string, string> BlockDeviceMapping
		{
			[Token(Token = "0x60003BB")]
			[Address(RVA = "0x11F6074", Offset = "0x11F6074", VA = "0x11F6074")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D5")]
		public static IEnumerable<NetworkInterfaceMetadata> NetworkInterfaces
		{
			[Token(Token = "0x60003BC")]
			[Address(RVA = "0x11F64C0", Offset = "0x11F64C0", VA = "0x11F64C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D6")]
		public static string UserData
		{
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x11F6918", Offset = "0x11F6918", VA = "0x11F6918")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D7")]
		public static string InstanceMonitoring
		{
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x11F69CC", Offset = "0x11F69CC", VA = "0x11F69CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D8")]
		public static string IdentityDocument
		{
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x11F5C84", Offset = "0x11F5C84", VA = "0x11F5C84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D9")]
		public static string IdentitySignature
		{
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x11F6AB4", Offset = "0x11F6AB4", VA = "0x11F6AB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DA")]
		public static string IdentityPkcs7
		{
			[Token(Token = "0x60003C1")]
			[Address(RVA = "0x11F6B9C", Offset = "0x11F6B9C", VA = "0x11F6B9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x11F5030", Offset = "0x11F5030", VA = "0x11F5030")]
		public static IEnumerable<string> GetItems(string path)
		{
			return null;
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x11F5488", Offset = "0x11F5488", VA = "0x11F5488")]
		public static string GetData(string path)
		{
			return null;
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x11F6D28", Offset = "0x11F6D28", VA = "0x11F6D28")]
		public static string GetData(string path, int tries)
		{
			return null;
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x11F6E14", Offset = "0x11F6E14", VA = "0x11F6E14")]
		public static IEnumerable<string> GetItems(string path, int tries)
		{
			return null;
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x11F4DD4", Offset = "0x11F4DD4", VA = "0x11F4DD4")]
		private static string FetchData(string path)
		{
			return null;
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x11F6EC4", Offset = "0x11F6EC4", VA = "0x11F6EC4")]
		private static string FetchData(string path, bool force)
		{
			return null;
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x11F70EC", Offset = "0x11F70EC", VA = "0x11F70EC")]
		public static string FetchApiToken()
		{
			return null;
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x11F7150", Offset = "0x11F7150", VA = "0x11F7150")]
		private static string FetchApiToken(int tries)
		{
			return null;
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x11F7900", Offset = "0x11F7900", VA = "0x11F7900")]
		public static void ClearTokenFlag()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x11F6C84", Offset = "0x11F6C84", VA = "0x11F6C84")]
		private static List<string> GetItems(string relativeOrAbsolutePath, int tries, bool slurp)
		{
			return null;
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x11F7964", Offset = "0x11F7964", VA = "0x11F7964")]
		private static List<string> GetItems(string relativeOrAbsolutePath, int tries, bool slurp, string token)
		{
			return null;
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x11F77F8", Offset = "0x11F77F8", VA = "0x11F77F8")]
		private static void PauseExponentially(int retry)
		{
		}
	}
}
