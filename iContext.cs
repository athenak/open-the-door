using System;

namespace AssemblyCSharp
{
  public interface IContext
	{
		void Load();
		void Unload();
		
		bool IsLoaded { get; }
	}
}
