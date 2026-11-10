using System.Collections;
using Core;
using UnityEngine;

public class WackAMoleBehaviour : MonoBehaviour
{
	public Transform[] holes;

	public GameObject flag;

	public ParticleSystem poofParticles;

	public float timeOnEachHole = 2f;

	public float movementSpeed = 5f;

	public int hitNeeded = 3;

	public Vector3 appearInHoleOffset = new Vector3(0f, 1.5f, 0f);

	public Vector3 hideInHoleOffset = new Vector3(0f, -1.5f, 0f);

	private int previousIndex = -1;

	private bool isInvincible;

	[SerializeField]
	private ParticleSystem _particles;

	[SerializeField]
	private PlayAudioClipSetting _onHitSFX;

	[SerializeField]
	private AnimationCurve _MoveDownAnimationCurve = AnimationCurve.EaseInOut(0f, 0f, 1f, 1f);

	[SerializeField]
	private AnimationCurve _MoveUpAnimationCurve = AnimationCurve.EaseInOut(0f, 0f, 1f, 1f);

	private void Start()
	{
		StartCoroutine(MoveUp());
	}

	private IEnumerator MoveUp()
	{
		if (holes == null || holes.Length == 0)
		{
			yield break;
		}
		while (hitNeeded > 0)
		{
			int idx = RandomHole();
			Transform hole = holes[idx];
			if (hole != null)
			{
				Vector3 startPos = hole.position + hideInHoleOffset;
				Vector3 endPos = hole.position + appearInHoleOffset;
				transform.position = startPos;
				if (poofParticles != null)
				{
					poofParticles.transform.position = hole.position;
					poofParticles.Play();
				}
				float dur = Mathf.Max(0.15f, 1f / Mathf.Max(1f, movementSpeed));
				float t = 0f;
				isInvincible = false;
				while (t < dur && !isInvincible)
				{
					t += Time.deltaTime;
					float n = Mathf.Clamp01(t / dur);
					float eval = _MoveUpAnimationCurve != null && _MoveUpAnimationCurve.length > 0 ? _MoveUpAnimationCurve.Evaluate(n) : n;
					transform.position = Vector3.Lerp(startPos, endPos, eval);
					yield return null;
				}
				float stay = 0f;
				while (stay < Mathf.Max(0.5f, timeOnEachHole) && !isInvincible)
				{
					stay += Time.deltaTime;
					yield return null;
				}
				if (!isInvincible)
				{
					yield return StartCoroutine(MoveDown(false));
				}
			}
			else
			{
				yield return null;
			}
		}
	}

	private IEnumerator MoveDown(bool wasHit = false)
	{
		Vector3 startPos = transform.position;
		Vector3 endPos = startPos + hideInHoleOffset - appearInHoleOffset;
		float dur = Mathf.Max(0.15f, 1f / Mathf.Max(1f, movementSpeed));
		float t = 0f;
		while (t < dur)
		{
			t += Time.deltaTime;
			float n = Mathf.Clamp01(t / dur);
			float eval = _MoveDownAnimationCurve != null && _MoveDownAnimationCurve.length > 0 ? _MoveDownAnimationCurve.Evaluate(n) : n;
			transform.position = Vector3.Lerp(startPos, endPos, eval);
			yield return null;
		}
		transform.position = endPos;
	}

	private IEnumerator GotHit()
	{
		isInvincible = true;
		hitNeeded--;
		if (_onHitSFX != null)
		{
			_onHitSFX.Play();
		}
		if (_particles != null)
		{
			_particles.Play();
		}
		yield return StartCoroutine(MoveDown(true));
		if (hitNeeded <= 0)
		{
			Win();
		}
		else
		{
			isInvincible = false;
		}
	}

	public int RandomHole()
	{
		if (holes == null || holes.Length == 0)
		{
			return 0;
		}
		if (holes.Length == 1)
		{
			return 0;
		}
		int idx = Random.Range(0, holes.Length);
		if (idx == previousIndex)
		{
			idx = (idx + 1) % holes.Length;
		}
		previousIndex = idx;
		return idx;
	}

	public void Win()
	{
		if (flag != null)
		{
			flag.SetActive(true);
		}
		if (Level.HasInstance && Level.Instance != null)
		{
			Level.Instance.Complete();
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (!isInvincible && collision != null && collision.gameObject.CompareTag("Player"))
		{
			StartCoroutine(GotHit());
		}
	}

	public void FlagHit()
	{
		if (!isInvincible)
		{
			StartCoroutine(GotHit());
		}
	}

	private void RemoveBall(GameObject ball)
	{
		if (ball != null)
		{
			ball.SetActive(false);
		}
	}
}
