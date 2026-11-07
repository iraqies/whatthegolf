using System.Collections.Generic;
using Audio;
using UnityEngine;

public class PoloRingHitCounter : MonoBehaviour
{
	public Animator FlagAnimator;

	public List<PoloRing> Rings;

	public ClipSettingsCollection AllHitClip;

	private int counter;

	private void Start()
	{
	}

	private void OnRingHit(PoloRing obj)
	{
	}
}
