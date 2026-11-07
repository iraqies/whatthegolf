using System;
using System.Collections.Generic;
using UnityEngine;

namespace Rewired.ComponentControls.Data
{
	[Serializable]
	public sealed class CustomControllerElementSelector
	{
		public enum ElementType
		{
			Axis = 0,
			Button = 1
		}

		public enum SelectorType
		{
			Name = 0,
			Index = 1,
			Id = 2
		}

		[SerializeField]
		private ElementType _elementType;

		[SerializeField]
		private SelectorType _selectorType;

		[SerializeField]
		private string _elementName;

		[SerializeField]
		private int _elementIndex;

		[SerializeField]
		private int _elementId;

		private int bZHBbmkmHZYQqFMtcmgNWgeBYwrIA;

		private int pwUzICXNXsZDQyMZeUuAfkUZfIkhA;

		public ElementType elementType
		{
			get
			{
				return ElementType.Axis;
			}
			set
			{
			}
		}

		public SelectorType selectorType => SelectorType.Name;

		public string elementName => null;

		public int elementIndex => 0;

		public int elementId => 0;

		public bool isAssigned => false;

		public int GetElementIndex(Rewired.CustomController customController)
		{
			return 0;
		}

		public string GetSelectorFormattedString()
		{
			return null;
		}

		private IList<ControllerElementIdentifier> qvVwrYBAAXQrxjjpEuLZPbzRvhAq(Rewired.CustomController P_0, ElementType P_1)
		{
			return null;
		}

		public void ClearCache()
		{
		}
	}
}
