using Audio;
using UnityEngine;
using UnityEngine.Events;

public class AmongUsCrewmateImposter : MonoBehaviour
{
	public GameObject HatItem;

	public ClipSettingsCollection gruntClipCollection;

	public ClipSettingsCollection impactClipCollection;

	private Transform position;

	public UnityEvent OnHit;

	private Animator animator;

	private bool isHit;

	private void Start()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void DefaultSetPos()
	{
	}

	private void Play()
	{
	}
}
