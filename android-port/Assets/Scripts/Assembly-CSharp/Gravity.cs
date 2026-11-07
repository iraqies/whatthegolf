using UnityEngine;

public class Gravity : MonoBehaviour
{
	[SerializeField] private bool twoD;
	[SerializeField] public float gravity = -9.81f;
	[SerializeField] private Vector3 extraGravity;

	private void OnEnable() => UpdateGravity();

	public void UpdateGravity()
	{
		float g = Mathf.Abs(gravity) > 0.01f ? -Mathf.Abs(gravity) : -9.81f;
		if (twoD)
			Physics2D.gravity = new Vector2(extraGravity.x, g + extraGravity.y);
		else
			Physics.gravity = new Vector3(extraGravity.x, g + extraGravity.y, extraGravity.z);
	}

	public bool IsFake2D() => twoD;
}
