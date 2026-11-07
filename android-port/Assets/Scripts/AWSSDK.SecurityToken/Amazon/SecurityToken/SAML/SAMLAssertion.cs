using System;
using System.Collections.Generic;
using Amazon.Runtime;

namespace Amazon.SecurityToken.SAML
{
	public class SAMLAssertion
	{
		private const string AssertionNamespace = "urn:oasis:names:tc:SAML:2.0:assertion";

		private const string RoleXPath = "//response:Attribute[@Name='https://aws.amazon.com/SAML/Attributes/Role']";

		public string AssertionDocument { get; private set; }

		public IDictionary<string, string> RoleSet { get; private set; }

		public SAMLImmutableCredentials GetRoleCredentials(IAmazonSecurityTokenService stsClient, string principalAndRoleArns, TimeSpan duration)
		{
			return null;
		}

		internal SAMLAssertion(string assertion)
		{
		}

		private IDictionary<string, string> ExtractRoleData()
		{
			return null;
		}

		private static bool IsSamlProvider(string chunk)
		{
			return false;
		}

		private static string ExtractRoleName(string chunk)
		{
			return null;
		}
	}
}
