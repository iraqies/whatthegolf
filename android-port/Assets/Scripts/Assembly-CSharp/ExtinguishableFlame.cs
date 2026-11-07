using UnityEngine;
using UnityEngine.Events;

public class ExtinguishableFlame : MonoBehaviour
{
	public Transform flameTransform;

	public float loseHealthCooldown;

	public float flameScaleTime;

	public int startingHealth;

	public Vector3 endScale;

	public UnityEvent OnFlameExtinguished;

	private float m_lastHealthTime;

	private Vector3 m_StartScale;

	public int CurrentHealth { get; private set; }

	private void Awake()
	{
	}

	public void TakeDamage(int damage)
	{
	}

	private void Update()
	{
	}
}
