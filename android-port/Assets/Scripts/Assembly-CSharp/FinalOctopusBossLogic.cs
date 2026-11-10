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
		if (legsToDestroy == null || m_hitsCount >= legsToDestroy.Count)
		{
			return;
		}
		DestructiblePart destructiblePart = legsToDestroy[m_hitsCount];
		if (destructiblePart != null)
		{
			if (destructiblePart.tail != null)
			{
				destructiblePart.tail.SetActive(value: false);
			}
			if (destructiblePart.catMesh != null)
			{
				destructiblePart.catMesh.SetActive(value: false);
			}
		}
		m_hitsCount++;
		if (m_hitsCount < legsToDestroy.Count)
		{
			hurtRoutine = StartCoroutine(HurtEffect());
		}
		else
		{
			OnLastLegDestroyed?.Invoke();
		}
	}

	private IEnumerator HurtEffect()
	{
		if (squidMaterials != null && squidMaterials.Count > 1)
		{
			ChangeMaterialLoop(squidMaterials[1]);
		}
		yield return new WaitForSeconds(0.1f);
		if (squidMaterials != null && squidMaterials.Count > 0)
		{
			ChangeMaterialLoop(squidMaterials[0]);
		}
	}

	private void ChangeMaterialLoop(Material newMat)
	{
		if (squidRenderer != null && squidRenderer.materials != null)
		{
			Material[] array = new Material[squidRenderer.materials.Length];
			for (int i = 0; i < squidRenderer.materials.Length; i++)
			{
				array[i] = newMat;
			}
			squidRenderer.materials = array;
		}
		if (skinnedMeshRendererList == null)
		{
			return;
		}
		for (int j = 0; j < skinnedMeshRendererList.Count; j++)
		{
			if (skinnedMeshRendererList[j] != null)
			{
				skinnedMeshRendererList[j].material = newMat;
			}
		}
	}
}
