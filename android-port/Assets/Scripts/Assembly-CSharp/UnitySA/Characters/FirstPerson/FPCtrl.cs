using Il2CppDummyDll;
using UnityEngine;
using UnitySA.Utility;

namespace UnitySA.Characters.FirstPerson
{
	[Token(Token = "0x2000F3E")]
	[Attribute(Name = "RequireComponent", RVA = "0x45858", Offset = "0x45858")]
	[Attribute(Name = "RequireComponent", RVA = "0x45858", Offset = "0x45858")]
	public class FPCtrl : MonoBehaviour
	{
		[Token(Token = "0x4005241")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_IsWalking;

		[Token(Token = "0x4005242")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_WalkSpeed;

		[Token(Token = "0x4005243")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_RunSpeed;

		[Token(Token = "0x4005244")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "RangeAttribute", RVA = "0x54194", Offset = "0x54194")]
		[SerializeField]
		private float m_RunstepLenghten;

		[Token(Token = "0x4005245")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_JumpSpeed;

		[Token(Token = "0x4005246")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_StickToGroundForce;

		[Token(Token = "0x4005247")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_GravityMultiplier;

		[Token(Token = "0x4005248")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private MLook m_MouseLook;

		[Token(Token = "0x4005249")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool m_UseFovKick;

		[Token(Token = "0x400524A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private FOVZoom m_FovKick;

		[Token(Token = "0x400524B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool m_UseHeadBob;

		[Token(Token = "0x400524C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CurveCtrlBob m_HeadBob;

		[Token(Token = "0x400524D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private LerpCtrlBob m_JumpBob;

		[Token(Token = "0x400524E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float m_StepInterval;

		[Token(Token = "0x400524F")]
		[FieldOffset(Offset = "0x70")]
		private Camera m_Camera;

		[Token(Token = "0x4005250")]
		[FieldOffset(Offset = "0x78")]
		private bool m_Jump;

		[Token(Token = "0x4005251")]
		[FieldOffset(Offset = "0x7C")]
		private float m_YRotation;

		[Token(Token = "0x4005252")]
		[FieldOffset(Offset = "0x80")]
		private Vector2 m_Input;

		[Token(Token = "0x4005253")]
		[FieldOffset(Offset = "0x88")]
		private Vector3 m_MoveDir;

		[Token(Token = "0x4005254")]
		[FieldOffset(Offset = "0x98")]
		private CharacterController m_CharacterController;

		[Token(Token = "0x4005255")]
		[FieldOffset(Offset = "0xA0")]
		private CollisionFlags m_CollisionFlags;

		[Token(Token = "0x4005256")]
		[FieldOffset(Offset = "0xA4")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x4005257")]
		[FieldOffset(Offset = "0xA8")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x4005258")]
		[FieldOffset(Offset = "0xB4")]
		private float m_StepCycle;

		[Token(Token = "0x4005259")]
		[FieldOffset(Offset = "0xB8")]
		private float m_NextStep;

		[Token(Token = "0x400525A")]
		[FieldOffset(Offset = "0xBC")]
		private bool m_Jumping;

		[Token(Token = "0x6004737")]
		[Address(RVA = "0x145589C", Offset = "0x145589C", VA = "0x145589C")]
		private void Start()
		{
		}

		[Token(Token = "0x6004738")]
		[Address(RVA = "0x14559B0", Offset = "0x14559B0", VA = "0x14559B0")]
		private void Update()
		{
		}

		[Token(Token = "0x6004739")]
		[Address(RVA = "0x1455B34", Offset = "0x1455B34", VA = "0x1455B34")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600473A")]
		[Address(RVA = "0x1455FE0", Offset = "0x1455FE0", VA = "0x1455FE0")]
		private void ProgressStepCycle(float speed)
		{
		}

		[Token(Token = "0x600473B")]
		[Address(RVA = "0x145610C", Offset = "0x145610C", VA = "0x145610C")]
		private void UpdateCameraPosition(float speed)
		{
		}

		[Token(Token = "0x600473C")]
		[Address(RVA = "0x1455DC8", Offset = "0x1455DC8", VA = "0x1455DC8")]
		private void GetInput(out float speed)
		{
		}

		[Token(Token = "0x600473D")]
		[Address(RVA = "0x1455AD8", Offset = "0x1455AD8", VA = "0x1455AD8")]
		private void RotateView()
		{
		}

		[Token(Token = "0x600473E")]
		[Address(RVA = "0x14562F4", Offset = "0x14562F4", VA = "0x14562F4")]
		private void OnControllerColliderHit(ControllerColliderHit hit)
		{
		}

		[Token(Token = "0x600473F")]
		[Address(RVA = "0x1456434", Offset = "0x1456434", VA = "0x1456434")]
		public FPCtrl()
		{
		}
	}
}
