using UnityEngine;

public class Katamari_GrowColliderWhenCollecting : MonoBehaviour
{
	public float GrowRate;

	public Transform trans;

	[SerializeField]
	private float duration;

	private Vector3 from;

	private Vector3 to;

	private void Awake()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}

	public void Grow()
	{
	}
}
