using UnityEngine;

public class Gravity : MonoBehaviour
{
	[SerializeField]
	private bool twoD;

	[SerializeField]
	public float gravity;

	[SerializeField]
	private Vector3 extraGravity;

	private void OnEnable()
	{
	}

	public void UpdateGravity()
	{
	}

	public bool IsFake2D()
	{
		return false;
	}
}
