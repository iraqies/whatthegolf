using UnityEngine;

public static class VectorExtensions
{
	public static Vector3 Rotate(this Vector3 vector, Quaternion rotation) => rotation * vector;

	public static Vector3 WithX(this Vector3 vector3, float newX) => new Vector3(newX, vector3.y, vector3.z);

	public static Vector3 WithY(this Vector3 vector3, float newY) => new Vector3(vector3.x, newY, vector3.z);
}
