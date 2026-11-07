using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using WwiseData;
using WwiseInteractiveMusicHierarchyData;

[Serializable]
public class MusicTrack : MonoBehaviour
{
	[Serializable]
	public class AudioclipInfo
	{
		public AudioClip clip;

		public AssetReference clipAssetReference;

		public string id;

		public string filename;

		public AsyncOperationHandle<AudioClip> asyncOperationHandle;
	}

	public PurpleMusicTrack data;

	public FluffyMusicTrack dataOther;

	public WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerChildrenListMusicPlaylistContainerChildrenListMusicSegmentMusicTrack updateData;

	public List<AudioclipInfo> files;

	public float volume;

	public bool hasRTPCurve;

	public string rtpcName;

	public string rtpcRef;

	public AnimationCurve rtpcDataCurve;

	public Dictionary<string, int> clipCounter;

	public bool overrideTempo;

	public double tempo;

	public double playAt;

	public double currentTime;

	public List<MusicClip> clips;

	public float rtpcValue;

	public float currentVolume;

	public float unityVolume;

	public bool IsPlaying()
	{
		return false;
	}

	public void UpdatePlaying(float parentVolume, float parentFadeVolume)
	{
	}

	public void Stop()
	{
	}

	public double GetLength()
	{
		return 0.0;
	}

	public void Play(MusicSegment.PlayInfo info)
	{
	}
}
