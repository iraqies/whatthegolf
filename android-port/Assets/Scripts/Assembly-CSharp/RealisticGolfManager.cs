using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Cinemachine;
using Core;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[Token(Token = "0x2000E98")]
public class RealisticGolfManager : MonoBehaviour
{
	[Token(Token = "0x2000E99")]
	private enum RealisticGolfStates
	{
		[Token(Token = "0x4004EEC")]
		AIM = 0,
		[Token(Token = "0x4004EED")]
		SHOT = 1,
		[Token(Token = "0x4004EEE")]
		GOAL = 2
	}

	[Token(Token = "0x2000E9A")]
	public enum ClubStates
	{
		[Token(Token = "0x4004EF0")]
		MAIN = 0,
		[Token(Token = "0x4004EF1")]
		SECONDARY = 1
	}

	[Serializable]
	[Token(Token = "0x2000E9B")]
	public class Club
	{
		[Token(Token = "0x4004EF2")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x4004EF3")]
		[FieldOffset(Offset = "0x18")]
		public Sprite clubImage;

		[Token(Token = "0x4004EF4")]
		[FieldOffset(Offset = "0x20")]
		public Color clubColor;

		[Token(Token = "0x4004EF5")]
		[FieldOffset(Offset = "0x30")]
		public float strength;

		[Token(Token = "0x4004EF6")]
		[FieldOffset(Offset = "0x34")]
		public float pitch;

		[Token(Token = "0x4004EF7")]
		[FieldOffset(Offset = "0x38")]
		public float arrowSize;

		[Token(Token = "0x4004EF8")]
		[FieldOffset(Offset = "0x40")]
		public ClubEquipIcon iconInScene;

		[Token(Token = "0x4004EF9")]
		[FieldOffset(Offset = "0x48")]
		public GameObject clubInScene;

		[Token(Token = "0x4004EFA")]
		[FieldOffset(Offset = "0x50")]
		public UnityEvent OnShootEffect;

		[Token(Token = "0x6004435")]
		[Address(RVA = "0x18315A0", Offset = "0x18315A0", VA = "0x18315A0")]
		public Club()
		{
		}
	}

	[Token(Token = "0x2000E9C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45148", Offset = "0x45148")]
	private sealed class _003CPlaceNewBallForOneShot_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004EFB")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004EFC")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004EFD")]
		[FieldOffset(Offset = "0x20")]
		public RealisticGolfManager _003C_003E4__this;

