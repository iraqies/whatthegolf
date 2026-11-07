using System;
using UnityEngine;

public interface IHitscanTarget
{
	Action<IHitscanTarget> OnHitscanHit { get; set; }

	void OnHit(Vector3 point);
}
