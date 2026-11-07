using System;
using System.Text;

namespace Rewired.Utils.Interfaces
{
	internal interface IExportToJson
	{
		void WriteJson(StringBuilder stringBuilder, Action<StringBuilder, object> appendValueDelegate);
	}
}
