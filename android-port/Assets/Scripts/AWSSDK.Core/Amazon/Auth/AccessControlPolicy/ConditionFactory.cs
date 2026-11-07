using System;
using Il2CppDummyDll;

namespace Amazon.Auth.AccessControlPolicy
{
	[Token(Token = "0x200025B")]
	public static class ConditionFactory
	{
		[Token(Token = "0x200025C")]
		public enum ArnComparisonType
		{
			[Token(Token = "0x4000891")]
			ArnEquals = 0,
			[Token(Token = "0x4000892")]
			ArnLike = 1,
			[Token(Token = "0x4000893")]
			ArnNotEquals = 2,
			[Token(Token = "0x4000894")]
			ArnNotLike = 3
		}

		[Token(Token = "0x200025D")]
		public enum DateComparisonType
		{
			[Token(Token = "0x4000896")]
			DateEquals = 0,
			[Token(Token = "0x4000897")]
			DateGreaterThan = 1,
			[Token(Token = "0x4000898")]
			DateGreaterThanEquals = 2,
			[Token(Token = "0x4000899")]
			DateLessThan = 3,
			[Token(Token = "0x400089A")]
			DateLessThanEquals = 4,
			[Token(Token = "0x400089B")]
			DateNotEquals = 5
		}

		[Token(Token = "0x200025E")]
		public enum IpAddressComparisonType
		{
			[Token(Token = "0x400089D")]
			IpAddress = 0,
			[Token(Token = "0x400089E")]
			NotIpAddress = 1
		}

		[Token(Token = "0x200025F")]
		public enum NumericComparisonType
		{
			[Token(Token = "0x40008A0")]
			NumericEquals = 0,
			[Token(Token = "0x40008A1")]
			NumericGreaterThan = 1,
			[Token(Token = "0x40008A2")]
			NumericGreaterThanEquals = 2,
			[Token(Token = "0x40008A3")]
			NumericLessThan = 3,
			[Token(Token = "0x40008A4")]
			NumericLessThanEquals = 4,
			[Token(Token = "0x40008A5")]
			NumericNotEquals = 5
		}

		[Token(Token = "0x2000260")]
		public enum StringComparisonType
		{
			[Token(Token = "0x40008A7")]
			StringEquals = 0,
			[Token(Token = "0x40008A8")]
			StringEqualsIgnoreCase = 1,
			[Token(Token = "0x40008A9")]
			StringLike = 2,
			[Token(Token = "0x40008AA")]
			StringNotEquals = 3,
			[Token(Token = "0x40008AB")]
			StringNotEqualsIgnoreCase = 4,
			[Token(Token = "0x40008AC")]
			StringNotLike = 5
		}

		[Token(Token = "0x400087F")]
		public const string CURRENT_TIME_CONDITION_KEY = "aws:CurrentTime";

		[Token(Token = "0x4000880")]
		public const string SECURE_TRANSPORT_CONDITION_KEY = "aws:SecureTransport";

		[Token(Token = "0x4000881")]
		public const string SOURCE_IP_CONDITION_KEY = "aws:SourceIp";

		[Token(Token = "0x4000882")]
		public const string USER_AGENT_CONDITION_KEY = "aws:UserAgent";

		[Token(Token = "0x4000883")]
		public const string EPOCH_TIME_CONDITION_KEY = "aws:EpochTime";

		[Token(Token = "0x4000884")]
		public const string REFERRER_CONDITION_KEY = "aws:Referer";

		[Token(Token = "0x4000885")]
		public const string SOURCE_ARN_CONDITION_KEY = "aws:SourceArn";

		[Token(Token = "0x4000886")]
		public const string S3_CANNED_ACL_CONDITION_KEY = "s3:x-amz-acl";

		[Token(Token = "0x4000887")]
		public const string S3_LOCATION_CONSTRAINT_CONDITION_KEY = "s3:LocationConstraint";

		[Token(Token = "0x4000888")]
		public const string S3_PREFIX_CONDITION_KEY = "s3:prefix";

		[Token(Token = "0x4000889")]
		public const string S3_DELIMITER_CONDITION_KEY = "s3:delimiter";

