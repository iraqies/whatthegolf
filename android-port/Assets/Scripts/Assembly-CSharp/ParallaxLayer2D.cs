using UnityEngine;

public class ParallaxLayer2D : MonoBehaviour
{
	public Camera Camera;

	[SerializeField]
	private float parallaxCoefficient;

	private Vector3 lastCameraPos;

	private void LateUpdate()
	{
	}
}
