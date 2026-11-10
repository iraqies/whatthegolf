using UnityEngine;

public class Gravity : MonoBehaviour
{
	[SerializeField] private bool twoD;
	[SerializeField] public float gravity = 10f;
	[SerializeField] private Vector3 extraGravity;

	private void OnEnable() => UpdateGravity();

	public void UpdateGravity()
	{
		Vector3 baseDir = twoD ? Vector3.back : Vector3.down;
		Physics.gravity = baseDir * gravity + extraGravity;
		Physics2D.gravity = Physics.gravity;
	}

	public bool IsFake2D() => twoD;
}
