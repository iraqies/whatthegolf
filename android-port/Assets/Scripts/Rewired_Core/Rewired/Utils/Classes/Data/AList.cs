using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Rewired.Utils.Classes.Data
{
	[Serializable]
	[Token(Token = "0x2000378")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x1921A8", Offset = "0x1921A8")]
	internal class AList<T> : IList, IEnumerable, IEnumerable<T>, ICollection, ICollection<T>, IList<T>
	{
		[Serializable]
		[Token(Token = "0x2000379")]
		public struct VsjqrmMwrGApowVfPWdhesQntjjH : IDisposable, IEnumerator, IEnumerator<T>
		{
			[Token(Token = "0x40011D7")]
			[FieldOffset(Offset = "0x0")]
			private AList<T> list;

			[Token(Token = "0x40011D8")]
			[FieldOffset(Offset = "0x0")]
			private int index;

			[Token(Token = "0x40011D9")]
			[FieldOffset(Offset = "0x0")]
			private int version;

			[Token(Token = "0x40011DA")]
			[FieldOffset(Offset = "0x0")]
			private T current;

			[Token(Token = "0x1700071C")]
			public T Current
			{
				[Token(Token = "0x6001B05")]
				get
				{
					return (T)null;
				}
			}

			[Token(Token = "0x1700071D")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6001B06")]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6001B01")]
			internal VsjqrmMwrGApowVfPWdhesQntjjH(AList<T> P_0)
			{
			}

			[Token(Token = "0x6001B02")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6001B03")]
			public bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6001B04")]
			private bool TXujFZWZoalxahmedVbObmnbHsJg()
			{
				return default;
			}

			[Token(Token = "0x6001B06")]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6001B07")]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x40011CB")]
		private const int jDXsvNveXaCGZiVlVQKptZXrUrlMA = 4;

		[Token(Token = "0x40011CC")]
		[FieldOffset(Offset = "0x0")]
		private static readonly T[] pKJComKBzdYbRGqrHKCIOdimmgCw;

		[Token(Token = "0x40011CD")]
		[FieldOffset(Offset = "0x0")]
		private IEqualityComparer<T> csVFVCmLCxbZLAudZQNydzCxlEqy;

		[Token(Token = "0x40011CE")]
		[FieldOffset(Offset = "0x0")]
		public T[] _items;

		[Token(Token = "0x40011CF")]
		[FieldOffset(Offset = "0x0")]
		private int eAZTOidCgblheDmZfgTMJcXnhJLfb;

		[Token(Token = "0x40011D0")]
		[FieldOffset(Offset = "0x0")]
		public int _count;

		[Token(Token = "0x40011D1")]
		[FieldOffset(Offset = "0x0")]
		private int eAjgZKgebBEZVwciSQTqLnpVoCCh;

		[Token(Token = "0x40011D2")]
		[FieldOffset(Offset = "0x0")]
		private bool piMxCDOMyQRIiGsbmpdOXshLbJgC;

		[Token(Token = "0x40011D3")]
		[FieldOffset(Offset = "0x0")]
		private readonly int zodaBsUiqoAcDTrTOJNyHhqSJdhb;

		[Token(Token = "0x40011D4")]
		[FieldOffset(Offset = "0x0")]
		private readonly bool HTlmaduSzPbvHWUJwuhObVPmTuBg;

		[Token(Token = "0x40011D5")]
		[FieldOffset(Offset = "0x0")]
		private int ZMmXJIUpRkkINbjuQpRQDgAgOgdk;

		[NonSerialized]
		[Token(Token = "0x40011D6")]
		[FieldOffset(Offset = "0x0")]
		private object YmPJVmEIVpGMAdftFocwGnzawvaZb;

		[Token(Token = "0x17000712")]
		public int Count
		{
			[Token(Token = "0x6001AD5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000713")]
		public bool IsFixedSize
		{
			[Token(Token = "0x6001AD6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000714")]
		public int Version
		{
			[Token(Token = "0x6001AD7")]
			get
			{
				return default;
			}
		}

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x17000715")]
		[Token(Token = "0x6001AD8")]
		public T get_Item(int index)
		{
			return (T)null;
		}

		[Token(Token = "0x6001AD9")]
		public void set_Item(int index, T value)
		{
		}

		[Token(Token = "0x17000716")]
		private bool System_002ECollections_002EGeneric_002EICollection_003CT_003E_002EIsReadOnly
		{
			[Token(Token = "0x6001AF1")]
			get
			{
				return System_002ECollections_002EGeneric_002EICollection_003CT_003E_002Eget_IsReadOnly();
			}
		}

		[Token(Token = "0x17000717")]
		private bool System_002ECollections_002EIList_002EIsReadOnly
		{
			[Token(Token = "0x6001AF2")]
			get
			{
				return System_002ECollections_002EIList_002Eget_IsReadOnly();
			}
		}

		// C# has no syntax for parameterized property 'System.Collections.IList.Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x17000718")]
		[Token(Token = "0x6001AFA")]
		private object get_System_002ECollections_002EIList_002EItem(int index)
		{
			return System_002ECollections_002EIList_002Eget_Item(index);
		}

		[Token(Token = "0x6001AFB")]
		private void set_System_002ECollections_002EIList_002EItem(int index, object value)
		{
			System_002ECollections_002EIList_002Eset_Item(index, value);
		}

		[Token(Token = "0x17000719")]
		private int System_002ECollections_002EICollection_002ECount
		{
			[Token(Token = "0x6001AFC")]
			get
			{
				return System_002ECollections_002EICollection_002Eget_Count();
			}
		}

		[Token(Token = "0x1700071A")]
		private bool System_002ECollections_002EICollection_002EIsSynchronized
		{
			[Token(Token = "0x6001AFD")]
			get
			{
				return System_002ECollections_002EICollection_002Eget_IsSynchronized();
			}
		}

		[Token(Token = "0x1700071B")]
		private object System_002ECollections_002EICollection_002ESyncRoot
		{
			[Token(Token = "0x6001AFE")]
			get
			{
				return System_002ECollections_002EICollection_002Eget_SyncRoot();
			}
		}

		[Token(Token = "0x6001ADA")]
		public AList()
		{
		}

		[Token(Token = "0x6001ADB")]
		public AList(int P_0)
		{
		}

		[Token(Token = "0x6001ADC")]
		public AList(int P_0, int P_1, int P_2)
		{
		}

		[Token(Token = "0x6001ADD")]
		public AList(IEnumerable<T> P_0)
		{
		}

		[Token(Token = "0x6001ADE")]
		public AList(IEnumerable<T> P_0, int P_1, int P_2)
		{
		}

		[Token(Token = "0x6001ADF")]
		public int Add(T item)
		{
			return default;
		}

		[Token(Token = "0x6001AE0")]
		public bool Insert(int index, T item)
		{
			return default;
		}

		[Token(Token = "0x6001AE1")]
		public bool Remove(T item)
		{
			return default;
		}

		[Token(Token = "0x6001AE2")]
		public void RemoveAt(int index)
		{
		}

		[Token(Token = "0x6001AE3")]
		public bool Contains(T item)
		{
			return default;
		}

		[Token(Token = "0x6001AE4")]
		public bool Contains(T item, IEqualityComparer<T> comparer)
		{
			return default;
		}

		[Token(Token = "0x6001AE5")]
		public int IndexOf(T item)
		{
			return default;
		}

		[Token(Token = "0x6001AE6")]
		public int IndexOf(T item, IEqualityComparer<T> comparer)
		{
			return default;
		}

		[Token(Token = "0x6001AE7")]
		public void Sort(IComparer<T> comparer)
		{
		}

		[Token(Token = "0x6001AE8")]
		public void Sort(int index, int count, IComparer<T> comparer)
		{
		}

		[Token(Token = "0x6001AE9")]
		public void Clear()
		{
		}

		[Token(Token = "0x6001AEA")]
		private int jEKabbQowylGlaqrnCjUcBMEMyRyA(int P_0, bool P_1 = false)
		{
			return default;
		}

		[Token(Token = "0x6001AEB")]
		private int rcDdEdQDyUnyxqDgGUlhHJPIzVHN(int P_0, int P_1)
		{
			return default;
		}

		[Token(Token = "0x6001AEC")]
		private bool tDOYzectlTkeiSukMnmpKmfTjmIr(int P_0, bool P_1 = false)
		{
			return default;
		}

		[Token(Token = "0x6001AED")]
		private void System_002ECollections_002EGeneric_002EIList_003CT_003E_002EInsert(int P_0, T P_1)
		{
		}

		[Token(Token = "0x6001AEE")]
		private void System_002ECollections_002EGeneric_002EICollection_003CT_003E_002EAdd(T P_0)
		{
		}

		[Token(Token = "0x6001AEF")]
		private void System_002ECollections_002EGeneric_002EICollection_003CT_003E_002ECopyTo(T[] P_0, int P_1)
		{
		}

		[Token(Token = "0x6001AF0")]
		private void System_002ECollections_002EICollection_002ECopyTo(Array array, int index)
		{
		}

		[Token(Token = "0x6001AF1")]
		private bool System_002ECollections_002EGeneric_002EICollection_003CT_003E_002Eget_IsReadOnly()
		{
			return default;
		}

		[Token(Token = "0x6001AF2")]
		private bool System_002ECollections_002EIList_002Eget_IsReadOnly()
		{
			return default;
		}

		[Token(Token = "0x6001AF3")]
		private IEnumerator<T> System_002ECollections_002EGeneric_002EIEnumerable_003CT_003E_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6001AF4")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6001AF5")]
		private int System_002ECollections_002EIList_002EAdd(object value)
		{
			return default;
		}

		[Token(Token = "0x6001AF6")]
		private bool System_002ECollections_002EIList_002EContains(object value)
		{
			return default;
		}

		[Token(Token = "0x6001AF7")]
		private int System_002ECollections_002EIList_002EIndexOf(object value)
		{
			return default;
		}

		[Token(Token = "0x6001AF8")]
		private void System_002ECollections_002EIList_002EInsert(int index, object value)
		{
		}

		[Token(Token = "0x6001AF9")]
		private void System_002ECollections_002EIList_002ERemove(object value)
		{
		}

		[Token(Token = "0x6001AFA")]
		private object System_002ECollections_002EIList_002Eget_Item(int index)
		{
			return null;
		}

		[Token(Token = "0x6001AFB")]
		private void System_002ECollections_002EIList_002Eset_Item(int index, object value)
		{
		}

		[Token(Token = "0x6001AFC")]
		private int System_002ECollections_002EICollection_002Eget_Count()
		{
			return default;
		}

		[Token(Token = "0x6001AFD")]
		private bool System_002ECollections_002EICollection_002Eget_IsSynchronized()
		{
			return default;
		}

		[Token(Token = "0x6001AFE")]
		private object System_002ECollections_002EICollection_002Eget_SyncRoot()
		{
			return null;
		}

		[Token(Token = "0x6001AFF")]
		private static bool DWbngvFsbhohBTLtjsqYFVKRlBns(object P_0)
		{
			return default;
		}
	}
}
