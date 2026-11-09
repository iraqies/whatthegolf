using CameraStack;
using UnityEngine;

public class HintEffect : MonoBehaviour
{
	[SerializeField] private TrailRenderer trailTemplate;
	[SerializeField] private AudioClip sound;
	private TrailRenderer[] trails = new TrailRenderer[0];
	private OverworldCamera camera;
	private static HintEffect instance;

	public static HintEffect Instance
	{
		get
		{
			if (instance == null)
				Initialize(OverworldCamera.Instance ?? FindObjectOfType<OverworldCamera>());
			return instance;
		}
	}

	public void Play(Vector3 centerPosition, Vector3[] outerPositions)
	{
		if (outerPositions == null || outerPositions.Length == 0)
			return;
		if (trails == null)
			trails = new TrailRenderer[0];
		if (outerPositions.Length > trails.Length)
			Expand(outerPositions.Length - trails.Length);

		StopAllCoroutines();
		for (int i = 0; i < trails.Length; i++)
		{
			if (trails[i] != null)
				trails[i].gameObject.SetActive(i < outerPositions.Length);
		}

		StartCoroutine(pTween.To(0.15f, 0f, 1f, t =>
		{
			for (int i = 0; i < outerPositions.Length && i < trails.Length; i++)
			{
				if (trails[i] != null)
					trails[i].transform.position = Vector3.Lerp(centerPosition, outerPositions[i], t);
			}
		}));

		if (sound != null && AudioManager.Instance != null && AudioManager.Instance.sfx != null)
		{
			AudioManager.Instance.sfx.PlaySimple(sound, 0.5f, 1f, centerPosition);
		}
		if (camera == null)
			camera = OverworldCamera.Instance ?? FindObjectOfType<OverworldCamera>();
		if (camera != null)
			camera.Shake(0.1f, 20f, 0.4f);
	}

	private void Expand(int size)
	{
		if (trailTemplate == null || size <= 0)
			return;
		int oldLen = trails != null ? trails.Length : 0;
		var next = new TrailRenderer[oldLen + size];
		if (trails != null)
			System.Array.Copy(trails, next, oldLen);
		for (int i = 0; i < size; i++)
		{
			var tr = Instantiate(trailTemplate.gameObject, transform).GetComponent<TrailRenderer>();
			if (tr != null)
			{
				tr.gameObject.SetActive(false);
				next[oldLen + i] = tr;
			}
		}
		trails = next;
	}

	public static void Initialize(OverworldCamera camera)
	{
		if (instance == null)
		{
			var prefab = Resources.Load<GameObject>("Prefabs/HintEffect");
			if (prefab != null)
			{
				var go = Instantiate(prefab, null);
				instance = go.GetComponent<HintEffect>();
			}
			else
			{
				var go = new GameObject("HintEffect");
				instance = go.AddComponent<HintEffect>();
			}
		}
		if (instance != null)
		{
			instance.camera = camera;
			if (instance.trails == null || instance.trails.Length == 0)
				instance.Expand(15);
		}
	}
}
