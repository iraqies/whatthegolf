using System;
using System.Collections.Generic;
using System.Reflection;

namespace MonitorComponents
{
	public class TypeInspectors
	{
		private class DefaultTypeInspector : ITypeInspector
		{
			private string[] fieldNameStrings;

			private Field[] fields;

			private Dictionary<string, FieldInfo> nameToFieldInfo;

			public DefaultTypeInspector(TypeInspectors typeInspectors, Type type)
			{
			}

			public object GetValue(object instance, string fieldName)
			{
				return null;
			}
		}

		public class Field
		{
			public string name;

			public Type type;
		}

		private class QuaternionTypeInspector : ITypeInspector
		{
			private string[] fieldNameStrings;

			private Field[] fields;

			public object GetValue(object instance, string fieldName)
			{
				return null;
			}
		}

		public interface ITypeInspector
		{
			object GetValue(object instance, string fieldName);
		}

		private HashSet<Type> sampleTypes;

		private static BindingFlags flags;

		private static TypeInspectors instance;

		private Dictionary<Type, ITypeInspector> inspectors;

		private static Dictionary<Type, string> valueTypes;

		public static TypeInspectors Instance => null;

		public ITypeInspector GetTypeInspector(Type type)
		{
			return null;
		}

		public bool IsSampleType(Type type)
		{
			return false;
		}

		public bool IsAcceptableType(Type type)
		{
			return false;
		}

		private static string GetReadableName(Type type)
		{
			return null;
		}
	}
}
