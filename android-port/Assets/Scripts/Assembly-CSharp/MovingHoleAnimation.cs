using UnityEngine;

public class MovingHoleAnimation : MonoBehaviour
{
	[SerializeField]
	private AnimationCurve movementCurve;

	[SerializeField]
	private float timeOffset;

	[SerializeField]
	private float speedRatio;

	private MovingHole hole;

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
