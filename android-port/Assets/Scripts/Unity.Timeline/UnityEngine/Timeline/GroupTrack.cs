using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	[Serializable]
	[Token(Token = "0x200002B")]
	[AttributeAttribute(Name = "SupportsChildTracksAttribute", RVA = "0x1BB970", Offset = "0x1BB970")]
	[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x1BB970", Offset = "0x1BB970")]
	public class GroupTrack : TrackAsset
	{
		[Token(Token = "0x17000090")]
		public override IEnumerable<PlayableBinding> outputs
		{
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x2AE7C74", Offset = "0x2AE7C74", VA = "0x2AE7C74", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x2AE7C6C", Offset = "0x2AE7C6C", VA = "0x2AE7C6C", Slot = "32")]
		internal override bool CanCompileClips()
		{
			return default;
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x2AE7CD8", Offset = "0x2AE7CD8", VA = "0x2AE7CD8")]
		public GroupTrack()
		{
		}
	}
}
