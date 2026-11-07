using UnityEngine;

public class AvatarOnTop : MonoBehaviour
{
	public Animator animator;

	public Rigidbody rigidbodyOverride;

	public float animatorOffset;

	public float animationSpeedMod;

	public bool setAnimationSpeed;

	public SphereCollider ballCollider;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}
}
