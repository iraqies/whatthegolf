using System.Linq;
using Core;
using UnityEngine;
using UnityEngine.Events;

public class RagdollShooter : GolfBallShooterBase
{
	public float Force = 25f;

	public float Pitch;

	public Vector2 RandomRange = new Vector2(0.8f, 1.2f);

	public bool ignoreTail;

	public Rigidbody[] rigidbodies;

	public Rigidbody[] blacklist;

	public UnityEvent BeforeFirstShot;

	public bool FullPowerOnFirstShot;

	protected override void Awake()
	{
		base.Awake();
		rigidbodies = GetComponentsInChildren<Rigidbody>();
		if (blacklist != null && blacklist.Length > 0)
			rigidbodies = rigidbodies.Where(r => !blacklist.Contains(r)).ToArray();
		GolfBallController gbc = GolfBallController != null ? GolfBallController : GetComponentInParent<GolfBallController>();
		if (gbc != null && rigidbodies != null)
		{
			for (int i = 0; i < rigidbodies.Length; i++)
			{
				Rigidbody rb = rigidbodies[i];
				if (rb != null && rb.gameObject != gbc.gameObject)
				{
					var fwd = rb.gameObject.GetComponent<ChildOutOfBoundsForwarder>();
					if (fwd == null) fwd = rb.gameObject.AddComponent<ChildOutOfBoundsForwarder>();
					fwd.controller = gbc;
				}
			}
		}
	}

	public override void OnShoot(Vector3 boost)
	{
		if (BeforeFirstShot != null)
		{
			BeforeFirstShot.Invoke();
			BeforeFirstShot = null;
		}
		if (FullPowerOnFirstShot)
		{
			boost.Normalize();
			FullPowerOnFirstShot = false;
		}
		base.OnShoot(boost);
		if (Pitch != 0f && GolfBallController != null)
		{
			Vector3 normal = GolfBallController.GetPlane(GolfBallController.AimPlane).normal;
			Vector3 axis = Vector3.Cross(boost, normal);
			boost = Quaternion.AngleAxis(Pitch, axis) * boost;
		}
		if (rigidbodies == null || rigidbodies.Length == 0)
			rigidbodies = GetComponentsInChildren<Rigidbody>();
		for (int i = 0; i < rigidbodies.Length; i++)
		{
			Rigidbody rb = rigidbodies[i];
			if (rb == null) continue;
			if (ignoreTail && rb.gameObject.name.Length >= 4 && rb.gameObject.name.Substring(0, 4).Equals("tail", System.StringComparison.OrdinalIgnoreCase))
				continue;
			rb.isKinematic = false;
			rb.velocity = Vector3.zero;
			rb.angularVelocity = Vector3.zero;
			float rand = RandomRange.sqrMagnitude > 0.001f ? Random.Range(RandomRange.x, RandomRange.y) : 1f;
			rb.AddForce(boost * rand * (Force > 0f ? Force : 25f), ForceMode.Impulse);
		}
	}
}
