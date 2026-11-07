using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Prime31
{
	[Token(Token = "0x200025F")]
	public class iCloudManager : AbstractManager
	{
		[Token(Token = "0x2000260")]
		public class iCloudDocument
		{
			[Token(Token = "0x4000F9D")]
			[FieldOffset(Offset = "0x10")]
			public string filename;

			[Token(Token = "0x4000F9E")]
			[FieldOffset(Offset = "0x18")]
			public bool isDownloaded;

			[Token(Token = "0x4000F9F")]
			[FieldOffset(Offset = "0x20")]
			public DateTime contentChangedDate;

			[Token(Token = "0x4000FA0")]
			[FieldOffset(Offset = "0x28")]
			public string downloadStatus;

			[Token(Token = "0x4000FA1")]
			[FieldOffset(Offset = "0x30")]
			public string path;

			[Token(Token = "0x6000FD1")]
			[Address(RVA = "0x135A118", Offset = "0x135A118", VA = "0x135A118")]
			public iCloudDocument(Dictionary<string, object> dict)
			{
			}

			[Token(Token = "0x6000FD2")]
			[Address(RVA = "0x135A3EC", Offset = "0x135A3EC", VA = "0x135A3EC")]
			public static List<iCloudDocument> fromJSON(string json)
			{
				return null;
			}

			[Token(Token = "0x6000FD3")]
			[Address(RVA = "0x135A670", Offset = "0x135A670", VA = "0x135A670", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x4000F90")]
		[FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x36F18", Offset = "0x36F18")]
		private static Action<List<object>> m_keyValueStoreDidChangeEvent;

		[Token(Token = "0x4000F91")]
		[FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x36F28", Offset = "0x36F28")]
		private static Action<iCloudKeyValueStoreReason> m_keyValueStoreDidChangeReasonEvent;

		[Token(Token = "0x4000F92")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x36F38", Offset = "0x36F38")]
		private static Action m_ubiquityIdentityDidChangeEvent;

		[Token(Token = "0x4000F93")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x36F48", Offset = "0x36F48")]
		private static Action m_entitlementsMissingEvent;

		[Token(Token = "0x4000F94")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x36F58", Offset = "0x36F58")]
		private static Action<List<iCloudDocument>> m_documentStoreUpdatedEvent;

		[Token(Token = "0x4000F95")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x36F68", Offset = "0x36F68")]
		private static Action<string> m_cloudKitSaveRecordFailedEvent;

		[Token(Token = "0x4000F96")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x36F78", Offset = "0x36F78")]
		private static Action m_cloudKitSaveRecordSucceededEvent;

		[Token(Token = "0x4000F97")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x36F88", Offset = "0x36F88")]
		private static Action<string> m_cloudKitFetchRecordFailedEvent;

		[Token(Token = "0x4000F98")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x36F98", Offset = "0x36F98")]
		private static Action<Dictionary<string, string>> m_cloudKitFetchRecordSucceededEvent;

		[Token(Token = "0x4000F99")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x36FA8", Offset = "0x36FA8")]
		private static Action<string> m_cloudKitUpdateRecordFailedEvent;

		[Token(Token = "0x4000F9A")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x36FB8", Offset = "0x36FB8")]
		private static Action m_cloudKitUpdateRecordSucceededEvent;

		[Token(Token = "0x4000F9B")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x36FC8", Offset = "0x36FC8")]
		private static Action<string> m_cloudKitDeleteRecordFailedEvent;

		[Token(Token = "0x4000F9C")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x36FD8", Offset = "0x36FD8")]
		private static Action m_cloudKitDeleteRecordSucceededEvent;

		[Token(Token = "0x14000007")]
		public static event Action<List<object>> keyValueStoreDidChangeEvent
		{
			[Token(Token = "0x6000FA8")]
			[Address(RVA = "0x132E1A4", Offset = "0x132E1A4", VA = "0x132E1A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B42C", Offset = "0x3B42C")]
			add
			{
			}
			[Token(Token = "0x6000FA9")]
			[Address(RVA = "0x132E2AC", Offset = "0x132E2AC", VA = "0x132E2AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B43C", Offset = "0x3B43C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000008")]
		public static event Action<iCloudKeyValueStoreReason> keyValueStoreDidChangeReasonEvent
		{
			[Token(Token = "0x6000FAA")]
			[Address(RVA = "0x132E3B4", Offset = "0x132E3B4", VA = "0x132E3B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B44C", Offset = "0x3B44C")]
			add
			{
			}
			[Token(Token = "0x6000FAB")]
			[Address(RVA = "0x132E4C0", Offset = "0x132E4C0", VA = "0x132E4C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B45C", Offset = "0x3B45C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000009")]
		public static event Action ubiquityIdentityDidChangeEvent
		{
			[Token(Token = "0x6000FAC")]
			[Address(RVA = "0x132E5CC", Offset = "0x132E5CC", VA = "0x132E5CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B46C", Offset = "0x3B46C")]
			add
			{
			}
			[Token(Token = "0x6000FAD")]
			[Address(RVA = "0x132E6D8", Offset = "0x132E6D8", VA = "0x132E6D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B47C", Offset = "0x3B47C")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000A")]
		public static event Action entitlementsMissingEvent
		{
			[Token(Token = "0x6000FAE")]
			[Address(RVA = "0x132E7E4", Offset = "0x132E7E4", VA = "0x132E7E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B48C", Offset = "0x3B48C")]
			add
			{
			}
			[Token(Token = "0x6000FAF")]
			[Address(RVA = "0x132E8F0", Offset = "0x132E8F0", VA = "0x132E8F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B49C", Offset = "0x3B49C")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000B")]
		public static event Action<List<iCloudDocument>> documentStoreUpdatedEvent
		{
			[Token(Token = "0x6000FB0")]
			[Address(RVA = "0x132E9FC", Offset = "0x132E9FC", VA = "0x132E9FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B4AC", Offset = "0x3B4AC")]
			add
			{
			}
			[Token(Token = "0x6000FB1")]
			[Address(RVA = "0x132EB08", Offset = "0x132EB08", VA = "0x132EB08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B4BC", Offset = "0x3B4BC")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000C")]
		public static event Action<string> cloudKitSaveRecordFailedEvent
		{
			[Token(Token = "0x6000FB2")]
			[Address(RVA = "0x132EC14", Offset = "0x132EC14", VA = "0x132EC14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B4CC", Offset = "0x3B4CC")]
			add
			{
			}
			[Token(Token = "0x6000FB3")]
			[Address(RVA = "0x132ED20", Offset = "0x132ED20", VA = "0x132ED20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B4DC", Offset = "0x3B4DC")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000D")]
		public static event Action cloudKitSaveRecordSucceededEvent
		{
			[Token(Token = "0x6000FB4")]
			[Address(RVA = "0x132EE2C", Offset = "0x132EE2C", VA = "0x132EE2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B4EC", Offset = "0x3B4EC")]
			add
			{
			}
			[Token(Token = "0x6000FB5")]
			[Address(RVA = "0x132EF38", Offset = "0x132EF38", VA = "0x132EF38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B4FC", Offset = "0x3B4FC")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000E")]
		public static event Action<string> cloudKitFetchRecordFailedEvent
		{
			[Token(Token = "0x6000FB6")]
			[Address(RVA = "0x132F044", Offset = "0x132F044", VA = "0x132F044")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B50C", Offset = "0x3B50C")]
			add
			{
			}
			[Token(Token = "0x6000FB7")]
			[Address(RVA = "0x132F150", Offset = "0x132F150", VA = "0x132F150")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B51C", Offset = "0x3B51C")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000F")]
		public static event Action<Dictionary<string, string>> cloudKitFetchRecordSucceededEvent
		{
			[Token(Token = "0x6000FB8")]
			[Address(RVA = "0x132F25C", Offset = "0x132F25C", VA = "0x132F25C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B52C", Offset = "0x3B52C")]
			add
			{
			}
			[Token(Token = "0x6000FB9")]
			[Address(RVA = "0x132F368", Offset = "0x132F368", VA = "0x132F368")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B53C", Offset = "0x3B53C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000010")]
		public static event Action<string> cloudKitUpdateRecordFailedEvent
		{
			[Token(Token = "0x6000FBA")]
			[Address(RVA = "0x132F474", Offset = "0x132F474", VA = "0x132F474")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B54C", Offset = "0x3B54C")]
			add
			{
			}
			[Token(Token = "0x6000FBB")]
			[Address(RVA = "0x132F580", Offset = "0x132F580", VA = "0x132F580")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B55C", Offset = "0x3B55C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000011")]
		public static event Action cloudKitUpdateRecordSucceededEvent
		{
			[Token(Token = "0x6000FBC")]
			[Address(RVA = "0x132F68C", Offset = "0x132F68C", VA = "0x132F68C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B56C", Offset = "0x3B56C")]
			add
			{
			}
			[Token(Token = "0x6000FBD")]
			[Address(RVA = "0x132F798", Offset = "0x132F798", VA = "0x132F798")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B57C", Offset = "0x3B57C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000012")]
		public static event Action<string> cloudKitDeleteRecordFailedEvent
		{
			[Token(Token = "0x6000FBE")]
			[Address(RVA = "0x132F8A4", Offset = "0x132F8A4", VA = "0x132F8A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B58C", Offset = "0x3B58C")]
			add
			{
			}
			[Token(Token = "0x6000FBF")]
			[Address(RVA = "0x132F9B0", Offset = "0x132F9B0", VA = "0x132F9B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B59C", Offset = "0x3B59C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000013")]
		public static event Action cloudKitDeleteRecordSucceededEvent
		{
			[Token(Token = "0x6000FC0")]
			[Address(RVA = "0x132FABC", Offset = "0x132FABC", VA = "0x132FABC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B5AC", Offset = "0x3B5AC")]
			add
			{
			}
			[Token(Token = "0x6000FC1")]
			[Address(RVA = "0x132FBC8", Offset = "0x132FBC8", VA = "0x132FBC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B5BC", Offset = "0x3B5BC")]
			remove
			{
			}
		}

		[Token(Token = "0x6000FC2")]
		[Address(RVA = "0x132FCD4", Offset = "0x132FCD4", VA = "0x132FCD4")]
		static iCloudManager()
		{
		}

		[Token(Token = "0x6000FC3")]
		[Address(RVA = "0x132FD64", Offset = "0x132FD64", VA = "0x132FD64")]
		private void ubiquityIdentityDidChange(string param)
		{
		}

		[Token(Token = "0x6000FC4")]
		[Address(RVA = "0x132FDCC", Offset = "0x132FDCC", VA = "0x132FDCC")]
		private void keyValueStoreDidChange(string param)
		{
		}

		[Token(Token = "0x6000FC5")]
		[Address(RVA = "0x132FEA8", Offset = "0x132FEA8", VA = "0x132FEA8")]
		private void keyValueStoreChangeReason(string reason)
		{
		}

		[Token(Token = "0x6000FC6")]
		[Address(RVA = "0x132FF88", Offset = "0x132FF88", VA = "0x132FF88")]
		private void entitlementsMissing(string empty)
		{
		}

		[Token(Token = "0x6000FC7")]
		[Address(RVA = "0x1330028", Offset = "0x1330028", VA = "0x1330028")]
		private void documentStoreUpdated(string json)
		{
		}

		[Token(Token = "0x6000FC8")]
		[Address(RVA = "0x1330104", Offset = "0x1330104", VA = "0x1330104")]
		private void cloudKitSaveRecordFailed(string error)
		{
		}

		[Token(Token = "0x6000FC9")]
		[Address(RVA = "0x1330198", Offset = "0x1330198", VA = "0x1330198")]
		private void cloudKitSaveRecordSucceeded(string empty)
		{
		}

		[Token(Token = "0x6000FCA")]
		[Address(RVA = "0x1330200", Offset = "0x1330200", VA = "0x1330200")]
		private void cloudKitFetchRecordFailed(string error)
		{
		}

		[Token(Token = "0x6000FCB")]
		[Address(RVA = "0x1330294", Offset = "0x1330294", VA = "0x1330294")]
		private void cloudKitFetchRecordSucceeded(string json)
		{
		}

		[Token(Token = "0x6000FCC")]
		[Address(RVA = "0x133037C", Offset = "0x133037C", VA = "0x133037C")]
		private void cloudKitUpdateRecordFailed(string error)
		{
		}

		[Token(Token = "0x6000FCD")]
		[Address(RVA = "0x1330410", Offset = "0x1330410", VA = "0x1330410")]
		private void cloudKitUpdateRecordSucceeded(string empty)
		{
		}

		[Token(Token = "0x6000FCE")]
		[Address(RVA = "0x1330478", Offset = "0x1330478", VA = "0x1330478")]
		private void cloudKitDeleteRecordFailed(string error)
		{
		}

		[Token(Token = "0x6000FCF")]
		[Address(RVA = "0x133050C", Offset = "0x133050C", VA = "0x133050C")]
		private void cloudKitDeleteRecordSucceeded(string empty)
		{
		}

		[Token(Token = "0x6000FD0")]
		[Address(RVA = "0x1330574", Offset = "0x1330574", VA = "0x1330574")]
		public iCloudManager()
		{
		}
	}
}
