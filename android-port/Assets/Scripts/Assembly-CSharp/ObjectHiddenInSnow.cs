using System.Collections;
using Audio;
using UnityEngine;

public class ObjectHiddenInSnow : MonoBehaviour
{
	[SerializeField]
	private Animator m_animator;

	[SerializeField]
	private bool m_stay = true;

	[SerializeField]
	private float m_timeBeforeDisappearing = 3f;

	[SerializeField]
	private float m_ballSpeedAfterColliding = 0.5f;

	[SerializeField]
	private ParticleSystem m_fallingSnowFX;

	[SerializeField]
	private Transform m_maskingPatchContainer;

	[SerializeField]
	private AudioEventAsset m_SfxOnAppear;

	private GameObject[] m_maskingSnowPatches;

	private Coroutine m_revealCoroutine;

	public bool m_isVisible;

	private void Start()
	{
		if (m_maskingPatchContainer != null)
		{
			int count = m_maskingPatchContainer.childCount;
			m_maskingSnowPatches = new GameObject[count];
			for (int i = 0; i < count; i++)
			{
				m_maskingSnowPatches[i] = m_maskingPatchContainer.GetChild(i).gameObject;
			}
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision == null || collision.collider == null || !collision.collider.CompareTag("GolfBall"))
		{
			return;
		}
		if (collision.rigidbody != null)
		{
			collision.rigidbody.velocity *= m_ballSpeedAfterColliding;
		}
		if (m_stay)
		{
			if (!m_isVisible)
			{
				RevealItself();
			}
			else if (m_animator != null)
			{
				m_animator.SetTrigger("Hit");
			}
		}
		else
		{
			if (m_revealCoroutine != null)
			{
				StopCoroutine(m_revealCoroutine);
			}
			m_revealCoroutine = StartCoroutine(RevealAndStayForAwhile());
		}
	}

	private void OnEnable()
	{
		if (m_isVisible && m_animator != null)
		{
			m_animator.SetTrigger("Appear");
		}
	}

	private void RevealItself()
	{
		if (m_animator != null)
		{
			m_animator.SetTrigger("Appear");
		}
		if (m_fallingSnowFX != null)
		{
			m_fallingSnowFX.Play();
		}
		if (m_SfxOnAppear != null)
		{
			m_SfxOnAppear.Play(transform.position, 1f, 1f);
		}
		if (m_maskingSnowPatches != null)
		{
			for (int i = 0; i < m_maskingSnowPatches.Length; i++)
			{
				if (m_maskingSnowPatches[i] != null)
				{
					m_maskingSnowPatches[i].SetActive(false);
				}
			}
		}
		m_isVisible = true;
		if (transform.parent != null)
		{
			SnowmanCluster cluster = transform.parent.GetComponent<SnowmanCluster>();
			if (cluster != null)
			{
				cluster.SnowmanActivated();
			}
		}
	}

	private IEnumerator RevealAndStayForAwhile()
	{
		RevealItself();
		yield return new WaitForSeconds(m_timeBeforeDisappearing);
		if (m_animator != null)
		{
			m_animator.SetTrigger("Disappear");
		}
		m_isVisible = false;
	}
}
