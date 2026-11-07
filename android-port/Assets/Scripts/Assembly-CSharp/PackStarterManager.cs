using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class PackStarterManager : MonoBehaviour
{
	[SerializeField]
	private List<PackStarterDef> packStarters;

	private static PackStarterManager instance;

	public Action<ContentPack> PackStarted;

	public Action<string, bool> PackFinished;

	public string lastPackId;

	public static PackStarterManager Instance
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	private void Awake()
	{
	}

	public static Task<bool> StartPack(ContentPack pack, bool isLevelNotification, params object[] args)
	{
		return null;
	}

	public Task<bool> StartPack(IPackWithData pack, bool isLevelNotification, params object[] args)
	{
		return null;
	}

	private Task<bool> StartPack(IPackWithData pack, BasePackStarter starter, params object[] args)
	{
		return null;
	}

	private void PackCompleted(bool didComplete)
	{
	}

	public static Task PackFinishedAsync()
	{
		return null;
	}
}
