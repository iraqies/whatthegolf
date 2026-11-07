using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Token(Token = "0x2000006")]
public sealed class CinemachineShot : PlayableAsset, IPropertyPreview
{
	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x18")]
	public string DisplayName;

	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x20")]
	public ExposedReference<CinemachineVirtualCameraBase> VirtualCamera;

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x18FDA98", Offset = "0x18FDA98", VA = "0x18FDA98", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default;
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x18FDBD0", Offset = "0x18FDBD0", VA = "0x18FDBD0", Slot = "9")]
	public void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x18FE198", Offset = "0x18FE198", VA = "0x18FE198")]
	public CinemachineShot()
	{
	}
}
