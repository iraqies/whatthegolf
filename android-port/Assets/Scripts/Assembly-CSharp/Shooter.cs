using System.Collections.Generic;
using System.Linq;
using Core;
using UnityEngine;
using Utility;

public class Shooter : MonoBehaviour
{
	public SpriteRenderer splatter;

	public float DistSplatter = 1f;

	public float HeightCheck = 1f;

	public float NormalMod = 0.3f;

	public LayerMask SplatterLayer;

	public List<Sprite> Sprites;

	public float GroundSplatterRotation = 36.72f;

	public float WallSplatterRotation = 20f;

	public float SplatterLifeTime = 20f;

	public float SplatterFadeTime = 5f;

	public LayerMask KillLayer;

	public ParticleSystem KillParticles;

	private new Rigidbody rigidbody;

	private Vector3 lastPosition;

	private GameObject splatterContainer;

	private ObjectPool<SpriteRenderer> splatterPool;

	private Dictionary<SpriteRenderer, float> activeSplatters;

	private GolfBallController controller;

	private void Awake()
	{
		controller = GetComponent<GolfBallController>();
		activeSplatters = new Dictionary<SpriteRenderer, float>();
		rigidbody = GetComponent<Rigidbody>();
	}

	private void Start()
	{
		splatterContainer = new GameObject("Splatters");
		if (gameObject.scene.IsValid() && splatterContainer.scene != gameObject.scene)
			UnityEngine.SceneManagement.SceneManager.MoveGameObjectToScene(splatterContainer, gameObject.scene);
		if (splatter != null)
		{
			splatterPool = new ObjectPool<SpriteRenderer>(splatter.gameObject, 100, null);
			splatterPool.SetPoolTransformParent(splatterContainer.transform);
		}
		if (KillParticles != null)
		{
			KillParticles.transform.SetParent(null);
			if (gameObject.scene.IsValid() && KillParticles.gameObject.scene != gameObject.scene)
				UnityEngine.SceneManagement.SceneManager.MoveGameObjectToScene(KillParticles.gameObject, gameObject.scene);
		}
	}

	private void Update()
	{
		if (activeSplatters == null || activeSplatters.Count < 1)
			return;

		for (int i = activeSplatters.Count - 1; i >= 0; i--)
		{
			SpriteRenderer sr = activeSplatters.Keys.ElementAt(i);
			activeSplatters[sr] += Time.deltaTime;
			if (activeSplatters[sr] >= SplatterLifeTime)
			{
				float elapsed = activeSplatters[sr];
				float alpha = 1f - ((SplatterFadeTime > 0f) ? ((elapsed - SplatterLifeTime) / SplatterFadeTime) : 1f);
				if (splatter != null && sr != null)
				{
					Color baseCol = splatter.color;
					sr.color = new Color(baseCol.r, baseCol.g, baseCol.b, alpha);
				}
				if (alpha <= 0f)
				{
					if (sr != null && splatterPool != null)
					{
						splatterPool.Release(sr.gameObject, true);
					}
					activeSplatters.Remove(sr);
				}
			}
		}
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other == null || other.gameObject == null)
			return;

		int splatMask = SplatterLayer;
		if (splatMask == (splatMask | (1 << other.gameObject.layer)))
		{
			ContactPoint[] contacts = other.contacts;
			if (contacts != null && contacts.Length > 0)
			{
				SplatterAt(contacts[0], other.gameObject);
			}
		}

		int killMask = KillLayer;
		if (killMask == (killMask | (1 << other.gameObject.layer)))
		{
			ContactPoint[] contacts2 = other.contacts;
			if (KillParticles != null && contacts2 != null && contacts2.Length > 0)
			{
				KillParticles.transform.position = contacts2[0].point;
				KillParticles.Play();
			}
			if (controller != null)
			{
				controller.OutOfBounds("OUCH!", 1f);
			}
		}
	}

	private void OnCollisionStay(Collision other)
	{
		if (other == null || other.gameObject == null)
			return;

		int splatMask = SplatterLayer;
		if (splatMask == (splatMask | (1 << other.gameObject.layer)) && rigidbody != null)
		{
			if (Vector3.Distance(rigidbody.position, lastPosition) >= DistSplatter)
			{
				ContactPoint[] contacts = other.contacts;
				if (contacts != null && contacts.Length > 0)
				{
					SplatterAt(contacts[0], other.gameObject);
				}
				lastPosition = rigidbody.position;
			}
		}
	}

	private void SplatterAt(ContactPoint contact, GameObject objectHit)
	{
		if (!base.enabled || splatterPool == null || splatterContainer == null)
			return;

		Vector3 point = contact.point;
		Vector3 normal = contact.normal;
		float normalOffset = NormalMod;
		float rotAngle;
		if (Vector3.Distance(normal, Vector3.right) < 0.01f || Vector3.Distance(normal, Vector3.left) < 0.01f)
		{
			normalOffset = 0f;
			rotAngle = WallSplatterRotation;
		}
		else
		{
			rotAngle = GroundSplatterRotation;
		}

		Quaternion lookRot = Quaternion.LookRotation(normal, Vector3.forward);
		GameObject go = splatterPool.Retrieve(point + normal * normalOffset, lookRot, splatterContainer.transform);
		if (go == null)
			return;

		SpriteRenderer sr = go.GetComponent<SpriteRenderer>();
		if (sr == null)
			return;

		sr.transform.SetParent(splatterContainer.transform);
		Vector3 cross = Vector3.Cross(normal, Vector3.up);
		sr.transform.RotateAround(sr.transform.position, normal, Random.Range(0, 360));
		sr.transform.RotateAround(sr.transform.position, cross, rotAngle);

		if (Sprites != null && Sprites.Count > 0)
		{
			sr.sprite = Sprites[Random.Range(0, Sprites.Count)];
		}
		if (splatter != null)
		{
			sr.color = splatter.color;
		}
		if (objectHit != null && objectHit.tag == "DynamicSplatterSurface")
		{
			sr.transform.SetParent(objectHit.transform);
			sr.gameObject.layer = LayerMask.NameToLayer("DynamicSplatter");
		}
		else
		{
			sr.gameObject.layer = LayerMask.NameToLayer("StaticSplatter");
		}
		activeSplatters[sr] = 0f;
	}
}
