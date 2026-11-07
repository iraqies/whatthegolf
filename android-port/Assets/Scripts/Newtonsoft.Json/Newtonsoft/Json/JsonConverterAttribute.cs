using System;

namespace Newtonsoft.Json
{
	public sealed class JsonConverterAttribute : Attribute
	{
		private readonly Type _converterType;

		public Type ConverterType => null;

		public object[] ConverterParameters { get; }

		public JsonConverterAttribute(Type converterType)
		{
		}
	}
}
