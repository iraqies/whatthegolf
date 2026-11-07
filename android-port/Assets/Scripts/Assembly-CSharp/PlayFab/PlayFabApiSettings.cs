using System.Collections.Generic;
using Il2CppDummyDll;

namespace PlayFab
{
	[Token(Token = "0x200118A")]
	public class PlayFabApiSettings
	{
		[Token(Token = "0x4005EBB")]
		[FieldOffset(Offset = "0x10")]
		private string _ProductionEnvironmentUrl;

		[Token(Token = "0x4005EBC")]
		[FieldOffset(Offset = "0x18")]
		public readonly Dictionary<string, string> _requestGetParams;

		[Token(Token = "0x4005EBD")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5743C", Offset = "0x5743C")]
		private string TitleId__BackingField;

		[Token(Token = "0x4005EBE")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5744C", Offset = "0x5744C")]
		private string VerticalName__BackingField;

		[Token(Token = "0x4005EBF")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5745C", Offset = "0x5745C")]
		private string AdvertisingIdType__BackingField;

		[Token(Token = "0x4005EC0")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5746C", Offset = "0x5746C")]
		private string AdvertisingIdValue__BackingField;

		[Token(Token = "0x4005EC1")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5747C", Offset = "0x5747C")]
		private bool DisableAdvertising__BackingField;

		[Token(Token = "0x4005EC2")]
		[FieldOffset(Offset = "0x41")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5748C", Offset = "0x5748C")]
		private bool DisableDeviceInfo__BackingField;

		[Token(Token = "0x4005EC3")]
		[FieldOffset(Offset = "0x42")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5749C", Offset = "0x5749C")]
		private bool DisableFocusTimeCollection__BackingField;

		[Token(Token = "0x1700089D")]
		public virtual Dictionary<string, string> RequestGetParams
		{
			[Token(Token = "0x6005026")]
			[Address(RVA = "0x15E9E68", Offset = "0x15E9E68", VA = "0x15E9E68", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700089E")]
		public virtual string ProductionEnvironmentUrl
		{
			[Token(Token = "0x6005027")]
			[Address(RVA = "0x15E9E70", Offset = "0x15E9E70", VA = "0x15E9E70", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700089F")]
		public virtual string TitleId
		{
			[Token(Token = "0x6005028")]
			[Address(RVA = "0x15E9E78", Offset = "0x15E9E78", VA = "0x15E9E78", Slot = "6")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x70178", Offset = "0x70178")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008A0")]
		internal virtual string VerticalName
		{
			[Token(Token = "0x6005029")]
			[Address(RVA = "0x15E9E80", Offset = "0x15E9E80", VA = "0x15E9E80", Slot = "7")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x70188", Offset = "0x70188")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008A1")]
		public virtual bool DisableFocusTimeCollection
		{
			[Token(Token = "0x600502A")]
			[Address(RVA = "0x15E9E88", Offset = "0x15E9E88", VA = "0x15E9E88", Slot = "8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x70198", Offset = "0x70198")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600502B")]
		[Address(RVA = "0x15E9E90", Offset = "0x15E9E90", VA = "0x15E9E90", Slot = "9")]
		public virtual string GetFullUrl(string apiCall, Dictionary<string, string> getParams)
		{
			return null;
		}

		[Token(Token = "0x600502C")]
		[Address(RVA = "0x15E9F14", Offset = "0x15E9F14", VA = "0x15E9F14")]
		public PlayFabApiSettings()
		{
		}
	}
}
