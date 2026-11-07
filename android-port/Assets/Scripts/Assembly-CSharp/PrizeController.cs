using System;
using System.Collections.Generic;
using CameraStack;
using Core;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000F14")]
public class PrizeController : MonoBehaviour
{
	[Token(Token = "0x2000F15")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45660", Offset = "0x45660")]
	private sealed class _003C_003Ec__DisplayClass36_0
	{
		[Token(Token = "0x4005173")]
		[FieldOffset(Offset = "0x10")]
		public GolfBallController c;

		[Token(Token = "0x4005174")]
		[FieldOffset(Offset = "0x18")]
		public PrizeController _003C_003E4__this;

		[Token(Token = "0x6004693")]
		[Address(RVA = "0x182B140", Offset = "0x182B140", VA = "0x182B140")]
		public _003C_003Ec__DisplayClass36_0()
		{
		}

		[Token(Token = "0x6004694")]
		[Address(RVA = "0x182B148", Offset = "0x182B148", VA = "0x182B148")]
		internal void _003CStart_003Eb__7(Vector3 a, bool b)
		{
		}
	}

	[Token(Token = "0x2000F16")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45670", Offset = "0x45670")]
	private sealed class _003C_003Ec__DisplayClass36_1
	{
		[Token(Token = "0x4005175")]
		[FieldOffset(Offset = "0x10")]
		public GolfBallController c;

		[Token(Token = "0x4005176")]
		[FieldOffset(Offset = "0x18")]
		public PrizeController _003C_003E4__this;

		[Token(Token = "0x6004695")]
		[Address(RVA = "0x182B16C", Offset = "0x182B16C", VA = "0x182B16C")]
		public _003C_003Ec__DisplayClass36_1()
		{
		}

		[Token(Token = "0x6004696")]
		[Address(RVA = "0x182B174", Offset = "0x182B174", VA = "0x182B174")]
		internal void _003CStart_003Eb__8(Vector3 a)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000F17")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45680", Offset = "0x45680")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4005177")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4005178")]
		[FieldOffset(Offset = "0x8")]
		public static Func<MeshRenderer, Transform> _003C_003E9__36_0;

		[Token(Token = "0x4005179")]
		[FieldOffset(Offset = "0x10")]
		public static Func<Transform, float> _003C_003E9__36_1;

		[Token(Token = "0x400517A")]
		[FieldOffset(Offset = "0x18")]
		public static Func<DailyPrizeData.Prize, bool> _003C_003E9__36_3;

		[Token(Token = "0x400517B")]
		[FieldOffset(Offset = "0x20")]
		public static Func<DailyPrizeData.Prize, bool> _003C_003E9__36_4;

		[Token(Token = "0x400517C")]
		[FieldOffset(Offset = "0x28")]
		public static Func<DailyPrizeData.Prize, bool> _003C_003E9__47_0;

		[Token(Token = "0x6004698")]
		[Address(RVA = "0x182AFE0", Offset = "0x182AFE0", VA = "0x182AFE0")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6004699")]
		[Address(RVA = "0x182AFE8", Offset = "0x182AFE8", VA = "0x182AFE8")]
		internal Transform _003CStart_003Eb__36_0(MeshRenderer m)
		{
			return null;
		}

		[Token(Token = "0x600469A")]
		[Address(RVA = "0x182B004", Offset = "0x182B004", VA = "0x182B004")]
		internal float _003CStart_003Eb__36_1(Transform a)
		{
			return default;
		}

		[Token(Token = "0x600469B")]
		[Address(RVA = "0x182B03C", Offset = "0x182B03C", VA = "0x182B03C")]
		internal bool _003CStart_003Eb__36_3(DailyPrizeData.Prize a)
		{
			return default;
		}

		[Token(Token = "0x600469C")]
		[Address(RVA = "0x182B048", Offset = "0x182B048", VA = "0x182B048")]
		internal bool _003CStart_003Eb__36_4(DailyPrizeData.Prize a)
		{
			return default;
		}

		[Token(Token = "0x600469D")]
		[Address(RVA = "0x182B0C4", Offset = "0x182B0C4", VA = "0x182B0C4")]
		internal bool _003CGetNextPrize_003Eb__47_0(DailyPrizeData.Prize a)
		{
			return default;
		}
	}

