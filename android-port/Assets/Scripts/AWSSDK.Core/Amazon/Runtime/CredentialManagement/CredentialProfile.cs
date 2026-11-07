using System;
using System.Collections.Generic;
using Amazon.Runtime.CredentialManagement.Internal;
using Il2CppDummyDll;

namespace Amazon.Runtime.CredentialManagement
{
	[Token(Token = "0x2000131")]
	public class CredentialProfile
	{
		[Serializable]
		[Token(Token = "0x2000132")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25C04", Offset = "0x25C04")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x400048B")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x400048C")]
			[FieldOffset(Offset = "0x8")]
			public static Func<KeyValuePair<string, string>, string> _003C_003E9__59_0;

			[Token(Token = "0x400048D")]
			[FieldOffset(Offset = "0x10")]
			public static Func<KeyValuePair<string, string>, string> _003C_003E9__59_1;

			[Token(Token = "0x60009D8")]
			[Address(RVA = "0x12899F0", Offset = "0x12899F0", VA = "0x12899F0")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60009D9")]
			[Address(RVA = "0x12899F8", Offset = "0x12899F8", VA = "0x12899F8")]
			internal string _003CGetPropertiesString_003Eb__59_0(KeyValuePair<string, string> p)
			{
				return null;
			}

			[Token(Token = "0x60009DA")]
			[Address(RVA = "0x1289A38", Offset = "0x1289A38", VA = "0x1289A38")]
			internal string _003CGetPropertiesString_003Eb__59_1(KeyValuePair<string, string> p)
			{
				return null;
			}
		}

