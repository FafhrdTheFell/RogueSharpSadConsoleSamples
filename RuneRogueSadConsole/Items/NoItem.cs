﻿using RuneRogueSadConsole.Core;

namespace RuneRogueSadConsole.Items
{
   public class NoItem : Item
   {
      public NoItem()
      {
         Name = "None";
         RemainingUses = 1;
      }

      protected override bool UseItem()
      {
         return false;
      }
   }
}
