using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003B4")]
public class OverworldSeaAreaMusic : OverworldMusicChanger
{
	[Token(Token = "0x400145D")]
	[FieldOffset(Offset = "0x20")]
	public OverworldMusicData SailingMusic;

	[Token(Token = "0x400145E")]
	[FieldOffset(Offset = "0x28")]
	public OverworldMusicData IslandMusic;

	[Token(Token = "0x400145F")]
	[FieldOffset(Offset = "0x30")]
	public float BehaviourCooldown;

	[Token(Token = "0x4001460")]
	[FieldOffset(Offset = "0x34")]
	public float minimumPierDistance;

	[Token(Token = "0x4001461")]
	[FieldOffset(Offset = "0x38")]
	public float minFlagDistance;

	[Token(Token = "0x4001462")]
	[FieldOffset(Offset = "0x40")]
	public Transform[] dockingPoints;

	[Token(Token = "0x4001463")]
	[FieldOffset(Offset = "0x48")]
	public Transform IslandFlagContainer;

	[Token(Token = "0x4001464")]
	[FieldOffset(Offset = "0x50")]
	private Transmogriffable m_transmogriffable;

	[Token(Token = "0x4001465")]
	[FieldOffset(Offset = "0x58")]
	private Transmogrif.BALLSHAPES m_lastShape;

	[Token(Token = "0x4001466")]
	[FieldOffset(Offset = "0x5C")]
	private bool DoSailBehaviour;

	[Token(Token = "0x4001467")]
	[FieldOffset(Offset = "0x5D")]
	private bool DoIslandBehaviour;

	[Token(Token = "0x4001468")]
	[FieldOffset(Offset = "0x60")]
	private OverworldGoal[] goals;

	[Token(Token = "0x4001469")]
	[FieldOffset(Offset = "0x68")]
	private float m_lastRTPC_Time;

	[Token(Token = "0x600118E")]
	[Address(RVA = "0x15CB38C", Offset = "0x15CB38C", VA = "0x15CB38C", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x600118F")]
	[Address(RVA = "0x15CB390", Offset = "0x15CB390", VA = "0x15CB390")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	[Token(Token = "0x6001190")]
	[Address(RVA = "0x15CB630", Offset = "0x15CB630", VA = "0x15CB630")]
	private void OnTriggerExit2D(Collider2D collision)
	{
	}

	[Token(Token = "0x6001191")]
	[Address(RVA = "0x15CB6E0", Offset = "0x15CB6E0", VA = "0x15CB6E0")]
	private void Update()
	{
	}

	[Token(Token = "0x6001192")]
	private void SetByDistance<T>(T[] array, float minDist, MusicData music, float minRTPC, float maxRTPC) where T : Component
	{
	}

	[Token(Token = "0x6001193")]
	[Address(RVA = "0x15CB858", Offset = "0x15CB858", VA = "0x15CB858")]
	public OverworldSeaAreaMusic()
	{
	}
}
