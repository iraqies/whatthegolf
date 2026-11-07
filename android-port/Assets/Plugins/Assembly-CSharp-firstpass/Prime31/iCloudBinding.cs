using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Prime31
{
	[Token(Token = "0x200025E")]
	public class iCloudBinding
	{
		[PreserveSig]
		[Token(Token = "0x6000F9C")]
		[Address(RVA = "0x132DCB8", Offset = "0x132DCB8", VA = "0x132DCB8")]
		private static extern bool _iCloudAreiCloudCredentialsValid();

		[Token(Token = "0x6000F9D")]
		[Address(RVA = "0x132DCD4", Offset = "0x132DCD4", VA = "0x132DCD4")]
		public static bool areiCloudCredentialsValid()
		{
			return default;
		}

		[PreserveSig]
		[Token(Token = "0x6000F9E")]
		[Address(RVA = "0x132DD1C", Offset = "0x132DD1C", VA = "0x132DD1C")]
		private static extern bool _iCloudSelectDatabase(string identifier, bool usePrivateDatabase);

		[Token(Token = "0x6000F9F")]
		[Address(RVA = "0x132DD5C", Offset = "0x132DD5C", VA = "0x132DD5C")]
		public static bool selectDatabase(bool usePrivateDatabase, [Optional] string containerIdentifier)
		{
			return default;
		}

		[PreserveSig]
		[Token(Token = "0x6000FA0")]
		[Address(RVA = "0x132DDCC", Offset = "0x132DDCC", VA = "0x132DDCC")]
		private static extern void _iCloudSaveRecord(string recordType, string recordId, string title, string path);

		[Token(Token = "0x6000FA1")]
		[Address(RVA = "0x132DE54", Offset = "0x132DE54", VA = "0x132DE54")]
		public static void saveRecord(string recordType, string recordId, string title, string path)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000FA2")]
		[Address(RVA = "0x132DF14", Offset = "0x132DF14", VA = "0x132DF14")]
		private static extern void _iCloudFetchRecord(string recordType, string recordId);

		[Token(Token = "0x6000FA3")]
		[Address(RVA = "0x132DF5C", Offset = "0x132DF5C", VA = "0x132DF5C")]
		public static void fetchRecord(string recordType, string recordId)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000FA4")]
		[Address(RVA = "0x132DFD8", Offset = "0x132DFD8", VA = "0x132DFD8")]
		private static extern void _iCloudUpdateRecord(string recordType, string recordId, string title, string path);

		[Token(Token = "0x6000FA5")]
		[Address(RVA = "0x132E060", Offset = "0x132E060", VA = "0x132E060")]
		public static void updateRecord(string recordType, string recordId, string title, string path)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000FA6")]
		[Address(RVA = "0x132E120", Offset = "0x132E120", VA = "0x132E120")]
		private static extern void _iCloudDeleteRecord(string recordId);

		[Token(Token = "0x6000FA7")]
		[Address(RVA = "0x132E148", Offset = "0x132E148", VA = "0x132E148")]
		public static void deleteRecord(string recordId)
		{
		}
	}
}
