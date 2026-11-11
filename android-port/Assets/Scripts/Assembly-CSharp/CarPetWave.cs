using UnityEngine;

public class CarPetWave : MonoBehaviour
{
	private static readonly int WorldSpaceOffset = Shader.PropertyToID("_Offset");

	[SerializeField]
	private float m_Speed = 2f;

	[SerializeField]
	private float _texturescrolling = 2f;

	[SerializeField]
	private Vector3 m_MoveAxis = Vector3.forward;

	[SerializeField]
	private MeshRenderer m_MeshRenderer;

	private Vector4 m_Offset;

	private Rigidbody m_RigidBody;

	private void Awake()
	{
		m_RigidBody = GetComponent<Rigidbody>();
	}

	private void FixedUpdate()
	{
		Vector3 vector = base.transform.TransformDirection(m_MoveAxis) * (m_Speed * Time.deltaTime);
		m_RigidBody.position -= vector;
		m_RigidBody.MovePosition(m_RigidBody.position + vector);
		m_Offset.x += vector.x;
		m_Offset.y += vector.z;
		m_MeshRenderer.sharedMaterial.mainTextureOffset = new Vector4(m_Offset.x * _texturescrolling, m_Offset.y * _texturescrolling, m_Offset.z * _texturescrolling, m_Offset.w * _texturescrolling);
	}

	public void Setup(Vector3 m, float speed)
	{
		m_MoveAxis = m;
		m_Speed = speed;
	}

	public void SetSpeed(float s)
	{
		m_Speed = s;
	}
}
