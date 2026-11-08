using System.Collections.Generic;
using Core;
using UnityEngine;

public class RagdollReset : MonoBehaviour
{
	public bool TwoD;

	public bool ManualReset;

	private Dictionary<Rigidbody2D, ResetInfo2D> savedResetInfo2D;

	private Dictionary<Rigidbody, ResetInfo> savedResetInfo;

	public bool resetOnFirstFixed = true;

	private void Awake()
	{
		if (TwoD)
		{
			savedResetInfo2D = new Dictionary<Rigidbody2D, ResetInfo2D>();
			Rigidbody2D[] rbs2D = gameObject.GetComponentsInChildren<Rigidbody2D>();
			for (int i = 0; i < rbs2D.Length; i++)
			{
				if (rbs2D[i] != null && !savedResetInfo2D.ContainsKey(rbs2D[i]))
					savedResetInfo2D.Add(rbs2D[i], new ResetInfo2D());
			}
		}
		else
		{
			savedResetInfo = new Dictionary<Rigidbody, ResetInfo>();
			Rigidbody[] rbs = gameObject.GetComponentsInChildren<Rigidbody>(true);
			for (int i = 0; i < rbs.Length; i++)
			{
				if (rbs[i] != null && !savedResetInfo.ContainsKey(rbs[i]))
					savedResetInfo.Add(rbs[i], new ResetInfo());
			}
		}
		SaveResetInfo();
		if (!ManualReset)
		{
			GolfBallController gbc = GetComponentInParent<GolfBallController>();
			if (gbc != null)
				gbc.OnReset += ResetRagdoll;
		}
	}

	private void FixedUpdate()
	{
		if (resetOnFirstFixed)
		{
			resetOnFirstFixed = false;
			ResetRagdoll();
		}
	}

	public void SaveResetInfo()
	{
		if (TwoD)
		{
			if (savedResetInfo2D == null) return;
			foreach (KeyValuePair<Rigidbody2D, ResetInfo2D> kvp in savedResetInfo2D)
			{
				Rigidbody2D rb2d = kvp.Key;
				ResetInfo2D info2d = kvp.Value;
				if (rb2d == null || info2d == null) continue;
				info2d.Position = rb2d.position;
				info2d.Rotation = rb2d.rotation;
				info2d.Velocity = rb2d.velocity;
				info2d.AngularVelocity = rb2d.angularVelocity;
			}
		}
		else
		{
			if (savedResetInfo == null) return;
			foreach (KeyValuePair<Rigidbody, ResetInfo> kvp in savedResetInfo)
			{
				Rigidbody rb = kvp.Key;
				ResetInfo info = kvp.Value;
				if (rb == null || info == null) continue;
				info.Position = rb.transform.position;
				info.Rotation = rb.transform.rotation;
				info.Velocity = rb.velocity;
				info.AngularVelocity = rb.angularVelocity;
			}
		}
	}

	public void ResetRagdoll()
	{
		if (TwoD)
		{
			if (savedResetInfo2D == null) return;
			foreach (KeyValuePair<Rigidbody2D, ResetInfo2D> kvp in savedResetInfo2D)
			{
				Rigidbody2D rb2d = kvp.Key;
				ResetInfo2D info2d = kvp.Value;
				if (rb2d == null || info2d == null) continue;
				rb2d.position = info2d.Position;
				rb2d.rotation = info2d.Rotation;
				rb2d.velocity = info2d.Velocity;
				rb2d.angularVelocity = info2d.AngularVelocity;
			}
		}
		else
		{
			if (savedResetInfo == null) return;
			foreach (KeyValuePair<Rigidbody, ResetInfo> kvp in savedResetInfo)
			{
				Rigidbody rb = kvp.Key;
				ResetInfo info = kvp.Value;
				if (rb == null || info == null) continue;
				rb.transform.position = info.Position;
				rb.transform.rotation = info.Rotation;
				if (!rb.isKinematic)
				{
					rb.velocity = info.Velocity;
					rb.angularVelocity = info.AngularVelocity;
				}
			}
		}
	}
}
