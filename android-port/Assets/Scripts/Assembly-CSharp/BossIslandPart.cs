using System.Collections.Generic;
using UnityEngine;
using Utility;

public class BossIslandPart : MonoBehaviour
{
	public Transform EndPoint;

	public List<Transform> DriveNodes;

	public ObjectPool<BossIslandPart> OwnerPool;

	public MeshRenderer IslandMesh;
}
