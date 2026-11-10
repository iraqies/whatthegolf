using System.Collections.Generic;
using System.Linq;
using Core;
using UnityEngine;

public class MagnetCraneShooter : MonoBehaviour
{
	public GolfBallController Controller;

	public BoxCollider Magnet;

	public LayerMask AffectMask = ~0;

	public float MagnetDistance = 10f;

	public float MagnetForce;

	public ForceMode MagnetForceMode;

	public MeshRenderer MagnetRenderer;

	public Material CraneMaterial;

	public Color OnColor;

	public Color OffColor;

	private List<FixedJoint> stuckRigidbodies;

	private Rigidbody rigid;

	private AudioSource magnetSource;

	private bool attractingAny;

	private void Awake()
	{
		stuckRigidbodies = new List<FixedJoint>();
		rigid = GetComponent<Rigidbody>();
		magnetSource = GetComponent<AudioSource>();
		if (CraneMaterial != null)
		{
			CraneMaterial = Instantiate(CraneMaterial);
			if (MagnetRenderer != null)
				MagnetRenderer.sharedMaterial = CraneMaterial;
			CraneMaterial.color = OffColor;
		}
	}

	private void Update()
	{
		if (Controller != null && CraneMaterial != null)
		{
			Color targetColor = Controller.IsCharging ? OnColor : OffColor;
			CraneMaterial.color = Color.Lerp(CraneMaterial.color, targetColor, Time.deltaTime * 3f);
		}
		if (magnetSource != null)
		{
			float targetVol = attractingAny ? 0.3f : 0f;
			magnetSource.volume = Mathf.MoveTowards(magnetSource.volume, targetVol, Time.unscaledDeltaTime * 2f);
		}
	}

	private void FixedUpdate()
	{
		attractingAny = false;
		if (Controller == null)
			return;

		if (Controller.IsCharging && stuckRigidbodies != null && stuckRigidbodies.Count == 0 && Magnet != null)
		{
			Vector3 center = Magnet.transform.position + Magnet.center;
			Vector3 halfExtents = Magnet.size;
			RaycastHit[] hits = Physics.BoxCastAll(center, halfExtents, Vector3.down, Magnet.transform.rotation, MagnetDistance, AffectMask);
			if (hits != null && hits.Length > 0)
			{
				RaycastHit closest = hits.OrderBy(h => Vector3.Distance(h.transform.position, Magnet.transform.position)).First();
				if (closest.rigidbody != null && !closest.rigidbody.isKinematic)
				{
					if (!stuckRigidbodies.Any(r => r != null && r.gameObject == closest.transform.gameObject))
					{
						attractingAny = true;
						Vector3 dir = (center - closest.rigidbody.position).normalized;
						closest.rigidbody.AddForce(dir * MagnetForce, MagnetForceMode);
					}
				}
			}
		}
		else if (!Controller.IsCharging && stuckRigidbodies != null && stuckRigidbodies.Count > 0)
		{
			foreach (FixedJoint joint in stuckRigidbodies)
			{
				if (joint != null)
					Destroy(joint);
			}
			stuckRigidbodies.Clear();
		}
	}

	private void OnCollisionEnter(Collision other)
	{
		if (Controller == null || !Controller.IsCharging || other == null || other.rigidbody == null || other.rigidbody.isKinematic)
			return;
		if (other.gameObject.GetComponent<FixedJoint>() == null)
		{
			FixedJoint fj = other.gameObject.AddComponent<FixedJoint>();
			if (stuckRigidbodies != null)
				stuckRigidbodies.Add(fj);
			if (fj != null)
				fj.connectedBody = rigid;
		}
	}

	private void OnDrawGizmosSelected()
	{
		if (Magnet != null)
		{
			Vector3 center = Magnet.transform.position + Magnet.center;
			Gizmos.DrawLine(center, center + Vector3.down * MagnetDistance);
		}
	}
}
