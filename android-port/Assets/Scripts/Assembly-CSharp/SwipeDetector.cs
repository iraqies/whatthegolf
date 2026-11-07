using UnityEngine;
using UnityEngine.Events;

public class SwipeDetector : MonoBehaviour
{
	public float swipeThreshold;

	public float timeThreshold;

	public float degreesTreshold;

	public UnityEvent onSwipeLeft;

	public UnityEvent onSwipeRight;

	public UnityEvent onSwipeUp;

	public UnityEvent onSwipeDown;

	private Vector2 _fingerDown;

	private float _fingerDownTime;

	private Vector2 _fingerUp;

	private float _fingerUpTime;

	private void Update()
	{
	}

	private void CheckSwipe()
	{
	}
}
