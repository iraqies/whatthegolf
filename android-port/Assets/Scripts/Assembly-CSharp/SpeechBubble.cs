using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpeechBubble : MonoBehaviour
{
	public string Text;
	public string TextID;
	public float LifeTime = 3f;
	public float FloatStrength = 0.5f;
	public List<GameObject> TriggerObjects;
	public float SpeechSpeed = 0.03f;
	public float Distance = 3f;
	public float Delay;
	public float TextDelay;
	private ParticleSystem particles;
	private float lifeTimer;
	private TextMeshProUGUI text;
	private bool started;
	private Transform container;
	private bool killParticles;

	private void Awake()
	{
		particles = GetComponentInChildren<ParticleSystem>();
		text = GetComponentInChildren<TextMeshProUGUI>();
		if (transform.childCount > 0)
			container = transform.GetChild(0);
	}

	private void Start()
	{
		if (!string.IsNullOrEmpty(TextID) && Localization.Instance != null)
		{
			string loc = Localization.Instance.GetString(TextID);
			if (!string.IsNullOrEmpty(loc))
				Text = loc;
		}
		if (text != null)
			text.text = string.Empty;
		if (container != null && (TriggerObjects != null && TriggerObjects.Count > 0))
			container.gameObject.SetActive(false);
		else
			Show();
	}

	private void Update()
	{
		if (!started && TriggerObjects != null)
		{
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
		if (started && LifeTime > 0f)
		{
			lifeTimer += Time.deltaTime;
			if (lifeTimer >= LifeTime)
				Hide();
		}
	}

	private void FixedUpdate()
	{
	}

	private IEnumerator ShowText()
	{
		if (Delay > 0f)
			yield return new WaitForSeconds(Delay);
		if (container != null)
			container.gameObject.SetActive(true);
		if (particles != null)
			particles.Play();
		if (TextDelay > 0f)
			yield return new WaitForSeconds(TextDelay);
		if (text != null)
			text.text = Text ?? string.Empty;
	}

	public void Show()
	{
		if (started) return;
		started = true;
		lifeTimer = 0f;
		StartCoroutine(ShowText());
	}

	public void Hide()
	{
		if (container != null)
			container.gameObject.SetActive(false);
		if (particles != null)
			particles.Stop();
	}
}
