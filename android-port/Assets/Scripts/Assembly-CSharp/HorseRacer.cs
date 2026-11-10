using UnityEngine;

public class HorseRacer : MonoBehaviour
{
	private Rigidbody rigidbody;

	[SerializeField]
	private Animator horseAnimator;

	[SerializeField]
	private float maxInputVelocity = 10f;

	[SerializeField]
	private float maxAnimationSpeed = 2f;

	[SerializeField]
	private float jumpDuration = 0.7f;

	[SerializeField]
	private AnimationCurve jumpLayerWeight = AnimationCurve.Linear(0f, 0f, 1f, 0f);

	private int jumpLayerIndex;

	private void Awake()
	{
		rigidbody = GetComponent<Rigidbody>();
		jumpLayerIndex = horseAnimator.GetLayerIndex("Jump");
	}

	private void Update()
	{
		float num = Mathf.Clamp01(rigidbody.velocity.magnitude / maxInputVelocity);
		horseAnimator.SetFloat("Speed", num);
		horseAnimator.speed = num * maxAnimationSpeed;
	}

	public void Jump()
	{
		StartCoroutine(pTween.To(jumpDuration, delegate(float t)
		{
			horseAnimator.SetLayerWeight(jumpLayerIndex, jumpLayerWeight.Evaluate(t));
		}));
	}
}
