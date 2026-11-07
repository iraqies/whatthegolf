using System;
using System.Collections.Generic;
using Amazon.Runtime.Internal.Util;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Auth
{
	[Token(Token = "0x2000253")]
	public class S3Signer : AbstractAWSSigner
	{
		[Token(Token = "0x2000254")]
		public delegate void RegionDetectionUpdater(IRequest request);

		[Serializable]
		[Token(Token = "0x2000255")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26060", Offset = "0x26060")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4000878")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4000879")]
			[FieldOffset(Offset = "0x8")]
			public static Func<string, string> _003C_003E9__10_0;

			[Token(Token = "0x400087A")]
			[FieldOffset(Offset = "0x10")]
			public static Comparison<KeyValuePair<string, string>> _003C_003E9__13_0;

			[Token(Token = "0x60011AE")]
			[Address(RVA = "0x12954E0", Offset = "0x12954E0", VA = "0x12954E0")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60011AF")]
			[Address(RVA = "0x12954E8", Offset = "0x12954E8", VA = "0x12954E8")]
			internal string _003CBuildCanonicalizedHeaders_003Eb__10_0(string x)
			{
				return null;
			}

			[Token(Token = "0x60011B0")]
			[Address(RVA = "0x12954F0", Offset = "0x12954F0", VA = "0x12954F0")]
			internal int _003CBuildCanonicalizedResource_003Eb__13_0(KeyValuePair<string, string> firstPair, KeyValuePair<string, string> nextPair)
			{
				return default;
			}
		}

		[Token(Token = "0x4000874")]
		[FieldOffset(Offset = "0x18")]
		private readonly bool _useSigV4;

		[Token(Token = "0x4000875")]
		[FieldOffset(Offset = "0x20")]
		private readonly RegionDetectionUpdater _regionDetector;

		[Token(Token = "0x4000876")]
		[FieldOffset(Offset = "0x0")]
		private static readonly HashSet<string> SignableParameters;

		[Token(Token = "0x4000877")]
		[FieldOffset(Offset = "0x8")]
		private static readonly HashSet<string> SubResourcesSigningExclusion;

		[Token(Token = "0x17000460")]
		public override ClientProtocol Protocol
		{
			[Token(Token = "0x60011A2")]
			[Address(RVA = "0x1267420", Offset = "0x1267420", VA = "0x1267420", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60011A0")]
		[Address(RVA = "0x12673B4", Offset = "0x12673B4", VA = "0x12673B4")]
		public S3Signer()
		{
		}

		[Token(Token = "0x60011A1")]
		[Address(RVA = "0x12673E4", Offset = "0x12673E4", VA = "0x12673E4")]
		public S3Signer(bool useSigV4, RegionDetectionUpdater regionDetector)
		{
		}

		[Token(Token = "0x60011A3")]
		[Address(RVA = "0x1267428", Offset = "0x1267428", VA = "0x1267428", Slot = "4")]
		public override void Sign(IRequest request, IClientConfig clientConfig, RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)
		{
		}

		[Token(Token = "0x60011A4")]
		[Address(RVA = "0x12677B4", Offset = "0x12677B4", VA = "0x12677B4")]
		public static void SignRequest(IRequest request, RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)
		{
		}

		[Token(Token = "0x60011A5")]
		[Address(RVA = "0x1267BF4", Offset = "0x1267BF4", VA = "0x1267BF4")]
		private static string BuildStringToSign(IRequest request)
		{
			return null;
		}

		[Token(Token = "0x60011A6")]
		[Address(RVA = "0x12687C4", Offset = "0x12687C4", VA = "0x12687C4")]
		private static string BuildCanonicalizedHeaders(IDictionary<string, string> headers)
		{
			return null;
		}

		[Token(Token = "0x60011A7")]
		[Address(RVA = "0x1268E24", Offset = "0x1268E24", VA = "0x1268E24")]
		private static string BuildCanonicalizedResource(IRequest request)
		{
			return null;
		}
	}
}
