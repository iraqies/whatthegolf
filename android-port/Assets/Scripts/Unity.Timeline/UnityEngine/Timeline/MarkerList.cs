using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	[Serializable]
	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x1BB8D0", Offset = "0x1BB8D0")]
	internal struct MarkerList : ISerializationCallbackReceiver
	{
		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<ScriptableObject> m_Objects;

		[NonSerialized]
		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x8")]
		private List<IMarker> m_Cache;

		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x10")]
		private bool m_CacheDirty;

		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x11")]
		private bool m_HasNotifications;

		[Token(Token = "0x1700008C")]
		public List<IMarker> markers
		{
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x2AE8088", Offset = "0x2AE8088", VA = "0x2AE8088")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008D")]
		public int Count
		{
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x2AE8A60", Offset = "0x2AE8A60", VA = "0x2AE8A60")]
			get
			{
				return default;
			}
		}

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x1700008E")]
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x2AE8AB4", Offset = "0x2AE8AB4", VA = "0x2AE8AB4")]
		public IMarker get_Item(int idx)
		{
			return null;
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x2AE834C", Offset = "0x2AE834C", VA = "0x2AE834C")]
		public MarkerList(int capacity)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x2AE8428", Offset = "0x2AE8428", VA = "0x2AE8428")]
		public void Add(ScriptableObject item)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x2AE84D8", Offset = "0x2AE84D8", VA = "0x2AE84D8")]
		public bool Remove(IMarker item)
		{
			return default;
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x2AE8888", Offset = "0x2AE8888", VA = "0x2AE8888")]
		public bool Remove(ScriptableObject item, TimelineAsset timelineAsset, PlayableAsset thingToDirty)
		{
			return default;
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x2AE89DC", Offset = "0x2AE89DC", VA = "0x2AE89DC")]
		public void Clear()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x2AE8A3C", Offset = "0x2AE8A3C", VA = "0x2AE8A3C")]
		public IEnumerable<IMarker> GetMarkers()
		{
			return null;
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x2AE8B30", Offset = "0x2AE8B30", VA = "0x2AE8B30")]
		public List<ScriptableObject> GetRawMarkerList()
		{
			return null;
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x2AE8B38", Offset = "0x2AE8B38", VA = "0x2AE8B38")]
		public IMarker CreateMarker(Type type, double time, TrackAsset owner)
		{
			return null;
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x2AE9048", Offset = "0x2AE9048", VA = "0x2AE9048")]
		public bool HasNotifications()
		{
			return default;
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x2AE906C", Offset = "0x2AE906C", VA = "0x2AE906C", Slot = "4")]
		private void UnityEngine_002EISerializationCallbackReceiver_002EOnBeforeSerialize()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x2AE9070", Offset = "0x2AE9070", VA = "0x2AE9070", Slot = "5")]
		private void UnityEngine_002EISerializationCallbackReceiver_002EOnAfterDeserialize()
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x2AE80AC", Offset = "0x2AE80AC", VA = "0x2AE80AC")]
		private void BuildCache()
		{
		}
	}
}
