using System;
using UnityEngine;

public abstract class BasePackStarter : MonoBehaviour
{
	public Action<bool> OnPackDone;

	public abstract bool StartPack(ContentPack pack, params object[] additionalContext);
}
