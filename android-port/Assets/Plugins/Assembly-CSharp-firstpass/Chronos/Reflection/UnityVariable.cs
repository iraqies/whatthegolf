using System;
using System.Reflection;

namespace Chronos.Reflection
{
	[Serializable]
	public class UnityVariable : UnityMember
	{
		private enum SourceType
		{
			Unknown = 0,
			Field = 1,
			Property = 2
		}

		private SourceType sourceType;

		public FieldInfo fieldInfo { get; private set; }

		public PropertyInfo propertyInfo { get; private set; }

		public override void Reflect()
		{
		}

		public object Get()
		{
			return null;
		}

		public void Set(object value)
		{
		}
	}
}
