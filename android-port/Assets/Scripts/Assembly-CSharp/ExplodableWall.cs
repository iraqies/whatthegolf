using Core;
using UnityEngine;

public class ExplodableWall : MonoBehaviour, IExplodable
{
	[SerializeField]
	private Transform centerOfForce;

	[SerializeField]
	private float explosionForce;

	private bool didCollapse;

	public void OnExplode()
	{
	}
}
