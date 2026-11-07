using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Serializable]
[Token(Token = "0x2000008")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x77EA4", Offset = "0x77EA4")]
[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0x77EA4", Offset = "0x77EA4")]
public class CinemachineTrack : TrackAsset
{
	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1903AE8", Offset = "0x1903AE8", VA = "0x1903AE8", Slot = "23")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default;
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1903BD4", Offset = "0x1903BD4", VA = "0x1903BD4")]
	public CinemachineTrack()
	{
	}
}
