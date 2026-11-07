using System;
using System.Collections;
using System.Collections.Generic;
using Rewired.Utils.Attributes;
using Rewired.Utils.Interfaces;
using Rewired.Utils.Libraries.TinyJson;
using UnityEngine;

namespace Rewired
{
	public sealed class ControllerMapLayoutManager
	{
		internal class iZBHTLMJEscsCxujGlXwPdwYSOZv
		{
			public bool kzXMFixQhdfqdwRZTXNUgEOsGVFD;

			public bool RPjxhQSdjcTHwaKJnCMbHbwTpzYDA;

			public vNnAsbNOxQRuVRxCcHhnyysOuoGy[] skDiKcsxfIWRYRUooobRNKLwyssi;

			public iZBHTLMJEscsCxujGlXwPdwYSOZv(bool P_0, bool P_1, vNnAsbNOxQRuVRxCcHhnyysOuoGy[] P_2)
			{
			}
		}

		[Serializable]
		[Preserve]
		public sealed class Rule : IDeepCloneable
		{
			[Serialize]
			[SerializeField]
			private string _tag;

			[Serialize]
			[SerializeField]
			private int[] _categoryIds;

			[SerializeField]
			[Serialize]
			private int _layoutId;

			[SerializeField]
			[Serialize]
			private ControllerSetSelector _controllerSetSelector;

			[NonSerialized]
			private string[] _preInitCategoryNames;

			[NonSerialized]
			private string _preInitLayoutName;

			public string tag => null;

			public ControllerSetSelector controllerSetSelector => null;

			public int[] categoryIds => null;

			public int layoutId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public string layoutName
			{
				set
				{
				}
			}

			internal bool isValid => false;

			public Rule()
			{
			}

			public Rule(Rule P_0)
			{
			}

			internal Rule(string P_0, int[] P_1, int P_2, ControllerSetSelector P_3)
			{
			}

			private void Initialize()
			{
			}

			object IDeepCloneable.DeepClone()
			{
				return null;
			}
		}

		[Serializable]
		[Preserve]
		public sealed class RuleSet : IList<Rule>, ICollection<Rule>, IEnumerable<Rule>, IEnumerable, IDeepCloneable
		{
			private const string className = "ControllerMapLayoutManager.RuleSet";

			[SerializeField]
			[Serialize]
			private bool _enabled;

			[Serialize]
			[SerializeField]
			private string _tag;

			[Serialize]
			[SerializeField]
			private List<Rule> _rules;

			public bool enabled
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public string tag => null;

			// C# has no syntax for parameterized property 'Item'.
			public Rule get_Item(int index)
			{
				return null;
			}

			public void set_Item(int index, Rule value)
			{
			}

			public int Count => 0;

			bool ICollection<Rule>.IsReadOnly => false;

			internal RuleSet(bool P_0, string P_1, List<Rule> P_2)
			{
			}

			public RuleSet()
			{
			}

			public RuleSet(RuleSet P_0)
			{
			}

			public int IndexOf(Rule item)
			{
				return 0;
			}

			public void Insert(int index, Rule item)
			{
			}

			public void RemoveAt(int index)
			{
			}

			public void Add(Rule item)
			{
			}

			public void Clear()
			{
			}

			public bool Contains(Rule item)
			{
				return false;
			}

			public void CopyTo(Rule[] array, int arrayIndex)
			{
			}

			public bool Remove(Rule item)
			{
				return false;
			}

			public IEnumerator<Rule> GetEnumerator()
			{
				return null;
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			object IDeepCloneable.DeepClone()
			{
				return null;
			}

			private void CheckList()
			{
			}
		}

		private bool kKFZZElqKQSUFMZnWdEudRvTJGpo;

		private bool yaJjuxjAwvQOrxZOVvBEDekOmAml;

		private Player XGUdRXTQSWQSPvuOLhFeAdcEiwfEA;

		private iZBHTLMJEscsCxujGlXwPdwYSOZv XzXJPYjgnEWOyBozllWRpzkenCmx;

		private readonly int QajDFFaomlkLHzaostfWYpGUioys;

		private List<RuleSet> CVIrxabQeQqQApdMyogYZKmdHqZeA;

		private Action SfnipWeCwWMelczDtJvvLzklmVCp;

		public bool enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool loadFromUserDataStore
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public List<RuleSet> ruleSets => null;

		internal event Action AQUdKrvukOGrQjObMyNlMmxVWmvsA
		{
			add
			{
				CeJRcgZOSEuGJtUQPOXOkZDmYkJk(action);
			}
			remove
			{
				sKssmgnypNItlCgfRbieHJPUbdHfA(action);
			}
		}

		internal void CeJRcgZOSEuGJtUQPOXOkZDmYkJk(Action P_0)
		{
		}

		internal void sKssmgnypNItlCgfRbieHJPUbdHfA(Action P_0)
		{
		}

		internal ControllerMapLayoutManager(Player P_0, iZBHTLMJEscsCxujGlXwPdwYSOZv P_1)
		{
		}

		public void Apply()
		{
		}

		public void LoadDefaults()
		{
		}
	}
}
