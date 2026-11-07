using System;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json
{
	public abstract class JsonContainerAttribute : Attribute
	{
		internal bool? _isReference;

		internal bool? _itemIsReference;

		internal ReferenceLoopHandling? _itemReferenceLoopHandling;

		internal TypeNameHandling? _itemTypeNameHandling;

		private Type _namingStrategyType;

		private object[] _namingStrategyParameters;

		public Type ItemConverterType { get; }

		public object[] ItemConverterParameters { get; }

		public Type NamingStrategyType => null;

		public object[] NamingStrategyParameters => null;

		internal NamingStrategy NamingStrategyInstance { get; set; }
	}
}
