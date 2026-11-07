using System;

namespace Amazon.Runtime.Internal.Auth
{
	public class AWS4SigningResult
	{
		private readonly string _awsAccessKeyId;

		private readonly DateTime _originalDateTime;

		private readonly string _signedHeaders;

		private readonly string _scope;

		private readonly byte[] _signingKey;

		private readonly byte[] _signature;

		public string AccessKeyId => null;

		public string ISO8601DateTime => null;

		public string ISO8601Date => null;

		public string SignedHeaders => null;

		public string Scope => null;

		public byte[] SigningKey => null;

		public string Signature => null;

		public byte[] SignatureBytes => null;

		public string ForAuthorizationHeader => null;

		public string ForQueryParameters => null;

		public AWS4SigningResult(string awsAccessKeyId, DateTime signedAt, string signedHeaders, string scope, byte[] signingKey, byte[] signature)
		{
		}
	}
}
