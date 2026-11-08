using UnityEngine;

public struct HitInfo
{
	public Vector3 point;
	public Vector3 incomingVelocity;
	public Vector3 impactOnNormal;
	public GameObject childHit;
	public GameObject otherHit;

	public HitInfo(Vector3 point, Vector3 impactOnNormal, GameObject childHit, GameObject otherHit)
	{
		this.point = point;
		this.incomingVelocity = impactOnNormal;
		this.impactOnNormal = impactOnNormal;
		this.childHit = childHit;
		this.otherHit = otherHit;
	}
}
