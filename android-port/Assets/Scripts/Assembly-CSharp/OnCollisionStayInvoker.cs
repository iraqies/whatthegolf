using System;
using UnityEngine;

public class OnCollisionStayInvoker : MonoBehaviour
{
	public Action<Collision> OnCollisionStayEvent;

	private void OnCollisionStay(Collision other)
	{
	}
}
