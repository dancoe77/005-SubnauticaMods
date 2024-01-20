using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Harmony;
using System.Reflection;

namespace MAC.PassiveReapers {
    [HarmonyPatch(typeof(ReaperLeviathan))]
    [HarmonyPatch("Update")]
    internal class ReaperLeviathan_Update_Patch {
        [HarmonyPostfix]
        public static void Postfix(ReaperLeviathan __instance)
        {
            __instance.Aggression.Value = 0.0f;
        }
    }

}