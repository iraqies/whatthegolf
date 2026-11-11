using System.Collections;
using UnityEngine;

public class SheepLevel : MonoBehaviour
{
	public int target = 5;

	public GolfGoal goal;

	public Transform spawnTransform;

	public RagdollReset sheep;

	public Sheep sheepMovement;

	public SkinnedMeshRenderer[] meshes;

	private int progress;

	private Coroutine coroutine;

	public void OnSheepCounted()
	{
		progress++;
		if (progress >= target)
		{
			if (goal != null)
			{
				goal.TriggerGoal("SheepCounted");
			}
		}
		else if (coroutine == null)
		{
			coroutine = StartCoroutine(ResetSheep());
		}
	}

	public void OnSheepOutOfBounds()
	{
		if (coroutine == null && progress < target)
		{
			coroutine = StartCoroutine(ResetSheep());
		}
	}

	public void OnSheepNearFence()
	{
		if (sheepMovement != null)
		{
			sheepMovement.enabled = false;
		}
	}

	public void OnSheepPassedFence()
	{
		if (sheepMovement != null)
		{
			sheepMovement.enabled = true;
		}
	}

	private IEnumerator ResetSheep()
	{
		if (sheepMovement != null)
		{
			sheepMovement.enabled = false;
		}
		if (meshes != null)
		{
			for (int i = 0; i < meshes.Length; i++)
			{
				if (meshes[i] != null)
				{
					meshes[i].enabled = false;
				}
			}
		}
		yield return new WaitForSeconds(0.5f);
		if (sheep != null)
		{
			sheep.ResetRagdoll();
		}
		if (meshes != null)
		{
			for (int i = 0; i < meshes.Length; i++)
			{
				if (meshes[i] != null)
				{
					meshes[i].enabled = true;
				}
			}
		}
		if (sheepMovement != null)
		{
			sheepMovement.enabled = true;
		}
		coroutine = null;
	}
}
