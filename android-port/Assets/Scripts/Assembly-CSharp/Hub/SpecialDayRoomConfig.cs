using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Hub
{
	[Token(Token = "0x2001089")]
	public class SpecialDayRoomConfig : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x200108A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x479F4", Offset = "0x479F4")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40056F8")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40056F9")]
			[FieldOffset(Offset = "0x8")]
			public static Func<SpecialDayStage, bool> _003C_003E9__6_0;

			[Token(Token = "0x6004A2C")]
			[Address(RVA = "0x1856308", Offset = "0x1856308", VA = "0x1856308")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6004A2D")]
			[Address(RVA = "0x1856310", Offset = "0x1856310", VA = "0x1856310")]
			internal bool _003Cget_LiveStage_003Eb__6_0(SpecialDayStage s)
			{
				return default;
			}
		}

		[Token(Token = "0x40056F7")]
		[FieldOffset(Offset = "0x18")]
		public List<SpecialDayStage> Stages;

		[Token(Token = "0x170007CE")]
		public SpecialDayStage PostStage
		{
			[Token(Token = "0x6004A25")]
			[Address(RVA = "0x16C9770", Offset = "0x16C9770", VA = "0x16C9770")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007CF")]
		public List<SpecialDayStage> PreStages
		{
			[Token(Token = "0x6004A26")]
			[Address(RVA = "0x16CB6CC", Offset = "0x16CB6CC", VA = "0x16CB6CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007D0")]
		public SpecialDayStage LiveStage
		{
			[Token(Token = "0x6004A27")]
			[Address(RVA = "0x16C982C", Offset = "0x16C982C", VA = "0x16C982C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004A28")]
		[Address(RVA = "0x16CB7AC", Offset = "0x16CB7AC", VA = "0x16CB7AC")]
		public SpecialDayRoomConfig()
		{
		}

		[Token(Token = "0x6004A29")]
		[Address(RVA = "0x16CB7B4", Offset = "0x16CB7B4", VA = "0x16CB7B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F444", Offset = "0x6F444")]
		private bool _003Cget_PostStage_003Eb__2_0(SpecialDayStage s)
		{
			return default;
		}

		[Token(Token = "0x6004A2A")]
		[Address(RVA = "0x16CB848", Offset = "0x16CB848", VA = "0x16CB848")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F454", Offset = "0x6F454")]
		private bool _003Cget_PreStages_003Eb__4_0(SpecialDayStage s)
		{
			return default;
		}
	}
}
