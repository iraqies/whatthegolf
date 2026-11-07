using UnityEngine;
using Utility;

public interface IObjectPooler
{
	ObjectPool<GameObject> GetPool { get; }
}
