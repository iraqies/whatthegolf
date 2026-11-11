using System.Collections;
using System.Linq;
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
		if (BangClips != null)
		{
			BangClips.Play(null, transform.position, 1f, 1f);
		}
	}

	public void PlayLiquidSound()
	{
		if (LiquidClips != null)
		{
			LiquidClips.Play(null, transform.position, 1f, 1f);
		}
	}

	public void PlayEngineStart()
	{
		if (EngineStartClips != null)
		{
			EngineStartClips.Play(null, transform.position, 1f, 1f);
		}
	}

	public void ActivateCar()
	{
		StartCoroutine(ActivateCarRoutine());
	}

	private IEnumerator ActivateCarRoutine()
	{
		if (RagdollRig != null && VikeOnCarRig != null)
		{
			Rigidbody[] bones = RagdollRig.GetComponentsInChildren<Rigidbody>();
			if (bones != null)
			{
				for (int i = 0; i < bones.Length; i++)
				{
					Rigidbody bone = bones[i];
					if (bone == null)
					{
						continue;
					}
					bone.isKinematic = true;
					Collider col = bone.GetComponent<Collider>();
					if (col != null)
					{
						col.enabled = false;
					}
					Transform targetBone = FindMatchingBone(bone, VikeOnCarRig);
					if (targetBone != null)
					{
						Vector3 startPos = bone.transform.position;
						Quaternion startRot = bone.transform.rotation;
						StartCoroutine(pTween.To(0.25f, t =>
						{
							if (bone != null && targetBone != null)
							{
								float st = Mathf.Clamp01(TweenFunctions.SmoothStep(t));
								bone.transform.position = Vector3.Lerp(startPos, targetBone.position, st);
								bone.transform.rotation = Quaternion.Lerp(startRot, targetBone.rotation, st);
							}
						}));
					}
				}
			}
		}
		yield return new WaitForSeconds(0.25f);
		if (Car != null)
		{
			Car.SetActive(true);
		}
		if (FakeCar != null)
		{
			FakeCar.SetActive(false);
		}
		if (RagdollRigRoot != null)
		{
			RagdollRigRoot.gameObject.SetActive(false);
		}
		if (Animator != null)
		{
			Animator.enabled = false;
		}
		if (CameraController != null)
		{
			CameraController.SetTrigger("ActivateCar");
		}
	}

	private Transform FindMatchingBone(Rigidbody bone, Transform otherRig)
	{
		if (bone == null || otherRig == null)
		{
			return null;
		}
		Transform[] all = otherRig.GetComponentsInChildren<Transform>();
		return all != null ? all.FirstOrDefault(r => r != null && r.name == bone.name) : null;
	}
}
