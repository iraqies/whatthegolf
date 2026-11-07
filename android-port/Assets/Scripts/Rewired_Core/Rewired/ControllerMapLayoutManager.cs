using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired.Utils.Attributes;
using Rewired.Utils.Interfaces;
using Rewired.Utils.Libraries.TinyJson;
using UnityEngine;

namespace Rewired
{
	[Token(Token = "0x20000E7")]
	public sealed class ControllerMapLayoutManager
	{
		[Token(Token = "0x20000E8")]
		internal class iZBHTLMJEscsCxujGlXwPdwYSOZv
		{
			[Token(Token = "0x4000561")]
			[FieldOffset(Offset = "0x10")]
			public bool kzXMFixQhdfqdwRZTXNUgEOsGVFD;

			[Token(Token = "0x4000562")]
			[FieldOffset(Offset = "0x11")]
			public bool RPjxhQSdjcTHwaKJnCMbHbwTpzYDA;

			[Token(Token = "0x4000563")]
			[FieldOffset(Offset = "0x18")]
			public vNnAsbNOxQRuVRxCcHhnyysOuoGy[] skDiKcsxfIWRYRUooobRNKLwyssi;

			[Token(Token = "0x6000659")]
			[Address(RVA = "0x245A40C", Offset = "0x245A40C", VA = "0x245A40C")]
			public iZBHTLMJEscsCxujGlXwPdwYSOZv(bool P_0, bool P_1, vNnAsbNOxQRuVRxCcHhnyysOuoGy[] P_2)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E9")]
		[Preserve]
		public sealed class Rule : IDeepCloneable
		{
			[Token(Token = "0x4000564")]
			[FieldOffset(Offset = "0x10")]
			[Serialize]
			[SerializeField]
			private string _tag;

			[Token(Token = "0x4000565")]
			[FieldOffset(Offset = "0x18")]
			[Serialize]
			[SerializeField]
			private int[] _categoryIds;

