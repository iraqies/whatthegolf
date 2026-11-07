using UnityEngine;

public class IgnoreCollisionsSimple2D : MonoBehaviour
{
	[SerializeField]
	private GameObject Root;

	[SerializeField]
	private Collider2D[] IgnoreWith;

	[SerializeField]
	private bool ignore;

	private void Awake()
	{
	}
}
