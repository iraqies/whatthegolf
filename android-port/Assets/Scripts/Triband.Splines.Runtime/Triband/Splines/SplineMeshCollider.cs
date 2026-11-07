using UnityEngine;

namespace Triband.Splines
{
	public class SplineMeshCollider : MonoBehaviour
	{
		[SerializeField]
		private MeshCollider meshCollider;

		private void Reset()
		{
			if (meshCollider == null) meshCollider = GetComponent<MeshCollider>();
		}

		private void OnValidate() { }

		public void UpdateCollider(Mesh mesh)
		{
			if (meshCollider == null) meshCollider = GetComponent<MeshCollider>();
			if (meshCollider != null && mesh != null)
				meshCollider.sharedMesh = mesh;
		}
	}
}