		[Token(Token = "0x170006FC")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004439")]
			[Address(RVA = "0x183118C", Offset = "0x183118C", VA = "0x183118C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006FD")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600443B")]
			[Address(RVA = "0x18311D4", Offset = "0x18311D4", VA = "0x18311D4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6004436")]
		[Address(RVA = "0x1830F84", Offset = "0x1830F84", VA = "0x1830F84")]
		[DebuggerHidden]
		public _003CPlaceNewBallForOneShot_003Ed__38(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004437")]
		[Address(RVA = "0x1830FB0", Offset = "0x1830FB0", VA = "0x1830FB0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004438")]
		[Address(RVA = "0x1830FB4", Offset = "0x1830FB4", VA = "0x1830FB4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6004439")]
		[Address(RVA = "0x183118C", Offset = "0x183118C", VA = "0x183118C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600443A")]
		[Address(RVA = "0x1831194", Offset = "0x1831194", VA = "0x1831194", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600443B")]
		[Address(RVA = "0x18311D4", Offset = "0x18311D4", VA = "0x18311D4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000E9D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45158", Offset = "0x45158")]
	private sealed class _003CCustomShotRoutine_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004EFE")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004EFF")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004F00")]
		[FieldOffset(Offset = "0x20")]
		public RealisticGolfManager _003C_003E4__this;

		[Token(Token = "0x4004F01")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 boost;

		[Token(Token = "0x170006FE")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600443F")]
			[Address(RVA = "0x1830CF0", Offset = "0x1830CF0", VA = "0x1830CF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006FF")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004441")]
			[Address(RVA = "0x1830D38", Offset = "0x1830D38", VA = "0x1830D38", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600443C")]
		[Address(RVA = "0x1830A84", Offset = "0x1830A84", VA = "0x1830A84")]
		[DebuggerHidden]
		public _003CCustomShotRoutine_003Ed__39(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600443D")]
		[Address(RVA = "0x1830AB0", Offset = "0x1830AB0", VA = "0x1830AB0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600443E")]
		[Address(RVA = "0x1830AB4", Offset = "0x1830AB4", VA = "0x1830AB4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600443F")]
		[Address(RVA = "0x1830CF0", Offset = "0x1830CF0", VA = "0x1830CF0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6004440")]
		[Address(RVA = "0x1830CF8", Offset = "0x1830CF8", VA = "0x1830CF8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6004441")]
		[Address(RVA = "0x1830D38", Offset = "0x1830D38", VA = "0x1830D38", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000E9E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45168", Offset = "0x45168")]
	private sealed class _003CSwitchToFollowCamera_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004F02")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004F03")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004F04")]
		[FieldOffset(Offset = "0x20")]
		public RealisticGolfManager _003C_003E4__this;

		[Token(Token = "0x17000700")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004445")]
			[Address(RVA = "0x1831550", Offset = "0x1831550", VA = "0x1831550", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000701")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004447")]
			[Address(RVA = "0x1831598", Offset = "0x1831598", VA = "0x1831598", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6004442")]
		[Address(RVA = "0x1831448", Offset = "0x1831448", VA = "0x1831448")]
		[DebuggerHidden]
		public _003CSwitchToFollowCamera_003Ed__42(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004443")]
		[Address(RVA = "0x1831474", Offset = "0x1831474", VA = "0x1831474", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004444")]
		[Address(RVA = "0x1831478", Offset = "0x1831478", VA = "0x1831478", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6004445")]
		[Address(RVA = "0x1831550", Offset = "0x1831550", VA = "0x1831550", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6004446")]
		[Address(RVA = "0x1831558", Offset = "0x1831558", VA = "0x1831558", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6004447")]
		[Address(RVA = "0x1831598", Offset = "0x1831598", VA = "0x1831598", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000E9F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45178", Offset = "0x45178")]
	private sealed class _003CSwitchToAimCamera_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004F05")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004F06")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004F07")]
		[FieldOffset(Offset = "0x20")]
		public RealisticGolfManager _003C_003E4__this;

		[Token(Token = "0x17000702")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600444B")]
			[Address(RVA = "0x18313F8", Offset = "0x18313F8", VA = "0x18313F8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000703")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600444D")]
			[Address(RVA = "0x1831440", Offset = "0x1831440", VA = "0x1831440", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6004448")]
		[Address(RVA = "0x18311DC", Offset = "0x18311DC", VA = "0x18311DC")]
		[DebuggerHidden]
		public _003CSwitchToAimCamera_003Ed__44(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004449")]
		[Address(RVA = "0x1831208", Offset = "0x1831208", VA = "0x1831208", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600444A")]
		[Address(RVA = "0x183120C", Offset = "0x183120C", VA = "0x183120C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600444B")]
		[Address(RVA = "0x18313F8", Offset = "0x18313F8", VA = "0x18313F8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600444C")]
		[Address(RVA = "0x1831400", Offset = "0x1831400", VA = "0x1831400", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600444D")]
		[Address(RVA = "0x1831440", Offset = "0x1831440", VA = "0x1831440", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000EA0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45188", Offset = "0x45188")]
	private sealed class _003CFadeInOut_003Ed__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004F08")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004F09")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004F0A")]
		[FieldOffset(Offset = "0x20")]
		public RealisticGolfManager _003C_003E4__this;

		[Token(Token = "0x4004F0B")]
		[FieldOffset(Offset = "0x28")]
		public float endValue;

		[Token(Token = "0x4004F0C")]
		[FieldOffset(Offset = "0x2C")]
		private float _003CfadeStartValue_003E5__2;

		[Token(Token = "0x4004F0D")]
		[FieldOffset(Offset = "0x30")]
		private float _003Ctime_003E5__3;

		[Token(Token = "0x17000704")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004451")]
			[Address(RVA = "0x1830F34", Offset = "0x1830F34", VA = "0x1830F34", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000705")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004453")]
			[Address(RVA = "0x1830F7C", Offset = "0x1830F7C", VA = "0x1830F7C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600444E")]
		[Address(RVA = "0x1830D40", Offset = "0x1830D40", VA = "0x1830D40")]
		[DebuggerHidden]
		public _003CFadeInOut_003Ed__49(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600444F")]
		[Address(RVA = "0x1830D6C", Offset = "0x1830D6C", VA = "0x1830D6C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004450")]
		[Address(RVA = "0x1830D70", Offset = "0x1830D70", VA = "0x1830D70", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6004451")]
		[Address(RVA = "0x1830F34", Offset = "0x1830F34", VA = "0x1830F34", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6004452")]
		[Address(RVA = "0x1830F3C", Offset = "0x1830F3C", VA = "0x1830F3C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6004453")]
		[Address(RVA = "0x1830F7C", Offset = "0x1830F7C", VA = "0x1830F7C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004ED1")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GolfBallController m_golfBall;

	[Token(Token = "0x4004ED2")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform m_flag;

	[Token(Token = "0x4004ED3")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject m_goalPin;

	[Token(Token = "0x4004ED4")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool oneShotLevel;

	[Token(Token = "0x4004ED5")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject m_ballPrefab;

	[Token(Token = "0x4004ED6")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private bool m_useClubUI;

	[Token(Token = "0x4004ED7")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject m_golfer;

	[Token(Token = "0x4004ED8")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Avatar m_golferAvatar;

	[Token(Token = "0x4004ED9")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private float m_shootDelayFromAnimation;

	[Token(Token = "0x4004EDA")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	private Vector3 m_golferOffsetPos;

	[Token(Token = "0x4004EDB")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private float m_rotationOffset;

	[Token(Token = "0x4004EDC")]
	[FieldOffset(Offset = "0x70")]
	private Animator m_golferAnimator;

	[Token(Token = "0x4004EDD")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private CinemachineBrain m_cameraBrain;

	[Token(Token = "0x4004EDE")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private CinemachineVirtualCamera m_aimCamera;

	[Token(Token = "0x4004EDF")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private CinemachineVirtualCamera m_followShotCamera;

	[Token(Token = "0x4004EE0")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Image m_fadeToBlack;

	[Token(Token = "0x4004EE1")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private List<Club> m_clubs;

	[Token(Token = "0x4004EE2")]
	[FieldOffset(Offset = "0xA0")]
	private RealisticGolfStates currentState;

	[Token(Token = "0x4004EE3")]
	[FieldOffset(Offset = "0xA4")]
	private ClubStates currentClub;

	[Token(Token = "0x4004EE4")]
	[FieldOffset(Offset = "0xA8")]
	private Vector3 m_ballStartPos;

	[Token(Token = "0x4004EE5")]
	[FieldOffset(Offset = "0xB8")]
	private Rigidbody m_ballRb;

	[Token(Token = "0x4004EE6")]
	[FieldOffset(Offset = "0xC0")]
	private GolfBallShooterExperimental m_shooter;

	[Token(Token = "0x4004EE7")]
	[FieldOffset(Offset = "0xC8")]
	private CinemachineComposer aimCamComposer;

	[Token(Token = "0x4004EE8")]
	[FieldOffset(Offset = "0xD0")]
	private float nextShotVelocityMax;

	[Token(Token = "0x4004EE9")]
	[FieldOffset(Offset = "0xD8")]
	private ShootArrow m_shootArrow;

	[Token(Token = "0x4004EEA")]
	[FieldOffset(Offset = "0xE0")]
	private ConstantForce m_windForceOnBall;

	[Token(Token = "0x600441F")]
	[Address(RVA = "0x1644450", Offset = "0x1644450", VA = "0x1644450")]
	private void Start()
	{
	}

	[Token(Token = "0x6004420")]
	[Address(RVA = "0x1644514", Offset = "0x1644514", VA = "0x1644514")]
	private void GetGolfBallComponents()
	{
	}

	[Token(Token = "0x6004421")]
	[Address(RVA = "0x16446B0", Offset = "0x16446B0", VA = "0x16446B0")]
	private void SetAllClubIcons()
	{
	}

	[Token(Token = "0x6004422")]
	[Address(RVA = "0x1644B6C", Offset = "0x1644B6C", VA = "0x1644B6C")]
	private void PlaceGolferNextToBall()
	{
	}

	[Token(Token = "0x6004423")]
	[Address(RVA = "0x1644BDC", Offset = "0x1644BDC", VA = "0x1644BDC")]
	private void AnimatedGolfer(Vector3 boost, bool unused)
	{
	}

	[Token(Token = "0x6004424")]
	[Address(RVA = "0x1644C58", Offset = "0x1644C58", VA = "0x1644C58")]
	private void Update()
	{
	}

	[Token(Token = "0x6004425")]
	[Address(RVA = "0x1644E50", Offset = "0x1644E50", VA = "0x1644E50")]
	private void AimUpdate()
	{
	}

	[Token(Token = "0x6004426")]
	[Address(RVA = "0x1644E54", Offset = "0x1644E54", VA = "0x1644E54")]
	private void ShotUpdate()
	{
	}

	[Token(Token = "0x6004427")]
	[Address(RVA = "0x16451BC", Offset = "0x16451BC", VA = "0x16451BC")]
	private void HasShot(Vector3 boost)
	{
	}

	[Token(Token = "0x6004428")]
	[Address(RVA = "0x16454B4", Offset = "0x16454B4", VA = "0x16454B4")]
	private IEnumerator PlaceNewBallForOneShot()
	{
		return null;
	}

	[Token(Token = "0x6004429")]
	[Address(RVA = "0x164541C", Offset = "0x164541C", VA = "0x164541C")]
	private IEnumerator CustomShotRoutine(Vector3 boost)
	{
		return null;
	}

	[Token(Token = "0x600442A")]
	[Address(RVA = "0x1645528", Offset = "0x1645528", VA = "0x1645528")]
	private void SwitchCamPriority(int aimCam, int followCam)
	{
	}

	[Token(Token = "0x600442B")]
	[Address(RVA = "0x1645554", Offset = "0x1645554", VA = "0x1645554")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600442C")]
	[Address(RVA = "0x1645674", Offset = "0x1645674", VA = "0x1645674")]
	private IEnumerator SwitchToFollowCamera()
	{
		return null;
	}

	[Token(Token = "0x600442D")]
	[Address(RVA = "0x16456E8", Offset = "0x16456E8", VA = "0x16456E8")]
	private void SmallShotAndPutt()
	{
	}

	[Token(Token = "0x600442E")]
	[Address(RVA = "0x1645148", Offset = "0x1645148", VA = "0x1645148")]
	private IEnumerator SwitchToAimCamera()
	{
		return null;
	}

	[Token(Token = "0x600442F")]
	[Address(RVA = "0x1645034", Offset = "0x1645034", VA = "0x1645034")]
	private float GoalDistance()
	{
		return default;
	}

	[Token(Token = "0x6004430")]
	[Address(RVA = "0x1644820", Offset = "0x1644820", VA = "0x1644820")]
	private void SwitchControllerToEquippedClub()
	{
	}

	[Token(Token = "0x6004431")]
	[Address(RVA = "0x1645718", Offset = "0x1645718", VA = "0x1645718")]
	public void ButtonSwitchCurrentClub()
	{
	}

	[Token(Token = "0x6004432")]
	[Address(RVA = "0x164573C", Offset = "0x164573C", VA = "0x164573C")]
	public void SwitchClubOnTrigger(int newClubIndex)
	{
	}

	[Token(Token = "0x6004433")]
	[Address(RVA = "0x16450C4", Offset = "0x16450C4", VA = "0x16450C4")]
	private IEnumerator FadeInOut(float endValue)
	{
		return null;
	}

	[Token(Token = "0x6004434")]
	[Address(RVA = "0x1645A44", Offset = "0x1645A44", VA = "0x1645A44")]
	public RealisticGolfManager()
	{
	}
}
