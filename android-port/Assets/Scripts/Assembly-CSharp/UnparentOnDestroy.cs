using System.Collections.Generic;
using UnityEngine;

public class UnparentOnDestroy : MonoBehaviour
{
	[SerializeField]
	private List<Transform> childrenToUnparent;

	private void OnDestroy()
	{
	}
}
