using UnityEngine;

public class ShadowProjector2D : MonoBehaviour
{
	public Vector3 Down;

	public float Offset;

	public LayerMask GroundLayers;

	public float MaxHeight;

	public bool is2D;

	public float SizeMod;

	private float startOrthoSize;

	public Projector Projector { get; private set; }

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void SetProjector(float distance)
	{
	}
}
