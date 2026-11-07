using RootMotion.Demos;
using RootMotion.Dynamics;

public class WrestlingAIController : UserControlThirdPerson
{
	public float getUpGracePeriod;

	public float knockOutTime;

	public BehaviourPuppet behaviourPuppet;

	public PuppetMaster puppetMaster;

	public BehaviourFall fallBehaviour;

	public float unconsciousTimer;

	public float consciousTimer;

	public int health;

	private float lastFallTime;

	private float lastGetupTime;

	private bool isFallen;

	private void Awake()
	{
	}

	private void OnRecover()
	{
	}

	private void OnFall()
	{
	}

	protected override void Update()
	{
	}

	private void OnLostBalance()
	{
	}
}
