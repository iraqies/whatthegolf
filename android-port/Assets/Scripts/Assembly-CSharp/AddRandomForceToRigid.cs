using Audio;
using UnityEngine;
using UnityEngine.Events;

public class AddRandomForceToRigid : MonoBehaviour
{
	[SerializeField]
	private Rigidbody Rigidbody;

	[SerializeField]
	private ParticleSystem Particles;

	[SerializeField]
	private float forceMultiplier;

	[SerializeField]
	private Animator Animator;

	[SerializeField]
	private AudioEventAsset sfxEventOnCollapse;

	[SerializeField]
	private bool CountTicks;

	[SerializeField]
	private UnityEvent BeforeCollapse;

	private bool hasCollapsed;

	public void AddForceToAllOther()
	{
	}

	public void Collapse(Transform center)
	{
	}
}
