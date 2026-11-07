using System.Collections;
using UnityEngine;

public class SheepLevel : MonoBehaviour
{
	public int target;

	public GolfGoal goal;

	public Transform spawnTransform;

	public RagdollReset sheep;

	public Sheep sheepMovement;

	public SkinnedMeshRenderer[] meshes;

	private int progress;

	private Coroutine coroutine;

	public void OnSheepCounted()
	{
	}

	public void OnSheepOutOfBounds()
	{
	}

	public void OnSheepNearFence()
	{
	}

	public void OnSheepPassedFence()
	{
	}

	private IEnumerator ResetSheep()
	{
		return null;
	}
}
