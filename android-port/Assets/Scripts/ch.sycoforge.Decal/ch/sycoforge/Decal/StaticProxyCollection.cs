using System.Collections.Generic;
using UnityEngine;

namespace ch.sycoforge.Decal
{
	public class StaticProxyCollection : MonoBehaviour
	{
		public List<GameObject> Proxies;

		[SerializeField]
		public List<ProxyMesh> MeshProxies;

		public int GetStaticVertexCount()
		{
			return 0;
		}

		public Mesh GetMesh(GameObject obj)
		{
			return null;
		}

		public void InitializeProxies()
		{
		}

		public static Mesh CloneMesh(Mesh mesh)
		{
			return null;
		}

		private static int GetMeshHash(Mesh clone)
		{
			return 0;
		}
	}
}