		[Token(Token = "0x400088A")]
		public const string S3_MAX_KEYS_CONDITION_KEY = "s3:max-keys";

		[Token(Token = "0x400088B")]
		public const string S3_COPY_SOURCE_CONDITION_KEY = "s3:x-amz-copy-source";

		[Token(Token = "0x400088C")]
		public const string S3_METADATA_DIRECTIVE_CONDITION_KEY = "s3:x-amz-metadata-directive";

		[Token(Token = "0x400088D")]
		public const string S3_VERSION_ID_CONDITION_KEY = "s3:VersionId";

		[Token(Token = "0x400088E")]
		public const string SNS_ENDPOINT_CONDITION_KEY = "sns:Endpoint";

		[Token(Token = "0x400088F")]
		public const string SNS_PROTOCOL_CONDITION_KEY = "sns:Protocol";

		[Token(Token = "0x60011C4")]
		[Address(RVA = "0x11E3960", Offset = "0x11E3960", VA = "0x11E3960")]
		public static Condition NewCondition(ArnComparisonType type, string key, string value)
		{
			return null;
		}

		[Token(Token = "0x60011C5")]
		[Address(RVA = "0x11E3A94", Offset = "0x11E3A94", VA = "0x11E3A94")]
		public static Condition NewCondition(string key, bool value)
		{
			return null;
		}

		[Token(Token = "0x60011C6")]
		[Address(RVA = "0x11E3BA8", Offset = "0x11E3BA8", VA = "0x11E3BA8")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x2C010", Offset = "0x2C010")]
		public static Condition NewCondition(DateComparisonType type, DateTime date)
		{
			return null;
		}

		[Token(Token = "0x60011C7")]
		[Address(RVA = "0x11E3D50", Offset = "0x11E3D50", VA = "0x11E3D50")]
		public static Condition NewConditionUtc(DateComparisonType type, DateTime date)
		{
			return null;
		}

		[Token(Token = "0x60011C8")]
		[Address(RVA = "0x11E3F0C", Offset = "0x11E3F0C", VA = "0x11E3F0C")]
		public static Condition NewIpAddressCondition(string ipAddressRange)
		{
			return null;
		}

		[Token(Token = "0x60011C9")]
		[Address(RVA = "0x11E3F18", Offset = "0x11E3F18", VA = "0x11E3F18")]
		public static Condition NewCondition(IpAddressComparisonType type, string ipAddressRange)
		{
			return null;
		}

		[Token(Token = "0x60011CA")]
		[Address(RVA = "0x11E4058", Offset = "0x11E4058", VA = "0x11E4058")]
		public static Condition NewCondition(NumericComparisonType type, string key, string value)
		{
			return null;
		}

		[Token(Token = "0x60011CB")]
		[Address(RVA = "0x11E418C", Offset = "0x11E418C", VA = "0x11E418C")]
		public static Condition NewCondition(StringComparisonType type, string key, string value)
		{
			return null;
		}

		[Token(Token = "0x60011CC")]
		[Address(RVA = "0x11E42C0", Offset = "0x11E42C0", VA = "0x11E42C0")]
		public static Condition NewSourceArnCondition(string arnPattern)
		{
			return null;
		}

		[Token(Token = "0x60011CD")]
		[Address(RVA = "0x11E4318", Offset = "0x11E4318", VA = "0x11E4318")]
		public static Condition NewSecureTransportCondition()
		{
			return null;
		}

		[Token(Token = "0x60011CE")]
		[Address(RVA = "0x11E4360", Offset = "0x11E4360", VA = "0x11E4360")]
		public static Condition NewCannedACLCondition(string cannedAcl)
		{
			return null;
		}

		[Token(Token = "0x60011CF")]
		[Address(RVA = "0x11E43B8", Offset = "0x11E43B8", VA = "0x11E43B8")]
		public static Condition NewEndpointCondition(string endpointPattern)
		{
			return null;
		}

		[Token(Token = "0x60011D0")]
		[Address(RVA = "0x11E4410", Offset = "0x11E4410", VA = "0x11E4410")]
		public static Condition NewProtocolCondition(string protocol)
		{
			return null;
		}
	}
}
