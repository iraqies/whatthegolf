using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.ComponentControls.Data
{
	[Serializable]
	[Token(Token = "0x2000318")]
	public sealed class CustomControllerSelector
	{
		[Token(Token = "0x4001042")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool _findUsingSourceId;

		[Token(Token = "0x4001043")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private int _sourceId;

		[Token(Token = "0x4001044")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _findUsingTag;

		[Token(Token = "0x4001045")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _tag;

		[Token(Token = "0x4001046")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _findInPlayer;

		[Token(Token = "0x4001047")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int _playerId;

		[Token(Token = "0x17000662")]
		public bool findUsingSourceId
		{
			[Token(Token = "0x60017CC")]
			[Address(RVA = "0x23752A4", Offset = "0x23752A4", VA = "0x23752A4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000663")]
		public int sourceId
		{
			[Token(Token = "0x60017CD")]
			[Address(RVA = "0x23752AC", Offset = "0x23752AC", VA = "0x23752AC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000664")]
		public bool findUsingTag
		{
			[Token(Token = "0x60017CE")]
			[Address(RVA = "0x23752B4", Offset = "0x23752B4", VA = "0x23752B4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000665")]
		public string tag
		{
			[Token(Token = "0x60017CF")]
			[Address(RVA = "0x23752BC", Offset = "0x23752BC", VA = "0x23752BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000666")]
		public bool findInPlayer
		{
			[Token(Token = "0x60017D0")]
			[Address(RVA = "0x23752C4", Offset = "0x23752C4", VA = "0x23752C4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000667")]
		public int playerId
		{
			[Token(Token = "0x60017D1")]
			[Address(RVA = "0x23752CC", Offset = "0x23752CC", VA = "0x23752CC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60017D2")]
		[Address(RVA = "0x23739CC", Offset = "0x23739CC", VA = "0x23739CC")]
		internal Rewired.CustomController GetCustomController()
		{
			return null;
		}

		[Token(Token = "0x60017D3")]
		[Address(RVA = "0x2371B8C", Offset = "0x2371B8C", VA = "0x2371B8C")]
		public CustomControllerSelector()
		{
		}
	}
}
