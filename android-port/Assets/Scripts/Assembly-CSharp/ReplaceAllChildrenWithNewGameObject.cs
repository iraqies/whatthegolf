using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class ReplaceAllChildrenWithNewGameObject : MonoBehaviour
{
	public GameObject ObjectToReplaceWith;

	public bool Replace;

	public bool DestroyNew;

	public bool DestroyOld;

	public Vector3 ScaleMod;

	public Vector3 PositionOffset;

	public List<GameObject> NewObjects;

	private void Update()
	{
	}
}
