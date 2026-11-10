using UnityEngine;

public class ShadowProjector2D : MonoBehaviour
{
	public Vector3 Down = new Vector3(0f, -1f, 0f);

	public float Offset = 1f;

	public LayerMask GroundLayers;

	public float MaxHeight = 10f;

	public bool is2D;

	public float SizeMod = 1f;

	private float startOrthoSize;

	public Projector Projector { get; private set; }

	private void Start()
	{
		Projector = GetComponent<Projector>();
		if (Projector != null)
		{
			startOrthoSize = Projector.orthographicSize;
		}
	}

	private void Update()
	{
		if (is2D)
		{
			RaycastHit2D hit = Physics2D.Raycast(base.transform.position, Down, float.PositiveInfinity, GroundLayers);
			if (hit.transform != null)
			{
				SetProjector(hit.distance);
			}
		}
		else if (Physics.Raycast(base.transform.position, Down, out var hitInfo, float.PositiveInfinity, GroundLayers))
		{
			SetProjector(hitInfo.distance);
		}
	}

	private void SetProjector(float distance)
	{
		if (Projector != null)
		{
			Projector.farClipPlane = distance + Offset;
			Projector.nearClipPlane = distance - Offset;
			Projector.orthographicSize = Mathf.Lerp(startOrthoSize, 0f, distance / MaxHeight) * SizeMod;
		}
	}
}
