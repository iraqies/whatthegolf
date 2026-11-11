using RootMotion.Demos;
using RootMotion.Dynamics;
using UnityEngine;

public class WrestlingAIController : UserControlThirdPerson
{
	public float getUpGracePeriod = 1f;

	public float knockOutTime = 3f;

	public BehaviourPuppet behaviourPuppet;

	public PuppetMaster puppetMaster;

	public BehaviourFall fallBehaviour;

	public float unconsciousTimer;

	public float consciousTimer;

	public int health = 3;

	private float lastFallTime;

	private float lastGetupTime;

	private bool isFallen;

	private void Awake()
	{
		if (behaviourPuppet != null && behaviourPuppet.onLoseBalance.unityEvent != null)
		{
			behaviourPuppet.onLoseBalance.unityEvent.AddListener(OnLostBalance);
		}
		if (fallBehaviour != null)
		{
			fallBehaviour.OnPreActivate = (BehaviourBase.BehaviourDelegate)System.Delegate.Combine(fallBehaviour.OnPreActivate, new BehaviourBase.BehaviourDelegate(OnFall));
			fallBehaviour.OnPreDeactivate = (BehaviourBase.BehaviourDelegate)System.Delegate.Combine(fallBehaviour.OnPreDeactivate, new BehaviourBase.BehaviourDelegate(OnRecover));
		}
	}

	private void OnRecover()
	{
		isFallen = false;
		lastGetupTime = Time.time;
	}

	private void OnFall()
	{
		unconsciousTimer = 0f;
		consciousTimer = 0f;
		isFallen = true;
	}

	protected override void Update()
	{
		base.Update();
		if (isFallen)
		{
			unconsciousTimer += Time.deltaTime;
		}
		else
		{
			consciousTimer += Time.deltaTime;
		}
	}

	private void OnLostBalance()
	{
		if (behaviourPuppet != null)
		{
			health--;
		}
	}
}
