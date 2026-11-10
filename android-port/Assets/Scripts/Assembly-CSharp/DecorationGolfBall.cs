using System.Collections.Generic;
using Core;
using UnityEngine;

public class DecorationGolfBall : MonoBehaviour
{
	[SerializeField]
	private List<AudioClip> clips;

	[SerializeField]
	private float baseVolume = 0.04f;

	[SerializeField]
	private float volumeDeviance = 0.03f;

	[SerializeField]
	private float basePitch = 1.1f;

	[SerializeField]
	private float pitchDeviance = 0.08f;

	[SerializeField]
	private float force = 2f;

	public bool useLocalY;

	[SerializeField]
	private Vector2 upwardsForceRange = new Vector2(0.5f, 1f);

	[SerializeField]
	private List<string> otherTags;

	[SerializeField]
	private LayerMask otherLayers;

	[SerializeField]
	private float minForce;

	[SerializeField]
	private float useImpactVelocity;

	private Rigidbody rigid;

	private Rigidbody2D rigid2D;

	private float nextPush;

	private void Awake()
	{
		rigid = GetComponent<Rigidbody>();
		rigid2D = GetComponent<Rigidbody2D>();
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (rigid == null || Time.time <= nextPush || collision == null || collision.rigidbody == null)
		{
			return;
		}
		bool valid = collision.rigidbody.GetComponent<GolfBallController>() != null;
		if (!valid && otherTags != null && collision.transform != null && otherTags.Contains(collision.transform.tag))
		{
			valid = true;
		}
		if (!valid && collision.gameObject != null)
		{
			int mask = otherLayers;
			if (mask == (mask | (1 << collision.gameObject.layer)))
			{
				valid = true;
			}
		}
		if (valid && collision.contacts != null && collision.contacts.Length > 0)
		{
			Vector3 vel = ((useImpactVelocity > 0f) ? collision.relativeVelocity : collision.rigidbody.velocity);
			TryKick(vel, collision.contacts[0].point, collision.contacts[0].normal);
		}
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
		if (rigid2D == null || Time.time <= nextPush || other == null || other.rigidbody == null)
		{
			return;
		}
		bool valid = other.rigidbody.GetComponent<GolfBallController>() != null;
		if (!valid && otherTags != null && other.transform != null && otherTags.Contains(other.transform.tag))
		{
			valid = true;
		}
		if (!valid && other.gameObject != null)
		{
			int mask = otherLayers;
			if (mask == (mask | (1 << other.gameObject.layer)))
			{
				valid = true;
			}
		}
		if (valid && other.contacts != null && other.contacts.Length > 0)
		{
			Vector2 vel = other.rigidbody.velocity;
			Vector2 pt = other.contacts[0].point;
			Vector2 n = other.contacts[0].normal;
			TryKick(new Vector3(vel.x, vel.y, 0f), new Vector3(pt.x, pt.y, 0f), new Vector3(n.x, n.y, 0f));
		}
	}

	private void TryKick(Vector3 magnitude, Vector3 point, Vector3 normal)
	{
		if (magnitude.magnitude < minForce)
		{
			return;
		}
		nextPush = Time.time + 0.1f;
		Vector3 dir = normal;
		if (upwardsForceRange.magnitude > 0f)
		{
			if (useLocalY)
			{
				dir += base.transform.up * Random.Range(upwardsForceRange.x, upwardsForceRange.y);
			}
			else
			{
				dir.y = 0f;
				dir.Normalize();
				dir.y = Random.Range(upwardsForceRange.x, upwardsForceRange.y);
			}
		}
		else
		{
			dir.Normalize();
		}
		float randMult = Random.Range(0.8f, 1.3f);
		Vector3 kickForce = ((useImpactVelocity > 0f) ? (magnitude * useImpactVelocity) : (dir * randMult * force));
		if (rigid != null)
		{
			rigid.AddForceAtPosition(kickForce, point, ForceMode.Impulse);
		}
		else if (rigid2D != null)
		{
			rigid2D.AddForceAtPosition(new Vector2(kickForce.x, kickForce.y), new Vector2(point.x, point.y), ForceMode2D.Impulse);
		}
		PlaySfx();
	}

	private void PlaySfx()
	{
		if (AudioManager.Instance == null || AudioManager.Instance.shortEffects == null || clips == null || clips.Count == 0)
		{
			return;
		}
		AudioManager.Instance.shortEffects.Play(clips, delegate(AudioSource s)
		{
			if (s != null)
			{
				s.transform.position = base.transform.position;
				s.volume = Random.Range(baseVolume - volumeDeviance, baseVolume + volumeDeviance);
				float p = basePitch - pitchDeviance;
				s.pitch = Random.Range(p, basePitch + pitchDeviance);
				s.priority = 200;
			}
		}, true, false, 0f);
	}
}
