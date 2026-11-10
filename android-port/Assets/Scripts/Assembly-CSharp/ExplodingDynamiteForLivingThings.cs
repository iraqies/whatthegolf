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
	private float _warningTime = 2.5f;

	[SerializeField]
	private float _appearTime = 0.35f;

	[SerializeField]
	private AnimationCurve _appearCurve = AnimationCurve.EaseInOut(0f, 0f, 1f, 1f);

	[SerializeField]
	private AnimationCurve _blinkCurve = AnimationCurve.Linear(0f, 0f, 1f, 1f);

	[SerializeField]
	private float _warningSpeed = 6f;

	[SerializeField]
	private float _warningSizeIncrease = 0.25f;

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
	private LayerMask _mask = -1;

	private State _state;

	private Vector3 _startPos;

	public UnityEvent OnExplodeEvent;

	[SerializeField]
	private float _blinkSomething;

	[SerializeField]
	private GameObject _audio;

	[SerializeField]
	private float _radius = 5f;

	[SerializeField]
	private float _explosionForce = 15f;

	[SerializeField]
	private ParticleSystem _explosionParticles;

	private bool _exploded;

	private Collider _ballCollider;

	public Action<Vector3> OnAudioEvent { get; set; }

	private void Start()
	{
		_startPos = transform.localScale;
		_time = 0.0;
		_state = _startWarningOnPickup ? State.Appear : State.Warning;
		if (!_startWarningOnPickup)
		{
			SetWarning();
		}
	}

	private void Update()
	{
		switch (_state)
		{
		case State.Appear:
			Appear();
			break;
		case State.Warning:
			Warning();
			break;
		case State.Explode:
			Explode();
			break;
		}
	}

	private void Appear()
	{
		_time += Time.deltaTime;
		float t = _appearTime > 0.001f ? Mathf.Clamp01((float)_time / _appearTime) : 1f;
		float eval = _appearCurve != null && _appearCurve.length > 0 ? _appearCurve.Evaluate(t) : t;
		transform.localScale = _startPos * eval;
		if (!_startWarningOnPickup && t >= 1f)
		{
			SetWarning();
		}
	}

	private void SetWarning()
	{
		_time = 0.0;
		_state = State.Warning;
		if (_rings != null)
		{
			_rings.SetActive(true);
		}
	}

	private void Warning()
	{
		_time += Time.deltaTime;
		float t = _warningTime > 0.001f ? Mathf.Clamp01((float)_time / _warningTime) : 1f;
		float blink = Mathf.Sin((float)_time * _warningSpeed * (1f + t * 2f));
		bool showBlink = blink > 0f;
		if (_blinkRenderer != null)
		{
			_blinkRenderer.SetActive(showBlink);
		}
		if (_normalRenderer != null)
		{
			_normalRenderer.SetActive(!showBlink);
		}
		transform.localScale = _startPos * (1f + t * _warningSizeIncrease);
		if (t >= 1f)
		{
			_state = State.Explode;
		}
	}

	private void OnDrawGizmos()
	{
	}

	private void Explode()
	{
		if (_exploded)
		{
			return;
		}
		_exploded = true;
		_state = State.Done;
		if (_rings != null)
		{
			_rings.SetActive(false);
		}
		if (_blinkRenderer != null)
		{
			_blinkRenderer.SetActive(false);
		}
		if (_normalRenderer != null)
		{
			_normalRenderer.SetActive(false);
		}
		if (_explosionshadow != null)
		{
			_explosionshadow.SetActive(true);
		}
		if (_explosionParticles != null)
		{
			_explosionParticles.Play();
		}
		if (_splash != null)
		{
			_splash.Play();
		}
		Collider[] cols = Physics.OverlapSphere(transform.position, _radius, _mask);
		for (int i = 0; i < cols.Length; i++)
		{
			if (cols[i] != null && cols[i].attachedRigidbody != null)
			{
				cols[i].attachedRigidbody.AddExplosionForce(_explosionForce, transform.position, _radius, 1.5f, ForceMode.VelocityChange);
			}
		}
		OnAudioEvent?.Invoke(transform.position);
		OnExplodeEvent?.Invoke();
		StartCoroutine(Aduio());
	}

	private IEnumerator Aduio()
	{
		if (_audio != null)
		{
			_audio.SetActive(true);
		}
		yield return new WaitForSeconds(2f);
		gameObject.SetActive(false);
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (_startWarningOnPickup && _state == State.Appear && collision != null && collision.gameObject.CompareTag("Player"))
		{
			SetWarning();
		}
	}

	public void OnPickedUp(Collider ballCollider)
	{
		_ballCollider = ballCollider;
		if (_state == State.Appear)
		{
			SetWarning();
		}
	}
}
