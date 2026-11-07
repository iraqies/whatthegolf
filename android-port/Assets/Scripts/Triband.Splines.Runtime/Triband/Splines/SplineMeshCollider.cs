using UnityEngine;

namespace Triband.Splines
{
	public class SplineMeshCollider : MonoBehaviour
	{
		[SerializeField]
		private MeshCollider meshCollider;

		private void Reset()
		{
		}

		private void OnValidate()
		{
		}

		public void UpdateCollider(Mesh mesh)
		{
		}
	}
}
