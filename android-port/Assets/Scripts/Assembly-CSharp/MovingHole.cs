using UnityEngine;

public class MovingHole : MonoBehaviour
{
	[SerializeField]
	private Transform collisionBoxHigh;

	[SerializeField]
	private Transform collisionBoxLow;

	[SerializeField]
	private Transform pivotTransform;

	[SerializeField]
	private float targetLengthLow;

	[SerializeField]
	private float centerLow;

	public float PositionRatio;

	private void Update()
	{
	}
}
