using System;
using Il2CppDummyDll;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner
{
	[Serializable]
	[Token(Token = "0x2001236")]
	public class SerializableLevelData : ISerializationCallbackReceiver
	{
		[Serializable]
		[Token(Token = "0x2001237")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x485B4", Offset = "0x485B4")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4006267")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4006268")]
			[FieldOffset(Offset = "0x8")]
			public static Func<SelectableData, bool> _003C_003E9__11_0;

			[Token(Token = "0x60053FC")]
			[Address(RVA = "0x18425E0", Offset = "0x18425E0", VA = "0x18425E0")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60053FD")]
			[Address(RVA = "0x18425E8", Offset = "0x18425E8", VA = "0x18425E8")]
			internal bool _003C_002Ector_003Eb__11_0(SelectableData s)
			{
				return default;
			}
		}

		[Token(Token = "0x400625B")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string m_SerializedGuid;

		[Token(Token = "0x400625C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string m_Name;

		[Token(Token = "0x400625D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string m_Description;

		[Token(Token = "0x400625E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int m_BallId;

		[Token(Token = "0x400625F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private byte[] m_SerializedThumbnail;

		[Token(Token = "0x4006260")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string m_SerializedLevelContentData;

		[Token(Token = "0x4006261")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool m_CanPublish;

		[Token(Token = "0x4006262")]
		[FieldOffset(Offset = "0x41")]
		[SerializeField]
		private bool m_Published;

		[Token(Token = "0x4006263")]
		[FieldOffset(Offset = "0x44")]
		private Guid m_Guid;

		[Token(Token = "0x4006264")]
		[FieldOffset(Offset = "0x58")]
		private Texture2D m_Thumbnail;

		[Token(Token = "0x4006265")]
		[FieldOffset(Offset = "0x60")]
		private LevelContentData m_LevelContentData;

		[Token(Token = "0x4006266")]
		[FieldOffset(Offset = "0x0")]
		public static string levelUrlBase;

		[Token(Token = "0x17000952")]
		public Guid guid
		{
			[Token(Token = "0x60053E8")]
			[Address(RVA = "0x168A1E4", Offset = "0x168A1E4", VA = "0x168A1E4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000953")]
		public string name
		{
			[Token(Token = "0x60053E9")]
			[Address(RVA = "0x168A1F4", Offset = "0x168A1F4", VA = "0x168A1F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60053EA")]
			[Address(RVA = "0x168A1FC", Offset = "0x168A1FC", VA = "0x168A1FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000954")]
		public string description
		{
			[Token(Token = "0x60053EB")]
			[Address(RVA = "0x168A204", Offset = "0x168A204", VA = "0x168A204")]
			get
			{
				return null;
			}
			[Token(Token = "0x60053EC")]
			[Address(RVA = "0x168A20C", Offset = "0x168A20C", VA = "0x168A20C")]
			set
			{
			}
		}

		[Token(Token = "0x17000955")]
		public Texture2D thumbnail
		{
			[Token(Token = "0x60053ED")]
			[Address(RVA = "0x168A214", Offset = "0x168A214", VA = "0x168A214")]
			get
			{
				return null;
			}
			[Token(Token = "0x60053EE")]
			[Address(RVA = "0x168A2E8", Offset = "0x168A2E8", VA = "0x168A2E8")]
			set
			{
			}
		}

		[Token(Token = "0x17000956")]
		public LevelContentData levelContentData
		{
			[Token(Token = "0x60053EF")]
			[Address(RVA = "0x168A2F0", Offset = "0x168A2F0", VA = "0x168A2F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000957")]
		public int ballID
		{
			[Token(Token = "0x60053F0")]
			[Address(RVA = "0x168A2F8", Offset = "0x168A2F8", VA = "0x168A2F8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000958")]
		public bool canPublish
		{
			[Token(Token = "0x60053F1")]
			[Address(RVA = "0x168A300", Offset = "0x168A300", VA = "0x168A300")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000959")]
		public bool published
		{
			[Token(Token = "0x60053F2")]
			[Address(RVA = "0x168A308", Offset = "0x168A308", VA = "0x168A308")]
			get
			{
				return default;
			}
			[Token(Token = "0x60053F3")]
			[Address(RVA = "0x168A310", Offset = "0x168A310", VA = "0x168A310")]
			set
			{
			}
		}

		[Token(Token = "0x1700095A")]
		public bool hasSerializedLevelContentData
		{
			[Token(Token = "0x60053F4")]
			[Address(RVA = "0x168A318", Offset = "0x168A318", VA = "0x168A318")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700095B")]
		public string url
		{
			[Token(Token = "0x60053F5")]
			[Address(RVA = "0x168A328", Offset = "0x168A328", VA = "0x168A328")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700095C")]
		public string shortGuid
		{
			[Token(Token = "0x60053F6")]
			[Address(RVA = "0x168A3B4", Offset = "0x168A3B4", VA = "0x168A3B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60053E7")]
		[Address(RVA = "0x168A048", Offset = "0x168A048", VA = "0x168A048")]
		public SerializableLevelData(LevelData levelData)
		{
		}

		[Token(Token = "0x60053F7")]
		[Address(RVA = "0x168A3C8", Offset = "0x168A3C8", VA = "0x168A3C8")]
		public void LoadContentData(ElementDatabase elementDatabase)
		{
		}

		[Token(Token = "0x60053F8")]
		[Address(RVA = "0x168A458", Offset = "0x168A458", VA = "0x168A458", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x60053F9")]
		[Address(RVA = "0x168A4DC", Offset = "0x168A4DC", VA = "0x168A4DC", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}
	}
}
