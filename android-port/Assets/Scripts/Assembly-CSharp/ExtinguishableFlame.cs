using UnityEngine;
using UnityEngine.Events;

public class ExtinguishableFlame : MonoBehaviour
{
	public Transform flameTransform;

	public float loseHealthCooldown;

	public float flameScaleTime = 0.5f;

	public int startingHealth;

	public Vector3 endScale = new Vector3(0.01f, 0.01f, 0.01f);

	public UnityEvent OnFlameExtinguished;

	private float m_lastHealthTime;

	private Vector3 m_StartScale;

	public int CurrentHealth { get; private set; }

	private void Awake()
	{
		CurrentHealth = startingHealth;
		m_StartScale = flameTransform.transform.localScale;
	}

	public void TakeDamage(int damage)
	{
		if (Time.time < m_lastHealthTime + loseHealthCooldown)
		{
			return;
		}
		m_lastHealthTime = Time.time;
		CurrentHealth -= damage;
		Vector3 scale = flameTransform.transform.localScale;
		float value = (float)CurrentHealth / (float)startingHealth;
		Vector3 targetScale = Vector3.Lerp(endScale, m_StartScale, Mathf.Clamp01(value));
		if (flameScaleTime > loseHealthCooldown)
		{
			flameScaleTime = loseHealthCooldown;
		}
		if (CurrentHealth > 0)
		{
			StartCoroutine(pTween.To(flameScaleTime, delegate(float v)
			{
				flameTransform.transform.localScale = Vector3.Lerp(scale, targetScale, TweenFunctions.EaseOut(v));
			}));
		}
		else
		{
			StartCoroutine(pTween.To(flameScaleTime, delegate(float v)
			{
				flameTransform.transform.localScale = Vector3.Lerp(scale, targetScale, TweenFunctions.EaseOut(v));
			}).Then(delegate
			{
				OnFlameExtinguished?.Invoke();
			}));
		}
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Q))
		{
			TakeDamage(1);
		}
	}
}
