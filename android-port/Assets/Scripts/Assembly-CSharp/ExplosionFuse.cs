using System.Collections.Generic;
using UnityEngine;

public class ExplosionFuse : MonoBehaviour
{
	public Transform Fuse;

	public List<Transform> FusePoints;

	public float FuseMoveSpeed;

	public ExplosionBarrelHelper Barrel;

	public float NewPointDistance;

	private int nextPointIndex;

	private float speedRampUp;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
