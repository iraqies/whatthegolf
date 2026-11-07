using System;
using System.Collections.Generic;
using UnityEngine;

public class PortalsAsDoors : GolfBehaviour
{
	private SimplePortal portal;

	private SimplePortal linkedPortal;

	[SerializeField]
	private List<OverworldGoal> goals;

	public Action OnPortalUsed;

	private bool isOpen;

	[SerializeField]
	private OverworldID overworldID;

	public override void OnPrePlayOrPreCompile()
	{
	}

	private void Start()
	{
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	private void CheckGoal(OverworldGoal goal = null)
	{
	}

	private void Open()
	{
	}

	private void LinkedPortalUsed(SimplePortal s, GameObject go, SimplePortal s2)
	{
	}

	public bool IsOpen()
	{
		return false;
	}

	private void OnDestroy()
	{
	}

	private void UnSubscribe()
	{
	}
}
