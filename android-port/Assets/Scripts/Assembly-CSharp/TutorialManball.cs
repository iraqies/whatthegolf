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
		if (_ball != null)
			_ball.OnShoot += OnShoot;
	}

	private void OnShoot(Vector3 aim)
	{
		int prev = _shotCount;
		_shotCount++;
		if (prev == 0 || aim.magnitude > 0.2f)
			_noActionDuration = 0f;

		if (_shown && _shownTime > 5f)
		{
			if (_ball != null)
				_ball.OnShoot -= OnShoot;
			if (_bubble != null)
				_bubble.Hide();
			enabled = false;
		}
	}

	private void Update()
	{
		if (_shown)
		{
			_shownTime += Time.deltaTime;
		}
		else
		{
			_noActionDuration += Time.deltaTime;
			if (_shotCount >= 1 && _noActionDuration > INACTIVE_DURATION)
			{
				_shown = true;
				if (_bubble != null)
					_bubble.Show();
			}
		}
	}
}
