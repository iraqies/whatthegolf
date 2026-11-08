using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

namespace Rewired
{
	[Serializable]
	public sealed class InputMapCategory : InputCategory
	{
		[SerializeField]
		private bool _checkConflictsWithAllCategories;

		[SerializeField]
		private List<int> _checkConflictsCategoryIds;

		private ReadOnlyCollection<int> _checkConflictsCategoryIds_readOnly;

		public bool checkConflictsWithAllCategories
		{
			get
			{
				return false;
			}
			internal set
			{
				wCSxwiqotcZMrRMttyyFfwKZNIVi(value);
			}
		}

		public IList<int> checkConflictsCategoryIds => null;

		internal void wCSxwiqotcZMrRMttyyFfwKZNIVi(bool P_0)
		{
		}

		internal void zQQfvDZMmpVqPPLYlLuSJXXpwJcI()
		{
		}
	}
}
