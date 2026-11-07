using System.Collections.Generic;
using System.Reflection;

namespace Amazon.Runtime.CredentialManagement.Internal
{
	public class CredentialProfilePropertyMapping
	{
		private static readonly HashSet<string> TypePropertySet;

		private static readonly PropertyInfo[] CredentialProfileReflectionProperties;

		private readonly Dictionary<string, string> _nameMapping;

		private readonly HashSet<string> _mappedNames;

		public CredentialProfilePropertyMapping(Dictionary<string, string> nameMapping)
		{
		}

		public void ExtractProfileParts(Dictionary<string, string> profileDictionary, HashSet<string> reservedKeys, out CredentialProfileOptions profileOptions, out Dictionary<string, string> userProperties)
		{
			profileOptions = null;
			userProperties = null;
		}

		public void ExtractProfileParts(Dictionary<string, string> profileDictionary, HashSet<string> reservedKeys, out CredentialProfileOptions profileOptions, out Dictionary<string, string> reservedProperties, out Dictionary<string, string> userProperties)
		{
			profileOptions = null;
			reservedProperties = null;
			userProperties = null;
		}

		public Dictionary<string, string> CombineProfileParts(CredentialProfileOptions profileOptions, HashSet<string> reservedPropertyNames, Dictionary<string, string> reservedProperties, Dictionary<string, string> userProperties)
		{
			return null;
		}

		private static void ValidateNoReservedProperties(HashSet<string> reservedPropertyNames, Dictionary<string, string> userProperties)
		{
		}

		private void ValidateNoProfileOptionsProperties(Dictionary<string, string> userProperties)
		{
		}

		private Dictionary<string, string> Convert(CredentialProfileOptions profileOptions)
		{
			return null;
		}
	}
}
