using System;
using UnityEngine;

public abstract class ChallengeTriggerBase : MonoBehaviour
{
	public Action<ChallengeTriggerBase> OnTrigger;
}
