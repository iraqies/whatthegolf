using UnityEngine;

public class HorseRacer : MonoBehaviour
{
	private Rigidbody rigidbody;

	[SerializeField]
	private Animator horseAnimator;

	[SerializeField]
	private float maxInputVelocity;

	[SerializeField]
	private float maxAnimationSpeed;

	[SerializeField]
	private float jumpDuration;

	[SerializeField]
	private AnimationCurve jumpLayerWeight;

	private int jumpLayerIndex;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void Jump()
	{
	}
}
