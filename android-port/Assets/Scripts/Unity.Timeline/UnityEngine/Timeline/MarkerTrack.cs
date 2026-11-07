using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	[Serializable]
	[Token(Token = "0x200002A")]
	[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0x1BB908", Offset = "0x1BB908")]
	public class MarkerTrack : TrackAsset
	{
		[Token(Token = "0x1700008F")]
		public override IEnumerable<PlayableBinding> outputs
		{
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x2AE907C", Offset = "0x2AE907C", VA = "0x2AE907C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x2AE92E4", Offset = "0x2AE92E4", VA = "0x2AE92E4")]
		public MarkerTrack()
		{
		}
	}
}
