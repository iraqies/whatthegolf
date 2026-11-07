using System.Collections;
using Audio;
using UnityEngine;

public class BirdGrowOnScare : MonoBehaviour
{
	public float growSizeFactor;

	public AnimationCurve curve;

	public float animationTime;

	public ClipSettingsCollection growStartClip;

	private BirdNPC bird;

	private void Awake()
	{
	}

	private void Bird_OnScared(BirdNPC obj)
	{
	}

	private IEnumerator GrowRoutine()
	{
		return null;
	}
}
