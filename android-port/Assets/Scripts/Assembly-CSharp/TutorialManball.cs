using Core;
using UnityEngine;

public class TutorialManball : MonoBehaviour
{
	[SerializeField]
	private SpeechBubble _bubble;

	[SerializeField]
	private GolfBallController _ball;

	private int _shotCount;

	private float _noActionDuration;

	private bool _shown;

	private float _shownTime;

	private const float INACTIVE_DURATION = 10f;

	private void Start()
	{
	}

	private void OnShoot(Vector3 aim)
	{
	}

	private void Update()
	{
	}
}
