using System.Collections.Generic;
using UnityEngine;

namespace Audio
{
	public struct RigidbodyHierarchyInfo
	{
		public Rigidbody rootRB;

		public Rigidbody[] allRigids;

		public List<Rigidbody> rigidsOnice;

		public RigidbodyHierarchyInfo(Rigidbody rootRB, Rigidbody initRigid)
		{
			this.rootRB = null;
			allRigids = null;
			rigidsOnice = null;
		}
	}
}
