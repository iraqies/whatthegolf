using System.Collections;
using Core;
using UnityEngine;
using UnityEngine.Events;

public class LivingBush : MonoBehaviour
{
	[SerializeField]
	private LivingBush _bush;

	[SerializeField]
	private float _speed;

	private GolfBallController _controller;

	[SerializeField]
	private ForceMode _forceMode;

	[SerializeField]
	private Transform _shootPos;

	[SerializeField]
	private Animator _animator;

	public UnityEvent OnShoot;

	private static readonly int Bounce;

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
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void WakeUp()
	{
	}

	private IEnumerator SFX()
	{
		return null;
	}

	private void Lookat(Transform t)
	{
	}

	private void Start()
	{
	}
}
