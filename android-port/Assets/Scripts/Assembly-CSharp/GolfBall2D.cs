using System.Collections.Generic;
using UnityEngine;

public class GolfBall2D : MonoBehaviour
{
	private GolfBall2DSurface surface;

	private List<GolfBall2DSurface> surfaces = new List<GolfBall2DSurface>();

	private Rigidbody2D rigidbody2D;

	private float radius;

	private float alignedWithGroundAngleMax = 5f;

	private float angularVelocityFrictionLimit = 1f;

	private float sleepTolerance = 0.001f;

	private void Awake()
	{
		rigidbody2D = GetComponent<Rigidbody2D>();
		radius = base.transform.localScale.x;
	}

	private void FixedUpdate()
	{
		if (surface == null || surface.Material == null || rigidbody2D == null)
		{
			return;
		}
		Vector2 ballPos = base.transform.position;
		Vector2 surfPos = surface.Point;
		Vector2 surfNormal = surface.Normal;
		float distAlongNormal = Vector2.Dot(ballPos - surfPos, surfNormal);
		float depthFactor = Mathf.Clamp01((radius + surface.Material.Depth - distAlongNormal) / (radius * 2f));
		float angDamp = Mathf.Clamp01(1f - depthFactor * surface.Material.AngularFriction * Time.deltaTime);
		rigidbody2D.angularVelocity *= angDamp;
		if (rigidbody2D.velocity.magnitude > sleepTolerance)
		{
			Vector2 velDir = rigidbody2D.velocity.normalized;
			float sinMax = Mathf.Sin(alignedWithGroundAngleMax * ((float)System.Math.PI / 180f));
			float angFactor = Mathf.Lerp(1f, 0f, Mathf.InverseLerp(0f, angularVelocityFrictionLimit, Mathf.Abs(rigidbody2D.angularVelocity)));
			float cross = Mathf.Abs(surfNormal.y * velDir.x - surfNormal.x * velDir.y);
			float alignFactor = ((sinMax > 1e-05f) ? (cross / sinMax * angFactor) : 0f);
			float linDamp = Mathf.Clamp01(1f - depthFactor * alignFactor * surface.Material.LinearFriction * Time.deltaTime);
			rigidbody2D.velocity *= linDamp;
		}
	}

	private void RefeshActiveSurface()
	{
		surface = ((surfaces != null && surfaces.Count > 0) ? surfaces[0] : null);
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision == null)
		{
			return;
		}
		GolfBall2DSurface surf = collision.GetComponent<GolfBall2DSurface>();
		if ((bool)surf && !surfaces.Contains(surf))
		{
			surfaces.Add(surf);
			RefeshActiveSurface();
		}
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		if (collision == null)
		{
			return;
		}
		GolfBall2DSurface surf = collision.GetComponent<GolfBall2DSurface>();
		if ((bool)surf && surfaces.Contains(surf))
		{
			surfaces.Remove(surf);
			RefeshActiveSurface();
		}
	}
}
