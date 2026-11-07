using System;

namespace Newtonsoft.Json
{
	public sealed class JsonPropertyAttribute : Attribute
	{
		internal NullValueHandling? _nullValueHandling;

		internal DefaultValueHandling? _defaultValueHandling;

		internal ReferenceLoopHandling? _referenceLoopHandling;

		internal ObjectCreationHandling? _objectCreationHandling;

		internal TypeNameHandling? _typeNameHandling;

		internal bool? _isReference;

		internal int? _order;

		internal Required? _required;

		internal bool? _itemIsReference;

		internal ReferenceLoopHandling? _itemReferenceLoopHandling;

		internal TypeNameHandling? _itemTypeNameHandling;

		public Type ItemConverterType { get; }

		public object[] ItemConverterParameters { get; }

		public Type NamingStrategyType { get; }

		public object[] NamingStrategyParameters { get; }

		public NullValueHandling NullValueHandling
		{
			set
			{
			}
		}

		public string PropertyName { get; set; }

		public JsonPropertyAttribute(string propertyName)
		{
		}
	}
}
