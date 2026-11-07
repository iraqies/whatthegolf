using UnityEngine;

public static class Awaiters
{
	private static readonly WaitForUpdate _waitForUpdate;

	private static readonly WaitForFixedUpdate _waitForFixedUpdate;

	private static readonly WaitForEndOfFrame _waitForEndOfFrame;

	public static WaitForUpdate NextFrame => null;

	public static WaitForEndOfFrame EndOfFrame => null;
}
