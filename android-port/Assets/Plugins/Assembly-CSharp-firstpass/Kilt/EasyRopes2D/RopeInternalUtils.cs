using UnityEngine;

namespace Kilt.EasyRopes2D
{
	public static class RopeInternalUtils
	{
		public static Camera GetCameraThatDrawLayer(int p_layer)
		{
			return null;
		}

		public static void TryClearRigidBody2D(Rigidbody2D p_body)
		{
		}

		public static float GetObjectMass(GameObject p_object, bool p_includeChildrens = true, bool p_multiplyByGravityScale = true)
		{
			return 0f;
		}

		public static bool FindLineIntersection(Vector2 p_line1_p1, Vector2 p_line1_p2, Vector2 p_line2_p1, Vector2 p_line2_p2, ref Vector2 p_intersection)
		{
			return false;
		}

		public static Vector3 GetVectorDirection(Vector3 from, Vector3 to)
		{
			return default;
		}

		public static Vector3 RotateZ(Vector3 p, float angle)
		{
			return default;
		}

		public static bool IsPrefab(GameObject p_object)
		{
			return false;
		}

		public static T CopyComponent<T>(GameObject p_destination, T p_original, bool p_pasteAsValue = true, bool p_deleteOldOne = false) where T : Component
		{
			return null;
		}
	}
}
