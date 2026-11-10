using Audio;
using Core;
using UnityEngine;

public class BeachBall : MonoBehaviour
{
	[SerializeField]
	private GolfBallController Controller;

	[SerializeField]
	private ParticleSystem explosionParticleSystem;

	[SerializeField]
	private RandomAudioClips bangClips;

	[SerializeField]
	private float popOnCollisionThreshold = -1f;

	[SerializeField]
	private bool failOnPopped = true;

	[SerializeField]
	private bool instantiateParticleSystem;

	private bool popped;

	private Level level;

	private void Awake()
	{
		level = Level.Instance;
	}

	public void Bang()
	{
		if (Level.Instance != null && Level.Instance.IsMultiplayer)
		{
			if (bangClips != null)
			{
				bangClips.PlayRandomClip(base.transform);
			}
			if (explosionParticleSystem != null)
			{
				explosionParticleSystem.Emit(10);
			}
			if (Controller != null)
			{
				Controller.Reset(0f);
			}
		}
		else if (!popped)
		{
			if (failOnPopped && level != null)
			{
				level.Fail(true, true, null, 0f, true, "");
			}
			if (bangClips != null)
			{
				bangClips.PlayRandomClip(base.transform);
			}
			ParticleSystem ps = explosionParticleSystem;
			if (instantiateParticleSystem && ps != null)
			{
				ps = Object.Instantiate(ps, base.transform.position, Quaternion.identity);
				if (ps != null && base.gameObject.scene.IsValid() && ps.gameObject.scene != base.gameObject.scene)
				{
					UnityEngine.SceneManagement.SceneManager.MoveGameObjectToScene(ps.gameObject, base.gameObject.scene);
				}
			}
			if (ps != null)
			{
				ps.transform.position = base.transform.position;
				ps.Emit(10);
			}
			if (Controller != null)
			{
				if (Controller.shootArrow != null)
				{
					Controller.shootArrow.Hide();
				}
				Controller.gameObject.SetActive(false);
			}
			popped = true;
		}
	}

	private void OnCollisionEnter(Collision other)
	{
		if (popOnCollisionThreshold >= 0f && other != null && other.impulse.magnitude > popOnCollisionThreshold)
		{
			Bang();
		}
	}
}
