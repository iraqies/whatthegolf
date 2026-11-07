using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceOnEnable2D : MonoBehaviour
{
	public Rigidbody2D rigid;

	public List<AudioClip> clips;

	public float Delay;

	public Vector3 Force;

	public float Torque;

	private Vector3 position;

	private Quaternion rotation;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private IEnumerator PopToast()
	{
		return null;
	}
}
