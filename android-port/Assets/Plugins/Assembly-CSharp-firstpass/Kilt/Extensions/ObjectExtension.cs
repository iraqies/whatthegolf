using UnityEngine;

namespace Kilt.Extensions
{
	public static class ObjectExtension
	{
		public static T[] GetNonMarkedComponentsInChildren<T>(this Component p_component, bool p_includeInactive = false, bool p_includeSelf = true, bool p_checkGameobject = false) where T : Component
		{
			return null;
		}

		public static T[] GetNonMarkedComponentsInParent<T>(this Component p_component, bool p_includeInactive = false, bool p_includeSelf = true, bool p_checkGameobject = false) where T : Component
		{
			return null;
		}

		public static T GetNonMarkedComponent<T>(this Component p_component, bool p_checkGameobject = false) where T : Component
		{
			return null;
		}

		public static T GetNonMarkedComponentInChildren<T>(this Component p_component, bool p_includeInactive = false, bool p_includeSelf = true, bool p_checkGameobject = false) where T : Component
		{
			return null;
		}

		public static T GetNonMarkedComponentInParent<T>(this Component p_component, bool p_includeInactive = false, bool p_includeSelf = true, bool p_checkGameobject = false) where T : Component
		{
			return null;
		}

		public static bool IsMarkedToDestroy(this Component p_component, bool p_checkGameObjectToo = false)
		{
			return false;
		}

		public static T[] GetNonMarkedComponentsInChildren<T>(this GameObject p_object, bool p_includeInactive = false, bool p_includeSelf = true, bool p_checkGameobject = false) where T : Component
		{
			return null;
		}

		public static T[] GetNonMarkedComponentsInParent<T>(this GameObject p_object, bool p_includeInactive = false, bool p_includeSelf = true, bool p_checkGameobject = false) where T : Component
		{
			return null;
		}

		public static T GetNonMarkedComponent<T>(this GameObject p_object, bool p_checkGameobject = false) where T : Component
		{
			return null;
		}

		public static T GetNonMarkedComponentInChildren<T>(this GameObject p_object, bool p_includeInactive = false, bool p_includeSelf = true, bool p_checkGameobject = false) where T : Component
		{
			return null;
		}

		public static T GetNonMarkedComponentInParent<T>(this GameObject p_object, bool p_includeInactive = false, bool p_includeSelf = true, bool p_checkGameobject = false) where T : Component
		{
			return null;
		}
	}
}
