using UnityEngine;

public class EnablePhysicsOnVisible : GolfBehaviour
{
	public Rigidbody2D target;

	public InvisibleCullingObject cullingObject;

	public bool forceSleep;

	public override void OnPrePlayOrPreCompile()
	{
		base.OnPrePlayOrPreCompile();
		if (target == null)
		{
			target = GetComponent<Rigidbody2D>();
		}
		if (cullingObject == null)
		{
			cullingObject = GetComponent<InvisibleCullingObject>();
		}
	}

	public void Sleep()
	{
		if (target != null)
		{
			target.Sleep();
		}
	}

	private void Awake()
	{
		if (target == null)
		{
			target = GetComponent<Rigidbody2D>();
		}
		if (forceSleep && target != null)
		{
			target.Sleep();
		}
	}

	private void OnEnable()
	{
		if (target != null)
		{
			target.simulated = true;
			if (forceSleep)
			{
				target.Sleep();
			}
		}
	}
}
