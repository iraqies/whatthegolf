using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateInOnEnableAxis : MonoBehaviour
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
	private AnimationCurve curveX;

	[SerializeField]
	private AnimationCurve curveY;

	[SerializeField]
	private AnimationCurve curveZ;

	public List<GameObject> gameObjects;

	[SerializeField]
	private bool useAnimation;

	[SerializeField]
	private bool disableOnAwake;

	[SerializeField]
	private bool shuffle;

	[SerializeField]
	private bool startOnEnable;

	private bool isStarted;

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
