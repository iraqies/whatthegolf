using System.Collections;
using Audio;
using UnityEngine;

public class OverworldMouth : MonoBehaviour
{
	public Transform leftMouth;

	public Transform rightMouth;

	public Transform leftMouthInPos;

	public Transform rightMouthInPos;

	public AnimationCurve closeCurve;

	public ShortcutTunnelEntry tunnelEntry;

	public float animationTime;

	private float nextEatTime;

	private Vector3 rightMouthOutPosition;

	private Vector3 leftMouthOutPosition;

	public Animator SuckerAnimator;

	public Animator FlagAnimator;

	public float delaySFX;

	public ClipSettingsCollection EatSFX;

	private void Start()
	{
	}

	private IEnumerator Eat(OverworldBall2D ball)
	{
		return null;
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}
}
