using System.Collections;
using System.Collections.Generic;
using CameraStack;
using TMPro;
using UnityEngine;

public class SpeechBubble : MonoBehaviour
{
	public string Text;
	public string TextID;
	public float LifeTime = 5f;
	public float FloatStrength = 3f;
	public List<GameObject> TriggerObjects;
	public float SpeechSpeed = 0.02f;
	public float Distance = 100f;
	public float Delay = 0.5f;
	public float TextDelay = 1f;
	private ParticleSystem particles;
	private float lifeTimer;
	private TextMeshProUGUI text;
	private bool started;
	private Transform container;
	private bool killParticles = true;

	private void Awake()
	{
		text = GetComponentInChildren<TextMeshProUGUI>(true);
		if (text != null)
			text.maxVisibleCharacters = 0;
	}

	private void Start()
	{
		if (transform.childCount > 0)
			container = transform.GetChild(0);
		particles = GetComponentInChildren<ParticleSystem>(true);
	}

	private void Update()
	{
		if (started)
		{
			if (CameraManager.Instance != null && CameraManager.Instance.MainCamera != null)
			{
				Vector3 dir = (transform.position - CameraManager.Instance.MainCamera.transform.position).normalized;
				if (dir.sqrMagnitude > 1e-4f)
					transform.rotation = Quaternion.LookRotation(dir, Vector3.up);
			}
			return;
		}

		if (TriggerObjects == null)
			return;

		for (int i = 0; i < TriggerObjects.Count; i++)
		{
			var obj = TriggerObjects[i];
			if (obj != null && Vector3.Distance(transform.position, obj.transform.position) <= Distance)
			{
				Show();
				break;
			}
		}
	}

	private void FixedUpdate()
	{
		if (!started && (particles == null || !particles.isPlaying))
			return;

		lifeTimer += Time.deltaTime;
		if (lifeTimer < LifeTime)
			return;

		if (killParticles && particles != null)
		{
			killParticles = false;
			var main = particles.main;
			main.loop = false;
			main.startLifetime = 0.5f;
		}

		if (text != null)
		{
			float t = (lifeTimer - LifeTime) * 2f;
			text.color = Color.Lerp(Color.white, Color.clear, t);
		}
	}

	private IEnumerator ShowText()
	{
		if (Delay > 0f)
			yield return new WaitForSecondsRealtime(Delay);
		if (particles != null)
			particles.Play();
		if (TextDelay > 0f)
			yield return new WaitForSecondsRealtime(TextDelay);
		if (text == null)
			yield break;

		text.ForceMeshUpdate();
		int totalVisibleCharacters = (text.textInfo != null && text.textInfo.characterCount > 0)
			? text.textInfo.characterCount
			: (text.text != null ? text.text.Length : 0);
		int counter = 0;
		while (true)
		{
			int visibleCount = counter % (totalVisibleCharacters + 1);
			text.maxVisibleCharacters = visibleCount;
			if (visibleCount >= totalVisibleCharacters)
				break;
			counter++;
			if (SpeechSpeed > 0f)
				yield return new WaitForSecondsRealtime(SpeechSpeed);
		}
	}

	public void Show()
	{
		if (container != null)
			container.gameObject.SetActive(true);
		started = true;
		StartCoroutine(ShowText());
	}

	public void Hide()
	{
		LifeTime = 0f;
		lifeTimer = 0f;
	}
}
