using System.Collections.Generic;
using UnityEngine;

public class RagdollReset : MonoBehaviour
{
	public bool TwoD;

	public bool ManualReset;

	private Dictionary<Rigidbody2D, ResetInfo2D> savedResetInfo2D;

	private Dictionary<Rigidbody, ResetInfo> savedResetInfo;

	public bool resetOnFirstFixed;

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}

	public void SaveResetInfo()
	{
	}

	public void ResetRagdoll()
	{
	}
}
