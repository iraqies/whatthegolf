using System.Runtime.InteropServices;

namespace Prime31
{
	public class iCloudBinding
	{
		[PreserveSig]
		private static extern bool _iCloudAreiCloudCredentialsValid();

		public static bool areiCloudCredentialsValid()
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _iCloudSelectDatabase(string identifier, bool usePrivateDatabase);

		public static bool selectDatabase(bool usePrivateDatabase, string containerIdentifier = null)
		{
			return false;
		}

		[PreserveSig]
		private static extern void _iCloudSaveRecord(string recordType, string recordId, string title, string path);

		public static void saveRecord(string recordType, string recordId, string title, string path)
		{
		}

		[PreserveSig]
		private static extern void _iCloudFetchRecord(string recordType, string recordId);

		public static void fetchRecord(string recordType, string recordId)
		{
		}

		[PreserveSig]
		private static extern void _iCloudUpdateRecord(string recordType, string recordId, string title, string path);

		public static void updateRecord(string recordType, string recordId, string title, string path)
		{
		}

		[PreserveSig]
		private static extern void _iCloudDeleteRecord(string recordId);

		public static void deleteRecord(string recordId)
		{
		}
	}
}
