using System.Collections;
using UnityEngine;

public class WackAMoleBehaviour : MonoBehaviour
{
	public Transform[] holes;

	public GameObject flag;

	public ParticleSystem poofParticles;

	public float timeOnEachHole;

	public float movementSpeed;

	public int hitNeeded;

	public Vector3 appearInHoleOffset;

	public Vector3 hideInHoleOffset;

	private int previousIndex;

	private bool isInvincible;

	[SerializeField]
	private ParticleSystem _particles;

	[SerializeField]
	private PlayAudioClipSetting _onHitSFX;

	[SerializeField]
	private AnimationCurve _MoveDownAnimationCurve;

	[SerializeField]
	private AnimationCurve _MoveUpAnimationCurve;

	private void Start()
	{
	}

	private IEnumerator MoveUp()
	{
		return null;
	}

	private IEnumerator MoveDown(bool wasHit = false)
	{
		return null;
	}

	private IEnumerator GotHit()
	{
		return null;
	}

	public int RandomHole()
	{
		return 0;
	}

	public void Win()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	public void FlagHit()
	{
	}

	private void RemoveBall(GameObject ball)
	{
	}
}
