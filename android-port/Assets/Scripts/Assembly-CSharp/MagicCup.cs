using System.Collections.Generic;
using Core;
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
		rigid = GetComponent<Rigidbody>();
		currentContent = new List<GameObject>();
		contentOffsets = new List<Vector3>();
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other == null)
		{
			return;
		}
		GolfBallController component = other.gameObject.GetComponent<GolfBallController>();
		if (component != null && component.enabled && Sorter != null)
		{
			Sorter.TryShow(this);
		}
	}

	public void Move(Vector3 pos)
	{
		if (rigid != null)
		{
			rigid.MovePosition(pos);
		}
	}

	public void Rotate(Quaternion rot)
	{
		if (rigid != null)
		{
			rigid.MoveRotation(rot);
		}
	}

	public void HideContents()
	{
		Collider[] array = Physics.OverlapBox(base.transform.position, ContentCheckSize * 0.5f, Quaternion.identity, ~ContentBlacklist.value);
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] == null)
			{
				continue;
			}
			Transform root = array[i].transform.root;
			if (root != base.transform && !currentContent.Contains(root.gameObject))
			{
				currentContent.Add(root.gameObject);
				contentOffsets.Add(root.transform.position - base.transform.position);
				root.gameObject.SetActive(false);
			}
		}
	}

	public void ShowContents()
	{
		if (currentContent == null)
		{
			return;
		}
		for (int i = 0; i < currentContent.Count; i++)
		{
			GameObject gameObject = currentContent[i];
			if (gameObject != null)
			{
				gameObject.SetActive(true);
				if (TeleportContentPosition != null)
				{
					gameObject.transform.position = TeleportContentPosition.position;
				}
				else if (contentOffsets != null && i < contentOffsets.Count)
				{
					gameObject.transform.position = base.transform.position + contentOffsets[i];
				}
			}
		}
	}

	private void OnDrawGizmosSelected()
	{
		Gizmos.DrawWireCube(base.transform.position, ContentCheckSize);
	}
}
