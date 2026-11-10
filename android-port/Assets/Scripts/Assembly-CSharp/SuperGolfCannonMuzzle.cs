using System.Collections;
using UnityEngine;

public class SuperGolfCannonMuzzle : MonoBehaviour
{
	public Transform BulletOrigin;

	public Transform MuzzleObject;

	public ParticleSystem Particles;

	public bool MoveCannonOnShot = true;

	public IEnumerator PreFireAnimation()
	{
		Vector3 backPos = Vector3.forward * -0.75f;
		yield return StartCoroutine(pTween.To(0.1f, delegate(float t)
		{
			if (MuzzleObject != null)
			{
				MuzzleObject.transform.localPosition = Vector3.Lerp(Vector3.zero, backPos, Mathf.Clamp01(t));
			}
		}));
		yield return StartCoroutine(pTween.To(1.4f, delegate(float t)
		{
			if (MuzzleObject != null)
			{
				MuzzleObject.transform.localPosition = Vector3.Lerp(backPos, Vector3.zero, Mathf.Clamp01(t));
			}
		}));
	}
}
