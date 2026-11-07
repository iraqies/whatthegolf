using System.Collections;
using Audio;
using UnityEngine;

public class AnimationActions : MonoBehaviour
{
	public Animator Animator;

	public Animator CameraController;

	public Transform RagdollRigRoot;

	public Transform RagdollRig;

	public Transform VikeOnCarRig;

	public GameObject Car;

	public GameObject FakeCar;

	public ClipSettingsCollection BangClips;

	public ClipSettingsCollection LiquidClips;

	public ClipSettingsCollection EngineStartClips;

	public void PlayBang()
	{
	}

	public void PlayLiquidSound()
	{
	}

	public void PlayEngineStart()
	{
	}

	public void ActivateCar()
	{
	}

	private IEnumerator ActivateCarRoutine()
	{
		return null;
	}

	private Transform FindMatchingBone(Rigidbody bone, Transform otherRig)
	{
		return null;
	}
}
