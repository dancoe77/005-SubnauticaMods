using Harmony;
using System;
using System.Reflection;

namespace MAC.PassiveReapers {
    public class MainPatcher {
        public static void Patch()
        {
            var harmony = HarmonyInstance.Create("com.oldark.subnautica.passivereapers.mod");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}