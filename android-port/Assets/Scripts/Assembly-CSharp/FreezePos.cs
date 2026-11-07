using UnityEngine;

public class FreezePos : MonoBehaviour
{
	[SerializeField]
	private Transform m_transform;

	[SerializeField]
	private bool freezeX;

	[SerializeField]
	private bool freezeY;

	[SerializeField]
	private bool freezeZ;

	private Vector3 savedInitialPos;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
