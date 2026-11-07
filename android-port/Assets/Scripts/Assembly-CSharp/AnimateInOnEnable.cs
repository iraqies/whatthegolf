using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateInOnEnable : MonoBehaviour
{
	[SerializeField]
	private float DurationMax;

	[SerializeField]
	private float DurationMin;

	[SerializeField]
	private Vector2 Delay;

	[SerializeField]
	private float Stagger;

	[SerializeField]
	private AnimationCurve curve;

	public List<GameObject> gameObjects;

	[SerializeField]
	private bool useAnimation;

	[SerializeField]
	private bool disableOnAwake;

	[SerializeField]
	private bool shuffle;

	[SerializeField]
	private bool startOnEnable;

	[SerializeField]
	private bool _useSetDurations;

	[SerializeField]
	private List<float> _setDurations;

	private bool isStarted;

	[SerializeField]
	private Vector3 _startScale;

	private void Awake()
	{
	}

	private IEnumerator AnimateIn()
	{
		return null;
	}

	private void Start()
	{
	}

	public void StartAnimateIn()
	{
	}
}
