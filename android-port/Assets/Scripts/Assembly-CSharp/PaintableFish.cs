using UnityEngine;

public class PaintableFish : MonoBehaviour
{
	[SerializeField]
	private RigidbodyThrower thrower;

	[SerializeField]
	private Rigidbody rb;

	[SerializeField]
	private Vector3 velThres;

	[SerializeField]
	private float offset;

	[SerializeField]
	private ChangeColor cangeColor;

	[SerializeField]
	private PlayAudioClipSetting playAudioClipSetting;

	[SerializeField]
	private GameObject paintableFish;

	[SerializeField]
	private ActionAfterNumEvents ticker;

	private RaycastHit _hit;

	[SerializeField]
	private ParticleSystem PSystem;

	private void Collapse()
	{
	}

	private void FixedUpdate()
	{
	}
}