	[Token(Token = "0x2000F18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45690", Offset = "0x45690")]
	private sealed class _003C_003Ec__DisplayClass52_0
	{
		[Token(Token = "0x400517D")]
		[FieldOffset(Offset = "0x10")]
		public Image i;

		[Token(Token = "0x400517E")]
		[FieldOffset(Offset = "0x18")]
		public Color s;

		[Token(Token = "0x400517F")]
		[FieldOffset(Offset = "0x28")]
		public Color e;

		[Token(Token = "0x600469E")]
		[Address(RVA = "0x182B198", Offset = "0x182B198", VA = "0x182B198")]
		public _003C_003Ec__DisplayClass52_0()
		{
		}

		[Token(Token = "0x600469F")]
		[Address(RVA = "0x182B1A0", Offset = "0x182B1A0", VA = "0x182B1A0")]
		internal void _003CDimImage_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x4005153")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private DailyPrizeData PrizeData;

	[Token(Token = "0x4005154")]
	[FieldOffset(Offset = "0x20")]
	private List<Transform> positions;

	[Token(Token = "0x4005155")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform positionContainer;

	[Token(Token = "0x4005156")]
	[FieldOffset(Offset = "0x30")]
	private List<DailyPrize> placedPrized;

	[Token(Token = "0x4005157")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private WinSceneUI winSceneUI;

	[Token(Token = "0x4005158")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject LockedCube;

	[Token(Token = "0x4005159")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private AnimateRectTransform ReplayBtn;

	[Token(Token = "0x400515A")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Image LeftPan;

	[Token(Token = "0x400515B")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Image RightPan;

	[Token(Token = "0x400515C")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Image LeftPanController;

	[Token(Token = "0x400515D")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Image RightPanController;

	[Token(Token = "0x400515E")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private List<Image> LeftPanController_c;

	[Token(Token = "0x400515F")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private List<Image> RightPanController_c;

	[Token(Token = "0x4005160")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private CameraBehavior cameraBehaviour;

	[Token(Token = "0x4005161")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private float leftMin;

	[Token(Token = "0x4005162")]
	[FieldOffset(Offset = "0x8C")]
	[SerializeField]
	private float leftMax;

	[Token(Token = "0x4005163")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private float rightMin;

	[Token(Token = "0x4005164")]
	[FieldOffset(Offset = "0x94")]
	[SerializeField]
	private float rightMax;

	[Token(Token = "0x4005165")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private float leftMin_s;

	[Token(Token = "0x4005166")]
	[FieldOffset(Offset = "0x9C")]
	[SerializeField]
	private float leftMax_s;

	[Token(Token = "0x4005167")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private float rightMin_s;

	[Token(Token = "0x4005168")]
	[FieldOffset(Offset = "0xA4")]
	[SerializeField]
	private float rightMax_s;

	[Token(Token = "0x4005169")]
	[FieldOffset(Offset = "0xA8")]
	private float panTimer;

	[Token(Token = "0x400516A")]
	[FieldOffset(Offset = "0xAC")]
	[SerializeField]
	private float panTimerThres;

	[Token(Token = "0x400516B")]
	[FieldOffset(Offset = "0xB0")]
	private int LastViewablePedistal;

	[Token(Token = "0x400516C")]
	[FieldOffset(Offset = "0xB4")]
	private int TotalNumberOfPedistals;

	[Token(Token = "0x400516D")]
	[FieldOffset(Offset = "0xB8")]
	private Vector2 LastDir;

	[Token(Token = "0x400516E")]
	[FieldOffset(Offset = "0xC0")]
	private List<GolfBallController> controllers;

	[Token(Token = "0x400516F")]
	[FieldOffset(Offset = "0xC8")]
	public bool showAll;

	[Token(Token = "0x4005170")]
	[FieldOffset(Offset = "0xD0")]
	public string showThis;

	[Token(Token = "0x4005171")]
	[FieldOffset(Offset = "0xD8")]
	public bool didUnpackPrize;

	[Token(Token = "0x4005172")]
	[FieldOffset(Offset = "0xE0")]
	public string lastPackReceived;

	[Token(Token = "0x6004673")]
	[Address(RVA = "0x161F510", Offset = "0x161F510", VA = "0x161F510")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6004674")]
	[Address(RVA = "0x161F7EC", Offset = "0x161F7EC", VA = "0x161F7EC")]
	private Transform GetPosition(int i)
	{
		return null;
	}

	[Token(Token = "0x6004675")]
	[Address(RVA = "0x161F874", Offset = "0x161F874", VA = "0x161F874")]
	private DailyPrize PlacePrize(DailyPrizeData.Prize prize, Transform p, bool isWrapped, bool permanentlyLocked = false)
	{
		return null;
	}

	[Token(Token = "0x6004676")]
	[Address(RVA = "0x161FA88", Offset = "0x161FA88", VA = "0x161FA88")]
	private DailyPrizeData.Prize TodaysPrize(List<DailyPrizeData.Prize> savedPrizes)
	{
		return null;
	}

	[Token(Token = "0x6004677")]
	[Address(RVA = "0x161FE58", Offset = "0x161FE58", VA = "0x161FE58")]
	private void Start()
	{
	}

	[Token(Token = "0x6004678")]
	[Address(RVA = "0x161FD44", Offset = "0x161FD44", VA = "0x161FD44")]
	private bool ShouldGiveSpecialDayPack(List<DailyPrizeData.Prize> savedPrizes)
	{
		return default;
	}

	[Token(Token = "0x6004679")]
	[Address(RVA = "0x1620E38", Offset = "0x1620E38", VA = "0x1620E38")]
	private void OnCounterReachZero()
	{
	}

	[Token(Token = "0x600467A")]
	[Address(RVA = "0x1620EB0", Offset = "0x1620EB0", VA = "0x1620EB0")]
	private void OnAimUpdate(Vector3 b, bool s, GolfBallController c)
	{
	}

	[Token(Token = "0x600467B")]
	[Address(RVA = "0x162128C", Offset = "0x162128C", VA = "0x162128C")]
	private void OnShoot(Vector3 b, GolfBallController c)
	{
	}

	[Token(Token = "0x600467C")]
	[Address(RVA = "0x1620D00", Offset = "0x1620D00", VA = "0x1620D00")]
	private void TactileArrowsOnSwitch()
	{
	}

	[Token(Token = "0x600467D")]
	[Address(RVA = "0x1621268", Offset = "0x1621268", VA = "0x1621268")]
	private bool isLeft(Vector2 v)
	{
		return default;
	}

	[Token(Token = "0x600467E")]
	[Address(RVA = "0x1621244", Offset = "0x1621244", VA = "0x1621244")]
	private bool isRight(Vector2 v)
	{
		return default;
	}

	[Token(Token = "0x600467F")]
	[Address(RVA = "0x1621220", Offset = "0x1621220", VA = "0x1621220")]
	private bool isLeft_s(Vector2 v)
	{
		return default;
	}

	[Token(Token = "0x6004680")]
	[Address(RVA = "0x16211FC", Offset = "0x16211FC", VA = "0x16211FC")]
	private bool isRight_S(Vector2 v)
	{
		return default;
	}

	[Token(Token = "0x6004681")]
	[Address(RVA = "0x1621684", Offset = "0x1621684", VA = "0x1621684")]
	private void Update()
	{
	}

	[Token(Token = "0x6004682")]
	[Address(RVA = "0x161FB68", Offset = "0x161FB68", VA = "0x161FB68")]
	private DailyPrizeData.Prize GetNextPrize(List<DailyPrizeData.Prize> savePrized)
	{
		return null;
	}

	[Token(Token = "0x6004683")]
	[Address(RVA = "0x162162C", Offset = "0x162162C", VA = "0x162162C")]
	public void PanLeft()
	{
	}

	[Token(Token = "0x6004684")]
	[Address(RVA = "0x16215CC", Offset = "0x16215CC", VA = "0x16215CC")]
	public void PanRight()
	{
	}

	[Token(Token = "0x6004685")]
	[Address(RVA = "0x1621904", Offset = "0x1621904", VA = "0x1621904")]
	public void SetControllerActive(bool b)
	{
	}

	[Token(Token = "0x6004686")]
	[Address(RVA = "0x1620BAC", Offset = "0x1620BAC", VA = "0x1620BAC")]
	private void ActivatePedistal()
	{
	}

	[Token(Token = "0x6004687")]
	[Address(RVA = "0x1620A80", Offset = "0x1620A80", VA = "0x1620A80")]
	private void DimImage(Image i, float a)
	{
	}

	[Token(Token = "0x6004688")]
	[Address(RVA = "0x1620C74", Offset = "0x1620C74", VA = "0x1620C74")]
	private void DimImageStep(Image i, float step)
	{
	}

	[Token(Token = "0x6004689")]
	[Address(RVA = "0x1621988", Offset = "0x1621988", VA = "0x1621988")]
	public PrizeController()
	{
	}

	[Token(Token = "0x600468A")]
	[Address(RVA = "0x1621A58", Offset = "0x1621A58", VA = "0x1621A58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E924", Offset = "0x6E924")]
	private DailyPrizeData.Prize _003CStart_003Eb__36_2(string s)
	{
		return null;
	}

	[Token(Token = "0x600468B")]
	[Address(RVA = "0x1621A74", Offset = "0x1621A74", VA = "0x1621A74")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E934", Offset = "0x6E934")]
	private void _003CStart_003Eb__36_5(GolfBallController c)
	{
	}

	[Token(Token = "0x600468C")]
	[Address(RVA = "0x1621B54", Offset = "0x1621B54", VA = "0x1621B54")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E944", Offset = "0x6E944")]
	private void _003CStart_003Eb__36_6(GolfBallController c)
	{
	}

	[Token(Token = "0x600468D")]
	[Address(RVA = "0x1621C34", Offset = "0x1621C34", VA = "0x1621C34")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E954", Offset = "0x6E954")]
	private void _003COnAimUpdate_003Eb__39_0(Image g)
	{
	}

	[Token(Token = "0x600468E")]
	[Address(RVA = "0x1621CC8", Offset = "0x1621CC8", VA = "0x1621CC8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E964", Offset = "0x6E964")]
	private void _003COnAimUpdate_003Eb__39_1(Image g)
	{
	}

	[Token(Token = "0x600468F")]
	[Address(RVA = "0x1621D5C", Offset = "0x1621D5C", VA = "0x1621D5C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E974", Offset = "0x6E974")]
	private void _003COnShoot_003Eb__40_0(Image g)
	{
	}

	[Token(Token = "0x6004690")]
	[Address(RVA = "0x1621DE8", Offset = "0x1621DE8", VA = "0x1621DE8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E984", Offset = "0x6E984")]
	private void _003COnShoot_003Eb__40_1(Image g)
	{
	}

	[Token(Token = "0x6004691")]
	[Address(RVA = "0x1621E74", Offset = "0x1621E74", VA = "0x1621E74")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E994", Offset = "0x6E994")]
	private void _003CUpdate_003Eb__46_0(Image g)
	{
	}

	[Token(Token = "0x6004692")]
	[Address(RVA = "0x1621F08", Offset = "0x1621F08", VA = "0x1621F08")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E9A4", Offset = "0x6E9A4")]
	private void _003CUpdate_003Eb__46_1(Image g)
	{
	}
}
