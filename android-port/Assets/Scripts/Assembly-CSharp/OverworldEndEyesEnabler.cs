using System.Collections;
using Audio;
using UnityEngine;

public class OverworldEndEyesEnabler : MonoBehaviour
{
	public InvisibleCullingObject culling;

	public Transform eyes;

	public OverworldBumper[] hitEyes;

	public Collider2D col;

	public ClipSettingsCollection FirstHitSFX;

	public ClipSettingsCollection enableSFX;

	public uint wwiseTrigger;

	private OverworldBumper[] allEyes;

	private void Start()
	{
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	private IEnumerator ShowEyes()
	{
		return null;
	}

	public void Reset()
	{
	}
}
