using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using Il2CppDummyDll;

namespace ThirdParty.Json.LitJson
{
	[Token(Token = "0x2000018")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x25678", Offset = "0x25678")]
	public class JsonData : IJsonWrapper, IList, ICollection, IEnumerable, IOrderedDictionary, IDictionary, IEquatable<JsonData>
	{
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x10")]
		private IList<JsonData> inst_array;

		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x18")]
		private bool inst_boolean;

		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x20")]
		private double inst_double;

		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x28")]
		private ulong inst_number;

		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x30")]
		private IDictionary<string, JsonData> inst_object;

		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x38")]
		private string inst_string;

		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x40")]
		private string json;

		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x48")]
		private JsonType type;

		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x50")]
		private IList<KeyValuePair<string, JsonData>> object_list;

		[Token(Token = "0x1700001E")]
		public int Count
		{
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x121EE14", Offset = "0x121EE14", VA = "0x121EE14")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700001F")]
		public bool IsArray
		{
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x121EFAC", Offset = "0x121EFAC", VA = "0x121EFAC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000020")]
		public bool IsBoolean
		{
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x121EFBC", Offset = "0x121EFBC", VA = "0x121EFBC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000021")]
		public bool IsDouble
		{
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x121EFCC", Offset = "0x121EFCC", VA = "0x121EFCC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000022")]
		public bool IsInt
		{
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x121EFDC", Offset = "0x121EFDC", VA = "0x121EFDC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000023")]
		public bool IsUInt
		{
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x121EFEC", Offset = "0x121EFEC", VA = "0x121EFEC", Slot = "8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000024")]
		public bool IsLong
		{
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x121EFFC", Offset = "0x121EFFC", VA = "0x121EFFC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000025")]
		public bool IsULong
		{
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x121F00C", Offset = "0x121F00C", VA = "0x121F00C", Slot = "10")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000026")]
		public bool IsObject
		{
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x121F01C", Offset = "0x121F01C", VA = "0x121F01C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000027")]
		public bool IsString
		{
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x121F02C", Offset = "0x121F02C", VA = "0x121F02C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000028")]
		private int System_002ECollections_002EICollection_002ECount
		{
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x121F03C", Offset = "0x121F03C", VA = "0x121F03C", Slot = "43")]
			get
			{
				return System_002ECollections_002EICollection_002Eget_Count();
			}
		}

		[Token(Token = "0x17000029")]
		private bool System_002ECollections_002EICollection_002EIsSynchronized
		{
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x121F040", Offset = "0x121F040", VA = "0x121F040", Slot = "45")]
			get
			{
				return System_002ECollections_002EICollection_002Eget_IsSynchronized();
			}
		}

		[Token(Token = "0x1700002A")]
		private object System_002ECollections_002EICollection_002ESyncRoot
		{
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x121F100", Offset = "0x121F100", VA = "0x121F100", Slot = "44")]
			get
			{
				return System_002ECollections_002EICollection_002Eget_SyncRoot();
			}
		}

		[Token(Token = "0x1700002B")]
		private bool System_002ECollections_002EIDictionary_002EIsFixedSize
		{
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x121F1C0", Offset = "0x121F1C0", VA = "0x121F1C0", Slot = "60")]
			get
			{
				return System_002ECollections_002EIDictionary_002Eget_IsFixedSize();
			}
		}

		[Token(Token = "0x1700002C")]
		private bool System_002ECollections_002EIDictionary_002EIsReadOnly
		{
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x121F3D8", Offset = "0x121F3D8", VA = "0x121F3D8", Slot = "59")]
			get
			{
				return System_002ECollections_002EIDictionary_002Eget_IsReadOnly();
			}
		}

		[Token(Token = "0x1700002D")]
		private ICollection System_002ECollections_002EIDictionary_002EKeys
		{
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x121F498", Offset = "0x121F498", VA = "0x121F498", Slot = "54")]
			get
			{
				return System_002ECollections_002EIDictionary_002Eget_Keys();
			}
		}

		[Token(Token = "0x1700002E")]
		private ICollection System_002ECollections_002EIDictionary_002EValues
		{
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x121F8AC", Offset = "0x121F8AC", VA = "0x121F8AC", Slot = "55")]
			get
			{
				return System_002ECollections_002EIDictionary_002Eget_Values();
			}
		}

		[Token(Token = "0x1700002F")]
		private bool ThirdParty_002EJson_002ELitJson_002EIJsonWrapper_002EIsArray
		{
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x121FCC0", Offset = "0x121FCC0", VA = "0x121FCC0", Slot = "4")]
			get
			{
				return ThirdParty_002EJson_002ELitJson_002EIJsonWrapper_002Eget_IsArray();
			}
		}

		[Token(Token = "0x17000030")]
		private bool ThirdParty_002EJson_002ELitJson_002EIJsonWrapper_002EIsBoolean
		{
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x121FCD0", Offset = "0x121FCD0", VA = "0x121FCD0", Slot = "5")]
			get
			{
				return ThirdParty_002EJson_002ELitJson_002EIJsonWrapper_002Eget_IsBoolean();
			}
		}

		[Token(Token = "0x17000031")]
		private bool ThirdParty_002EJson_002ELitJson_002EIJsonWrapper_002EIsDouble
		{
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x121FCE0", Offset = "0x121FCE0", VA = "0x121FCE0", Slot = "6")]
			get
			{
				return ThirdParty_002EJson_002ELitJson_002EIJsonWrapper_002Eget_IsDouble();
			}
		}

		[Token(Token = "0x17000032")]
		private bool ThirdParty_002EJson_002ELitJson_002EIJsonWrapper_002EIsInt
		{
			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x121FCF0", Offset = "0x121FCF0", VA = "0x121FCF0", Slot = "7")]
			get
			{
				return ThirdParty_002EJson_002ELitJson_002EIJsonWrapper_002Eget_IsInt();
			}
		}

		[Token(Token = "0x17000033")]
		private bool ThirdParty_002EJson_002ELitJson_002EIJsonWrapper_002EIsLong
		{
			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x121FD00", Offset = "0x121FD00", VA = "0x121FD00", Slot = "9")]
			get
			{
				return ThirdParty_002EJson_002ELitJson_002EIJsonWrapper_002Eget_IsLong();
			}
		}

		[Token(Token = "0x17000034")]
		private bool ThirdParty_002EJson_002ELitJson_002EIJsonWrapper_002EIsObject
		{
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x121FD10", Offset = "0x121FD10", VA = "0x121FD10", Slot = "11")]
			get
			{
				return ThirdParty_002EJson_002ELitJson_002EIJsonWrapper_002Eget_IsObject();
			}
		}

		[Token(Token = "0x17000035")]
		private bool ThirdParty_002EJson_002ELitJson_002EIJsonWrapper_002EIsString
		{
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x121FD20", Offset = "0x121FD20", VA = "0x121FD20", Slot = "12")]
			get
			{
				return ThirdParty_002EJson_002ELitJson_002EIJsonWrapper_002Eget_IsString();
			}
		}

		[Token(Token = "0x17000036")]
		private bool System_002ECollections_002EIList_002EIsFixedSize
		{
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x121FD30", Offset = "0x121FD30", VA = "0x121FD30", Slot = "37")]
			get
			{
				return System_002ECollections_002EIList_002Eget_IsFixedSize();
			}
		}

		[Token(Token = "0x17000037")]
		private bool System_002ECollections_002EIList_002EIsReadOnly
		{
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x121FF2C", Offset = "0x121FF2C", VA = "0x121FF2C", Slot = "36")]
			get
			{
				return System_002ECollections_002EIList_002Eget_IsReadOnly();
			}
		}

		// C# has no syntax for parameterized property 'System.Collections.IDictionary.Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x17000038")]
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x121FFEC", Offset = "0x121FFEC", VA = "0x121FFEC", Slot = "52")]
		private object get_System_002ECollections_002EIDictionary_002EItem(object key)
		{
			return System_002ECollections_002EIDictionary_002Eget_Item(key);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x12200B8", Offset = "0x12200B8", VA = "0x12200B8", Slot = "53")]
		private void set_System_002ECollections_002EIDictionary_002EItem(object key, object value)
		{
			System_002ECollections_002EIDictionary_002Eset_Item(key, value);
		}

		// C# has no syntax for parameterized property 'System.Collections.Specialized.IOrderedDictionary.Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x17000039")]
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x122061C", Offset = "0x122061C", VA = "0x122061C", Slot = "47")]
		private object get_System_002ECollections_002ESpecialized_002EIOrderedDictionary_002EItem(int idx)
		{
			return System_002ECollections_002ESpecialized_002EIOrderedDictionary_002Eget_Item(idx);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x12206FC", Offset = "0x12206FC", VA = "0x12206FC", Slot = "48")]
		private void set_System_002ECollections_002ESpecialized_002EIOrderedDictionary_002EItem(int idx, object value)
		{
			System_002ECollections_002ESpecialized_002EIOrderedDictionary_002Eset_Item(idx, value);
		}

		// C# has no syntax for parameterized property 'System.Collections.IList.Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x1700003A")]
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x1220940", Offset = "0x1220940", VA = "0x1220940", Slot = "31")]
		private object get_System_002ECollections_002EIList_002EItem(int index)
		{
			return System_002ECollections_002EIList_002Eget_Item(index);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x1220A0C", Offset = "0x1220A0C", VA = "0x1220A0C", Slot = "32")]
		private void set_System_002ECollections_002EIList_002EItem(int index, object value)
		{
			System_002ECollections_002EIList_002Eset_Item(index, value);
		}

		[Token(Token = "0x1700003B")]
		public IEnumerable<string> PropertyNames
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x1220D30", Offset = "0x1220D30", VA = "0x1220D30")]
			get
			{
				return null;
			}
		}

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x1700003C")]
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x1220DF0", Offset = "0x1220DF0", VA = "0x1220DF0")]
		public JsonData get_Item(string prop_name)
		{
			return null;
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x1220220", Offset = "0x1220220", VA = "0x1220220")]
		public void set_Item(string prop_name, JsonData value)
		{
		}

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x1700003D")]
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x1220EDC", Offset = "0x1220EDC", VA = "0x1220EDC")]
		public JsonData get_Item(int index)
		{
			return null;
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x1220A50", Offset = "0x1220A50", VA = "0x1220A50")]
		public void set_Item(int index, JsonData value)
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x121F03C", Offset = "0x121F03C", VA = "0x121F03C", Slot = "43")]
		private int System_002ECollections_002EICollection_002Eget_Count()
		{
			return default;
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x121F040", Offset = "0x121F040", VA = "0x121F040", Slot = "45")]
		private bool System_002ECollections_002EICollection_002Eget_IsSynchronized()
		{
			return default;
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x121F100", Offset = "0x121F100", VA = "0x121F100", Slot = "44")]
		private object System_002ECollections_002EICollection_002Eget_SyncRoot()
		{
			return null;
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x121F1C0", Offset = "0x121F1C0", VA = "0x121F1C0", Slot = "60")]
		private bool System_002ECollections_002EIDictionary_002Eget_IsFixedSize()
		{
			return default;
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x121F3D8", Offset = "0x121F3D8", VA = "0x121F3D8", Slot = "59")]
		private bool System_002ECollections_002EIDictionary_002Eget_IsReadOnly()
		{
			return default;
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x121F498", Offset = "0x121F498", VA = "0x121F498", Slot = "54")]
		private ICollection System_002ECollections_002EIDictionary_002Eget_Keys()
		{
			return null;
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x121F8AC", Offset = "0x121F8AC", VA = "0x121F8AC", Slot = "55")]
		private ICollection System_002ECollections_002EIDictionary_002Eget_Values()
		{
			return null;
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x121FCC0", Offset = "0x121FCC0", VA = "0x121FCC0", Slot = "4")]
		private bool ThirdParty_002EJson_002ELitJson_002EIJsonWrapper_002Eget_IsArray()
		{
			return default;
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x121FCD0", Offset = "0x121FCD0", VA = "0x121FCD0", Slot = "5")]
		private bool ThirdParty_002EJson_002ELitJson_002EIJsonWrapper_002Eget_IsBoolean()
		{
			return default;
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x121FCE0", Offset = "0x121FCE0", VA = "0x121FCE0", Slot = "6")]
		private bool ThirdParty_002EJson_002ELitJson_002EIJsonWrapper_002Eget_IsDouble()
		{
			return default;
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x121FCF0", Offset = "0x121FCF0", VA = "0x121FCF0", Slot = "7")]
		private bool ThirdParty_002EJson_002ELitJson_002EIJsonWrapper_002Eget_IsInt()
		{
			return default;
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x121FD00", Offset = "0x121FD00", VA = "0x121FD00", Slot = "9")]
		private bool ThirdParty_002EJson_002ELitJson_002EIJsonWrapper_002Eget_IsLong()
		{
			return default;
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x121FD10", Offset = "0x121FD10", VA = "0x121FD10", Slot = "11")]
		private bool ThirdParty_002EJson_002ELitJson_002EIJsonWrapper_002Eget_IsObject()
		{
			return default;
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x121FD20", Offset = "0x121FD20", VA = "0x121FD20", Slot = "12")]
		private bool ThirdParty_002EJson_002ELitJson_002EIJsonWrapper_002Eget_IsString()
		{
			return default;
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x121FD30", Offset = "0x121FD30", VA = "0x121FD30", Slot = "37")]
		private bool System_002ECollections_002EIList_002Eget_IsFixedSize()
		{
			return default;
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x121FF2C", Offset = "0x121FF2C", VA = "0x121FF2C", Slot = "36")]
		private bool System_002ECollections_002EIList_002Eget_IsReadOnly()
		{
			return default;
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x121FFEC", Offset = "0x121FFEC", VA = "0x121FFEC", Slot = "52")]
		private object System_002ECollections_002EIDictionary_002Eget_Item(object key)
		{
			return null;
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x12200B8", Offset = "0x12200B8", VA = "0x12200B8", Slot = "53")]
		private void System_002ECollections_002EIDictionary_002Eset_Item(object key, object value)
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x122061C", Offset = "0x122061C", VA = "0x122061C", Slot = "47")]
		private object System_002ECollections_002ESpecialized_002EIOrderedDictionary_002Eget_Item(int idx)
		{
			return null;
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x12206FC", Offset = "0x12206FC", VA = "0x12206FC", Slot = "48")]
		private void System_002ECollections_002ESpecialized_002EIOrderedDictionary_002Eset_Item(int idx, object value)
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x1220940", Offset = "0x1220940", VA = "0x1220940", Slot = "31")]
		private object System_002ECollections_002EIList_002Eget_Item(int index)
		{
			return null;
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x1220A0C", Offset = "0x1220A0C", VA = "0x1220A0C", Slot = "32")]
		private void System_002ECollections_002EIList_002Eset_Item(int index, object value)
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x122105C", Offset = "0x122105C", VA = "0x122105C")]
		public JsonData()
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x1221064", Offset = "0x1221064", VA = "0x1221064")]
		public JsonData(bool boolean)
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x1221098", Offset = "0x1221098", VA = "0x1221098")]
		public JsonData(double number)
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x12210D4", Offset = "0x12210D4", VA = "0x12210D4")]
		public JsonData(int number)
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x122110C", Offset = "0x122110C", VA = "0x122110C")]
		public JsonData(uint number)
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x1221144", Offset = "0x1221144", VA = "0x1221144")]
		public JsonData(long number)
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x1221178", Offset = "0x1221178", VA = "0x1221178")]
		public JsonData(ulong number)
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x12211AC", Offset = "0x12211AC", VA = "0x12211AC")]
		public JsonData(object obj)
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x122142C", Offset = "0x122142C", VA = "0x122142C")]
		public JsonData(string str)
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x1221460", Offset = "0x1221460", VA = "0x1221460")]
		public static implicit operator JsonData(bool data)
		{
			return null;
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x12214D0", Offset = "0x12214D0", VA = "0x12214D0")]
		public static implicit operator JsonData(double data)
		{
			return null;
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x1221540", Offset = "0x1221540", VA = "0x1221540")]
		public static implicit operator JsonData(int data)
		{
			return null;
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x12215B4", Offset = "0x12215B4", VA = "0x12215B4")]
		public static implicit operator JsonData(long data)
		{
			return null;
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x1221624", Offset = "0x1221624", VA = "0x1221624")]
		public static implicit operator JsonData(string data)
		{
			return null;
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x1221694", Offset = "0x1221694", VA = "0x1221694")]
		public static explicit operator bool(JsonData data)
		{
			return default;
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x122170C", Offset = "0x122170C", VA = "0x122170C")]
		public static explicit operator double(JsonData data)
		{
			return default;
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x1221784", Offset = "0x1221784", VA = "0x1221784")]
		public static explicit operator int(JsonData data)
		{
			return default;
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x12217FC", Offset = "0x12217FC", VA = "0x12217FC")]
		public static explicit operator uint(JsonData data)
		{
			return default;
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x1221874", Offset = "0x1221874", VA = "0x1221874")]
		public static explicit operator long(JsonData data)
		{
			return default;
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x12218F0", Offset = "0x12218F0", VA = "0x12218F0")]
		public static explicit operator ulong(JsonData data)
		{
			return default;
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x122196C", Offset = "0x122196C", VA = "0x122196C")]
		public static explicit operator string(JsonData data)
		{
			return null;
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x12219E4", Offset = "0x12219E4", VA = "0x12219E4", Slot = "42")]
		private void System_002ECollections_002EICollection_002ECopyTo(Array array, int index)
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x1221AB8", Offset = "0x1221AB8", VA = "0x1221AB8", Slot = "57")]
		private void System_002ECollections_002EIDictionary_002EAdd(object key, object value)
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x1221CA0", Offset = "0x1221CA0", VA = "0x1221CA0", Slot = "58")]
		private void System_002ECollections_002EIDictionary_002EClear()
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x1221DEC", Offset = "0x1221DEC", VA = "0x1221DEC", Slot = "56")]
		private bool System_002ECollections_002EIDictionary_002EContains(object key)
		{
			return default;
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1221EBC", Offset = "0x1221EBC", VA = "0x1221EBC", Slot = "61")]
		private IDictionaryEnumerator System_002ECollections_002EIDictionary_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x1221F70", Offset = "0x1221F70", VA = "0x1221F70", Slot = "62")]
		private void System_002ECollections_002EIDictionary_002ERemove(object key)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x122224C", Offset = "0x122224C", VA = "0x122224C", Slot = "46")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x1222308", Offset = "0x1222308", VA = "0x1222308", Slot = "13")]
		private bool ThirdParty_002EJson_002ELitJson_002EIJsonWrapper_002EGetBoolean()
		{
			return default;
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x1222370", Offset = "0x1222370", VA = "0x1222370", Slot = "14")]
		private double ThirdParty_002EJson_002ELitJson_002EIJsonWrapper_002EGetDouble()
		{
			return default;
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x12223D8", Offset = "0x12223D8", VA = "0x12223D8", Slot = "15")]
		private int ThirdParty_002EJson_002ELitJson_002EIJsonWrapper_002EGetInt()
		{
			return default;
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x1222440", Offset = "0x1222440", VA = "0x1222440", Slot = "16")]
		private uint ThirdParty_002EJson_002ELitJson_002EIJsonWrapper_002EGetUInt()
		{
			return default;
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x12224A8", Offset = "0x12224A8", VA = "0x12224A8", Slot = "18")]
		private long ThirdParty_002EJson_002ELitJson_002EIJsonWrapper_002EGetLong()
		{
			return default;
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x1222510", Offset = "0x1222510", VA = "0x1222510", Slot = "19")]
		private ulong ThirdParty_002EJson_002ELitJson_002EIJsonWrapper_002EGetULong()
		{
			return default;
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x1222578", Offset = "0x1222578", VA = "0x1222578", Slot = "20")]
		private string ThirdParty_002EJson_002ELitJson_002EIJsonWrapper_002EGetString()
		{
			return null;
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x12225E0", Offset = "0x12225E0", VA = "0x12225E0", Slot = "21")]
		private void ThirdParty_002EJson_002ELitJson_002EIJsonWrapper_002ESetBoolean(bool val)
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x12225F4", Offset = "0x12225F4", VA = "0x12225F4", Slot = "22")]
		private void ThirdParty_002EJson_002ELitJson_002EIJsonWrapper_002ESetDouble(double val)
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x1222608", Offset = "0x1222608", VA = "0x1222608", Slot = "23")]
		private void ThirdParty_002EJson_002ELitJson_002EIJsonWrapper_002ESetInt(int val)
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x1222620", Offset = "0x1222620", VA = "0x1222620", Slot = "24")]
		private void ThirdParty_002EJson_002ELitJson_002EIJsonWrapper_002ESetUInt(uint val)
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x1222638", Offset = "0x1222638", VA = "0x1222638", Slot = "26")]
		private void ThirdParty_002EJson_002ELitJson_002EIJsonWrapper_002ESetLong(long val)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x122264C", Offset = "0x122264C", VA = "0x122264C", Slot = "27")]
		private void ThirdParty_002EJson_002ELitJson_002EIJsonWrapper_002ESetULong(ulong val)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x1222660", Offset = "0x1222660", VA = "0x1222660", Slot = "28")]
		private void ThirdParty_002EJson_002ELitJson_002EIJsonWrapper_002ESetString(string val)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x1222670", Offset = "0x1222670", VA = "0x1222670", Slot = "29")]
		private string ThirdParty_002EJson_002ELitJson_002EIJsonWrapper_002EToJson()
		{
			return null;
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x1222734", Offset = "0x1222734", VA = "0x1222734", Slot = "30")]
		private void ThirdParty_002EJson_002ELitJson_002EIJsonWrapper_002EToJson(JsonWriter writer)
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x122279C", Offset = "0x122279C", VA = "0x122279C", Slot = "33")]
		private int System_002ECollections_002EIList_002EAdd(object value)
		{
			return default;
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x122287C", Offset = "0x122287C", VA = "0x122287C", Slot = "35")]
		private void System_002ECollections_002EIList_002EClear()
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x1222940", Offset = "0x1222940", VA = "0x1222940", Slot = "34")]
		private bool System_002ECollections_002EIList_002EContains(object value)
		{
			return default;
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x1222A10", Offset = "0x1222A10", VA = "0x1222A10", Slot = "38")]
		private int System_002ECollections_002EIList_002EIndexOf(object value)
		{
			return default;
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x1222AE0", Offset = "0x1222AE0", VA = "0x1222AE0", Slot = "39")]
		private void System_002ECollections_002EIList_002EInsert(int index, object value)
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x1222BBC", Offset = "0x1222BBC", VA = "0x1222BBC", Slot = "40")]
		private void System_002ECollections_002EIList_002ERemove(object value)
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x1222C90", Offset = "0x1222C90", VA = "0x1222C90", Slot = "41")]
		private void System_002ECollections_002EIList_002ERemoveAt(int index)
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x1222D64", Offset = "0x1222D64", VA = "0x1222D64", Slot = "49")]
		private IDictionaryEnumerator System_002ECollections_002ESpecialized_002EIOrderedDictionary_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1222E54", Offset = "0x1222E54", VA = "0x1222E54", Slot = "50")]
		private void System_002ECollections_002ESpecialized_002EIOrderedDictionary_002EInsert(int idx, object key, object value)
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x1222FC4", Offset = "0x1222FC4", VA = "0x1222FC4", Slot = "51")]
		private void System_002ECollections_002ESpecialized_002EIOrderedDictionary_002ERemoveAt(int idx)
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x121EED4", Offset = "0x121EED4", VA = "0x121EED4")]
		private ICollection EnsureCollection()
		{
			return null;
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x121F280", Offset = "0x121F280", VA = "0x121F280")]
		private IDictionary EnsureDictionary()
		{
			return null;
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x121FDF0", Offset = "0x121FDF0", VA = "0x121FDF0")]
		private IList EnsureList()
		{
			return null;
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x1220194", Offset = "0x1220194", VA = "0x1220194")]
		private JsonData ToJsonData(object obj)
		{
			return null;
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x12231AC", Offset = "0x12231AC", VA = "0x12231AC")]
		private static void WriteJson(IJsonWrapper obj, JsonWriter writer)
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x12227A0", Offset = "0x12227A0", VA = "0x12227A0")]
		public int Add(object value)
		{
			return default;
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x1224D00", Offset = "0x1224D00", VA = "0x1224D00")]
		public void Clear()
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x1224E40", Offset = "0x1224E40", VA = "0x1224E40", Slot = "63")]
		public bool Equals(JsonData x)
		{
			return default;
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x1224F8C", Offset = "0x1224F8C", VA = "0x1224F8C", Slot = "17")]
		public JsonType GetJsonType()
		{
			return default;
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x1224F94", Offset = "0x1224F94", VA = "0x1224F94", Slot = "25")]
		public void SetJsonType(JsonType type)
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x1222674", Offset = "0x1222674", VA = "0x1222674")]
		public string ToJson()
		{
			return null;
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x1222768", Offset = "0x1222768", VA = "0x1222768")]
		public void ToJson(JsonWriter writer)
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x1225168", Offset = "0x1225168", VA = "0x1225168", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
