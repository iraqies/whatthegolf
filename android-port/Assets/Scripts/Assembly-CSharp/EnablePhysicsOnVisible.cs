using UnityEngine;

public class EnablePhysicsOnVisible : GolfBehaviour
{
	public Rigidbody2D target;

	public InvisibleCullingObject cullingObject;

	public bool forceSleep;

	public override void OnPrePlayOrPreCompile()
	{
	}

	public void Sleep()
	{
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}
}
