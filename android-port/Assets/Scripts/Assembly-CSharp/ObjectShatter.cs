using System;
using Chronos;
using UnityEngine;

public class ObjectShatter : MonoBehaviour
{
	public bool UseTimelines = true;

	public bool UnparentAllRigidbodies;

	private RigidbodyTimeline3D[] rigidbodiesTimeline;

	private Rigidbody[] rigidbodies;

	private bool hasShattered;

	private void Start()
	{
		if (UseTimelines)
		{
			Timeline[] timelines = GetComponentsInChildren<Timeline>();
			if (timelines != null && timelines.Length > 0)
			{
				var list = new System.Collections.Generic.List<RigidbodyTimeline3D>();
				for (int i = 0; i < timelines.Length; i++)
				{
					if (timelines[i] != null && timelines[i].rigidbody != null)
						list.Add(timelines[i].rigidbody);
				}
				rigidbodiesTimeline = list.ToArray();
				if (rigidbodiesTimeline.Length > 0)
				{
					Toggle(false, null);
					return;
				}
			}
		}
		rigidbodies = GetComponentsInChildren<Rigidbody>();
		ToggleRagdolls(false, null);
	}

	private void Toggle(bool isEnabled, Action<RigidbodyTimeline3D> doToRigid = null)
	{
		if (rigidbodiesTimeline == null) return;
		for (int i = 0; i < rigidbodiesTimeline.Length; i++)
		{
			var rt = rigidbodiesTimeline[i];
			if (rt == null) continue;
			rt.isKinematic = !isEnabled;
			if (rt.component != null && rt.component.gameObject != null)
				rt.component.gameObject.SetActive(isEnabled);
			doToRigid?.Invoke(rt);
		}
	}

	private void ToggleRagdolls(bool isEnabled, Action<Rigidbody> doToRigid = null)
	{
		if (rigidbodies == null) return;
		for (int i = 0; i < rigidbodies.Length; i++)
		{
			var rb = rigidbodies[i];
			if (rb == null) continue;
			rb.isKinematic = !isEnabled;
			if (rb.gameObject != null)
				rb.gameObject.SetActive(isEnabled);
			doToRigid?.Invoke(rb);
		}
	}

	public void Shatter(Vector3 impactPoint, float force, float explosionRadius, float upwardsModifier, ForceMode forceMode)
	{
		if (hasShattered) return;
		hasShattered = true;
		transform.SetParent(null);
		if (gameObject.scene.IsValid())
			UnityEngine.SceneManagement.SceneManager.MoveGameObjectToScene(gameObject, gameObject.scene);
		if (UseTimelines && rigidbodiesTimeline != null && rigidbodiesTimeline.Length > 0)
		{
			Toggle(true, r =>
			{
				if (r == null) return;
				if (UnparentAllRigidbodies && r.component != null)
				{
					r.component.transform.SetParent(null);
					if (gameObject.scene.IsValid() && r.component.gameObject.scene != gameObject.scene)
						UnityEngine.SceneManagement.SceneManager.MoveGameObjectToScene(r.component.gameObject, gameObject.scene);
				}
				if (r.component != null)
					r.component.AddExplosionForce(force, impactPoint, explosionRadius, upwardsModifier, forceMode);
			});
		}
		else
		{
			if (rigidbodies == null || rigidbodies.Length == 0)
				rigidbodies = GetComponentsInChildren<Rigidbody>(true);
			ToggleRagdolls(true, r =>
			{
				if (r == null) return;
				if (UnparentAllRigidbodies)
				{
					r.transform.SetParent(null);
					if (gameObject.scene.IsValid() && r.gameObject.scene != gameObject.scene)
						UnityEngine.SceneManagement.SceneManager.MoveGameObjectToScene(r.gameObject, gameObject.scene);
				}
				r.AddExplosionForce(force, impactPoint, explosionRadius, upwardsModifier, forceMode);
			});
		}
	}
}
