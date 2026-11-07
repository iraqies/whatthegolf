using System.Collections.Generic;
using UnityEngine;

public class GolfTarget : MonoBehaviour
{
	public List<AudioClip> HitClips;

	public bool isCompleted;

	public LayerMask AcceptedLayers;

	public IncrementLevelMusicRTPC IncrementRTPC;

	private void OnCollisionEnter(Collision collision)
	{
	}
}
