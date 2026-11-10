using UnityEngine;

public class AmongUsDisableLineOnHeight : MonoBehaviour
{
	public LineRenderer lineRenderer;

	public LineRope lineRope;

	public float heightCapValue;

	private void Update()
	{
		if (base.transform.position.y < heightCapValue)
		{
			if (lineRope != null)
			{
				lineRope.enabled = false;
			}
			if (lineRenderer != null)
			{
				lineRenderer.enabled = false;
			}
		}
		if (base.transform.position.y > heightCapValue)
		{
			if (lineRope != null)
			{
				lineRope.enabled = true;
			}
			if (lineRenderer != null)
			{
				lineRenderer.enabled = true;
			}
		}
	}
}
