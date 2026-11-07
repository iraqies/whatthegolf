using UnityEngine;

[ExecuteInEditMode]
public class VolumetricSphere : MonoBehaviour
{
	public float radius;

	public float density;

	public float exponent;

	public int maxPixelizationLevel;

	public bool enableLayersInterpolation;

	public bool debugSphere;

	private void Update()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
