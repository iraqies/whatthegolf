using System;
using UnityEngine;

namespace Chronos.Reflection
{
	[Serializable]
	public abstract class UnityMember
	{
		[SerializeField]
		private UnityEngine.Object _target;

		[SerializeField]
		private string _component;

		[SerializeField]
		private string _name;

		public UnityEngine.Object target => null;

		public string component => null;

		public string name => null;

		protected bool isTargeted { get; }

		public bool isReflected { get; protected set; }

		public bool isAssigned => false;

		protected UnityEngine.Object reflectionTarget { get; private set; }

		public UnityMember()
		{
		}

		protected void Target()
		{
		}

		public abstract void Reflect();

		public void EnsureReflected()
		{
		}

		public void EnsureTargeted()
		{
		}

		public void EnsureAssigned()
		{
		}
	}
}
