using System;
using UnityEngine;

namespace Rewired.ComponentControls.Data
{
	[Serializable]
	public class CustomControllerElementTarget
	{
		internal enum ValueRange
		{
			Full = 0,
			Positive = 1,
			Negative = 2
		}

		[SerializeField]
		private CustomControllerElementSelector _element;

		[SerializeField]
		private ValueRange _valueRange;

		[SerializeField]
		private Pole _valueContribution;

		[SerializeField]
		private bool _invert;

		public CustomControllerElementSelector element => null;

		public Pole valueContribution
		{
			get
			{
				return Pole.Positive;
			}
			set
			{
			}
		}

		internal ValueRange valueRange
		{
			get
			{
				return ValueRange.Full;
			}
			set
			{
			}
		}

		public bool invert => false;

		internal CustomControllerElementTarget()
		{
		}

		internal CustomControllerElementTarget(CustomControllerElementSelector P_0)
		{
		}

		internal void ClearElementCaches()
		{
		}
	}
}
