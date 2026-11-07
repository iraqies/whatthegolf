using UnityEngine;

public class CarPetWave : MonoBehaviour
{
	private static readonly int WorldSpaceOffset;

	[SerializeField]
	private float m_Speed;

	[SerializeField]
	private float _texturescrolling;

	[SerializeField]
	private Vector3 m_MoveAxis;

	[SerializeField]
	private MeshRenderer m_MeshRenderer;

	private Vector4 m_Offset;

	private Rigidbody m_RigidBody;

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}

	public void Setup(Vector3 m, float speed)
	{
	}

	public void SetSpeed(float s)
	{
	}
}
