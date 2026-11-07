using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kilt
{
	[Serializable]
	public class FunctionAndParams
	{
		[SerializeField]
		private object m_target;

		[SerializeField]
		private Type m_functionType;

		[SerializeField]
		private string m_stringFunctionName;

		[SerializeField]
		private Delegate m_delegatePointer;

		[SerializeField]
		private List<object> m_params;

		public object Target
		{
			set
			{
			}
		}

		public Type FunctionType => null;

		public Delegate DelegatePointer
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<object> Params
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool CallFunction()
		{
			return false;
		}

		protected bool CallDelegateFunction()
		{
			return false;
		}
	}
}
