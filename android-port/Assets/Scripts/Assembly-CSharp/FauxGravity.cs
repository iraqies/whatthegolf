using System.Collections.Generic;
using UnityEngine;

public class FauxGravity : MonoBehaviour
{
	private Rigidbody[] r;

	public Transform center;

	public List<string> ignoreTags;

	public float force;

	[SerializeField]
	private bool _basedOnDist;

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}
}
