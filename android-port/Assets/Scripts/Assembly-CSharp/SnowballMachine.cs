using Audio;
using UnityEngine;

public class SnowballMachine : MonoBehaviour
{
	[SerializeField]
	private ParticleSystem m_snowballParticle;

	[SerializeField]
	private ClipSettingsCollection m_SpraySfx;

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}
}
