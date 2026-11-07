using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpeechBubble : MonoBehaviour
{
	public string Text;

	public string TextID;

	public float LifeTime;

	public float FloatStrength;

	public List<GameObject> TriggerObjects;

	public float SpeechSpeed;

	public float Distance;

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
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private IEnumerator ShowText()
	{
		return null;
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}
}
