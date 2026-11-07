using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Prime31
{
	public class iCloudManager : AbstractManager
	{
		public class iCloudDocument
		{
			public string filename;

			public bool isDownloaded;

			public DateTime contentChangedDate;

			public string downloadStatus;

			public string path;

			public iCloudDocument(Dictionary<string, object> dict)
			{
			}

			public static List<iCloudDocument> fromJSON(string json)
			{
				return null;
			}

			public override string ToString()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private static Action<List<object>> m_keyValueStoreDidChangeEvent;

		[CompilerGenerated]
		private static Action<iCloudKeyValueStoreReason> m_keyValueStoreDidChangeReasonEvent;

		[CompilerGenerated]
		private static Action m_ubiquityIdentityDidChangeEvent;

		[CompilerGenerated]
		private static Action m_entitlementsMissingEvent;

		[CompilerGenerated]
		private static Action<List<iCloudDocument>> m_documentStoreUpdatedEvent;

		[CompilerGenerated]
		private static Action<string> m_cloudKitSaveRecordFailedEvent;

		[CompilerGenerated]
		private static Action m_cloudKitSaveRecordSucceededEvent;

		[CompilerGenerated]
		private static Action<string> m_cloudKitFetchRecordFailedEvent;

		[CompilerGenerated]
		private static Action<Dictionary<string, string>> m_cloudKitFetchRecordSucceededEvent;

		[CompilerGenerated]
		private static Action<string> m_cloudKitUpdateRecordFailedEvent;

		[CompilerGenerated]
		private static Action m_cloudKitUpdateRecordSucceededEvent;

		[CompilerGenerated]
		private static Action<string> m_cloudKitDeleteRecordFailedEvent;

		[CompilerGenerated]
		private static Action m_cloudKitDeleteRecordSucceededEvent;

		public static event Action<List<object>> keyValueStoreDidChangeEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<iCloudKeyValueStoreReason> keyValueStoreDidChangeReasonEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action ubiquityIdentityDidChangeEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action entitlementsMissingEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<List<iCloudDocument>> documentStoreUpdatedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<string> cloudKitSaveRecordFailedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action cloudKitSaveRecordSucceededEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<string> cloudKitFetchRecordFailedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<Dictionary<string, string>> cloudKitFetchRecordSucceededEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<string> cloudKitUpdateRecordFailedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action cloudKitUpdateRecordSucceededEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<string> cloudKitDeleteRecordFailedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action cloudKitDeleteRecordSucceededEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		static iCloudManager()
		{
		}

		private void ubiquityIdentityDidChange(string param)
		{
		}

		private void keyValueStoreDidChange(string param)
		{
		}

		private void keyValueStoreChangeReason(string reason)
		{
		}

		private void entitlementsMissing(string empty)
		{
		}

		private void documentStoreUpdated(string json)
		{
		}

		private void cloudKitSaveRecordFailed(string error)
		{
		}

		private void cloudKitSaveRecordSucceeded(string empty)
		{
		}

		private void cloudKitFetchRecordFailed(string error)
		{
		}

		private void cloudKitFetchRecordSucceeded(string json)
		{
		}

		private void cloudKitUpdateRecordFailed(string error)
		{
		}

		private void cloudKitUpdateRecordSucceeded(string empty)
		{
		}

		private void cloudKitDeleteRecordFailed(string error)
		{
		}

		private void cloudKitDeleteRecordSucceeded(string empty)
		{
		}
	}
}
