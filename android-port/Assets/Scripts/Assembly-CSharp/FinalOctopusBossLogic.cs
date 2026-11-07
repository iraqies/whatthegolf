using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FinalOctopusBossLogic : MonoBehaviour
{
	[Serializable]
	public class DestructiblePart
	{
		public GameObject tail;

		public GameObject catMesh;
	}

	public UnityEvent OnLastLegDestroyed;

	public List<DestructiblePart> legsToDestroy;

	public MeshRenderer squidRenderer;

	public List<SkinnedMeshRenderer> skinnedMeshRendererList;

	public List<Material> squidMaterials;

	private int m_hitsCount;

	private Coroutine hurtRoutine;

	public void DestroyLeg()
	{
	}

	private IEnumerator HurtEffect()
	{
		return null;
	}

	private void ChangeMaterialLoop(Material newMat)
	{
	}
}
