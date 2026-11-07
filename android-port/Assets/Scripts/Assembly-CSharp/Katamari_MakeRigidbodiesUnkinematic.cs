using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class Katamari_MakeRigidbodiesUnkinematic : MonoBehaviour
{
	public KatamariBall katamariController;

	public CinemachineVirtualCamera virtualCamera;

	public float sizeTreshold;

	public GameObject explosion;

	public List<Rigidbody> rigidbodies;

	private float katamariSize;

	private bool madeUnkinematic;

	private void Update()
	{
	}

	private void MakeUnkinematic()
	{
	}
}