		[Token(Token = "0x400047F")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, string> _properties;

		[Token(Token = "0x4000480")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26EB8", Offset = "0x26EB8")]
		private string Name__BackingField;

		[Token(Token = "0x4000481")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26EC8", Offset = "0x26EC8")]
		private CredentialProfileOptions Options__BackingField;

		[Token(Token = "0x4000482")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26ED8", Offset = "0x26ED8")]
		private RegionEndpoint Region__BackingField;

		[Token(Token = "0x4000483")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26EE8", Offset = "0x26EE8")]
		private Guid? UniqueKey__BackingField;

		[Token(Token = "0x4000484")]
		[FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26EF8", Offset = "0x26EF8")]
		private bool? EndpointDiscoveryEnabled__BackingField;

		[Token(Token = "0x4000485")]
		[FieldOffset(Offset = "0x46")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26F08", Offset = "0x26F08")]
		private bool? S3UseArnRegion__BackingField;

		[Token(Token = "0x4000486")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26F18", Offset = "0x26F18")]
		private StsRegionalEndpointsValue? StsRegionalEndpoints__BackingField;

		[Token(Token = "0x4000487")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26F28", Offset = "0x26F28")]
		private S3UsEast1RegionalEndpointValue? S3RegionalEndpoint__BackingField;

		[Token(Token = "0x4000488")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26F38", Offset = "0x26F38")]
		private RequestRetryMode? RetryMode__BackingField;

		[Token(Token = "0x4000489")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26F48", Offset = "0x26F48")]
		private int? MaxAttempts__BackingField;

		[Token(Token = "0x400048A")]
		[FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26F58", Offset = "0x26F58")]
		private ICredentialProfileStore CredentialProfileStore__BackingField;

		[Token(Token = "0x17000283")]
		public string Name
		{
			[Token(Token = "0x60009B4")]
			[Address(RVA = "0x11E678C", Offset = "0x11E678C", VA = "0x11E678C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29B3C", Offset = "0x29B3C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009B5")]
			[Address(RVA = "0x11E6794", Offset = "0x11E6794", VA = "0x11E6794")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29B4C", Offset = "0x29B4C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000284")]
		public CredentialProfileOptions Options
		{
			[Token(Token = "0x60009B6")]
			[Address(RVA = "0x11E679C", Offset = "0x11E679C", VA = "0x11E679C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29B5C", Offset = "0x29B5C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009B7")]
			[Address(RVA = "0x11E67A4", Offset = "0x11E67A4", VA = "0x11E67A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29B6C", Offset = "0x29B6C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000285")]
		public RegionEndpoint Region
		{
			[Token(Token = "0x60009B8")]
			[Address(RVA = "0x11E67AC", Offset = "0x11E67AC", VA = "0x11E67AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29B7C", Offset = "0x29B7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009B9")]
			[Address(RVA = "0x11E67B4", Offset = "0x11E67B4", VA = "0x11E67B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29B8C", Offset = "0x29B8C")]
			set
			{
			}
		}

		[Token(Token = "0x17000286")]
		internal Guid? UniqueKey
		{
			[Token(Token = "0x60009BA")]
			[Address(RVA = "0x11E67BC", Offset = "0x11E67BC", VA = "0x11E67BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29B9C", Offset = "0x29B9C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009BB")]
			[Address(RVA = "0x11E67D0", Offset = "0x11E67D0", VA = "0x11E67D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29BAC", Offset = "0x29BAC")]
			set
			{
			}
		}

		[Token(Token = "0x17000287")]
		public bool? EndpointDiscoveryEnabled
		{
			[Token(Token = "0x60009BC")]
			[Address(RVA = "0x11E67E4", Offset = "0x11E67E4", VA = "0x11E67E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29BBC", Offset = "0x29BBC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009BD")]
			[Address(RVA = "0x11E67EC", Offset = "0x11E67EC", VA = "0x11E67EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29BCC", Offset = "0x29BCC")]
			set
			{
			}
		}

		[Token(Token = "0x17000288")]
		public bool? S3UseArnRegion
		{
			[Token(Token = "0x60009BE")]
			[Address(RVA = "0x11E67F4", Offset = "0x11E67F4", VA = "0x11E67F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29BDC", Offset = "0x29BDC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009BF")]
			[Address(RVA = "0x11E67FC", Offset = "0x11E67FC", VA = "0x11E67FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29BEC", Offset = "0x29BEC")]
			set
			{
			}
		}

		[Token(Token = "0x17000289")]
		public StsRegionalEndpointsValue? StsRegionalEndpoints
		{
			[Token(Token = "0x60009C0")]
			[Address(RVA = "0x11E6804", Offset = "0x11E6804", VA = "0x11E6804")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29BFC", Offset = "0x29BFC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009C1")]
			[Address(RVA = "0x11E680C", Offset = "0x11E680C", VA = "0x11E680C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29C0C", Offset = "0x29C0C")]
			set
			{
			}
		}

		[Token(Token = "0x1700028A")]
		public S3UsEast1RegionalEndpointValue? S3RegionalEndpoint
		{
			[Token(Token = "0x60009C2")]
			[Address(RVA = "0x11E6814", Offset = "0x11E6814", VA = "0x11E6814")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29C1C", Offset = "0x29C1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009C3")]
			[Address(RVA = "0x11E681C", Offset = "0x11E681C", VA = "0x11E681C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29C2C", Offset = "0x29C2C")]
			set
			{
			}
		}

		[Token(Token = "0x1700028B")]
		public RequestRetryMode? RetryMode
		{
			[Token(Token = "0x60009C4")]
			[Address(RVA = "0x11E6824", Offset = "0x11E6824", VA = "0x11E6824")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29C3C", Offset = "0x29C3C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009C5")]
			[Address(RVA = "0x11E682C", Offset = "0x11E682C", VA = "0x11E682C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29C4C", Offset = "0x29C4C")]
			set
			{
			}
		}

		[Token(Token = "0x1700028C")]
		public int? MaxAttempts
		{
			[Token(Token = "0x60009C6")]
			[Address(RVA = "0x11E6834", Offset = "0x11E6834", VA = "0x11E6834")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29C5C", Offset = "0x29C5C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009C7")]
			[Address(RVA = "0x11E683C", Offset = "0x11E683C", VA = "0x11E683C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29C6C", Offset = "0x29C6C")]
			set
			{
			}
		}

		[Token(Token = "0x1700028D")]
		internal Dictionary<string, string> Properties
		{
			[Token(Token = "0x60009C8")]
			[Address(RVA = "0x11E6844", Offset = "0x11E6844", VA = "0x11E6844")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009C9")]
			[Address(RVA = "0x11E68C0", Offset = "0x11E68C0", VA = "0x11E68C0")]
			set
			{
			}
		}

		[Token(Token = "0x1700028E")]
		public bool CanCreateAWSCredentials
		{
			[Token(Token = "0x60009CA")]
			[Address(RVA = "0x11E68C8", Offset = "0x11E68C8", VA = "0x11E68C8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700028F")]
		public ICredentialProfileStore CredentialProfileStore
		{
			[Token(Token = "0x60009CB")]
			[Address(RVA = "0x11E69D8", Offset = "0x11E69D8", VA = "0x11E69D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29C7C", Offset = "0x29C7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009CC")]
			[Address(RVA = "0x11E69E0", Offset = "0x11E69E0", VA = "0x11E69E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29C8C", Offset = "0x29C8C")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000290")]
		public string CredentialDescription
		{
			[Token(Token = "0x60009CD")]
			[Address(RVA = "0x11E69E8", Offset = "0x11E69E8", VA = "0x11E69E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000291")]
		internal CredentialProfileType? ProfileType
		{
			[Token(Token = "0x60009CE")]
			[Address(RVA = "0x11E6964", Offset = "0x11E6964", VA = "0x11E6964")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000292")]
		internal bool IsCallbackRequired
		{
			[Token(Token = "0x60009CF")]
			[Address(RVA = "0x11E6DA4", Offset = "0x11E6DA4", VA = "0x11E6DA4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x11E6E6C", Offset = "0x11E6E6C", VA = "0x11E6E6C")]
		public CredentialProfile(string name, CredentialProfileOptions profileOptions)
		{
		}

		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x11E6F3C", Offset = "0x11E6F3C", VA = "0x11E6F3C")]
		public AWSCredentials GetAWSCredentials(ICredentialProfileSource profileSource)
		{
			return null;
		}

		[Token(Token = "0x60009D2")]
		[Address(RVA = "0x11E6FCC", Offset = "0x11E6FCC", VA = "0x11E6FCC")]
		internal AWSCredentials GetAWSCredentials(ICredentialProfileSource profileSource, bool nonCallbackOnly)
		{
			return null;
		}

		[Token(Token = "0x60009D3")]
		[Address(RVA = "0x11E7070", Offset = "0x11E7070", VA = "0x11E7070")]
		private string GetPropertiesString()
		{
			return null;
		}

		[Token(Token = "0x60009D4")]
		[Address(RVA = "0x11E738C", Offset = "0x11E738C", VA = "0x11E738C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60009D5")]
		[Address(RVA = "0x11E7A00", Offset = "0x11E7A00", VA = "0x11E7A00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default;
		}

		[Token(Token = "0x60009D6")]
		[Address(RVA = "0x11E80A4", Offset = "0x11E80A4", VA = "0x11E80A4", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}
	}
}
