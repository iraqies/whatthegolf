using Core;
using UnityEngine;

namespace Audio
{
	public class OnCollisionAudio : OnCollisionAudioBase
	{
		protected override void Init()
		{
			if (startingCooldown)
				nextSoundTime = Time.time + 0.5f + coolDown;
			if (GetComponent<GolfBallController>() != null || GetComponent<GolfGoal>() != null)
				ShouldMuteOnOutOfBounds = false;
		}

		private void OnCollisionEnter2D(Collision2D col)
		{
			if (col == null || col.contacts == null || col.contacts.Length == 0) return;
			ContactPoint2D contact = col.GetContact(0);
			GameObject otherGo = col.rigidbody != null ? col.rigidbody.gameObject : (contact.otherCollider != null ? contact.otherCollider.gameObject : col.gameObject);
			if (otherGo == null) return;
			GameObject thisGo = contact.collider != null ? contact.collider.gameObject : gameObject;
			Vector3 impactOnNormal = Vector3.Project(col.relativeVelocity, contact.normal);
			HitInfo hitInfo = new HitInfo
			{
				point = contact.point,
				incomingVelocity = impactOnNormal,
				impactOnNormal = impactOnNormal,
				childHit = thisGo,
				otherHit = otherGo
			};
			PlayAudioFromCollision(hitInfo);
		}

		private void OnCollisionEnter(Collision col)
		{
			if (col == null) return;
			ContactPoint contact = col.GetContact(0);
			GameObject otherGo = col.rigidbody != null ? col.rigidbody.gameObject : (contact.otherCollider != null ? contact.otherCollider.gameObject : col.gameObject);
			if (otherGo == null) return;
			GameObject thisGo = contact.thisCollider != null ? contact.thisCollider.gameObject : gameObject;
			Vector3 impactOnNormal = Vector3.Project(col.relativeVelocity, contact.normal);
			HitInfo hitInfo = new HitInfo
			{
				point = contact.point,
				incomingVelocity = impactOnNormal,
				impactOnNormal = impactOnNormal,
				childHit = thisGo,
				otherHit = otherGo
			};
			PlayAudioFromCollision(hitInfo);
		}

		private void OnTriggerEnter2D(Collider2D col)
		{
			if (col == null) return;
			CheckOutOfBounds(col.gameObject);
			if (useTrigger)
				PlayAudioFromTrigger(col.gameObject);
		}

		private void OnTriggerEnter(Collider col)
		{
			if (col == null) return;
			CheckOutOfBounds(col.gameObject);
			if (useTrigger)
				PlayAudioFromTrigger(col.gameObject);
		}
	}
}
