using UnityEngine;

public class ScaleLogoToScreen : MonoBehaviour
{
	private void Start()
	{
		var col = GetComponentInChildren<Collider2D>();
		if (col == null || Camera.main == null)
			return;
		Bounds bounds = col.bounds;
		if (bounds.size.x <= 0.001f)
			return;
		Vector3 left = Camera.main.ScreenToWorldPoint(new Vector3(0f, Screen.height / 2, 0f));
		Vector3 right = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height / 2, 0f));
		float factor = (right.x - left.x) / bounds.size.x;
		Vector3 scaled = Vector3.ClampMagnitude(transform.localScale * factor, 1.6f);
		transform.localScale = new Vector3(scaled.x, scaled.y, transform.localScale.z);
	}
}
