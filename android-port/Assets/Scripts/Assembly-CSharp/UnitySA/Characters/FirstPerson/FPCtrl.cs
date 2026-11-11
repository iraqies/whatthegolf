using UnityEngine;
using UnitySA.Utility;

namespace UnitySA.Characters.FirstPerson
{
	public class FPCtrl : MonoBehaviour
	{
		[SerializeField]
		private bool m_IsWalking;

		[SerializeField]
		private float m_WalkSpeed = 5f;

		[SerializeField]
		private float m_RunSpeed = 10f;

		[SerializeField]
		private float m_RunstepLenghten = 0.7f;

		[SerializeField]
		private float m_JumpSpeed = 10f;

		[SerializeField]
		private float m_StickToGroundForce = 10f;

		[SerializeField]
		private float m_GravityMultiplier = 2f;

		[SerializeField]
		private MLook m_MouseLook = new MLook();

		[SerializeField]
		private bool m_UseFovKick;

		[SerializeField]
		private FOVZoom m_FovKick = new FOVZoom();

		[SerializeField]
		private bool m_UseHeadBob;

		[SerializeField]
		private CurveCtrlBob m_HeadBob = new CurveCtrlBob();

		[SerializeField]
		private LerpCtrlBob m_JumpBob = new LerpCtrlBob();

		[SerializeField]
		private float m_StepInterval = 5f;

		private Camera m_Camera;

		private bool m_Jump;

		private float m_YRotation;

		private Vector2 m_Input;

		private Vector3 m_MoveDir = Vector3.zero;

		private CharacterController m_CharacterController;

		private CollisionFlags m_CollisionFlags;

		private bool m_PreviouslyGrounded;

		private Vector3 m_OriginalCameraPosition;

		private float m_StepCycle;

		private float m_NextStep;

		private bool m_Jumping;

		private void Start()
		{
			m_CharacterController = GetComponent<CharacterController>();
			m_Camera = Camera.main;
			if (m_Camera != null)
			{
				m_OriginalCameraPosition = m_Camera.transform.localPosition;
				m_FovKick?.Setup(m_Camera);
				m_HeadBob?.Setup(m_Camera, m_StepInterval);
			}
			m_StepCycle = 0f;
			m_NextStep = m_StepCycle * 0.5f;
			m_Jumping = false;
			if (m_MouseLook != null && m_Camera != null)
			{
				m_MouseLook.Init(transform, m_Camera.transform);
			}
		}

		private void Update()
		{
			RotateView();
			if (!m_Jump)
			{
				m_Jump = Input.GetButtonDown("Jump");
			}
			if (!m_PreviouslyGrounded && m_CharacterController != null && m_CharacterController.isGrounded)
			{
				if (m_JumpBob != null)
				{
					StartCoroutine(m_JumpBob.DoBobCycle());
				}
				m_MoveDir.y = 0f;
				m_Jumping = false;
			}
			if (m_CharacterController != null && !m_CharacterController.isGrounded && !m_Jumping && m_PreviouslyGrounded)
			{
				m_MoveDir.y = 0f;
			}
			if (m_CharacterController != null)
			{
				m_PreviouslyGrounded = m_CharacterController.isGrounded;
			}
		}

		private void FixedUpdate()
		{
			if (m_CharacterController == null)
			{
				return;
			}
			GetInput(out float speed);
			Vector3 desiredMove = transform.forward * m_Input.y + transform.right * m_Input.x;
			if (Physics.SphereCast(transform.position, m_CharacterController.radius, Vector3.down, out RaycastHit hitInfo, m_CharacterController.height * 0.5f, -1, QueryTriggerInteraction.Ignore))
			{
				desiredMove = Vector3.ProjectOnPlane(desiredMove, hitInfo.normal).normalized;
			}
			m_MoveDir.x = desiredMove.x * speed;
			m_MoveDir.z = desiredMove.z * speed;
			if (m_CharacterController.isGrounded)
			{
				m_MoveDir.y = -m_StickToGroundForce;
				if (m_Jump)
				{
					m_MoveDir.y = m_JumpSpeed;
					m_Jump = false;
					m_Jumping = true;
				}
			}
			else
			{
				m_MoveDir += Physics.gravity * (m_GravityMultiplier * Time.fixedDeltaTime);
			}
			m_CollisionFlags = m_CharacterController.Move(m_MoveDir * Time.fixedDeltaTime);
			ProgressStepCycle(speed);
			UpdateCameraPosition(speed);
			m_MouseLook?.UpdateCursorLock();
		}

		private void ProgressStepCycle(float speed)
		{
			if (m_CharacterController == null)
			{
				return;
			}
			if (m_CharacterController.velocity.sqrMagnitude > 0f && (m_Input.x != 0f || m_Input.y != 0f))
			{
				m_StepCycle += (m_CharacterController.velocity.magnitude + speed * (m_IsWalking ? 1f : m_RunstepLenghten)) * Time.fixedDeltaTime;
			}
			if (m_StepCycle > m_NextStep)
			{
				m_NextStep = m_StepCycle + m_StepInterval;
			}
		}

		private void UpdateCameraPosition(float speed)
		{
			if (!m_UseHeadBob || m_Camera == null || m_CharacterController == null)
			{
				return;
			}
			Vector3 newCameraPosition;
			if (m_CharacterController.velocity.magnitude > 0f && m_CharacterController.isGrounded)
			{
				newCameraPosition = m_HeadBob.DoHeadBob(m_CharacterController.velocity.magnitude + speed * (m_IsWalking ? 1f : m_RunstepLenghten));
				newCameraPosition.y = m_Camera.transform.localPosition.y - (m_JumpBob != null ? m_JumpBob.Offset() : 0f);
			}
			else
			{
				newCameraPosition = m_Camera.transform.localPosition;
				newCameraPosition.y = m_OriginalCameraPosition.y - (m_JumpBob != null ? m_JumpBob.Offset() : 0f);
			}
			m_Camera.transform.localPosition = newCameraPosition;
		}

		private void GetInput(out float speed)
		{
			float horizontal = Input.GetAxis("Horizontal");
			float vertical = Input.GetAxis("Vertical");
			bool wasWalking = m_IsWalking;
			m_IsWalking = !Input.GetKey(KeyCode.LeftShift);
			speed = m_IsWalking ? m_WalkSpeed : m_RunSpeed;
			m_Input = new Vector2(horizontal, vertical);
			if (m_Input.sqrMagnitude > 1f)
			{
				m_Input.Normalize();
			}
			if (m_IsWalking != wasWalking && m_UseFovKick && m_CharacterController != null && m_CharacterController.velocity.sqrMagnitude > 0f && m_FovKick != null)
			{
				StopAllCoroutines();
				StartCoroutine(!m_IsWalking ? m_FovKick.FOVKickUp() : m_FovKick.FOVKickDown());
			}
		}

		private void RotateView()
		{
			if (m_MouseLook != null && m_Camera != null)
			{
				m_MouseLook.LookRotation(transform, m_Camera.transform);
			}
		}

		private void OnControllerColliderHit(ControllerColliderHit hit)
		{
			if (hit == null || hit.collider == null || m_CollisionFlags == CollisionFlags.Below)
			{
				return;
			}
			Rigidbody body = hit.collider.attachedRigidbody;
			if (body != null && !body.isKinematic && m_CharacterController != null)
			{
				body.AddForceAtPosition(m_CharacterController.velocity * 0.1f, hit.point, ForceMode.Impulse);
			}
		}
	}
}
