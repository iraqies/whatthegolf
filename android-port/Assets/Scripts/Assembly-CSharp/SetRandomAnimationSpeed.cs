using UnityEngine;

public class SetRandomAnimationSpeed : MonoBehaviour
{
	public float SpeedMin = 0.8f;

	public float SpeedMax = 1.2f;

	private void Awake()
	{
		Animator anim = GetComponent<Animator>();
		if (anim != null && SpeedMax > 0f)
		{
			anim.speed = Random.Range(Mathf.Min(SpeedMin, SpeedMax), Mathf.Max(SpeedMin, SpeedMax));
		}
	}
}
