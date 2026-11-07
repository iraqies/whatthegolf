using System.Collections;
using UnityEngine;

namespace Audio
{
	public class EvilFlagAudio : MonoBehaviour
	{
		public ClipSettingsCollection SFX_OnStop_NoHit;

		public ClipSettingsCollection SFX_OnSlide_Start;

		public ClipSettingsCollection SFX_OnHitFlag;

		public ScheduleHarmonics scheduleHarmonics;

		public Rigidbody rigid;

		private bool canPlay;

		private Vector3 lastVelocity;

		private bool moving;

		private bool hitFlag;

		private IEnumerator Start()
		{
			return null;
		}

		public void HitFlag()
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
