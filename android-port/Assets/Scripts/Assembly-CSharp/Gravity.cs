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

	private void OnDestroy()
	{
		Physics.gravity = new Vector3(0f, -9.81f, 0f);
		Physics2D.gravity = new Vector2(0f, -9.81f);
	}
}
