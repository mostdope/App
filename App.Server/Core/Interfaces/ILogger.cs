using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Server.Core.Interfaces
{
	public interface ILogger
	{
		void WriteLog(string message);
		void ClearEntries();
	}
}
