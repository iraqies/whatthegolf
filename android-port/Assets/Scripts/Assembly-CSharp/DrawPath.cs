using UnityEngine;

public class DrawPath : MonoBehaviour
{
	public Color color = Color.red;

	public float minPosChangeBeforeDraw = 1f;

	public float segmentDuration = 5f;

	private Vector3 lastPos;

	private void Start()
	{
		lastPos = base.transform.position;
	}

	private void Update()
	{
		if (Vector3.Distance(base.transform.position, lastPos) > minPosChangeBeforeDraw)
		{
			Debug.DrawLine(lastPos, base.transform.position, color, segmentDuration);
			lastPos = base.transform.position;
		}
	}
}
