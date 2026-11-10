using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwVatSLime : MonoBehaviour
{
	[SerializeField]
	private GameObject _gooMonster;

	[SerializeField]
	private Animator _gooMonsterAnimator;

	[SerializeField]
	private string _gooAnimationOnStartTrigger;

	[SerializeField]
	private string _gooAnimationMoveTrigger;

	[SerializeField]
	private GameObject _itemAchor;

	[SerializeField]
	private Animator _shockTurtleAnimator;

	[SerializeField]
	private string _shockTurtleTrigger;

	[SerializeField]
	private OpenBarricade _barricade;

	[SerializeField]
	private List<GameObject> _deactivate;

	[SerializeField]
	private List<GameObject> _activate;

	[SerializeField]
	private TweenScale _particleStoScale;

	[SerializeField]
	private ParticleSystem _slime;

	[SerializeField]
	private ParticleSystem _vatParticles;

	[SerializeField]
	private PlayAudioClipSetting _slimeAudio;

	[SerializeField]
	private PlayAudioClipSetting _laughAudio;

	[SerializeField]
	private Collider2D _collider;

	[SerializeField]
	private float _timeBeforeDeactivateGooMonster;

	[SerializeField]
	private OverworldCameraSettings cameraForOpeningChest;

	private bool previousBallState;

	[SerializeField]
	private Transform _ballProxy;

	[SerializeField]
	private Transform _goop;

	[SerializeField]
	private float _animationDuration;

	private bool hasBroken;

	private void OnEnable()
	{
		if (_gooMonsterAnimator != null)
		{
			_gooMonsterAnimator.SetTrigger(_gooAnimationOnStartTrigger);
		}
	}

	private IEnumerator OnOpen()
	{
		if (_deactivate != null)
		{
			foreach (GameObject item in _deactivate)
			{
				if (item != null)
				{
					item.SetActive(value: false);
				}
			}
		}
		if (_activate != null)
		{
			foreach (GameObject item2 in _activate)
			{
				if (item2 != null)
				{
					item2.SetActive(value: true);
				}
			}
		}
		if (_gooMonsterAnimator != null)
		{
			_gooMonsterAnimator.SetTrigger(_gooAnimationMoveTrigger);
			_gooMonsterAnimator.speed = 0f;
		}
		if (_barricade != null)
		{
			_barricade.OpenDoor(setObjectState: false);
		}
		if (_particleStoScale != null)
		{
			_particleStoScale.Scale();
		}
		if (_slime != null)
		{
			_slime.Play();
		}
		if (_slimeAudio != null)
		{
			_slimeAudio.Play();
		}
		if (_vatParticles != null)
		{
			_vatParticles.gameObject.SetActive(value: false);
		}
		if (_collider != null)
		{
			_collider.enabled = false;
		}
		if (_itemAchor != null)
		{
			_itemAchor.SetActive(value: false);
		}
		yield return FollowGoopCamera();
		if (_gooMonsterAnimator != null)
		{
			_gooMonsterAnimator.speed = 1f;
		}
		StartCoroutine(DelayToLaugh());
		StartCoroutine(DelayToDeactivate());
		StartCoroutine(DelayToShock());
		float elapsed = 0f;
		while (elapsed < _animationDuration)
		{
			elapsed += Time.fixedDeltaTime;
			if (_goop != null && _ballProxy != null)
			{
				_ballProxy.position = _goop.transform.position.WithX(_ballProxy.position.x);
			}
			yield return new WaitForFixedUpdate();
		}
		StopCameraFollowGoop();
	}

	private IEnumerator FollowGoopCamera()
	{
		if (OverworldBallManager.Instance != null && OverworldBallManager.Instance.Ball != null)
		{
			OverworldBall2D ball = OverworldBallManager.Instance.Ball;
			if (ball.Controller != null)
			{
				ball.Controller.CancelShooting();
			}
			ball.StopAndSleep();
			if (_ballProxy != null)
			{
				OverworldBallFollower component = _ballProxy.GetComponent<OverworldBallFollower>();
				if (component != null)
				{
					component.isFollowing = false;
				}
			}
			if (ball.Controller != null)
			{
				previousBallState = ball.Controller.enabled;
				ball.Controller.enabled = false;
			}
		}
		Vector3 startPos = (_ballProxy != null) ? _ballProxy.position : Vector3.zero;
		yield return StartCoroutine(pTween.To(1f, delegate(float t)
		{
			if (cameraForOpeningChest != null)
			{
				cameraForOpeningChest.SetValue(t);
			}
			if (_goop != null && _ballProxy != null)
			{
				_ballProxy.position = Vector3.Lerp(startPos, _goop.position, Mathf.Clamp01(t));
			}
		}));
	}

	public void StopCameraFollowGoop()
	{
		StartCoroutine(pTween.To(1f, delegate(float t)
		{
			if (cameraForOpeningChest != null)
			{
				cameraForOpeningChest.SetValue(1f - t);
			}
		}));
		if (OverworldBallManager.Instance != null && OverworldBallManager.Instance.Ball != null && OverworldBallManager.Instance.Ball.Controller != null)
		{
			OverworldBallManager.Instance.Ball.Controller.enabled = previousBallState;
		}
		if (_ballProxy != null)
		{
			OverworldBallFollower component = _ballProxy.GetComponent<OverworldBallFollower>();
			if (component != null)
			{
				component.isFollowing = true;
			}
		}
	}

	private void OnCollisionEnter2D(Collision2D col)
	{
		if (col != null && col.gameObject != null && col.gameObject.CompareTag("Player") && !hasBroken)
		{
			hasBroken = true;
			StartCoroutine(OnOpen());
		}
	}

	private IEnumerator DelayToDeactivate()
	{
		yield return new WaitForSeconds(_timeBeforeDeactivateGooMonster);
		if (_gooMonster != null)
		{
			_gooMonster.SetActive(value: false);
		}
	}

	private IEnumerator DelayToLaugh()
	{
		yield return new WaitForSeconds(1f);
		if (_laughAudio != null)
		{
			_laughAudio.Play();
		}
	}

	private IEnumerator DelayToShock()
	{
		yield return new WaitForSeconds(2.5f);
		if (_shockTurtleAnimator != null)
		{
			_shockTurtleAnimator.SetTrigger(_shockTurtleTrigger);
		}
	}

	public OwVatSLime()
	{
		_timeBeforeDeactivateGooMonster = 5f;
		_animationDuration = 5f;
	}
}
