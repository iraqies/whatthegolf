using System;
using System.Collections;
using Audio;
using UnityEngine;
using UnityEngine.Events;

public class ExplodingDynamiteForLivingThings : MonoBehaviour, IAudioEvent
{
	private enum State
	{
		Appear = 0,
		Warning = 1,
		Explode = 2,
		Done = 3
	}

	private double _time;

	[SerializeField]
	private float _warningTime;

	[SerializeField]
	private float _appearTime;

	[SerializeField]
	private AnimationCurve _appearCurve;

	[SerializeField]
	private AnimationCurve _blinkCurve;

	[SerializeField]
	private float _warningSpeed;

	[SerializeField]
	private float _warningSizeIncrease;

	[SerializeField]
	private bool _startWarningOnPickup;

	[SerializeField]
	private GameObject _rings;

	[SerializeField]
	private GameObject _explosionshadow;

	[SerializeField]
	private GameObject _blinkRenderer;

	[SerializeField]
	private GameObject _normalRenderer;

	[SerializeField]
	private ParticleSystem _splash;

	[SerializeField]
	private LayerMask _mask;

	private State _state;

	private Vector3 _startPos;

	public UnityEvent OnExplodeEvent;

	[SerializeField]
	private float _blinkSomething;

	[SerializeField]
	private GameObject _audio;

	[SerializeField]
	private float _radius;

	[SerializeField]
	private float _explosionForce;

	[SerializeField]
	private ParticleSystem _explosionParticles;

	private bool _exploded;

	private Collider _ballCollider;

	public Action<Vector3> OnAudioEvent { get; set; }

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void Appear()
	{
	}

	private void SetWarning()
	{
	}

	private void Warning()
	{
	}

	private void OnDrawGizmos()
	{
	}

	private void Explode()
	{
	}

	private IEnumerator Aduio()
	{
		return null;
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	public void OnPickedUp(Collider ballCollider)
	{
	}
}
