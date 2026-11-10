using UnityEngine;

namespace Hub
{
	public class MoveLineRendererWithTransform : MonoBehaviour
	{
		private LineRenderer _lineRenderer;

		private Vector3 lastTransformPosition;

		private void Awake()
		{
			_lineRenderer = GetComponent<LineRenderer>();
			lastTransformPosition = transform.position;
		}

		private void Update()
		{
			if (_lineRenderer == null)
			{
				return;
			}
			Vector3 curPos = transform.position;
			Vector3 delta = curPos - lastTransformPosition;
			if (delta.sqrMagnitude > 1e-6f)
			{
				int count = _lineRenderer.positionCount;
				for (int i = 0; i < count; i++)
				{
					_lineRenderer.SetPosition(i, _lineRenderer.GetPosition(i) + delta);
				}
				lastTransformPosition = curPos;
			}
		}
	}
}
