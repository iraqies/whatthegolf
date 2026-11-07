using System.Collections.Generic;
using UnityEngine;

namespace ch.sycoforge.Decal
{
	[DisallowMultipleComponent]
	public abstract class MeshLink : MonoBehaviour
	{
		public List<MeshFilter> MeshFilters;
	}
}
