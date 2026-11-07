using Audio;
using MPuppet;
using UnityEngine;

public class MPuppetAudio : MonoBehaviour
{
	[SerializeField]
	private MPuppetController puppetController;

	[SerializeField]
	private ClipSettingsCollection sfxOnFootStep;

	[SerializeField]
	private MPuppetGrabBehaviour grabBehaviour;

	[SerializeField]
	private ClipSettingsCollection sfxOnGrab;

	[SerializeField]
	private ClipSettingsCollection sfxOnThrow;

	private void Awake()
	{
	}

	private void GrabBehaviour_OnThrow(GameObject arg1, Vector3 arg2)
	{
	}

	private void GrabBehaviour_OnGrab(GameObject obj)
	{
	}

	private void PuppetController_OnFootstep()
	{
	}
}
