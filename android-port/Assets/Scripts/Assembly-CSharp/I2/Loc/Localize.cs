using System;
using System.Collections.Generic;
using System.Linq;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace I2.Loc
{
	[Token(Token = "0x20012F9")]
	public class Localize : MonoBehaviour
	{
		[Token(Token = "0x20012FA")]
		public enum TermModification
		{
			[Token(Token = "0x4006640")]
			DontModify = 0,
			[Token(Token = "0x4006641")]
			ToUpper = 1,
			[Token(Token = "0x4006642")]
			ToLower = 2,
			[Token(Token = "0x4006643")]
			ToUpperFirst = 3,
			[Token(Token = "0x4006644")]
			ToTitle = 4
		}

		[Serializable]
		[Token(Token = "0x20012FB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48AF0", Offset = "0x48AF0")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4006645")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4006646")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<UnityEngine.Object> _003C_003E9__49_0;

			[Token(Token = "0x4006647")]
			[FieldOffset(Offset = "0x10")]
			public static Func<UnityEngine.Object, string> _003C_003E9__49_1;

			[Token(Token = "0x4006648")]
			[FieldOffset(Offset = "0x18")]
			public static Func<IGrouping<string, UnityEngine.Object>, string> _003C_003E9__49_2;

			[Token(Token = "0x4006649")]
			[FieldOffset(Offset = "0x20")]
			public static Func<IGrouping<string, UnityEngine.Object>, UnityEngine.Object> _003C_003E9__49_3;

			[Token(Token = "0x6005829")]
			[Address(RVA = "0x17EECEC", Offset = "0x17EECEC", VA = "0x17EECEC")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x600582A")]
			[Address(RVA = "0x17EECF4", Offset = "0x17EECF4", VA = "0x17EECF4")]
			internal bool _003CUpdateAssetDictionary_003Eb__49_0(UnityEngine.Object x)
			{
				return default;
			}

			[Token(Token = "0x600582B")]
			[Address(RVA = "0x17EED64", Offset = "0x17EED64", VA = "0x17EED64")]
			internal string _003CUpdateAssetDictionary_003Eb__49_1(UnityEngine.Object o)
			{
				return null;
			}

			[Token(Token = "0x600582C")]
			[Address(RVA = "0x17EED80", Offset = "0x17EED80", VA = "0x17EED80")]
			internal string _003CUpdateAssetDictionary_003Eb__49_2(IGrouping<string, UnityEngine.Object> g)
			{
				return null;
			}

			[Token(Token = "0x600582D")]
			[Address(RVA = "0x17EEE30", Offset = "0x17EEE30", VA = "0x17EEE30")]
			internal UnityEngine.Object _003CUpdateAssetDictionary_003Eb__49_3(IGrouping<string, UnityEngine.Object> g)
			{
				return null;
			}
		}

		[Token(Token = "0x4006620")]
		[FieldOffset(Offset = "0x18")]
		public string mTerm;

		[Token(Token = "0x4006621")]
		[FieldOffset(Offset = "0x20")]
		public string mTermSecondary;

		[NonSerialized]
		[Token(Token = "0x4006622")]
		[FieldOffset(Offset = "0x28")]
		public string FinalTerm;

		[NonSerialized]
		[Token(Token = "0x4006623")]
		[FieldOffset(Offset = "0x30")]
		public string FinalSecondaryTerm;

		[Token(Token = "0x4006624")]
		[FieldOffset(Offset = "0x38")]
		public TermModification PrimaryTermModifier;

		[Token(Token = "0x4006625")]
		[FieldOffset(Offset = "0x3C")]
		public TermModification SecondaryTermModifier;

		[Token(Token = "0x4006626")]
		[FieldOffset(Offset = "0x40")]
		public string TermPrefix;

		[Token(Token = "0x4006627")]
		[FieldOffset(Offset = "0x48")]
		public string TermSuffix;

		[Token(Token = "0x4006628")]
		[FieldOffset(Offset = "0x50")]
		public bool LocalizeOnAwake;

		[Token(Token = "0x4006629")]
		[FieldOffset(Offset = "0x58")]
		private string LastLocalizedLanguage;

		[Token(Token = "0x400662A")]
		[FieldOffset(Offset = "0x60")]
		public bool IgnoreRTL;

		[Token(Token = "0x400662B")]
		[FieldOffset(Offset = "0x64")]
		public int MaxCharactersInRTL;

		[Token(Token = "0x400662C")]
		[FieldOffset(Offset = "0x68")]
		public bool IgnoreNumbersInRTL;

		[Token(Token = "0x400662D")]
		[FieldOffset(Offset = "0x69")]
		public bool CorrectAlignmentForRTL;

		[Token(Token = "0x400662E")]
		[FieldOffset(Offset = "0x6A")]
		public bool AddSpacesToJoinedLanguages;

		[Token(Token = "0x400662F")]
		[FieldOffset(Offset = "0x6B")]
		public bool AllowLocalizedParameters;

		[Token(Token = "0x4006630")]
		[FieldOffset(Offset = "0x70")]
		public List<UnityEngine.Object> TranslatedObjects;

		[NonSerialized]
		[Token(Token = "0x4006631")]
		[FieldOffset(Offset = "0x78")]
		public Dictionary<string, UnityEngine.Object> mAssetDictionary;

		[Token(Token = "0x4006632")]
		[FieldOffset(Offset = "0x80")]
		public UnityEvent LocalizeEvent;

		[Token(Token = "0x4006633")]
		[FieldOffset(Offset = "0x0")]
		public static string MainTranslation;

		[Token(Token = "0x4006634")]
		[FieldOffset(Offset = "0x8")]
		public static string SecondaryTranslation;

		[Token(Token = "0x4006635")]
		[FieldOffset(Offset = "0x10")]
		public static string CallBackTerm;

		[Token(Token = "0x4006636")]
		[FieldOffset(Offset = "0x18")]
		public static string CallBackSecondaryTerm;

		[Token(Token = "0x4006637")]
		[FieldOffset(Offset = "0x20")]
		public static Localize CurrentLocalizeComponent;

		[Token(Token = "0x4006638")]
		[FieldOffset(Offset = "0x88")]
		public bool AlwaysForceLocalize;

		[Token(Token = "0x4006639")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		public EventCallback LocalizeCallBack;

		[Token(Token = "0x400663A")]
		[FieldOffset(Offset = "0x98")]
		public bool mGUI_ShowReferences;

		[Token(Token = "0x400663B")]
		[FieldOffset(Offset = "0x99")]
		public bool mGUI_ShowTems;

		[Token(Token = "0x400663C")]
		[FieldOffset(Offset = "0x9A")]
		public bool mGUI_ShowCallback;

		[Token(Token = "0x400663D")]
		[FieldOffset(Offset = "0xA0")]
		public ILocalizeTarget mLocalizeTarget;

		[Token(Token = "0x400663E")]
		[FieldOffset(Offset = "0xA8")]
		public string mLocalizeTargetName;

		[Token(Token = "0x17000A0D")]
		public string Term
		{
			[Token(Token = "0x6005810")]
			[Address(RVA = "0x1544B50", Offset = "0x1544B50", VA = "0x1544B50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005811")]
			[Address(RVA = "0x1544B58", Offset = "0x1544B58", VA = "0x1544B58")]
			set
			{
			}
		}

		[Token(Token = "0x17000A0E")]
		public string SecondaryTerm
		{
			[Token(Token = "0x6005812")]
			[Address(RVA = "0x1544BD8", Offset = "0x1544BD8", VA = "0x1544BD8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005813")]
			[Address(RVA = "0x1544BE0", Offset = "0x1544BE0", VA = "0x1544BE0")]
			set
			{
			}
		}

		[Token(Token = "0x6005814")]
		[Address(RVA = "0x1544C7C", Offset = "0x1544C7C", VA = "0x1544C7C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005815")]
		[Address(RVA = "0x154562C", Offset = "0x154562C", VA = "0x154562C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6005816")]
		[Address(RVA = "0x1545634", Offset = "0x1545634", VA = "0x1545634")]
		public bool HasCallback()
		{
			return default;
		}

		[Token(Token = "0x6005817")]
		[Address(RVA = "0x1542CC8", Offset = "0x1542CC8", VA = "0x1542CC8")]
		public void OnLocalize(bool Force = false)
		{
		}

		[Token(Token = "0x6005818")]
		[Address(RVA = "0x15450F0", Offset = "0x15450F0", VA = "0x15450F0")]
		public bool FindTarget()
		{
			return default;
		}

		[Token(Token = "0x6005819")]
		[Address(RVA = "0x1545688", Offset = "0x1545688", VA = "0x1545688")]
		public void GetFinalTerms(out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x600581A")]
		[Address(RVA = "0x15457E4", Offset = "0x15457E4", VA = "0x15457E4")]
		public string GetMainTargetsText()
		{
			return null;
		}

		[Token(Token = "0x600581B")]
		[Address(RVA = "0x15458C0", Offset = "0x15458C0", VA = "0x15458C0")]
		public void SetFinalTerms(string Main, string Secondary, out string primaryTerm, out string secondaryTerm, bool RemoveNonASCII)
		{
		}

		[Token(Token = "0x600581C")]
		[Address(RVA = "0x1544B98", Offset = "0x1544B98", VA = "0x1544B98")]
		public void SetTerm(string primary)
		{
		}

		[Token(Token = "0x600581D")]
		[Address(RVA = "0x1544C28", Offset = "0x1544C28", VA = "0x1544C28")]
		public void SetTerm(string primary, string secondary)
		{
		}

		[Token(Token = "0x600581E")]
		internal T GetSecondaryTranslatedObj<T>(ref string mainTranslation, ref string secondaryTranslation) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x600581F")]
		[Address(RVA = "0x1544CC4", Offset = "0x1544CC4", VA = "0x1544CC4")]
		public void UpdateAssetDictionary()
		{
		}

		[Token(Token = "0x6005820")]
		internal T GetObject<T>(string Translation) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6005821")]
		private T GetTranslatedObject<T>(string Translation) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6005822")]
		[Address(RVA = "0x1545908", Offset = "0x1545908", VA = "0x1545908")]
		private void DeserializeTranslation(string translation, out string value, out string secondary)
		{
		}

		[Token(Token = "0x6005823")]
		public T FindTranslatedObject<T>(string value) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6005824")]
		[Address(RVA = "0x15459F4", Offset = "0x15459F4", VA = "0x15459F4")]
		public bool HasTranslatedObject(UnityEngine.Object Obj)
		{
			return default;
		}

		[Token(Token = "0x6005825")]
		[Address(RVA = "0x1545A88", Offset = "0x1545A88", VA = "0x1545A88")]
		public void AddTranslatedObject(UnityEngine.Object Obj)
		{
		}

		[Token(Token = "0x6005826")]
		[Address(RVA = "0x1545B30", Offset = "0x1545B30", VA = "0x1545B30")]
		public void SetGlobalLanguage(string Language)
		{
		}

		[Token(Token = "0x6005827")]
		[Address(RVA = "0x1545B98", Offset = "0x1545B98", VA = "0x1545B98")]
		public Localize()
		{
		}
	}
}
