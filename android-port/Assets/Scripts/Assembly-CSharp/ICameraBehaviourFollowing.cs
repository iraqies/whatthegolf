using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003F1")]
public interface ICameraBehaviourFollowing
{
	[Token(Token = "0x600127E")]
	void SetFollowTarget(Transform target);

	[Token(Token = "0x600127F")]
	Transform GetFollowTarget();
}
