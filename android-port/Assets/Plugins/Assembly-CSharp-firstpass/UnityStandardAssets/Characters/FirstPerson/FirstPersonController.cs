using Il2CppDummyDll;
using UnityEngine;
using UnityStandardAssets.Utility;

namespace UnityStandardAssets.Characters.FirstPerson
{
	[Token(Token = "0x200007B")]
	[Attribute(Name = "RequireComponent", RVA = "0x33344", Offset = "0x33344")]
	[Attribute(Name = "RequireComponent", RVA = "0x33344", Offset = "0x33344")]
	public class FirstPersonController : MonoBehaviour
	{
		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_IsWalking;

		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_WalkSpeed;

		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_RunSpeed;

		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "RangeAttribute", RVA = "0x34820", Offset = "0x34820")]
		[SerializeField]
		private float m_RunstepLenghten;

		[Token(Token = "0x40001FC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_JumpSpeed;

		[Token(Token = "0x40001FD")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_StickToGroundForce;

		[Token(Token = "0x40001FE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_GravityMultiplier;

		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private MouseLook m_MouseLook;

		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool m_UseFovKick;

		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private FOVKick m_FovKick;

		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool m_UseHeadBob;

		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CurveControlledBob m_HeadBob;

		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private LerpControlledBob m_JumpBob;

		[Token(Token = "0x4000205")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float m_StepInterval;

		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AudioClip[] m_FootstepSounds;

		[Token(Token = "0x4000207")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private AudioClip m_JumpSound;

		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private AudioClip m_LandSound;

		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x88")]
		private Camera m_Camera;

		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x90")]
		private bool m_Jump;

		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x94")]
		private Vector2 m_Input;

		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x9C")]
		private Vector3 m_MoveDir;

		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0xA8")]
		private CharacterController m_CharacterController;

		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0xB0")]
		private CollisionFlags m_CollisionFlags;

		[Token(Token = "0x400020F")]
		[FieldOffset(Offset = "0xB4")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x4000210")]
		[FieldOffset(Offset = "0xB8")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x4000211")]
		[FieldOffset(Offset = "0xC4")]
		private float m_StepCycle;

		[Token(Token = "0x4000212")]
		[FieldOffset(Offset = "0xC8")]
		private float m_NextStep;

		[Token(Token = "0x4000213")]
		[FieldOffset(Offset = "0xCC")]
		private bool m_Jumping;

		[Token(Token = "0x4000214")]
		[FieldOffset(Offset = "0xD0")]
		private AudioSource m_AudioSource;

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x137266C", Offset = "0x137266C", VA = "0x137266C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x13727A4", Offset = "0x13727A4", VA = "0x13727A4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x137295C", Offset = "0x137295C", VA = "0x137295C")]
		private void PlayLandingSound()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x13729B0", Offset = "0x13729B0", VA = "0x13729B0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x1372E94", Offset = "0x1372E94", VA = "0x1372E94")]
		private void PlayJumpSound()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x1372ED4", Offset = "0x1372ED4", VA = "0x1372ED4")]
		private void ProgressStepCycle(float speed)
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x13731F0", Offset = "0x13731F0", VA = "0x13731F0")]
		private void PlayFootStepAudio()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x1373008", Offset = "0x1373008", VA = "0x1373008")]
		private void UpdateCameraPosition(float speed)
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x1372C7C", Offset = "0x1372C7C", VA = "0x1372C7C")]
		private void GetInput(out float speed)
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x1372900", Offset = "0x1372900", VA = "0x1372900")]
		private void RotateView()
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x137333C", Offset = "0x137333C", VA = "0x137333C")]
		private void OnControllerColliderHit(ControllerColliderHit hit)
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x137347C", Offset = "0x137347C", VA = "0x137347C")]
		public FirstPersonController()
		{
		}
	}
}
