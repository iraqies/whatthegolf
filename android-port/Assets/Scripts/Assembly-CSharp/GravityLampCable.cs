using UnityEngine;

public class GravityLampCable : MonoBehaviour
{
	public Transform TransformOrigin;

	public Transform TransformLamp;

	private LineRenderer CableRenderer;

	private void Awake()
	{
		CableRenderer = GetComponent<LineRenderer>();
	}

	private void OnEnable()
	{
		if (TransformOrigin != null && CableRenderer != null)
		{
			CableRenderer.SetPosition(0, TransformOrigin.position);
			CableRenderer.sortingOrder = -10;
		}
	}

	private void Update()
	{
		if (TransformLamp != null && CableRenderer != null)
		{
			CableRenderer.SetPosition(1, TransformLamp.position);
		}
	}
}
