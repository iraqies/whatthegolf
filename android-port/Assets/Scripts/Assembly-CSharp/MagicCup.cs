using System.Collections.Generic;
using UnityEngine;

public class MagicCup : MonoBehaviour
{
	public MagicCupSorter Sorter;

	public Vector3 ContentCheckSize;

	public LayerMask ContentBlacklist;

	public Transform TeleportContentPosition;

	private Rigidbody rigid;

	private List<GameObject> currentContent;

	private List<Vector3> contentOffsets;

	private void Awake()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}

	public void Move(Vector3 pos)
	{
	}

	public void Rotate(Quaternion rot)
	{
	}

	public void HideContents()
	{
	}

	public void ShowContents()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
