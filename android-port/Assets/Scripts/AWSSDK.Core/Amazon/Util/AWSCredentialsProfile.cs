using Amazon.Runtime;
using Amazon.Runtime.Internal.Settings;
using Il2CppDummyDll;

namespace Amazon.Util
{
	[Token(Token = "0x2000072")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x258B4", Offset = "0x258B4")]
	public class AWSCredentialsProfile : ProfileSettingsBase
	{
		[Token(Token = "0x4000243")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26508", Offset = "0x26508")]
		private BasicAWSCredentials Credentials__BackingField;

		[Token(Token = "0x170000F7")]
		public BasicAWSCredentials Credentials
		{
			[Token(Token = "0x6000420")]
			[Address(RVA = "0x11C03F8", Offset = "0x11C03F8", VA = "0x11C03F8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x285DC", Offset = "0x285DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000421")]
			[Address(RVA = "0x11C0400", Offset = "0x11C0400", VA = "0x11C0400")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x285EC", Offset = "0x285EC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x11C0408", Offset = "0x11C0408", VA = "0x11C0408")]
		public static bool CanCreateFrom(string profileName)
		{
			return default;
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x11C0420", Offset = "0x11C0420", VA = "0x11C0420")]
		public static bool CanCreateFrom(SettingsCollection.ObjectSettings os)
		{
			return default;
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x11C0778", Offset = "0x11C0778", VA = "0x11C0778")]
		public static AWSCredentialsProfile LoadFrom(string profileName)
		{
			return null;
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x11C0790", Offset = "0x11C0790", VA = "0x11C0790")]
		public static AWSCredentialsProfile LoadFrom(SettingsCollection.ObjectSettings os)
		{
			return null;
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x11C0A94", Offset = "0x11C0A94", VA = "0x11C0A94")]
		public static void Validate(string profileName)
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x11C0680", Offset = "0x11C0680", VA = "0x11C0680")]
		private static void Validate(SettingsCollection.ObjectSettings os)
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x11C0AAC", Offset = "0x11C0AAC", VA = "0x11C0AAC", Slot = "4")]
		public override string Persist()
		{
			return null;
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x11C0B14", Offset = "0x11C0B14", VA = "0x11C0B14")]
		public static string Persist(string profileName, string accessKeyId, string secretKey)
		{
			return null;
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x11C09AC", Offset = "0x11C09AC", VA = "0x11C09AC")]
		private AWSCredentialsProfile(string profileName, string accessKeyId, string secretKey)
		{
		}
	}
}
