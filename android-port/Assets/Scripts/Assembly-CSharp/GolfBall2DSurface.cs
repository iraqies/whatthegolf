using UnityEngine;

public class GolfBall2DSurface : MonoBehaviour
{
	public GolfBall2DSurfaceMaterial Material;

	public Vector2 Point => base.transform.position;

	public Vector2 Normal => base.transform.up;
}
