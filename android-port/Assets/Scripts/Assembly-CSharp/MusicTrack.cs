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
	public float unityVolume = 1f;

	private void EnsureClips()
	{
		if (clips == null || clips.Count == 0)
			clips = new List<MusicClip>(GetComponentsInChildren<MusicClip>(true));
		if (files != null && clips != null)
		{
			foreach (var mc in clips)
			{
				if (mc != null && mc.clip == null)
				{
					var f = files.Find(x => x != null && x.clip != null && (x.id == mc.id || files.Count == 1));
					if (f != null) mc.clip = f.clip;
				}
			}
		}
	}

	public bool IsPlaying()
	{
		EnsureClips();
		if (clips == null) return false;
		foreach (var c in clips)
			if (c != null && c.IsPlaying()) return true;
		return false;
	}

	public void UpdatePlaying(float parentVolume, float parentFadeVolume)
	{
		EnsureClips();
		if (clips == null) return;
		foreach (var c in clips)
			c?.UpdatePlaying(parentVolume + volume, parentFadeVolume);
	}

	public void Stop()
	{
		EnsureClips();
		if (clips == null) return;
		foreach (var c in clips)
			c?.Stop();
	}

	public double GetLength()
	{
		EnsureClips();
		if (clips != null && clips.Count > 0 && clips[0] != null)
			return clips[0].GetLength();
		return 4.0;
	}

	public void Play(MusicSegment.PlayInfo info)
	{
		EnsureClips();
		if (clips != null && clips.Count > 0)
		{
			var c = clips[0];
			c?.Play(info);
		}
	}
}
