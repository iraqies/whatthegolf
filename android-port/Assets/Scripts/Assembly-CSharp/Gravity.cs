using UnityEngine;

public class Gravity : MonoBehaviour
{
	[SerializeField] private bool twoD;
	[SerializeField] public float gravity = 10f;
	[SerializeField] private Vector3 extraGravity;

	private void OnEnable() => UpdateGravity();
	private void OnDisable() => RestoreGravity();
	private void OnDestroy() => RestoreGravity();

	public void UpdateGravity()
	{
		Vector3 baseDir = twoD ? Vector3.back : Vector3.down;
		Physics.gravity = baseDir * gravity + extraGravity;
		Physics2D.gravity = Physics.gravity;
	}

	public bool IsFake2D() => twoD;

	private static void RestoreGravity()
	{
		foreach (var g in FindObjectsOfType<Gravity>())
		{
			if (g != null && g.isActiveAndEnabled && g.gameObject.activeInHierarchy)
			{
				g.UpdateGravity();
				return;
			}
		}
		if (FindObjectOfType<PhysicsOverride>() == null)
		{
			Physics.gravity = new Vector3(0f, -50f, 0f);
			Physics2D.gravity = new Vector2(0f, -50f);
		}
	}
}