			[Token(Token = "0x4000566")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			[Serialize]
			private int _layoutId;

			[Token(Token = "0x4000567")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			[Serialize]
			private ControllerSetSelector _controllerSetSelector;

			[NonSerialized]
			[Token(Token = "0x4000568")]
			[FieldOffset(Offset = "0x30")]
			private string[] _preInitCategoryNames;

			[NonSerialized]
			[Token(Token = "0x4000569")]
			[FieldOffset(Offset = "0x38")]
			private string _preInitLayoutName;

			[Token(Token = "0x1700020C")]
			public string tag
			{
				[Token(Token = "0x600065D")]
				[Address(RVA = "0x2458BDC", Offset = "0x2458BDC", VA = "0x2458BDC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700020D")]
			public ControllerSetSelector controllerSetSelector
			{
				[Token(Token = "0x600065E")]
				[Address(RVA = "0x2458BE4", Offset = "0x2458BE4", VA = "0x2458BE4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700020E")]
			public int[] categoryIds
			{
				[Token(Token = "0x600065F")]
				[Address(RVA = "0x2458C50", Offset = "0x2458C50", VA = "0x2458C50")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700020F")]
			public int layoutId
			{
				[Token(Token = "0x6000660")]
				[Address(RVA = "0x2458F68", Offset = "0x2458F68", VA = "0x2458F68")]
				get
				{
					return default;
				}
				[Token(Token = "0x6000661")]
				[Address(RVA = "0x2458F8C", Offset = "0x2458F8C", VA = "0x2458F8C")]
				set
				{
				}
			}

			[Token(Token = "0x17000210")]
			public string layoutName
			{
				[Token(Token = "0x6000662")]
				[Address(RVA = "0x2458FA0", Offset = "0x2458FA0", VA = "0x2458FA0")]
				set
				{
				}
			}

			[Token(Token = "0x17000211")]
			internal bool isValid
			{
				[Token(Token = "0x6000663")]
				[Address(RVA = "0x2459234", Offset = "0x2459234", VA = "0x2459234")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x600065A")]
			[Address(RVA = "0x24589A0", Offset = "0x24589A0", VA = "0x24589A0")]
			public Rule()
			{
			}

			[Token(Token = "0x600065B")]
			[Address(RVA = "0x2458A3C", Offset = "0x2458A3C", VA = "0x2458A3C")]
			public Rule(Rule P_0)
			{
			}

			[Token(Token = "0x600065C")]
			[Address(RVA = "0x2458B8C", Offset = "0x2458B8C", VA = "0x2458B8C")]
			internal Rule(string P_0, int[] P_1, int P_2, ControllerSetSelector P_3)
			{
			}

			[Token(Token = "0x6000664")]
			[Address(RVA = "0x2458CB0", Offset = "0x2458CB0", VA = "0x2458CB0")]
			private void Initialize()
			{
			}

			[Token(Token = "0x6000665")]
			[Address(RVA = "0x2459404", Offset = "0x2459404", VA = "0x2459404", Slot = "4")]
			private object Rewired_002EUtils_002EInterfaces_002EIDeepCloneable_002EDeepClone()
			{
				return null;
			}
		}

		[Serializable]
		[Token(Token = "0x20000EA")]
		[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x190BA0", Offset = "0x190BA0")]
		[AttributeAttribute(Name = "SerializationTypeAttribute", RVA = "0x190BA0", Offset = "0x190BA0")]
		[Preserve]
		public sealed class RuleSet : IList<Rule>, ICollection<Rule>, IEnumerable<Rule>, IEnumerable, IDeepCloneable
		{
			[Token(Token = "0x400056A")]
			private const string className = "ControllerMapLayoutManager.RuleSet";

			[Token(Token = "0x400056B")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			[Serialize]
			private bool _enabled;

			[Token(Token = "0x400056C")]
			[FieldOffset(Offset = "0x18")]
			[Serialize]
			[SerializeField]
			private string _tag;

			[Token(Token = "0x400056D")]
			[FieldOffset(Offset = "0x20")]
			[Serialize]
			[SerializeField]
			private List<Rule> _rules;

			[Token(Token = "0x17000212")]
			public bool enabled
			{
				[Token(Token = "0x6000666")]
				[Address(RVA = "0x2459468", Offset = "0x2459468", VA = "0x2459468")]
				get
				{
					return default;
				}
				[Token(Token = "0x6000667")]
				[Address(RVA = "0x2459470", Offset = "0x2459470", VA = "0x2459470")]
				set
				{
				}
			}

			[Token(Token = "0x17000213")]
			public string tag
			{
				[Token(Token = "0x6000668")]
				[Address(RVA = "0x2459478", Offset = "0x2459478", VA = "0x2459478")]
				get
				{
					return null;
				}
			}

			// C# has no syntax for parameterized property 'Item'.
			// Its 'property:' attributes below are ignored by the compiler (CS0657).
			[property: Token(Token = "0x17000214")]
			[Token(Token = "0x600066F")]
			[Address(RVA = "0x2459A2C", Offset = "0x2459A2C", VA = "0x2459A2C", Slot = "4")]
			public Rule get_Item(int index)
			{
				return null;
			}

			[Token(Token = "0x6000670")]
			[Address(RVA = "0x2459B0C", Offset = "0x2459B0C", VA = "0x2459B0C", Slot = "5")]
			public void set_Item(int index, Rule value)
			{
			}

			[Token(Token = "0x17000215")]
			public int Count
			{
				[Token(Token = "0x6000675")]
				[Address(RVA = "0x2459F1C", Offset = "0x2459F1C", VA = "0x2459F1C", Slot = "9")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000216")]
			private bool System_002ECollections_002EGeneric_002EICollection_003CRewired_002EControllerMapLayoutManager_002ERule_003E_002EIsReadOnly
			{
				[Token(Token = "0x6000676")]
				[Address(RVA = "0x2459FD4", Offset = "0x2459FD4", VA = "0x2459FD4", Slot = "10")]
				get
				{
					return System_002ECollections_002EGeneric_002EICollection_003CRewired_002EControllerMapLayoutManager_002ERule_003E_002Eget_IsReadOnly();
				}
			}

			[Token(Token = "0x6000669")]
			[Address(RVA = "0x2459480", Offset = "0x2459480", VA = "0x2459480")]
			internal RuleSet(bool P_0, string P_1, List<Rule> P_2)
			{
			}

			[Token(Token = "0x600066A")]
			[Address(RVA = "0x2459570", Offset = "0x2459570", VA = "0x2459570")]
			public RuleSet()
			{
			}

			[Token(Token = "0x600066B")]
			[Address(RVA = "0x2459674", Offset = "0x2459674", VA = "0x2459674")]
			public RuleSet(RuleSet P_0)
			{
			}

			[Token(Token = "0x600066C")]
			[Address(RVA = "0x24597CC", Offset = "0x24597CC", VA = "0x24597CC", Slot = "6")]
			public int IndexOf(Rule item)
			{
				return default;
			}

			[Token(Token = "0x600066D")]
			[Address(RVA = "0x2459884", Offset = "0x2459884", VA = "0x2459884", Slot = "7")]
			public void Insert(int index, Rule item)
			{
			}

			[Token(Token = "0x600066E")]
			[Address(RVA = "0x245995C", Offset = "0x245995C", VA = "0x245995C", Slot = "8")]
			public void RemoveAt(int index)
			{
			}

			[Token(Token = "0x6000671")]
			[Address(RVA = "0x2459BE4", Offset = "0x2459BE4", VA = "0x2459BE4", Slot = "11")]
			public void Add(Rule item)
			{
			}

			[Token(Token = "0x6000672")]
			[Address(RVA = "0x2459CB4", Offset = "0x2459CB4", VA = "0x2459CB4", Slot = "12")]
			public void Clear()
			{
			}

			[Token(Token = "0x6000673")]
			[Address(RVA = "0x2459D74", Offset = "0x2459D74", VA = "0x2459D74", Slot = "13")]
			public bool Contains(Rule item)
			{
				return default;
			}

			[Token(Token = "0x6000674")]
			[Address(RVA = "0x2459E44", Offset = "0x2459E44", VA = "0x2459E44", Slot = "14")]
			public void CopyTo(Rule[] array, int arrayIndex)
			{
			}

			[Token(Token = "0x6000676")]
			[Address(RVA = "0x2459FD4", Offset = "0x2459FD4", VA = "0x2459FD4", Slot = "10")]
			private bool System_002ECollections_002EGeneric_002EICollection_003CRewired_002EControllerMapLayoutManager_002ERule_003E_002Eget_IsReadOnly()
			{
				return default;
			}

			[Token(Token = "0x6000677")]
			[Address(RVA = "0x245A0F8", Offset = "0x245A0F8", VA = "0x245A0F8", Slot = "15")]
			public bool Remove(Rule item)
			{
				return default;
			}

			[Token(Token = "0x6000678")]
			[Address(RVA = "0x245A1C8", Offset = "0x245A1C8", VA = "0x245A1C8", Slot = "16")]
			public IEnumerator<Rule> GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000679")]
			[Address(RVA = "0x245A2B8", Offset = "0x245A2B8", VA = "0x245A2B8", Slot = "17")]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600067A")]
			[Address(RVA = "0x245A3A8", Offset = "0x245A3A8", VA = "0x245A3A8", Slot = "18")]
			private object Rewired_002EUtils_002EInterfaces_002EIDeepCloneable_002EDeepClone()
			{
				return null;
			}

			[Token(Token = "0x600067B")]
			[Address(RVA = "0x24595FC", Offset = "0x24595FC", VA = "0x24595FC")]
			private void CheckList()
			{
			}
		}

		[Token(Token = "0x400055A")]
		[FieldOffset(Offset = "0x10")]
		private bool kKFZZElqKQSUFMZnWdEudRvTJGpo;

		[Token(Token = "0x400055B")]
		[FieldOffset(Offset = "0x11")]
		private bool yaJjuxjAwvQOrxZOVvBEDekOmAml;

		[Token(Token = "0x400055C")]
		[FieldOffset(Offset = "0x18")]
		private Player XGUdRXTQSWQSPvuOLhFeAdcEiwfEA;

		[Token(Token = "0x400055D")]
		[FieldOffset(Offset = "0x20")]
		private iZBHTLMJEscsCxujGlXwPdwYSOZv XzXJPYjgnEWOyBozllWRpzkenCmx;

		[Token(Token = "0x400055E")]
		[FieldOffset(Offset = "0x28")]
		private readonly int QajDFFaomlkLHzaostfWYpGUioys;

		[Token(Token = "0x400055F")]
		[FieldOffset(Offset = "0x30")]
		private List<RuleSet> CVIrxabQeQqQApdMyogYZKmdHqZeA;

		[Token(Token = "0x4000560")]
		[FieldOffset(Offset = "0x38")]
		private Action SfnipWeCwWMelczDtJvvLzklmVCp;

		[Token(Token = "0x17000209")]
		public bool enabled
		{
			[Token(Token = "0x6000652")]
			[Address(RVA = "0x236277C", Offset = "0x236277C", VA = "0x236277C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000653")]
			[Address(RVA = "0x2362784", Offset = "0x2362784", VA = "0x2362784")]
			set
			{
			}
		}

		[Token(Token = "0x1700020A")]
		public bool loadFromUserDataStore
		{
			[Token(Token = "0x6000654")]
			[Address(RVA = "0x23638A8", Offset = "0x23638A8", VA = "0x23638A8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000655")]
			[Address(RVA = "0x23638B0", Offset = "0x23638B0", VA = "0x23638B0")]
			set
			{
			}
		}

		[Token(Token = "0x1700020B")]
		public List<RuleSet> ruleSets
		{
			[Token(Token = "0x6000656")]
			[Address(RVA = "0x23638B8", Offset = "0x23638B8", VA = "0x23638B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1400000B")]
		internal event Action AQUdKrvukOGrQjObMyNlMmxVWmvsA
		{
			[Token(Token = "0x600064F")]
			[Address(RVA = "0x2362530", Offset = "0x2362530", VA = "0x2362530")]
			add
			{
				CeJRcgZOSEuGJtUQPOXOkZDmYkJk(action);
			}
			[Token(Token = "0x6000650")]
			[Address(RVA = "0x23625B4", Offset = "0x23625B4", VA = "0x23625B4")]
			remove
			{
				sKssmgnypNItlCgfRbieHJPUbdHfA(action);
			}
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x2362530", Offset = "0x2362530", VA = "0x2362530")]
		internal void CeJRcgZOSEuGJtUQPOXOkZDmYkJk(Action P_0)
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x23625B4", Offset = "0x23625B4", VA = "0x23625B4")]
		internal void sKssmgnypNItlCgfRbieHJPUbdHfA(Action P_0)
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x2362638", Offset = "0x2362638", VA = "0x2362638")]
		internal ControllerMapLayoutManager(Player P_0, iZBHTLMJEscsCxujGlXwPdwYSOZv P_1)
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x2362794", Offset = "0x2362794", VA = "0x2362794")]
		public void Apply()
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x2363B50", Offset = "0x2363B50", VA = "0x2363B50")]
		public void LoadDefaults()
		{
		}
	}
}
