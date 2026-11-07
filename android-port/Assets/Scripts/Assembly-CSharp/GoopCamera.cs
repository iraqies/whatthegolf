using System.Collections;
using Audio;
using UnityEngine;

public class GoopCamera : MonoBehaviour
{
	private enum Area
	{
		LIVING = 0,
		SOCCER = 1,
		SNEAK = 2,
		OUTSIDE = 3
	}

	public OverworldCameraSettings cameraForOpeningChest;

	private bool previousBallState;

	[SerializeField]
	private Transform _ballProxy;

	[SerializeField]
	private Transform _goop;

	[SerializeField]
	private Animator _goopFlagAnimatior;

	private static readonly int Living;

	private static readonly int Soccer;

	private static readonly int Sneak;

	private static readonly int Outside;

	[SerializeField]
	private OpenBarricade _barricade;

	[SerializeField]
	private GameObject _openIndicator;

	[SerializeField]
	private ClipSettingsCollection _OnGoopMoveSFX;

	[SerializeField]
	private ClipSettingsCollection _OnGoopMoveSFX2;

	[SerializeField]
	private float _animationDuration;

	[SerializeField]
	private Area _area;

	private int GetAnimation()
	{
		return 0;
	}

	private void Awake()
	{
	}

	private void OnTriggerEnter2D(Collider2D col)
	{
	}

	private IEnumerator GoopCR()
	{
		return null;
	}

	private IEnumerator DoSomething()
	{
		return null;
	}

	public void UnDoSomething()
	{
	}
}
