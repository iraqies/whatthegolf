using System.Collections.Generic;
using Core;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoguelikeShooter : GolfBallShooterExperimental
{
	public List<GameObject> HealthIcons;

	public ParticleSystem HeartBreakParticles;

	public LayerMask HitLayers;

	public float StepSize;

	private void Start()
	{
		if (StepSize > 0f)
		{
			Vector3 pos = transform.position;
			transform.position = new Vector3(Mathf.RoundToInt(pos.x / StepSize) * StepSize, pos.y, Mathf.RoundToInt(pos.z / StepSize) * StepSize);
		}
	}

	public override void OnShoot(Vector3 boost)
	{
		Vector3 step = boost * StepSize;
		if (Physics.SphereCast(transform.position, 1f, step, out RaycastHit hit, StepSize, HitLayers))
		{
			if (hit.transform != null)
			{
				RoguelikeEnemy enemy = hit.transform.gameObject.GetComponent<RoguelikeEnemy>();
				if (enemy != null)
					enemy.Die();
			}
		}
		transform.position += step;
		if (StepSize > 0f)
		{
			Vector3 pos = transform.position;
			transform.position = new Vector3(Mathf.RoundToInt(pos.x / StepSize) * StepSize, pos.y, Mathf.RoundToInt(pos.z / StepSize) * StepSize);
		}
	}

	public void TakeDamage()
	{
		if (HealthIcons == null || HealthIcons.Count == 0)
			return;
		int lastIdx = HealthIcons.Count - 1;
		GameObject icon = HealthIcons[lastIdx];
		if (HeartBreakParticles != null && icon != null)
		{
			HeartBreakParticles.transform.position = icon.transform.position;
			HeartBreakParticles.Emit(200);
		}
		if (icon != null)
			Destroy(icon);
		HealthIcons.RemoveAt(lastIdx);
		if (HealthIcons.Count == 0)
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
	}
}
