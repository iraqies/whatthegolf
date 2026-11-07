using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace UnityEngine.AddressableAssets
{
	public class InvalidKeyException : Exception
	{
		private AddressablesImpl m_Addressables;

		private const string BaseInvalidKeyMessageFormat = "{0}, Key={1}, Type={2}";

		public object Key { get; private set; }

		public Type Type { get; private set; }

		public Addressables.MergeMode? MergeMode { get; }

		public override string Message => null;

		public InvalidKeyException(object key)
		{
		}

		public InvalidKeyException(object key, Type type)
		{
		}

		internal InvalidKeyException(object key, Type type, AddressablesImpl addr)
		{
		}

		public InvalidKeyException(object key, Type type, Addressables.MergeMode mergeMode)
		{
		}

		internal InvalidKeyException(object key, Type type, Addressables.MergeMode mergeMode, AddressablesImpl addr)
		{
		}

		public InvalidKeyException()
		{
		}

		public InvalidKeyException(string message)
		{
		}

		public InvalidKeyException(string message, Exception innerException)
		{
		}

		protected InvalidKeyException(SerializationInfo message, StreamingContext context)
		{
		}

		private string GetMessageForSingleKey(string keyString)
		{
			return null;
		}

		private string GetNotFoundMessage(string keyString)
		{
			return null;
		}

		private string GetTypeNotAssignableMessage(string keyString, HashSet<Type> typesAvailableForKey)
		{
			return null;
		}

		private string GetMultipleAssignableTypesMessage(string keyString, HashSet<Type> typesAvailableForKey)
		{
			return null;
		}

		private string GetMessageforMergeKeys(List<string> keys)
		{
			return null;
		}

		private HashSet<Type> GetTypesForKey(string keyString)
		{
			return null;
		}

		private bool GetTypeToKeys(string key, Dictionary<Type, List<string>> typeToKeys)
		{
			return false;
		}

		private string GetCSVString(IEnumerable<string> enumerator, string prefixSingle, string prefixPlural)
		{
			return null;
		}
	}
}
