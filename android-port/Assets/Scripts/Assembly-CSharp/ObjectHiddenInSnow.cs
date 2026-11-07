using System.Collections;
using Audio;
using UnityEngine;

public class ObjectHiddenInSnow : MonoBehaviour
{
	[SerializeField]
	private Animator m_animator;

	[SerializeField]
	private bool m_stay;

	[SerializeField]
	private float m_timeBeforeDisappearing;

	[SerializeField]
	private float m_ballSpeedAfterColliding;

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
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	private void OnEnable()
	{
	}

	private void RevealItself()
	{
	}

	private IEnumerator RevealAndStayForAwhile()
	{
		return null;
	}
}
