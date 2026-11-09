using System.Collections.Generic;
using UnityEngine;

public class EffectsInOne : MonoBehaviour
{
	private static EffectsInOne instance;

	[SerializeField]
	private ParticleSystem dustPuff;

	[SerializeField]
	private ParticleSystem waterRipple;

	[SerializeField]
	private ParticleSystem waterSplash;

	[SerializeField]
	private ParticleSystem sparks;

	[SerializeField]
	private GameObject anchorPrefab;

	[SerializeField]
	private ParticleSystem explosion;

	private Queue<GameObject> anchors;

	public static EffectsInOne Instance => instance ?? (instance = FindObjectOfType<EffectsInOne>());

	private void Awake()
	{
		instance = this;
		anchors = new Queue<GameObject>();
		if (anchorPrefab != null)
		{
			for (int i = 0; i < 30; i++)
			{
				GameObject go = Instantiate(anchorPrefab, Vector3.zero, Quaternion.identity);
				if (go != null)
				{
					go.transform.parent = transform;
					anchors.Enqueue(go);
				}
			}
		}
	}

	public static void EmitDustPuff(Vector3 position, int count = 1)
	{
		if (Instance != null && Instance.dustPuff != null)
		{
			Instance.dustPuff.transform.position = position;
			Instance.dustPuff.Emit(count);
		}
	}

	public static void EmitWaterRipple(Vector3 position, int count = 1)
	{
		if (Instance != null && Instance.waterRipple != null)
		{
			Instance.waterRipple.transform.position = position;
			Instance.waterRipple.Emit(count);
		}
	}

	public static void EmitWaterSplash(Vector3 position, int count = 10)
	{
		if (Instance != null && Instance.waterSplash != null)
		{
			Instance.waterSplash.transform.position = position;
			Instance.waterSplash.Emit(count);
		}
	}

	public static void EmitSparks(Vector3 position, int count = 10)
	{
		if (Instance != null && Instance.sparks != null)
		{
			Instance.sparks.transform.position = position;
			Instance.sparks.Emit(count);
		}
	}

	public static void EmitExplosion(Vector3 position, float size = 1f, int count = 10)
	{
		if (Instance == null || Instance.explosion == null) return;
		var main = Instance.explosion.main;
		float prevMin = main.startSize.constantMin;
		float prevMax = main.startSize.constantMax;
		main.startSize = new ParticleSystem.MinMaxCurve(prevMin * size, prevMax * size);
		Instance.explosion.transform.position = position;
		Instance.explosion.Emit(count);
		main.startSize = new ParticleSystem.MinMaxCurve(prevMin, prevMax);
	}

	public static void AddAnchor(Vector3 position, Vector3 normal)
	{
		if (Instance == null || Instance.anchors == null || Instance.anchors.Count == 0) return;
		GameObject go = Instance.anchors.Dequeue();
		if (go != null)
		{
			go.transform.position = position;
			go.transform.up = normal;
			Instance.anchors.Enqueue(go);
		}
	}
}
