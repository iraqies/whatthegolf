using System;
using Rewired.Interfaces;

namespace Rewired.Utils.Classes.Utility
{
	internal interface IPoolableObject_Internal : IDisposable, IPoolableObject
	{
		IObjectPool pool { set; }

		void Clear();
	}
}
