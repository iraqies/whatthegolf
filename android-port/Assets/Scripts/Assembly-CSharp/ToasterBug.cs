using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToasterBug : MonoBehaviour
{
	public List<Rigidbody> Toasts;

	public Transform Handle;

	public float HandleEndHeight;

	public float ToastForce;

	public List<AudioClip> ToastClip;

	private bool hasSprung;

	private void Awake()
	{
	}

	public void ToastBread()
	{
	}

	private IEnumerator ToastRoutine()
	{
		return null;
	}
}
