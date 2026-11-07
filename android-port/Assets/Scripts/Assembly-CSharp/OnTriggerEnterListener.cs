using System.Runtime.CompilerServices;
using UnityEngine;

public class OnTriggerEnterListener : MonoBehaviour
{
	public delegate void OnTriggerEnterDelegate(Collider other);

	[CompilerGenerated]
	private OnTriggerEnterDelegate m_OnTriggerEnterCallback;

	public event OnTriggerEnterDelegate OnTriggerEnterCallback
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void OnTriggerEnter(Collider other)
	{
	}
}
