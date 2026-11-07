using System;
using System.Collections.Generic;

namespace Amazon.Runtime
{
	public class ConstantClass
	{
		private static readonly object staticFieldsLock;

		private static Dictionary<Type, Dictionary<string, ConstantClass>> staticFields;

		public string Value { get; private set; }

		protected ConstantClass(string value)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		public static implicit operator string(ConstantClass value)
		{
			return null;
		}

		internal ConstantClass Intern()
		{
			return null;
		}

		protected static T FindValue<T>(string value) where T : ConstantClass
		{
			return null;
		}

		private static void LoadFields(Type t)
		{
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public virtual bool Equals(ConstantClass obj)
		{
			return false;
		}

		protected virtual bool Equals(string value)
		{
			return false;
		}

		public static bool operator ==(ConstantClass a, ConstantClass b)
		{
			return false;
		}

		public static bool operator !=(ConstantClass a, ConstantClass b)
		{
			return false;
		}

		public static bool operator ==(ConstantClass a, string b)
		{
			return false;
		}

		public static bool operator ==(string a, ConstantClass b)
		{
			return false;
		}

		public static bool operator !=(ConstantClass a, string b)
		{
			return false;
		}

		public static bool operator !=(string a, ConstantClass b)
		{
			return false;
		}
	}
}
