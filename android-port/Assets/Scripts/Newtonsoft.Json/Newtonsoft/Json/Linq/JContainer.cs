using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq
{
	[Token(Token = "0x20000CD")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x1840CC", Offset = "0x1840CC")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x1840CC", Offset = "0x1840CC")]
	public abstract class JContainer : JToken, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable, ITypedList, IBindingList, ICollection, IList
	{
		[Token(Token = "0x40002F4")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x188004", Offset = "0x188004")]
		internal ListChangedEventHandler _listChanged;

		[Token(Token = "0x40002F5")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x188018", Offset = "0x188018")]
		internal AddingNewEventHandler _addingNew;

		[Token(Token = "0x40002F6")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18802C", Offset = "0x18802C")]
		internal NotifyCollectionChangedEventHandler _collectionChanged;

		[Token(Token = "0x40002F7")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x188040", Offset = "0x188040")]
		private object _syncRoot;

		[Token(Token = "0x40002F8")]
		[FieldOffset(Offset = "0x50")]
		private bool _busy;

		[Token(Token = "0x170000FE")]
		protected abstract IList<JToken> ChildrenTokens
		{
			[Token(Token = "0x60005D2")]
			get;
		}

		[Token(Token = "0x170000FF")]
		public override bool HasValues
		{
			[Token(Token = "0x60005D9")]
			[Address(RVA = "0x22CBFA8", Offset = "0x22CBFA8", VA = "0x22CBFA8", Slot = "13")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000100")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18F714", Offset = "0x18F714")]
		public override JToken First
		{
			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x22CC07C", Offset = "0x22CC07C", VA = "0x22CC07C", Slot = "14")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A520", Offset = "0x18A520")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000101")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18F728", Offset = "0x18F728")]
		public override JToken Last
		{
			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x22CC1E0", Offset = "0x22CC1E0", VA = "0x22CC1E0", Slot = "15")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A534", Offset = "0x18A534")]
			get
			{
				return null;
			}
		}

		// C# has no syntax for parameterized property 'System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x17000102")]
		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x22CF530", Offset = "0x22CF530", VA = "0x22CF530", Slot = "19")]
		private JToken get_System_002ECollections_002EGeneric_002EIList_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EItem(int index)
		{
			return System_002ECollections_002EGeneric_002EIList_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002Eget_Item(index);
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x22CF540", Offset = "0x22CF540", VA = "0x22CF540", Slot = "20")]
		private void set_System_002ECollections_002EGeneric_002EIList_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EItem(int index, JToken value)
		{
			System_002ECollections_002EGeneric_002EIList_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002Eset_Item(index, value);
		}

		[Token(Token = "0x17000103")]
		private bool System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EIsReadOnly
		{
			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x22CF590", Offset = "0x22CF590", VA = "0x22CF590", Slot = "25")]
			get
			{
				return System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002Eget_IsReadOnly();
			}
		}

		[Token(Token = "0x17000104")]
		private bool System_002ECollections_002EIList_002EIsFixedSize
		{
			[Token(Token = "0x6000607")]
			[Address(RVA = "0x22CF778", Offset = "0x22CF778", VA = "0x22CF778", Slot = "56")]
			get
			{
				return System_002ECollections_002EIList_002Eget_IsFixedSize();
			}
		}

		[Token(Token = "0x17000105")]
		private bool System_002ECollections_002EIList_002EIsReadOnly
		{
			[Token(Token = "0x6000608")]
			[Address(RVA = "0x22CF780", Offset = "0x22CF780", VA = "0x22CF780", Slot = "55")]
			get
			{
				return System_002ECollections_002EIList_002Eget_IsReadOnly();
			}
		}

		// C# has no syntax for parameterized property 'System.Collections.IList.Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x17000106")]
		[Token(Token = "0x600060B")]
		[Address(RVA = "0x22CF7CC", Offset = "0x22CF7CC", VA = "0x22CF7CC", Slot = "50")]
		private object get_System_002ECollections_002EIList_002EItem(int index)
		{
			return System_002ECollections_002EIList_002Eget_Item(index);
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x22CF7DC", Offset = "0x22CF7DC", VA = "0x22CF7DC", Slot = "51")]
		private void set_System_002ECollections_002EIList_002EItem(int index, object value)
		{
			System_002ECollections_002EIList_002Eset_Item(index, value);
		}

		[Token(Token = "0x17000107")]
		public int Count
		{
			[Token(Token = "0x600060E")]
			[Address(RVA = "0x22CE084", Offset = "0x22CE084", VA = "0x22CE084", Slot = "62")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000108")]
		private bool System_002ECollections_002EICollection_002EIsSynchronized
		{
			[Token(Token = "0x600060F")]
			[Address(RVA = "0x22CF82C", Offset = "0x22CF82C", VA = "0x22CF82C", Slot = "64")]
			get
			{
				return System_002ECollections_002EICollection_002Eget_IsSynchronized();
			}
		}

		[Token(Token = "0x17000109")]
		private object System_002ECollections_002EICollection_002ESyncRoot
		{
			[Token(Token = "0x6000610")]
			[Address(RVA = "0x22CF834", Offset = "0x22CF834", VA = "0x22CF834", Slot = "63")]
			get
			{
				return System_002ECollections_002EICollection_002Eget_SyncRoot();
			}
		}

		[Token(Token = "0x1700010A")]
		private bool System_002EComponentModel_002EIBindingList_002EAllowEdit
		{
			[Token(Token = "0x6000613")]
			[Address(RVA = "0x22CFB88", Offset = "0x22CFB88", VA = "0x22CFB88", Slot = "35")]
			get
			{
				return System_002EComponentModel_002EIBindingList_002Eget_AllowEdit();
			}
		}

		[Token(Token = "0x1700010B")]
		private bool System_002EComponentModel_002EIBindingList_002EAllowNew
		{
			[Token(Token = "0x6000614")]
			[Address(RVA = "0x22CFB90", Offset = "0x22CFB90", VA = "0x22CFB90", Slot = "33")]
			get
			{
				return System_002EComponentModel_002EIBindingList_002Eget_AllowNew();
			}
		}

		[Token(Token = "0x1700010C")]
		private bool System_002EComponentModel_002EIBindingList_002EAllowRemove
		{
			[Token(Token = "0x6000615")]
			[Address(RVA = "0x22CFB98", Offset = "0x22CFB98", VA = "0x22CFB98", Slot = "36")]
			get
			{
				return System_002EComponentModel_002EIBindingList_002Eget_AllowRemove();
			}
		}

		[Token(Token = "0x1700010D")]
		private bool System_002EComponentModel_002EIBindingList_002EIsSorted
		{
			[Token(Token = "0x6000618")]
			[Address(RVA = "0x22CFC20", Offset = "0x22CFC20", VA = "0x22CFC20", Slot = "40")]
			get
			{
				return System_002EComponentModel_002EIBindingList_002Eget_IsSorted();
			}
		}

		[Token(Token = "0x1700010E")]
		private ListSortDirection System_002EComponentModel_002EIBindingList_002ESortDirection
		{
			[Token(Token = "0x600061B")]
			[Address(RVA = "0x22CFC6C", Offset = "0x22CFC6C", VA = "0x22CFC6C", Slot = "42")]
			get
			{
				return System_002EComponentModel_002EIBindingList_002Eget_SortDirection();
			}
		}

		[Token(Token = "0x1700010F")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18F73C", Offset = "0x18F73C")]
		private PropertyDescriptor System_002EComponentModel_002EIBindingList_002ESortProperty
		{
			[Token(Token = "0x600061C")]
			[Address(RVA = "0x22CFC74", Offset = "0x22CFC74", VA = "0x22CFC74", Slot = "41")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A610", Offset = "0x18A610")]
			get
			{
				return System_002EComponentModel_002EIBindingList_002Eget_SortProperty();
			}
		}

		[Token(Token = "0x17000110")]
		private bool System_002EComponentModel_002EIBindingList_002ESupportsChangeNotification
		{
			[Token(Token = "0x600061D")]
			[Address(RVA = "0x22CFC7C", Offset = "0x22CFC7C", VA = "0x22CFC7C", Slot = "37")]
			get
			{
				return System_002EComponentModel_002EIBindingList_002Eget_SupportsChangeNotification();
			}
		}

		[Token(Token = "0x17000111")]
		private bool System_002EComponentModel_002EIBindingList_002ESupportsSearching
		{
			[Token(Token = "0x600061E")]
			[Address(RVA = "0x22CFC84", Offset = "0x22CFC84", VA = "0x22CFC84", Slot = "38")]
			get
			{
				return System_002EComponentModel_002EIBindingList_002Eget_SupportsSearching();
			}
		}

		[Token(Token = "0x17000112")]
		private bool System_002EComponentModel_002EIBindingList_002ESupportsSorting
		{
			[Token(Token = "0x600061F")]
			[Address(RVA = "0x22CFC8C", Offset = "0x22CFC8C", VA = "0x22CFC8C", Slot = "39")]
			get
			{
				return System_002EComponentModel_002EIBindingList_002Eget_SupportsSorting();
			}
		}

		[Token(Token = "0x14000003")]
		public event ListChangedEventHandler ListChanged
		{
			[Token(Token = "0x60005D0")]
			[Address(RVA = "0x22CB83C", Offset = "0x22CB83C", VA = "0x22CB83C", Slot = "43")]
			add
			{
			}
			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x22CB8C0", Offset = "0x22CB8C0", VA = "0x22CB8C0", Slot = "44")]
			remove
			{
			}
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x22CA3AC", Offset = "0x22CA3AC", VA = "0x22CA3AC")]
		internal JContainer()
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x22CA4B4", Offset = "0x22CA4B4", VA = "0x22CA4B4")]
		internal JContainer(JContainer other)
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x22CBD54", Offset = "0x22CBD54", VA = "0x22CBD54")]
		internal void CheckReentrancy()
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x22CBE24", Offset = "0x22CBE24", VA = "0x22CBE24", Slot = "66")]
		protected virtual void OnAddingNew(AddingNewEventArgs e)
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x22CBE40", Offset = "0x22CBE40", VA = "0x22CBE40", Slot = "67")]
		protected virtual void OnListChanged(ListChangedEventArgs e)
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x22CBEF4", Offset = "0x22CBEF4", VA = "0x22CBEF4", Slot = "68")]
		protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x22CC344", Offset = "0x22CC344", VA = "0x22CC344", Slot = "16")]
		public override JEnumerable<JToken> Children()
		{
			return default;
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x22CC3C8", Offset = "0x22CC3C8", VA = "0x22CC3C8")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A548", Offset = "0x18A548")]
		internal bool IsMultiContent(object content)
		{
			return default;
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x22CC4C0", Offset = "0x22CC4C0", VA = "0x22CC4C0")]
		internal JToken EnsureParentToken([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18DD28", Offset = "0x18DD28")] JToken item, bool skipParentCheck)
		{
			return null;
		}

		[Token(Token = "0x60005DF")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A55C", Offset = "0x18A55C")]
		internal abstract int IndexOfItem(JToken item);

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x22CC62C", Offset = "0x22CC62C", VA = "0x22CC62C", Slot = "70")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A570", Offset = "0x18A570")]
		internal virtual bool InsertItem(int index, JToken item, bool skipParentCheck)
		{
			return default;
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x22CCAC4", Offset = "0x22CCAC4", VA = "0x22CCAC4", Slot = "71")]
		internal virtual void RemoveItemAt(int index)
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x22CCF80", Offset = "0x22CCF80", VA = "0x22CCF80", Slot = "72")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A584", Offset = "0x18A584")]
		internal virtual bool RemoveItem(JToken item)
		{
			return default;
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x22CCFE0", Offset = "0x22CCFE0", VA = "0x22CCFE0", Slot = "73")]
		internal virtual JToken GetItem(int index)
		{
			return null;
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x22CD0B8", Offset = "0x22CD0B8", VA = "0x22CD0B8", Slot = "74")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A598", Offset = "0x18A598")]
		internal virtual void SetItem(int index, JToken item)
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x22CD764", Offset = "0x22CD764", VA = "0x22CD764", Slot = "75")]
		internal virtual void ClearItems()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x22CDBB4", Offset = "0x22CDBB4", VA = "0x22CDBB4", Slot = "76")]
		internal virtual void ReplaceItem(JToken existing, JToken replacement)
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x22CDC14", Offset = "0x22CDC14", VA = "0x22CDC14", Slot = "77")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A5AC", Offset = "0x18A5AC")]
		internal virtual bool ContainsItem(JToken item)
		{
			return default;
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x22CDC3C", Offset = "0x22CDC3C", VA = "0x22CDC3C", Slot = "78")]
		internal virtual void CopyItemsTo(Array array, int arrayIndex)
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x22CD6A4", Offset = "0x22CD6A4", VA = "0x22CD6A4")]
		internal static bool IsTokenUnchanged(JToken currentValue, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18DD3C", Offset = "0x18DD3C")] JToken newValue)
		{
			return default;
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x22CE14C", Offset = "0x22CE14C", VA = "0x22CE14C", Slot = "79")]
		internal virtual void ValidateToken(JToken o, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18DD50", Offset = "0x18DD50")] JToken existing)
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x22CE294", Offset = "0x22CE294", VA = "0x22CE294", Slot = "80")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A5C0", Offset = "0x18A5C0")]
		public virtual void Add(object content)
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x22CE378", Offset = "0x22CE378", VA = "0x22CE378")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A5D4", Offset = "0x18A5D4")]
		internal bool TryAdd(object content)
		{
			return default;
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x22CE45C", Offset = "0x22CE45C", VA = "0x22CE45C")]
		internal void AddAndSkipParentCheck(JToken token)
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x22CB94C", Offset = "0x22CB94C", VA = "0x22CB94C")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A5E8", Offset = "0x18A5E8")]
		internal bool TryAddInternal(int index, object content, bool skipParentCheck)
		{
			return default;
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x22CE540", Offset = "0x22CE540", VA = "0x22CE540")]
		internal static JToken CreateFromContent([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18DD64", Offset = "0x18DD64")] object content)
		{
			return null;
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x22CE6E4", Offset = "0x22CE6E4", VA = "0x22CE6E4")]
		public void RemoveAll()
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x22CADF8", Offset = "0x22CADF8", VA = "0x22CADF8")]
		internal void ReadTokenFrom(JsonReader reader, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18DD78", Offset = "0x18DD78")] JsonLoadSettings options)
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x22CE6F4", Offset = "0x22CE6F4", VA = "0x22CE6F4")]
		internal void ReadContentFrom(JsonReader r, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18DD8C", Offset = "0x18DD8C")] JsonLoadSettings settings)
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x22CEE88", Offset = "0x22CEE88", VA = "0x22CEE88")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A5FC", Offset = "0x18A5FC")]
		private static JProperty ReadProperty([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18DDA0", Offset = "0x18DDA0")] JsonReader r, JsonLoadSettings settings, IJsonLineInfo lineInfo, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18DDB4", Offset = "0x18DDB4")] JContainer parent)
		{
			return null;
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x22CF3C8", Offset = "0x22CF3C8", VA = "0x22CF3C8", Slot = "31")]
		private string System_002EComponentModel_002EITypedList_002EGetListName(PropertyDescriptor[] listAccessors)
		{
			return null;
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x22CF414", Offset = "0x22CF414", VA = "0x22CF414", Slot = "32")]
		private PropertyDescriptorCollection System_002EComponentModel_002EITypedList_002EGetItemProperties(PropertyDescriptor[] listAccessors)
		{
			return null;
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x22CF4FC", Offset = "0x22CF4FC", VA = "0x22CF4FC", Slot = "21")]
		private int System_002ECollections_002EGeneric_002EIList_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EIndexOf(JToken item)
		{
			return default;
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x22CF50C", Offset = "0x22CF50C", VA = "0x22CF50C", Slot = "22")]
		private void System_002ECollections_002EGeneric_002EIList_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EInsert(int index, JToken item)
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x22CF520", Offset = "0x22CF520", VA = "0x22CF520", Slot = "23")]
		private void System_002ECollections_002EGeneric_002EIList_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002ERemoveAt(int index)
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x22CF530", Offset = "0x22CF530", VA = "0x22CF530", Slot = "19")]
		private JToken System_002ECollections_002EGeneric_002EIList_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002Eget_Item(int index)
		{
			return null;
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x22CF540", Offset = "0x22CF540", VA = "0x22CF540", Slot = "20")]
		private void System_002ECollections_002EGeneric_002EIList_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002Eset_Item(int index, JToken value)
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x22CF550", Offset = "0x22CF550", VA = "0x22CF550", Slot = "26")]
		private void System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EAdd(JToken item)
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x22CF560", Offset = "0x22CF560", VA = "0x22CF560", Slot = "27")]
		private void System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EClear()
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x22CF570", Offset = "0x22CF570", VA = "0x22CF570", Slot = "28")]
		private bool System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EContains(JToken item)
		{
			return default;
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x22CF580", Offset = "0x22CF580", VA = "0x22CF580", Slot = "29")]
		private void System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002ECopyTo(JToken[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x22CF590", Offset = "0x22CF590", VA = "0x22CF590", Slot = "25")]
		private bool System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002Eget_IsReadOnly()
		{
			return default;
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x22CF598", Offset = "0x22CF598", VA = "0x22CF598", Slot = "30")]
		private bool System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002ERemove(JToken item)
		{
			return default;
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x22CF5A8", Offset = "0x22CF5A8", VA = "0x22CF5A8")]
		private JToken EnsureValue(object value)
		{
			return null;
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x22CF678", Offset = "0x22CF678", VA = "0x22CF678", Slot = "52")]
		private int System_002ECollections_002EIList_002EAdd(object value)
		{
			return default;
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x22CF6BC", Offset = "0x22CF6BC", VA = "0x22CF6BC", Slot = "54")]
		private void System_002ECollections_002EIList_002EClear()
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x22CF6CC", Offset = "0x22CF6CC", VA = "0x22CF6CC", Slot = "53")]
		private bool System_002ECollections_002EIList_002EContains(object value)
		{
			return default;
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x22CF700", Offset = "0x22CF700", VA = "0x22CF700", Slot = "57")]
		private int System_002ECollections_002EIList_002EIndexOf(object value)
		{
			return default;
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x22CF734", Offset = "0x22CF734", VA = "0x22CF734", Slot = "58")]
		private void System_002ECollections_002EIList_002EInsert(int index, object value)
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x22CF778", Offset = "0x22CF778", VA = "0x22CF778", Slot = "56")]
		private bool System_002ECollections_002EIList_002Eget_IsFixedSize()
		{
			return default;
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x22CF780", Offset = "0x22CF780", VA = "0x22CF780", Slot = "55")]
		private bool System_002ECollections_002EIList_002Eget_IsReadOnly()
		{
			return default;
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x22CF788", Offset = "0x22CF788", VA = "0x22CF788", Slot = "59")]
		private void System_002ECollections_002EIList_002ERemove(object value)
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x22CF7BC", Offset = "0x22CF7BC", VA = "0x22CF7BC", Slot = "60")]
		private void System_002ECollections_002EIList_002ERemoveAt(int index)
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x22CF7CC", Offset = "0x22CF7CC", VA = "0x22CF7CC", Slot = "50")]
		private object System_002ECollections_002EIList_002Eget_Item(int index)
		{
			return null;
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x22CF7DC", Offset = "0x22CF7DC", VA = "0x22CF7DC", Slot = "51")]
		private void System_002ECollections_002EIList_002Eset_Item(int index, object value)
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x22CF81C", Offset = "0x22CF81C", VA = "0x22CF81C", Slot = "61")]
		private void System_002ECollections_002EICollection_002ECopyTo(Array array, int index)
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x22CF82C", Offset = "0x22CF82C", VA = "0x22CF82C", Slot = "64")]
		private bool System_002ECollections_002EICollection_002Eget_IsSynchronized()
		{
			return default;
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x22CF834", Offset = "0x22CF834", VA = "0x22CF834", Slot = "63")]
		private object System_002ECollections_002EICollection_002Eget_SyncRoot()
		{
			return null;
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x22CF8AC", Offset = "0x22CF8AC", VA = "0x22CF8AC", Slot = "45")]
		private void System_002EComponentModel_002EIBindingList_002EAddIndex(PropertyDescriptor property)
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x22CF8B0", Offset = "0x22CF8B0", VA = "0x22CF8B0", Slot = "34")]
		private object System_002EComponentModel_002EIBindingList_002EAddNew()
		{
			return null;
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x22CFB88", Offset = "0x22CFB88", VA = "0x22CFB88", Slot = "35")]
		private bool System_002EComponentModel_002EIBindingList_002Eget_AllowEdit()
		{
			return default;
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x22CFB90", Offset = "0x22CFB90", VA = "0x22CFB90", Slot = "33")]
		private bool System_002EComponentModel_002EIBindingList_002Eget_AllowNew()
		{
			return default;
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x22CFB98", Offset = "0x22CFB98", VA = "0x22CFB98", Slot = "36")]
		private bool System_002EComponentModel_002EIBindingList_002Eget_AllowRemove()
		{
			return default;
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x22CFBA0", Offset = "0x22CFBA0", VA = "0x22CFBA0", Slot = "46")]
		private void System_002EComponentModel_002EIBindingList_002EApplySort(PropertyDescriptor property, ListSortDirection direction)
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x22CFBE0", Offset = "0x22CFBE0", VA = "0x22CFBE0", Slot = "47")]
		private int System_002EComponentModel_002EIBindingList_002EFind(PropertyDescriptor property, object key)
		{
			return default;
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x22CFC20", Offset = "0x22CFC20", VA = "0x22CFC20", Slot = "40")]
		private bool System_002EComponentModel_002EIBindingList_002Eget_IsSorted()
		{
			return default;
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x22CFC28", Offset = "0x22CFC28", VA = "0x22CFC28", Slot = "48")]
		private void System_002EComponentModel_002EIBindingList_002ERemoveIndex(PropertyDescriptor property)
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x22CFC2C", Offset = "0x22CFC2C", VA = "0x22CFC2C", Slot = "49")]
		private void System_002EComponentModel_002EIBindingList_002ERemoveSort()
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x22CFC6C", Offset = "0x22CFC6C", VA = "0x22CFC6C", Slot = "42")]
		private ListSortDirection System_002EComponentModel_002EIBindingList_002Eget_SortDirection()
		{
			return default;
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x22CFC74", Offset = "0x22CFC74", VA = "0x22CFC74", Slot = "41")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A610", Offset = "0x18A610")]
		private PropertyDescriptor System_002EComponentModel_002EIBindingList_002Eget_SortProperty()
		{
			return null;
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x22CFC7C", Offset = "0x22CFC7C", VA = "0x22CFC7C", Slot = "37")]
		private bool System_002EComponentModel_002EIBindingList_002Eget_SupportsChangeNotification()
		{
			return default;
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x22CFC84", Offset = "0x22CFC84", VA = "0x22CFC84", Slot = "38")]
		private bool System_002EComponentModel_002EIBindingList_002Eget_SupportsSearching()
		{
			return default;
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x22CFC8C", Offset = "0x22CFC8C", VA = "0x22CFC8C", Slot = "39")]
		private bool System_002EComponentModel_002EIBindingList_002Eget_SupportsSorting()
		{
			return default;
		}
	}
}
