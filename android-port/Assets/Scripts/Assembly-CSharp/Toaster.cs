using System;
using System.Collections;
using System.Collections.Generic;
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

	public float ToastForce;

	public List<AudioClip> ToastClip;

	public LevelEvent toasterExists;

	public LevelEvent toasterPopped;

	public float AutoResetTime;

	public bool UnparentToasts;

	public Collectable Collectable;

	public string ToasterId;

	public TransitionTextEffect ToasterEffect;

	public List<string> CollisionTags;

	private bool hasSprung;

	private float resetTimer;

	private List<Transform> toastTransforms;

	public Action<Toaster> onToast;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void ToastBread(bool hitByPlayer)
	{
	}

	public void ResetToaster()
	{
	}

	public void DestroyBread()
	{
	}

	private IEnumerator ToastRoutine(bool hitByPlayer)
	{
		return null;
	}

	private void OnCollisionEnter(Collision collision)
	{
	}
}
