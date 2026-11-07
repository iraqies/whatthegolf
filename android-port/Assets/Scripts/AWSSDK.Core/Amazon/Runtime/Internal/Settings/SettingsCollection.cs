using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Il2CppDummyDll;
using ThirdParty.Json.LitJson;

namespace Amazon.Runtime.Internal.Settings
{
	[Token(Token = "0x200023F")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x25FB0", Offset = "0x25FB0")]
	public class SettingsCollection : IEnumerable<SettingsCollection.ObjectSettings>, IEnumerable
	{
		[Token(Token = "0x2000240")]
		[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x25FE8", Offset = "0x25FE8")]
		public class ObjectSettings
		{
			[Token(Token = "0x4000809")]
			[FieldOffset(Offset = "0x10")]
			private string _uniqueKey;

			[Token(Token = "0x400080A")]
			[FieldOffset(Offset = "0x18")]
			private Dictionary<string, object> _values;

			[Token(Token = "0x17000446")]
			public string UniqueKey
			{
				[Token(Token = "0x600112D")]
				[Address(RVA = "0x12963F4", Offset = "0x12963F4", VA = "0x12963F4")]
				get
				{
					return null;
				}
			}

			// C# has no syntax for parameterized property 'Item'.
			// Its 'property:' attributes below are ignored by the compiler (CS0657).
			[property: Token(Token = "0x17000447")]
			[Token(Token = "0x600112E")]
			[Address(RVA = "0x1291884", Offset = "0x1291884", VA = "0x1291884")]
			public string get_Item(string key)
			{
				return null;
			}

			[Token(Token = "0x600112F")]
			[Address(RVA = "0x12963FC", Offset = "0x12963FC", VA = "0x12963FC")]
			public void set_Item(string key, string value)
			{
			}

			[Token(Token = "0x17000448")]
			public bool IsEmpty
			{
				[Token(Token = "0x6001133")]
				[Address(RVA = "0x1296520", Offset = "0x1296520", VA = "0x1296520")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000449")]
			public IEnumerable<string> Keys
			{
				[Token(Token = "0x6001134")]
				[Address(RVA = "0x1296584", Offset = "0x1296584", VA = "0x1296584")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600112C")]
			[Address(RVA = "0x12963BC", Offset = "0x12963BC", VA = "0x12963BC")]
			internal ObjectSettings(string uniqueKey, Dictionary<string, object> values)
			{
			}

			[Token(Token = "0x6001130")]
			[Address(RVA = "0x12916E0", Offset = "0x12916E0", VA = "0x12916E0")]
			public string GetValueOrDefault(string key, string defaultValue)
			{
				return null;
			}

			[Token(Token = "0x6001131")]
			[Address(RVA = "0x1296468", Offset = "0x1296468", VA = "0x1296468")]
			public void Remove(string key)
			{
			}

			[Token(Token = "0x6001132")]
			[Address(RVA = "0x12964CC", Offset = "0x12964CC", VA = "0x12964CC")]
			public void Clear()
			{
			}

			[Token(Token = "0x6001135")]
			[Address(RVA = "0x1296664", Offset = "0x1296664", VA = "0x1296664")]
			internal void WriteToJson(JsonWriter writer)
			{
			}
		}

		[Token(Token = "0x2000241")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26020", Offset = "0x26020")]
		private sealed class _003CGetEnumerator_003Ed__11 : IEnumerator<ObjectSettings>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400080B")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400080C")]
			[FieldOffset(Offset = "0x18")]
			private ObjectSettings _003C_003E2__current;

			[Token(Token = "0x400080D")]
			[FieldOffset(Offset = "0x20")]
			public SettingsCollection _003C_003E4__this;

			[Token(Token = "0x400080E")]
			[FieldOffset(Offset = "0x28")]
			private Dictionary<string, Dictionary<string, object>>.KeyCollection.Enumerator _003C_003E7__wrap1;

			[Token(Token = "0x1700044A")]
			private ObjectSettings System_002ECollections_002EGeneric_002EIEnumerator_003CAmazon_002ERuntime_002EInternal_002ESettings_002ESettingsCollection_002EObjectSettings_003E_002ECurrent
			{
				[Token(Token = "0x600113A")]
				[Address(RVA = "0x129636C", Offset = "0x129636C", VA = "0x129636C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CAmazon_002ERuntime_002EInternal_002ESettings_002ESettingsCollection_002EObjectSettings_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700044B")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600113C")]
				[Address(RVA = "0x12963B4", Offset = "0x12963B4", VA = "0x12963B4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6001136")]
			[Address(RVA = "0x129609C", Offset = "0x129609C", VA = "0x129609C")]
			[DebuggerHidden]
			public _003CGetEnumerator_003Ed__11(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6001137")]
			[Address(RVA = "0x12960C8", Offset = "0x12960C8", VA = "0x12960C8", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6001138")]
			[Address(RVA = "0x129619C", Offset = "0x129619C", VA = "0x129619C", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6001139")]
			[Address(RVA = "0x1296140", Offset = "0x1296140", VA = "0x1296140")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x600113A")]
			[Address(RVA = "0x129636C", Offset = "0x129636C", VA = "0x129636C", Slot = "4")]
			[DebuggerHidden]
			private ObjectSettings System_002ECollections_002EGeneric_002EIEnumerator_003CAmazon_002ERuntime_002EInternal_002ESettings_002ESettingsCollection_002EObjectSettings_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600113B")]
			[Address(RVA = "0x1296374", Offset = "0x1296374", VA = "0x1296374", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x600113C")]
			[Address(RVA = "0x12963B4", Offset = "0x12963B4", VA = "0x12963B4", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000807")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, Dictionary<string, object>> _values;

		[Token(Token = "0x4000808")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27CB8", Offset = "0x27CB8")]
		private bool InitializedEmpty__BackingField;

		[Token(Token = "0x17000443")]
		public int Count
		{
			[Token(Token = "0x6001121")]
			[Address(RVA = "0x1272198", Offset = "0x1272198", VA = "0x1272198")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000444")]
		public bool InitializedEmpty
		{
			[Token(Token = "0x6001122")]
			[Address(RVA = "0x12721EC", Offset = "0x12721EC", VA = "0x12721EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BF60", Offset = "0x2BF60")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001123")]
			[Address(RVA = "0x12721F4", Offset = "0x12721F4", VA = "0x12721F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BF70", Offset = "0x2BF70")]
			private set
			{
			}
		}

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x17000445")]
		[Token(Token = "0x6001127")]
		[Address(RVA = "0x1272428", Offset = "0x1272428", VA = "0x1272428")]
		public ObjectSettings get_Item(string key)
		{
			return null;
		}

		[Token(Token = "0x600111F")]
		[Address(RVA = "0x12720DC", Offset = "0x12720DC", VA = "0x12720DC")]
		public SettingsCollection()
		{
		}

		[Token(Token = "0x6001120")]
		[Address(RVA = "0x1272168", Offset = "0x1272168", VA = "0x1272168")]
		public SettingsCollection(Dictionary<string, Dictionary<string, object>> values)
		{
		}

		[Token(Token = "0x6001124")]
		[Address(RVA = "0x12721FC", Offset = "0x12721FC", VA = "0x12721FC")]
		internal void Persist(StreamWriter writer)
		{
		}

		[Token(Token = "0x6001125")]
		[Address(RVA = "0x12724EC", Offset = "0x12724EC", VA = "0x12724EC", Slot = "5")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6001126")]
		[Address(RVA = "0x1272560", Offset = "0x1272560", VA = "0x1272560", Slot = "4")]
		public IEnumerator<ObjectSettings> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6001128")]
		[Address(RVA = "0x12725D4", Offset = "0x12725D4", VA = "0x12725D4")]
		public ObjectSettings NewObjectSettings()
		{
			return null;
		}

		[Token(Token = "0x6001129")]
		[Address(RVA = "0x126CA7C", Offset = "0x126CA7C", VA = "0x126CA7C")]
		public ObjectSettings NewObjectSettings(string uniqueKey)
		{
			return null;
		}

		[Token(Token = "0x600112A")]
		[Address(RVA = "0x1272668", Offset = "0x1272668", VA = "0x1272668")]
		public void Remove(string uniqueKey)
		{
		}

		[Token(Token = "0x600112B")]
		[Address(RVA = "0x12726CC", Offset = "0x12726CC", VA = "0x12726CC")]
		public void Clear()
		{
		}
	}
}
