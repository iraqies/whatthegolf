using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Token(Token = "0x20012EB")]
	[ExecuteInEditMode]
	public class LanguageSource : MonoBehaviour, ISerializationCallbackReceiver, ILanguageSource
	{
		[Token(Token = "0x20012EC")]
		public delegate void fnOnSourceUpdated(LanguageSourceData source, bool ReceivedNewData, string errorMsg);

		[Token(Token = "0x40065C6")]
		[FieldOffset(Offset = "0x18")]
		public LanguageSourceData mSource;

		[Token(Token = "0x40065C7")]
		[FieldOffset(Offset = "0x20")]
		public int version;

		[Token(Token = "0x40065C8")]
		[FieldOffset(Offset = "0x24")]
		public bool NeverDestroy;

		[Token(Token = "0x40065C9")]
		[FieldOffset(Offset = "0x25")]
		public bool UserAgreesToHaveItOnTheScene;

		[Token(Token = "0x40065CA")]
		[FieldOffset(Offset = "0x26")]
		public bool UserAgreesToHaveItInsideThePluginsFolder;

		[Token(Token = "0x40065CB")]
		[FieldOffset(Offset = "0x27")]
		public bool GoogleLiveSyncIsUptoDate;

		[Token(Token = "0x40065CC")]
		[FieldOffset(Offset = "0x28")]
		public List<Object> Assets;

		[Token(Token = "0x40065CD")]
		[FieldOffset(Offset = "0x30")]
		public string Google_WebServiceURL;

		[Token(Token = "0x40065CE")]
		[FieldOffset(Offset = "0x38")]
		public string Google_SpreadsheetKey;

		[Token(Token = "0x40065CF")]
		[FieldOffset(Offset = "0x40")]
		public string Google_SpreadsheetName;

		[Token(Token = "0x40065D0")]
		[FieldOffset(Offset = "0x48")]
		public string Google_LastUpdatedVersion;

		[Token(Token = "0x40065D1")]
		[FieldOffset(Offset = "0x50")]
		public LanguageSourceData.eGoogleUpdateFrequency GoogleUpdateFrequency;

		[Token(Token = "0x40065D2")]
		[FieldOffset(Offset = "0x54")]
		public float GoogleUpdateDelay;

		[Token(Token = "0x40065D3")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x59B4C", Offset = "0x59B4C")]
		private fnOnSourceUpdated m_Event_OnSourceUpdateFromGoogle;

		[Token(Token = "0x40065D4")]
		[FieldOffset(Offset = "0x60")]
		public List<LanguageData> mLanguages;

		[Token(Token = "0x40065D5")]
		[FieldOffset(Offset = "0x68")]
		public bool IgnoreDeviceLanguage;

		[Token(Token = "0x40065D6")]
		[FieldOffset(Offset = "0x6C")]
		public LanguageSourceData.eAllowUnloadLanguages _AllowUnloadingLanguages;

		[Token(Token = "0x40065D7")]
		[FieldOffset(Offset = "0x70")]
		public List<TermData> mTerms;

		[Token(Token = "0x40065D8")]
		[FieldOffset(Offset = "0x78")]
		public bool CaseInsensitiveTerms;

		[Token(Token = "0x40065D9")]
		[FieldOffset(Offset = "0x7C")]
		public LanguageSourceData.MissingTranslationAction OnMissingTranslation;

		[Token(Token = "0x40065DA")]
		[FieldOffset(Offset = "0x80")]
		public string mTerm_AppName;

		[Token(Token = "0x17000A09")]
		public LanguageSourceData SourceData
		{
			[Token(Token = "0x60057BC")]
			[Address(RVA = "0x1502FFC", Offset = "0x1502FFC", VA = "0x1502FFC", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x60057BD")]
			[Address(RVA = "0x1503004", Offset = "0x1503004", VA = "0x1503004", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x14000099")]
		public event fnOnSourceUpdated Event_OnSourceUpdateFromGoogle
		{
			[Token(Token = "0x60057BE")]
			[Address(RVA = "0x150300C", Offset = "0x150300C", VA = "0x150300C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x71E24", Offset = "0x71E24")]
			add
			{
			}
			[Token(Token = "0x60057BF")]
			[Address(RVA = "0x15030B0", Offset = "0x15030B0", VA = "0x15030B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x71E34", Offset = "0x71E34")]
			remove
			{
			}
		}

		[Token(Token = "0x60057C0")]
		[Address(RVA = "0x1503154", Offset = "0x1503154", VA = "0x1503154")]
		private void Awake()
		{
		}

		[Token(Token = "0x60057C1")]
		[Address(RVA = "0x1503200", Offset = "0x1503200", VA = "0x1503200")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60057C2")]
		[Address(RVA = "0x15032F4", Offset = "0x15032F4", VA = "0x15032F4")]
		public string GetSourceName()
		{
			return null;
		}

		[Token(Token = "0x60057C3")]
		[Address(RVA = "0x15033EC", Offset = "0x15033EC", VA = "0x15033EC", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x60057C4")]
		[Address(RVA = "0x15033F8", Offset = "0x15033F8", VA = "0x15033F8", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x60057C5")]
		[Address(RVA = "0x1503A60", Offset = "0x1503A60", VA = "0x1503A60")]
		public LanguageSource()
		{
		}
	}
}
