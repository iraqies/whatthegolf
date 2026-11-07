using System;
using System.Collections;
using System.Collections.Generic;
using Rewired.Utils.Attributes;
using Rewired.Utils.Interfaces;
using Rewired.Utils.Libraries.TinyJson;
using UnityEngine;

namespace Rewired
{
	public sealed class ControllerMapEnabler
	{
		[Serializable]
		[Preserve]
		public sealed class Rule : IDeepCloneable
		{
			[Serialize]
			[SerializeField]
			private string _tag;

			[Serialize]
			[SerializeField]
			private bool _enable;

			[Serialize]
			[SerializeField]
			private int[] _categoryIds;

			[SerializeField]
			[Serialize]
			private int[] _layoutIds;

			[Serialize]
			[SerializeField]
			private ControllerSetSelector _controllerSetSelector;

			[NonSerialized]
			private string[] _preInitCategoryNames;

			[NonSerialized]
			private string[] _preInitLayoutNames;

			public string tag => null;

			public bool enable
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public ControllerSetSelector controllerSetSelector => null;

			public int[] categoryIds => null;

			public int[] layoutIds => null;

			internal bool isValid => false;

			public Rule()
			{
			}

			public Rule(Rule P_0)
			{
			}

			internal Rule(string P_0, bool P_1, int[] P_2, int[] P_3, ControllerSetSelector P_4)
			{
			}

			internal bool Matches(ControllerMap map)
			{
				return false;
			}

			private void Initialize()
			{
			}

			private void CheckNoControllerTypeError()
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
			private const string className = "ControllerMapEnabler.RuleSet";

			[Serialize]
			[SerializeField]
			private bool _enabled;

			[SerializeField]
			[Serialize]
			private string _tag;

			[SerializeField]
			[Serialize]
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

		internal class oejthPnlmICeXCzkndFXvfozHuLjA
		{
			public bool kzXMFixQhdfqdwRZTXNUgEOsGVFD;

			public vNnAsbNOxQRuVRxCcHhnyysOuoGy[] skDiKcsxfIWRYRUooobRNKLwyssi;

			public oejthPnlmICeXCzkndFXvfozHuLjA(bool P_0, vNnAsbNOxQRuVRxCcHhnyysOuoGy[] P_1)
			{
			}
		}

		private bool kKFZZElqKQSUFMZnWdEudRvTJGpo;

		private Player XGUdRXTQSWQSPvuOLhFeAdcEiwfEA;

		private oejthPnlmICeXCzkndFXvfozHuLjA XzXJPYjgnEWOyBozllWRpzkenCmx;

		private readonly int QajDFFaomlkLHzaostfWYpGUioys;

		private List<RuleSet> CVIrxabQeQqQApdMyogYZKmdHqZeA;

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

		public List<RuleSet> ruleSets => null;

		internal ControllerMapEnabler(Player P_0, oejthPnlmICeXCzkndFXvfozHuLjA P_1)
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
