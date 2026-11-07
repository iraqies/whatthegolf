using Il2CppDummyDll;
using RootMotion.Demos;
using RootMotion.Dynamics;

[Token(Token = "0x200027C")]
public class WrestlingAIController : UserControlThirdPerson
{
	[Token(Token = "0x4000D15")]
	[FieldOffset(Offset = "0x48")]
	public float getUpGracePeriod;

	[Token(Token = "0x4000D16")]
	[FieldOffset(Offset = "0x4C")]
	public float knockOutTime;

	[Token(Token = "0x4000D17")]
	[FieldOffset(Offset = "0x50")]
	public BehaviourPuppet behaviourPuppet;

	[Token(Token = "0x4000D18")]
	[FieldOffset(Offset = "0x58")]
	public PuppetMaster puppetMaster;

	[Token(Token = "0x4000D19")]
	[FieldOffset(Offset = "0x60")]
	public BehaviourFall fallBehaviour;

	[Token(Token = "0x4000D1A")]
	[FieldOffset(Offset = "0x68")]
	public float unconsciousTimer;

	[Token(Token = "0x4000D1B")]
	[FieldOffset(Offset = "0x6C")]
	public float consciousTimer;

	[Token(Token = "0x4000D1C")]
	[FieldOffset(Offset = "0x70")]
	public int health;

	[Token(Token = "0x4000D1D")]
	[FieldOffset(Offset = "0x74")]
	private float lastFallTime;

	[Token(Token = "0x4000D1E")]
	[FieldOffset(Offset = "0x78")]
	private float lastGetupTime;

	[Token(Token = "0x4000D1F")]
	[FieldOffset(Offset = "0x7C")]
	private bool isFallen;

	[Token(Token = "0x6000B3D")]
	[Address(RVA = "0x175BF84", Offset = "0x175BF84", VA = "0x175BF84")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000B3E")]
	[Address(RVA = "0x175C120", Offset = "0x175C120", VA = "0x175C120")]
	private void OnRecover()
	{
	}

	[Token(Token = "0x6000B3F")]
	[Address(RVA = "0x175C14C", Offset = "0x175C14C", VA = "0x175C14C")]
	private void OnFall()
	{
	}

	[Token(Token = "0x6000B40")]
	[Address(RVA = "0x175C170", Offset = "0x175C170", VA = "0x175C170", Slot = "5")]
	protected override void Update()
	{
	}

	[Token(Token = "0x6000B41")]
	[Address(RVA = "0x175C24C", Offset = "0x175C24C", VA = "0x175C24C")]
	private void OnLostBalance()
	{
	}

	[Token(Token = "0x6000B42")]
	[Address(RVA = "0x175C27C", Offset = "0x175C27C", VA = "0x175C27C")]
	public WrestlingAIController()
	{
	}
}
