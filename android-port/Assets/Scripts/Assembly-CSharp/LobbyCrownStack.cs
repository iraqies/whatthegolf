using System.Collections;
using UnityEngine;

public class LobbyCrownStack : MonoBehaviour
{
	public Rigidbody[] StackRigidbodies;

	public bool StackCollapsed;

	public Transform ContainerTransform;

	public int CrownsOnStack;

	public void StartCollapse()
	{
	}

	private IEnumerator CollapseRoutine()
	{
		return null;
	}
}
