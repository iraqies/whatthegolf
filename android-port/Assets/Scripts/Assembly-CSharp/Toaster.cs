using System;
using System.Collections;
using System.Collections.Generic;
using Core;
using UnityEngine;

public class Toaster : MonoBehaviour
{
	public List<Rigidbody> Toasts;

	private Vector3[] originalToastPositions;

	private Vector3 originalToasterPosition;

	private Quaternion originalToasterRotation;

	private Vector3 originalHandlePosition;

	private Rigidbody rigid;

	[SerializeField]
	private bool isEditorToaster;

	public Transform Handle;

	public float HandleEndHeight;

	public float ToastForce = 10f;

	public List<AudioClip> ToastClip;

	public LevelEvent toasterExists;

	public LevelEvent toasterPopped;

	public float AutoResetTime = float.PositiveInfinity;

	public bool UnparentToasts = true;

	public Collectable Collectable;

	public string ToasterId;

	public TransitionTextEffect ToasterEffect;

	public List<string> CollisionTags = new List<string> { "Player" };

	private bool hasSprung;

	private float resetTimer;

	private List<Transform> toastTransforms;

	public Action<Toaster> onToast;

	private void Awake()
	{
		toastTransforms = new List<Transform>();
		rigid = GetComponent<Rigidbody>();
		originalToasterPosition = transform.position;
		if (Handle != null)
			originalHandlePosition = Handle.localPosition;
		originalToasterRotation = transform.rotation;

		int count = Toasts != null ? Toasts.Count : 2;
		originalToastPositions = new Vector3[Mathf.Max(2, count)];

		if (Toasts != null)
		{
			for (int i = 0; i < Toasts.Count; i++)
			{
				var rb = Toasts[i];
				if (rb == null) continue;
				if (i < originalToastPositions.Length)
					originalToastPositions[i] = rb.transform.localPosition;
				if (UnparentToasts)
				{
					rb.transform.SetParent(null);
					if (gameObject.scene.IsValid() && rb.gameObject.scene != gameObject.scene)
						UnityEngine.SceneManagement.SceneManager.MoveGameObjectToScene(rb.gameObject, gameObject.scene);
				}
				else
				{
					toastTransforms.Add(rb.transform);
					Destroy(rb);
				}
			}
			if (!UnparentToasts && !isEditorToaster)
				Toasts.Clear();
		}
	}

	private void Update()
	{
		if (hasSprung && !float.IsInfinity(AutoResetTime) && !float.IsNaN(AutoResetTime))
		{
			resetTimer += Time.deltaTime;
			if (resetTimer >= AutoResetTime)
			{
				if (Toasts != null)
				{
					foreach (var rb in Toasts)
					{
						if (rb != null)
							rb.isKinematic = true;
					}
				}
				hasSprung = false;
				resetTimer = 0f;
			}
		}
	}

	public void ToastBread()
	{
		ToastBread(true);
	}

	public void ToastBread(bool hitByPlayer)
	{
		if (hasSprung)
			return;
		hasSprung = true;
		onToast?.Invoke(this);
		StartCoroutine(ToastRoutine(hitByPlayer));
	}

	public void ResetToaster()
	{
		StopAllCoroutines();
		transform.position = originalToasterPosition;
		transform.rotation = originalToasterRotation;
		if (rigid != null)
		{
			rigid.velocity = Vector3.zero;
			rigid.angularVelocity = Vector3.zero;
		}
		if (hasSprung && Toasts != null && Toasts.Count >= 1)
		{
			for (int i = 0; i < Toasts.Count; i++)
			{
				var rb = Toasts[i];
				if (rb == null) continue;
				rb.isKinematic = true;
				rb.transform.SetParent(transform);
				if (originalToastPositions != null && i < originalToastPositions.Length)
					rb.transform.localPosition = originalToastPositions[i];
				rb.transform.rotation = Quaternion.Euler(Vector3.zero);
			}
		}
		hasSprung = false;
		if (Handle != null)
			Handle.localPosition = originalHandlePosition;
		Awake();
	}

	public void DestroyBread()
	{
		if (Toasts != null)
		{
			for (int i = 0; i < Toasts.Count; i++)
			{
				if (Toasts[i] != null)
					Destroy(Toasts[i].gameObject);
			}
		}
	}

	private IEnumerator ToastRoutine(bool hitByPlayer)
	{
		if (AudioManager.Instance != null && AudioManager.Instance.sfx != null && ToastClip != null && ToastClip.Count > 0)
		{
			AudioManager.Instance.sfx.Play(ToastClip, s =>
			{
				if (s != null)
				{
					s.transform.position = transform.position;
					s.volume = 1f;
				}
			}, true, 0f, false);
		}

		Vector3 handleStartPos = Handle != null ? Handle.localPosition : Vector3.zero;
		yield return pTween.To(0.1f, t =>
		{
			if (Handle != null)
			{
				Vector3 localUp = Handle.InverseTransformDirection(transform.up);
				Handle.localPosition = handleStartPos + localUp * (HandleEndHeight - handleStartPos.y) * Mathf.Clamp01(t);
			}
		});

		if (toastTransforms != null && Toasts != null)
		{
			foreach (var tr in toastTransforms)
			{
				if (tr != null)
				{
					var rb = tr.gameObject.GetComponent<Rigidbody>();
					if (rb == null)
						rb = tr.gameObject.AddComponent<Rigidbody>();
					if (!Toasts.Contains(rb))
						Toasts.Add(rb);
				}
			}
		}

		if (Toasts != null)
		{
			foreach (var rb in Toasts)
			{
				if (rb == null) continue;
				rb.isKinematic = false;
				rb.AddForce(transform.up * ToastForce + UnityEngine.Random.insideUnitSphere, ForceMode.Impulse);
				rb.AddTorque(UnityEngine.Random.insideUnitSphere * 10f, ForceMode.Impulse);
			}
		}

		yield return new WaitForSeconds(0.1f);

		if (Toasts != null)
		{
			foreach (var rb in Toasts)
			{
				if (rb == null) continue;
				rb.AddTorque(UnityEngine.Random.insideUnitSphere * 10f, ForceMode.Impulse);
			}
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision == null || collision.transform == null)
			return;
		if (CollisionTags != null && CollisionTags.Contains(collision.transform.tag))
		{
			ToastBread(true);
		}
	}
}
