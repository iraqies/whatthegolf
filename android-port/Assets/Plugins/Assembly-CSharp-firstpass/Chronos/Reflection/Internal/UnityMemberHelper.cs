using System.Reflection;
using UnityEngine;

namespace Chronos.Reflection.Internal
{
	internal static class UnityMemberHelper
	{
		internal static bool TryReflectVariable(out MemberInfo variableInfo, out UnityReflectionException exception, Object reflectionTarget, string name)
		{
			variableInfo = null;
			exception = null;
			return false;
		}

		internal static MemberInfo ReflectVariable(Object reflectionTarget, string name)
		{
			return null;
		}
	}
}
