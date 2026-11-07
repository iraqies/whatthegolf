using System.Collections.Generic;
using UnityEngine;

public class Smear : MonoBehaviour
{
	private Queue<Vector3> m_recentPositions;

	public int FramesBufferSize;

	public Renderer Renderer;

	private Material m_instancedMaterial;

	private Material InstancedMaterial
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}
}
