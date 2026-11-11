using System.Collections;
using System.Runtime.CompilerServices;
using Audio;
using CameraStack;
using Core;
using UnityEngine;

public class DominoBehavior : MonoBehaviour
{
	public AudioClip dominoSound;

	public int dominosInFront = 3;

	public bool followMe;

	public int dominoIndex;

	public DominoShooter shooter;

	private static float f = 1f;

	private bool collidedWith;

	private DrawDominos drawnDominos;

	private Rigidbody rb;

	private BoxCollider box;

	private AudioSource source;

	private float scaleAffectTargety;

	private float scale = 1f;

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
		f = 1f;
	}

	private void Awake()
	{
		drawnDominos = GetComponentInParent<DrawDominos>();
		rb = GetComponent<Rigidbody>();
		box = GetComponent<BoxCollider>();
		scale = transform.localScale.x;
		scaleAffectTargety = 1f / Mathf.Max(0.01f, scale);
		f = 1f;
		if (AudioManager.Instance != null)
		{
			source = gameObject.AddComponent<AudioSource>();
			source.clip = dominoSound;
			source.outputAudioMixerGroup = AudioManager.Instance.golf != null ? AudioManager.Instance.golf.GetMixerGroup() : null;
			source.volume = 0.5f;
			source.playOnAwake = false;
			source.spatialBlend = 0.5f;
		}
	}

	private void OnCollisionEnter(Collision other)
	{
		if (collidedWith || other == null || other.gameObject == null)
		{
			return;
		}
		if (other.gameObject.CompareTag("Domino"))
		{
			collidedWith = true;
			if (source != null)
			{
				source.pitch = Mathf.Clamp(f, 0.5f, 3f);
				if (f < 2f)
				{
					f *= 1.015f;
				}
				source.Play();
			}
			StartCoroutine(LayDown());
			StartCoroutine(Stroke());
			if (followMe && drawnDominos != null && drawnDominos.dominos != null)
			{
				int targetIdx = Mathf.Min(dominoIndex + dominosInFront, drawnDominos.dominos.Count - 1);
				if (targetIdx >= 0 && targetIdx < drawnDominos.dominos.Count && drawnDominos.dominos[targetIdx] != null && CameraManager.Instance != null)
				{
					CameraManager.Instance.FollowTarget(drawnDominos.dominos[targetIdx].transform);
				}
			}
		}
		else if (other.gameObject.CompareTag("OutOfBounds") || other.gameObject.CompareTag("OutOfBoundsReset"))
		{
			if (drawnDominos != null && drawnDominos.resetOnOutOfBounds)
			{
				Reset();
			}
		}
	}

	private IEnumerator LayDown()
	{
		if (rb == null)
		{
			yield break;
		}
		while (rb != null && rb.velocity.sqrMagnitude > 0.01f)
		{
			yield return new WaitForSeconds(0.25f);
		}
		if (rb != null)
		{
			rb.isKinematic = true;
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	private static IEnumerator Stroke()
	{
		yield return null;
	}

	public void Reset()
	{
		collidedWith = false;
		if (rb != null)
		{
			rb.isKinematic = false;
			rb.velocity = Vector3.zero;
			rb.angularVelocity = Vector3.zero;
		}
	}
}
