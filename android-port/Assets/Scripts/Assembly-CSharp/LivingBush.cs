using System.Collections;
using Core;
using UnityEngine;
using UnityEngine.Events;

public class LivingBush : MonoBehaviour
{
	[SerializeField]
	private LivingBush _bush;

	[SerializeField]
	private float _speed = 55f;

	private GolfBallController _controller;

	[SerializeField]
	private ForceMode _forceMode;

	[SerializeField]
	private Transform _shootPos;

	[SerializeField]
	private Animator _animator;

	public UnityEvent OnShoot;

	private static readonly int Bounce = Animator.StringToHash("Bounce");

	private bool _isHit;

	[SerializeField]
	private GameObject _eyes;

	[SerializeField]
	private PlayAudioClipSetting _SFXOnImpact;

	[SerializeField]
	private PlayAudioClipSetting _SFXOnThrow;

	[SerializeField]
	private PlayAudioClipSetting _SFXOnAwake;

	[SerializeField]
	private Transform _aimTransform;

	[SerializeField]
	private float _throwDelay;

	private void OnDrawGizmos()
	{
		if (_bush != null && _shootPos != null)
		{
			Gizmos.DrawLine(_shootPos.position, _bush.transform.position);
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other == null) return;
		GolfBallController ctrl = other.GetComponentInParent<GolfBallController>();
		if (ctrl == null) return;

		if (_SFXOnImpact != null)
			_SFXOnImpact.Play();

		GolfBallShooterBase shooter = ctrl.GetComponent<GolfBallShooterBase>();
		if (shooter != null)
			shooter.StopMagnitude = float.PositiveInfinity;

		ctrl.BlockShooting = true;
		ctrl.CancelShooting();

		if (_SFXOnImpact != null)
			_SFXOnImpact.Play();

		if (_animator != null)
		{
			_animator.enabled = true;
			_animator.SetBool(Bounce, false);
		}
		if (_bush != null)
		{
			transform.LookAt(_bush.transform.position.WithY(transform.position.y));
			if (_bush._animator != null)
			{
				_bush._animator.enabled = true;
				_bush._animator.SetBool(Bounce, true);
			}
			_bush.Lookat(transform);
		}
		OnShoot?.Invoke();

		if (_eyes != null && !_eyes.activeInHierarchy)
		{
			_eyes.SetActive(true);
			if (_SFXOnAwake != null)
				_SFXOnAwake.Play();
			if (_bush != null)
			{
				if (_bush._eyes != null)
					_bush._eyes.SetActive(true);
				if (_bush._SFXOnAwake != null)
					_bush._SFXOnAwake.Play();
			}
		}

		Rigidbody rb = ctrl.GetComponent<Rigidbody>();
		if (rb != null && _shootPos != null)
		{
			rb.velocity = Vector3.zero;
			rb.angularVelocity = Vector3.zero;
			rb.position = _shootPos.position;
			rb.transform.position = _shootPos.position;
		}
		_isHit = true;

		if (_bush != null && _bush._aimTransform != null && rb != null)
		{
			Vector3 throwVel = PhysicsAimUtility.GetThrowVelocityWithGravity(ctrl.transform.position, _bush._aimTransform.position, _speed);
			if (Random.Range(0, 1) >= 1 && _SFXOnThrow != null)
			{
				_SFXOnThrow.Play();
			}
			rb.AddForce(throwVel, _forceMode);
		}
	}

	private void WakeUp()
	{
		if (_eyes != null)
			_eyes.SetActive(true);
		if (_SFXOnAwake != null)
			_SFXOnAwake.Play();
	}

	private IEnumerator SFX()
	{
		if (_SFXOnImpact != null)
			_SFXOnImpact.Play();
		yield return new WaitForSeconds(_throwDelay);
		if (_SFXOnThrow != null)
			_SFXOnThrow.Play();
	}

	private void Lookat(Transform t)
	{
		if (t != null)
		{
			transform.LookAt(t.position.WithY(transform.position.y));
		}
	}

	private void Start()
	{
		if (_bush != null)
		{
			transform.LookAt(_bush.transform);
		}
	}
}
