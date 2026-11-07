using System.Collections.Generic;
using UnityEngine;

public class CustomGravityFromNearestVert : MonoBehaviour
{
	public List<Collider2D> GravityColliders;

	public Collider2D Collider;

	public float GravityForce;

	public bool AutoAlignObject;

	private ConstantForce2D gravityForce;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}
}
