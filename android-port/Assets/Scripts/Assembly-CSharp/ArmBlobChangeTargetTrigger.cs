using System;
using System.Collections.Generic;
using UnityEngine;

public class ArmBlobChangeTargetTrigger : MonoBehaviour
{
	[Serializable]
	public class ArmBlobTargetInfo
	{
		public ArmBlob arm;

		public Transform target;
	}

	public List<ArmBlobTargetInfo> arms;

	private void OnTriggerEnter2D(Collider2D collision)
	{
	}
}
