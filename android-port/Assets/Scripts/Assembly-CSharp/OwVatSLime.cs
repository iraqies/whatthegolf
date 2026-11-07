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
	}

	private IEnumerator OnOpen()
	{
		return null;
	}

	private IEnumerator FollowGoopCamera()
	{
		return null;
	}

	public void StopCameraFollowGoop()
	{
	}

	private void OnCollisionEnter2D(Collision2D col)
	{
	}

	private IEnumerator DelayToDeactivate()
	{
		return null;
	}

	private IEnumerator DelayToLaugh()
	{
		return null;
	}

	private IEnumerator DelayToShock()
	{
		return null;
	}
}
