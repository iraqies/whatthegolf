using System.Collections;
using UnityEngine;

public class TweenScaleTurkey : MonoBehaviour
{
	[SerializeField]
	private GameObject totween;

	[SerializeField]
	private Vector3 from;

	[SerializeField]
	private AnimationCurve animationCurve;

	[SerializeField]
	private float duration;

	[SerializeField]
	private bool StartOnAwake;

	public ParticleSystem leafPoofParticles;

	public float scaleFactor;

	public GameObject leafAudio;

	public GameObject turkeyAudio;

	private SphereCollider leafStackCollider;

	private Vector3 to;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Scale()
	{
	}

	private IEnumerator StartScaling()
	{
		return null;
	}

	private IEnumerator ScaleAllDown()
	{
		return null;
	}
}
