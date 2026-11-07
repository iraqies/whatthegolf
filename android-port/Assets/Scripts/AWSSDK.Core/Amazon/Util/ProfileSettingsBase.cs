using Amazon.Runtime.Internal.Settings;
using Il2CppDummyDll;

namespace Amazon.Util
{
	[Token(Token = "0x2000071")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x2587C", Offset = "0x2587C")]
	public abstract class ProfileSettingsBase
	{
		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x264E8", Offset = "0x264E8")]
		private string Name__BackingField;

		[Token(Token = "0x4000242")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x264F8", Offset = "0x264F8")]
		private string UniqueId__BackingField;

		[Token(Token = "0x170000F5")]
		public string Name
		{
			[Token(Token = "0x6000419")]
			[Address(RVA = "0x1253270", Offset = "0x1253270", VA = "0x1253270")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2859C", Offset = "0x2859C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600041A")]
			[Address(RVA = "0x1253278", Offset = "0x1253278", VA = "0x1253278")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x285AC", Offset = "0x285AC")]
			protected set
			{
			}
		}

		[Token(Token = "0x170000F6")]
		public string UniqueId
		{
			[Token(Token = "0x600041B")]
			[Address(RVA = "0x1253280", Offset = "0x1253280", VA = "0x1253280")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x285BC", Offset = "0x285BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600041C")]
			[Address(RVA = "0x1253288", Offset = "0x1253288", VA = "0x1253288")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x285CC", Offset = "0x285CC")]
			protected set
			{
			}
		}

		[Token(Token = "0x600041D")]
		public abstract string Persist();

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x1253290", Offset = "0x1253290", VA = "0x1253290")]
		protected static SettingsCollection.ObjectSettings LoadCredentialsProfile(string profileName)
		{
			return null;
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x1253354", Offset = "0x1253354", VA = "0x1253354")]
		protected ProfileSettingsBase()
		{
		}
	}
}
