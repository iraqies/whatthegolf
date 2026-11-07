using System;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200039F")]
public class LevelMusic : MonoBehaviour
{
	[Token(Token = "0x40013FB")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CF90", Offset = "0x4CF90")]
	private Action m_OnIntialized;

	[Token(Token = "0x40013FC")]
	[FieldOffset(Offset = "0x20")]
	public bool isMoving;

	[Token(Token = "0x40013FD")]
	[FieldOffset(Offset = "0x24")]
	public float distanceNormalized;

	[Token(Token = "0x40013FE")]
	[FieldOffset(Offset = "0x28")]
	public bool isAimingAffectingTime;

	[Token(Token = "0x40013FF")]
	[FieldOffset(Offset = "0x29")]
	public bool isSettingSlowmotionContinuesly;

	[Token(Token = "0x4001400")]
	[FieldOffset(Offset = "0x2A")]
	public bool isSlowmotion;

	[Token(Token = "0x4001401")]
	[FieldOffset(Offset = "0x2B")]
	public bool isInitialized;

	[Token(Token = "0x4001402")]
	[FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CFA0", Offset = "0x4CFA0")]
	private Action<int> m_OnShoot;

	[Token(Token = "0x4001403")]
	[FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CFB0", Offset = "0x4CFB0")]
	private Action<int> m_OnAimtStart;

	[Token(Token = "0x4001404")]
	[FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CFC0", Offset = "0x4CFC0")]
	private Action m_OnGoal;

	[Token(Token = "0x4001405")]
	[FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CFD0", Offset = "0x4CFD0")]
	private Action m_OnFail;

	[Token(Token = "0x4001406")]
	[FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CFE0", Offset = "0x4CFE0")]
	private Action m_OnStart;

	[Token(Token = "0x4001407")]
	[FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CFF0", Offset = "0x4CFF0")]
	private Action<bool> m_OnAimUpdate;

	[Token(Token = "0x4001408")]
	[FieldOffset(Offset = "0x60")]
	private GolfBallController ball;

	[Token(Token = "0x4001409")]
	[FieldOffset(Offset = "0x68")]
	private GolfGoal goal;

	[Token(Token = "0x400140A")]
	[FieldOffset(Offset = "0x70")]
	private float maxDistance;

	[Token(Token = "0x400140B")]
	[FieldOffset(Offset = "0x74")]
	private int strokeCount;

	[Token(Token = "0x400140C")]
	[FieldOffset(Offset = "0x78")]
	private Level currentLevel;

	[Token(Token = "0x400140D")]
	[FieldOffset(Offset = "0x80")]
	private float ballLocateTimer;

	[Token(Token = "0x1400000D")]
	public event Action OnIntialized
	{
		[Token(Token = "0x6001124")]
		[Address(RVA = "0x152F584", Offset = "0x152F584", VA = "0x152F584")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6185C", Offset = "0x6185C")]
		add
		{
		}
		[Token(Token = "0x6001125")]
		[Address(RVA = "0x152F628", Offset = "0x152F628", VA = "0x152F628")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6186C", Offset = "0x6186C")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000E")]
	public event Action<int> OnShoot
	{
		[Token(Token = "0x6001126")]
		[Address(RVA = "0x152F6CC", Offset = "0x152F6CC", VA = "0x152F6CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6187C", Offset = "0x6187C")]
		add
		{
		}
		[Token(Token = "0x6001127")]
		[Address(RVA = "0x152F770", Offset = "0x152F770", VA = "0x152F770")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6188C", Offset = "0x6188C")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000F")]
	public event Action<int> OnAimtStart
	{
		[Token(Token = "0x6001128")]
		[Address(RVA = "0x152F814", Offset = "0x152F814", VA = "0x152F814")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6189C", Offset = "0x6189C")]
		add
		{
		}
		[Token(Token = "0x6001129")]
		[Address(RVA = "0x152F8B8", Offset = "0x152F8B8", VA = "0x152F8B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618AC", Offset = "0x618AC")]
		remove
		{
		}
	}

	[Token(Token = "0x14000010")]
	public event Action OnGoal
	{
		[Token(Token = "0x600112A")]
		[Address(RVA = "0x152F95C", Offset = "0x152F95C", VA = "0x152F95C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618BC", Offset = "0x618BC")]
		add
		{
		}
		[Token(Token = "0x600112B")]
		[Address(RVA = "0x152FA00", Offset = "0x152FA00", VA = "0x152FA00")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618CC", Offset = "0x618CC")]
		remove
		{
		}
	}

	[Token(Token = "0x14000011")]
	public event Action OnFail
	{
		[Token(Token = "0x600112C")]
		[Address(RVA = "0x152FAA4", Offset = "0x152FAA4", VA = "0x152FAA4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618DC", Offset = "0x618DC")]
		add
		{
		}
		[Token(Token = "0x600112D")]
		[Address(RVA = "0x152FB48", Offset = "0x152FB48", VA = "0x152FB48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618EC", Offset = "0x618EC")]
		remove
		{
		}
	}

	[Token(Token = "0x14000012")]
	public event Action OnStart
	{
		[Token(Token = "0x600112E")]
		[Address(RVA = "0x152FBEC", Offset = "0x152FBEC", VA = "0x152FBEC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618FC", Offset = "0x618FC")]
		add
		{
		}
		[Token(Token = "0x600112F")]
		[Address(RVA = "0x152FC90", Offset = "0x152FC90", VA = "0x152FC90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6190C", Offset = "0x6190C")]
		remove
		{
		}
	}

	[Token(Token = "0x14000013")]
	public event Action<bool> OnAimUpdate
	{
		[Token(Token = "0x6001130")]
		[Address(RVA = "0x152FD34", Offset = "0x152FD34", VA = "0x152FD34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6191C", Offset = "0x6191C")]
		add
		{
		}
		[Token(Token = "0x6001131")]
		[Address(RVA = "0x152FDD8", Offset = "0x152FDD8", VA = "0x152FDD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6192C", Offset = "0x6192C")]
		remove
		{
		}
	}

	[Token(Token = "0x6001132")]
	[Address(RVA = "0x1523F34", Offset = "0x1523F34", VA = "0x1523F34")]
	public void InitializeForCurrentLevel(GolfGoal goal, GolfBallController ball, Level level)
	{
	}

	[Token(Token = "0x6001133")]
	[Address(RVA = "0x152FE7C", Offset = "0x152FE7C", VA = "0x152FE7C")]
	private void CurrentLevel_OnStart()
	{
	}

	[Token(Token = "0x6001134")]
	[Address(RVA = "0x152FE90", Offset = "0x152FE90", VA = "0x152FE90")]
	private void CurrentLevel_OnReset()
	{
	}

	[Token(Token = "0x6001135")]
	[Address(RVA = "0x152FE98", Offset = "0x152FE98", VA = "0x152FE98")]
	private void CurrentLevel_OnOutOfBounds()
	{
	}

	[Token(Token = "0x6001136")]
	[Address(RVA = "0x152FEA0", Offset = "0x152FEA0", VA = "0x152FEA0")]
	private void CurrentLevel_OnGoal(Level.CompletedState s)
	{
	}

	[Token(Token = "0x6001137")]
	[Address(RVA = "0x152FEB4", Offset = "0x152FEB4", VA = "0x152FEB4")]
	public void OnLevelWillUnload()
	{
	}

	[Token(Token = "0x6001138")]
	[Address(RVA = "0x1530408", Offset = "0x1530408", VA = "0x1530408")]
	private void Level_OnFail(GolfBallController arg1, string arg2, Level.State state)
	{
	}

	[Token(Token = "0x6001139")]
	[Address(RVA = "0x15304B8", Offset = "0x15304B8", VA = "0x15304B8")]
	private void Ball_OnShoot(Vector3 obj)
	{
	}

	[Token(Token = "0x600113A")]
	[Address(RVA = "0x153054C", Offset = "0x153054C", VA = "0x153054C")]
	private void Ball_OnCancel()
	{
	}

	[Token(Token = "0x600113B")]
	[Address(RVA = "0x15305AC", Offset = "0x15305AC", VA = "0x15305AC")]
	private void Ball_OnAimStart()
	{
	}

	[Token(Token = "0x600113C")]
	[Address(RVA = "0x1530634", Offset = "0x1530634", VA = "0x1530634")]
	private void Update()
	{
	}

	[Token(Token = "0x600113D")]
	[Address(RVA = "0x15308AC", Offset = "0x15308AC", VA = "0x15308AC")]
	public LevelMusic()
	{
	}
}
