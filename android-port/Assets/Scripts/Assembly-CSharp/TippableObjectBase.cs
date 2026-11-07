using System;
using UnityEngine;

public abstract class TippableObjectBase : MonoBehaviour
{
	public Action<GameObject> OnTip { get; set; }
}
