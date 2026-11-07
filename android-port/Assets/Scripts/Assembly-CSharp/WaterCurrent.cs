using System.Collections;
using UnityEngine;

public class WaterCurrent : MonoBehaviour
{
	private Vector3 startPosition;

	[SerializeField]
	private Vector3 velocity;

	private float maxDistance;

	private Rigidbody rigidbody;

	private void Awake()
	{
	}

	private IEnumerator Start()
	{
		return null;
	}
}
