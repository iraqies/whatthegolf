using UnityEngine;

public class OpenIndicatorAnimation : MonoBehaviour
{
	[SerializeField]
	private float frequency = 2f;

	[SerializeField]
	private float distance = 0.25f;

	[SerializeField]
	private float offset = 0.25f;

	[SerializeField]
	private Transform arrowTransform;

	private void Update()
	{
		if (arrowTransform != null)
		{
			float y = Mathf.Sin(Time.time * frequency) * distance + offset;
			arrowTransform.localPosition = new Vector3(0f, y, 0f);
		}
	}
}
