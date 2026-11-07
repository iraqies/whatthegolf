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
	[Token(Token = "0x20000E3")]
	public sealed class ControllerMapEnabler
	{
		[Serializable]
		[Token(Token = "0x20000E4")]
		[Preserve]
		public sealed class Rule : IDeepCloneable
		{
			[Token(Token = "0x400054D")]
			[FieldOffset(Offset = "0x10")]
			[Serialize]
			[SerializeField]
			private string _tag;

			[Token(Token = "0x400054E")]
			[FieldOffset(Offset = "0x18")]
			[Serialize]
			[SerializeField]
			private bool _enable;

			[Token(Token = "0x400054F")]
			[FieldOffset(Offset = "0x20")]
			[Serialize]
			[SerializeField]
			private int[] _categoryIds;

			[Token(Token = "0x4000550")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			[Serialize]
			private int[] _layoutIds;

			[Token(Token = "0x4000551")]
			[FieldOffset(Offset = "0x30")]
			[Serialize]
			[SerializeField]
			private ControllerSetSelector _controllerSetSelector;

			[NonSerialized]
			[Token(Token = "0x4000552")]
			[FieldOffset(Offset = "0x38")]
			private string[] _preInitCategoryNames;

			[NonSerialized]
			[Token(Token = "0x4000553")]
			[FieldOffset(Offset = "0x40")]
			private string[] _preInitLayoutNames;

			[Token(Token = "0x170001FE")]
			public string tag
			{
				[Token(Token = "0x600062D")]
				[Address(RVA = "0x2456E8C", Offset = "0x2456E8C", VA = "0x2456E8C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001FF")]
			public bool enable
			{
				[Token(Token = "0x600062E")]
				[Address(RVA = "0x2456E94", Offset = "0x2456E94", VA = "0x2456E94")]
				get
				{
					return default;
				}
				[Token(Token = "0x600062F")]
				[Address(RVA = "0x2456E9C", Offset = "0x2456E9C", VA = "0x2456E9C")]
				set
				{
				}
			}

			[Token(Token = "0x17000200")]
			public ControllerSetSelector controllerSetSelector
			{
				[Token(Token = "0x6000630")]
				[Address(RVA = "0x2456EA4", Offset = "0x2456EA4", VA = "0x2456EA4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000201")]
			public int[] categoryIds
			{
				[Token(Token = "0x6000631")]
				[Address(RVA = "0x2456F10", Offset = "0x2456F10", VA = "0x2456F10")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000202")]
			public int[] layoutIds
			{
				[Token(Token = "0x6000632")]
				[Address(RVA = "0x2457378", Offset = "0x2457378", VA = "0x2457378")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000203")]
			internal bool isValid
			{
				[Token(Token = "0x6000633")]
				[Address(RVA = "0x24573D8", Offset = "0x24573D8", VA = "0x24573D8")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x600062A")]
			[Address(RVA = "0x2456C1C", Offset = "0x2456C1C", VA = "0x2456C1C")]
			public Rule()
			{
			}

			[Token(Token = "0x600062B")]
			[Address(RVA = "0x2456CC4", Offset = "0x2456CC4", VA = "0x2456CC4")]
			public Rule(Rule P_0)
			{
			}

			[Token(Token = "0x600062C")]
			[Address(RVA = "0x2456E34", Offset = "0x2456E34", VA = "0x2456E34")]
			internal Rule(string P_0, bool P_1, int[] P_2, int[] P_3, ControllerSetSelector P_4)
			{
			}

			[Token(Token = "0x6000634")]
			[Address(RVA = "0x24575D4", Offset = "0x24575D4", VA = "0x24575D4")]
			internal bool Matches(ControllerMap map)
			{
				return default;
			}

			[Token(Token = "0x6000635")]
			[Address(RVA = "0x2456F70", Offset = "0x2456F70", VA = "0x2456F70")]
			private void Initialize()
			{
			}

			[Token(Token = "0x6000636")]
			[Address(RVA = "0x24576D4", Offset = "0x24576D4", VA = "0x24576D4")]
			private void CheckNoControllerTypeError()
			{
			}

			[Token(Token = "0x6000637")]
			[Address(RVA = "0x245795C", Offset = "0x245795C", VA = "0x245795C", Slot = "4")]
			private object Rewired_002EUtils_002EInterfaces_002EIDeepCloneable_002EDeepClone()
			{
				return null;
			}
		}

		[Serializable]
		[Token(Token = "0x20000E5")]
		[AttributeAttribute(Name = "SerializationTypeAttribute", RVA = "0x190B30", Offset = "0x190B30")]
		[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x190B30", Offset = "0x190B30")]
		[Preserve]
		public sealed class RuleSet : IList<Rule>, ICollection<Rule>, IEnumerable<Rule>, IEnumerable, IDeepCloneable
		{
			[Token(Token = "0x4000554")]
			private const string className = "ControllerMapEnabler.RuleSet";

			[Token(Token = "0x4000555")]
			[FieldOffset(Offset = "0x10")]
			[Serialize]
			[SerializeField]
			private bool _enabled;

			[Token(Token = "0x4000556")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			[Serialize]
			private string _tag;

			[Token(Token = "0x4000557")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			[Serialize]
			private List<Rule> _rules;

			[Token(Token = "0x17000204")]
			public bool enabled
			{
				[Token(Token = "0x6000638")]
				[Address(RVA = "0x24579C0", Offset = "0x24579C0", VA = "0x24579C0")]
				get
				{
					return default;
				}
				[Token(Token = "0x6000639")]
				[Address(RVA = "0x24579C8", Offset = "0x24579C8", VA = "0x24579C8")]
				set
				{
				}
			}

			[Token(Token = "0x17000205")]
			public string tag
			{
				[Token(Token = "0x600063A")]
				[Address(RVA = "0x24579D0", Offset = "0x24579D0", VA = "0x24579D0")]
				get
				{
					return null;
				}
			}

			// C# has no syntax for parameterized property 'Item'.
			// Its 'property:' attributes below are ignored by the compiler (CS0657).
			[property: Token(Token = "0x17000206")]
			[Token(Token = "0x6000641")]
			[Address(RVA = "0x2457F84", Offset = "0x2457F84", VA = "0x2457F84", Slot = "4")]
			public Rule get_Item(int index)
			{
				return null;
			}

			[Token(Token = "0x6000642")]
			[Address(RVA = "0x2458064", Offset = "0x2458064", VA = "0x2458064", Slot = "5")]
			public void set_Item(int index, Rule value)
			{
			}

			[Token(Token = "0x17000207")]
			public int Count
			{
				[Token(Token = "0x6000647")]
				[Address(RVA = "0x2458474", Offset = "0x2458474", VA = "0x2458474", Slot = "9")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000208")]
			private bool System_002ECollections_002EGeneric_002EICollection_003CRewired_002EControllerMapEnabler_002ERule_003E_002EIsReadOnly
			{
				[Token(Token = "0x6000648")]
				[Address(RVA = "0x245852C", Offset = "0x245852C", VA = "0x245852C", Slot = "10")]
				get
				{
					return System_002ECollections_002EGeneric_002EICollection_003CRewired_002EControllerMapEnabler_002ERule_003E_002Eget_IsReadOnly();
				}
			}

			[Token(Token = "0x600063B")]
			[Address(RVA = "0x24579D8", Offset = "0x24579D8", VA = "0x24579D8")]
			internal RuleSet(bool P_0, string P_1, List<Rule> P_2)
			{
			}

			[Token(Token = "0x600063C")]
			[Address(RVA = "0x2457AC8", Offset = "0x2457AC8", VA = "0x2457AC8")]
			public RuleSet()
			{
			}

			[Token(Token = "0x600063D")]
			[Address(RVA = "0x2457BCC", Offset = "0x2457BCC", VA = "0x2457BCC")]
			public RuleSet(RuleSet P_0)
			{
			}

			[Token(Token = "0x600063E")]
			[Address(RVA = "0x2457D24", Offset = "0x2457D24", VA = "0x2457D24", Slot = "6")]
			public int IndexOf(Rule item)
			{
				return default;
			}

			[Token(Token = "0x600063F")]
			[Address(RVA = "0x2457DDC", Offset = "0x2457DDC", VA = "0x2457DDC", Slot = "7")]
			public void Insert(int index, Rule item)
			{
			}

			[Token(Token = "0x6000640")]
			[Address(RVA = "0x2457EB4", Offset = "0x2457EB4", VA = "0x2457EB4", Slot = "8")]
			public void RemoveAt(int index)
			{
			}

			[Token(Token = "0x6000643")]
			[Address(RVA = "0x245813C", Offset = "0x245813C", VA = "0x245813C", Slot = "11")]
			public void Add(Rule item)
			{
			}

			[Token(Token = "0x6000644")]
			[Address(RVA = "0x245820C", Offset = "0x245820C", VA = "0x245820C", Slot = "12")]
			public void Clear()
			{
			}

			[Token(Token = "0x6000645")]
			[Address(RVA = "0x24582CC", Offset = "0x24582CC", VA = "0x24582CC", Slot = "13")]
			public bool Contains(Rule item)
			{
				return default;
			}

			[Token(Token = "0x6000646")]
			[Address(RVA = "0x245839C", Offset = "0x245839C", VA = "0x245839C", Slot = "14")]
			public void CopyTo(Rule[] array, int arrayIndex)
			{
			}

			[Token(Token = "0x6000648")]
			[Address(RVA = "0x245852C", Offset = "0x245852C", VA = "0x245852C", Slot = "10")]
			private bool System_002ECollections_002EGeneric_002EICollection_003CRewired_002EControllerMapEnabler_002ERule_003E_002Eget_IsReadOnly()
			{
				return default;
			}

			[Token(Token = "0x6000649")]
			[Address(RVA = "0x2458650", Offset = "0x2458650", VA = "0x2458650", Slot = "15")]
			public bool Remove(Rule item)
			{
				return default;
			}

			[Token(Token = "0x600064A")]
			[Address(RVA = "0x2458720", Offset = "0x2458720", VA = "0x2458720", Slot = "16")]
			public IEnumerator<Rule> GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600064B")]
			[Address(RVA = "0x2458810", Offset = "0x2458810", VA = "0x2458810", Slot = "17")]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600064C")]
			[Address(RVA = "0x2458900", Offset = "0x2458900", VA = "0x2458900", Slot = "18")]
			private object Rewired_002EUtils_002EInterfaces_002EIDeepCloneable_002EDeepClone()
			{
				return null;
			}

			[Token(Token = "0x600064D")]
			[Address(RVA = "0x2457B54", Offset = "0x2457B54", VA = "0x2457B54")]
			private void CheckList()
			{
			}
		}

		[Token(Token = "0x20000E6")]
		internal class oejthPnlmICeXCzkndFXvfozHuLjA
		{
			[Token(Token = "0x4000558")]
			[FieldOffset(Offset = "0x10")]
			public bool kzXMFixQhdfqdwRZTXNUgEOsGVFD;

			[Token(Token = "0x4000559")]
			[FieldOffset(Offset = "0x18")]
			public vNnAsbNOxQRuVRxCcHhnyysOuoGy[] skDiKcsxfIWRYRUooobRNKLwyssi;

			[Token(Token = "0x600064E")]
			[Address(RVA = "0x2458964", Offset = "0x2458964", VA = "0x2458964")]
			public oejthPnlmICeXCzkndFXvfozHuLjA(bool P_0, vNnAsbNOxQRuVRxCcHhnyysOuoGy[] P_1)
			{
			}
		}

		[Token(Token = "0x4000548")]
		[FieldOffset(Offset = "0x10")]
		private bool kKFZZElqKQSUFMZnWdEudRvTJGpo;

		[Token(Token = "0x4000549")]
		[FieldOffset(Offset = "0x18")]
		private Player XGUdRXTQSWQSPvuOLhFeAdcEiwfEA;

		[Token(Token = "0x400054A")]
		[FieldOffset(Offset = "0x20")]
		private oejthPnlmICeXCzkndFXvfozHuLjA XzXJPYjgnEWOyBozllWRpzkenCmx;

		[Token(Token = "0x400054B")]
		[FieldOffset(Offset = "0x28")]
		private readonly int QajDFFaomlkLHzaostfWYpGUioys;

		[Token(Token = "0x400054C")]
		[FieldOffset(Offset = "0x30")]
		private List<RuleSet> CVIrxabQeQqQApdMyogYZKmdHqZeA;

		[Token(Token = "0x170001FC")]
		public bool enabled
		{
			[Token(Token = "0x6000625")]
			[Address(RVA = "0x23615B4", Offset = "0x23615B4", VA = "0x23615B4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000626")]
			[Address(RVA = "0x23615BC", Offset = "0x23615BC", VA = "0x23615BC")]
			set
			{
			}
		}

		[Token(Token = "0x170001FD")]
		public List<RuleSet> ruleSets
		{
			[Token(Token = "0x6000627")]
			[Address(RVA = "0x23619EC", Offset = "0x23619EC", VA = "0x23619EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x2361478", Offset = "0x2361478", VA = "0x2361478")]
		internal ControllerMapEnabler(Player P_0, oejthPnlmICeXCzkndFXvfozHuLjA P_1)
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x23615CC", Offset = "0x23615CC", VA = "0x23615CC")]
		public void Apply()
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x23619F4", Offset = "0x23619F4", VA = "0x23619F4")]
		public void LoadDefaults()
		{
		}
	}
}
