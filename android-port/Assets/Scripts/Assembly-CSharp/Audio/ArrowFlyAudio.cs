using UnityEngine;

namespace Audio
{
	public class ArrowFlyAudio : MonoBehaviour
	{
		[SerializeField]
		private float minStartVelocity;

		[SerializeField]
		private float maxStartVelocity;

		[SerializeField]
		private Arrow2D m_arrow;

		[SerializeField]
		private ClipSettingsCollection FlyoffSFX;

		[SerializeField]
		private ClipSettingsCollection HitSFX;

		[SerializeField]
		private ClipSettingsCollection HitGoalSFX;

		private Coroutine m_followRoutine;

		private bool justEnabled;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void FixedUpdate()
		{
		}

		private void OnHit_MissGoal()
		{
		}

		private void OnHitGoal()
		{
		}
	}
}
