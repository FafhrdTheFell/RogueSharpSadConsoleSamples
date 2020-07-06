using RuneRogueSadConsole.Core;
using RuneRogueSadConsole.Systems;

namespace RuneRogueSadConsole.Interfaces
{
   public interface IBehavior
   {
      bool Act( Monster monster, CommandSystem commandSystem );
   }
}
