using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Amazon.Runtime.Internal.Util
{
	public class S3Uri
	{
		private const string S3EndpointPattern = "^(.+\\.)?s3[.-]([a-z0-9-]+)\\.";

		private const string S3ControlExlusionPattern = "^(.+\\.)?s3-control\\.";

		private static readonly Regex S3EndpointRegex;

		private static readonly Regex S3ControlExlusionRegex;

		public bool IsPathStyle { get; private set; }

		public string Bucket { get; private set; }

		public string Key { get; private set; }

		public RegionEndpoint Region { get; set; }

		public S3Uri(string uri)
		{
		}

		public S3Uri(Uri uri)
		{
		}

		public static bool IsS3Uri(Uri uri)
		{
			return false;
		}

		private static string Decode(string s)
		{
			return null;
		}

		private static string Decode(string s, int firstPercent)
		{
			return null;
		}

		private static void AppendDecoded(StringBuilder builder, string s, int index)
		{
		}

		private static int FromHex(char c)
		{
			return 0;
		}
	}
}
