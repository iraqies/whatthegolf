using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Menu
{
	[Token(Token = "0x200105D")]
	public class MenuDialogueConfig : ScriptableObject
	{
		[Token(Token = "0x200105E")]
		public enum Type
		{
			[Token(Token = "0x4005655")]
			Default = 0,
			[Token(Token = "0x4005656")]
			SpecialDay = 1,
			[Token(Token = "0x4005657")]
			NewEpisode = 2,
			[Token(Token = "0x4005658")]
			Daily = 3,
			[Token(Token = "0x4005659")]
			Welcome = 4
		}

		[Token(Token = "0x200105F")]
		public enum EffectType
		{
			[Token(Token = "0x400565B")]
			None = 0,
			[Token(Token = "0x400565C")]
			HighlightBonusArrow = 1,
			[Token(Token = "0x400565D")]
			HighlightEpisodesArrow = 2,
			[Token(Token = "0x400565E")]
			Hide = 3
		}

		[Token(Token = "0x2001060")]
		public enum DisplayType
		{
			[Token(Token = "0x4005660")]
			Auto = 0,
			[Token(Token = "0x4005661")]
			Exclamation = 1,
			[Token(Token = "0x4005662")]
			OnHit = 2
		}

		[Serializable]
		[Token(Token = "0x2001061")]
		public class TextAndEffectType
		{
			[Token(Token = "0x4005663")]
			[FieldOffset(Offset = "0x10")]
			public string text;

			[Token(Token = "0x4005664")]
			[FieldOffset(Offset = "0x18")]
			public EffectType EffectType;

			[Token(Token = "0x6004985")]
			[Address(RVA = "0x17F59C4", Offset = "0x17F59C4", VA = "0x17F59C4")]
			public TextAndEffectType()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2001062")]
		public class Entry
		{
			[Token(Token = "0x4005665")]
			[FieldOffset(Offset = "0x10")]
			public Type type;

			[Token(Token = "0x4005666")]
			[FieldOffset(Offset = "0x18")]
			public List<TextAndEffectType> texts;

			[Token(Token = "0x4005667")]
			[FieldOffset(Offset = "0x20")]
			public List<UserCriteria> criteriaList;

			[Token(Token = "0x4005668")]
			[FieldOffset(Offset = "0x28")]
			public DisplayType displayType;

			[Token(Token = "0x170007C0")]
			public string SaveKey
			{
				[Token(Token = "0x6004987")]
				[Address(RVA = "0x17F5940", Offset = "0x17F5940", VA = "0x17F5940")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6004986")]
			[Address(RVA = "0x17F5840", Offset = "0x17F5840", VA = "0x17F5840")]
			public Entry(Entry entry)
			{
			}

			[Token(Token = "0x6004988")]
			[Address(RVA = "0x17F54A4", Offset = "0x17F54A4", VA = "0x17F54A4")]
			public bool HasBeenSeenBefore()
			{
				return default;
			}
		}

		[Serializable]
		[Token(Token = "0x2001063")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x477B4", Offset = "0x477B4")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4005669")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x400566A")]
			[FieldOffset(Offset = "0x8")]
			public static Func<Entry, bool> _003C_003E9__10_0;

			[Token(Token = "0x400566B")]
			[FieldOffset(Offset = "0x10")]
			public static Func<ContentPackDef, bool> _003C_003E9__10_1;

			[Token(Token = "0x400566C")]
			[FieldOffset(Offset = "0x18")]
			public static Func<UserCriteria, bool> _003C_003E9__11_3;

			[Token(Token = "0x600498A")]
			[Address(RVA = "0x17F5460", Offset = "0x17F5460", VA = "0x17F5460")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x600498B")]
			[Address(RVA = "0x17F5468", Offset = "0x17F5468", VA = "0x17F5468")]
			internal bool _003CGetTextType_003Eb__10_0(Entry e)
			{
				return default;
			}

			[Token(Token = "0x600498C")]
			[Address(RVA = "0x17F5558", Offset = "0x17F5558", VA = "0x17F5558")]
			internal bool _003CGetTextType_003Eb__10_1(ContentPackDef e)
			{
				return default;
			}

			[Token(Token = "0x600498D")]
			[Address(RVA = "0x17F557C", Offset = "0x17F557C", VA = "0x17F557C")]
			internal bool _003CGetEntry_003Eb__11_3(UserCriteria c)
			{
				return default;
			}
		}

		[Token(Token = "0x2001064")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x477C4", Offset = "0x477C4")]
		private sealed class _003C_003Ec__DisplayClass11_0
		{
			[Token(Token = "0x400566D")]
			[FieldOffset(Offset = "0x10")]
			public Type type;

			[Token(Token = "0x400566E")]
			[FieldOffset(Offset = "0x18")]
			public MenuDialogueConfig _003C_003E4__this;

			[Token(Token = "0x400566F")]
			[FieldOffset(Offset = "0x20")]
			public Func<Entry, bool> _003C_003E9__1;

			[Token(Token = "0x600498E")]
			[Address(RVA = "0x17F55E4", Offset = "0x17F55E4", VA = "0x17F55E4")]
			public _003C_003Ec__DisplayClass11_0()
			{
			}

			[Token(Token = "0x600498F")]
			[Address(RVA = "0x17F55EC", Offset = "0x17F55EC", VA = "0x17F55EC")]
			internal bool _003CGetEntry_003Eb__1(Entry e)
			{
				return default;
			}

			[Token(Token = "0x6004990")]
			[Address(RVA = "0x17F5610", Offset = "0x17F5610", VA = "0x17F5610")]
			internal Entry _003CGetEntry_003Eg__GetEntryOfType_007C0()
			{
				return null;
			}

			[Token(Token = "0x6004991")]
			[Address(RVA = "0x17F56D8", Offset = "0x17F56D8", VA = "0x17F56D8")]
			internal bool _003CGetEntry_003Eb__2(Entry e)
			{
				return default;
			}
		}

		[Token(Token = "0x4005651")]
		[FieldOffset(Offset = "0x18")]
		public string UserName;

		[Token(Token = "0x4005652")]
		[FieldOffset(Offset = "0x20")]
		public List<Entry> entries;

		[Token(Token = "0x4005653")]
		[FieldOffset(Offset = "0x28")]
		public int overrideEntryIndex;

		[Token(Token = "0x6004980")]
		[Address(RVA = "0x1561050", Offset = "0x1561050", VA = "0x1561050")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6004981")]
		[Address(RVA = "0x1561054", Offset = "0x1561054", VA = "0x1561054")]
		public bool TryGetText(out Entry entry)
		{
			return default;
		}

		[Token(Token = "0x6004982")]
		[Address(RVA = "0x1561200", Offset = "0x1561200", VA = "0x1561200")]
		private Type GetTextType(List<Type> typesTried)
		{
			return default;
		}

		[Token(Token = "0x6004983")]
		[Address(RVA = "0x15615E0", Offset = "0x15615E0", VA = "0x15615E0")]
		private Entry GetEntry(Type type)
		{
			return null;
		}

		[Token(Token = "0x6004984")]
		[Address(RVA = "0x1561A78", Offset = "0x1561A78", VA = "0x1561A78")]
		public MenuDialogueConfig()
		{
		}
	}
}
