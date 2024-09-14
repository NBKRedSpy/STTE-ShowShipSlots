using HarmonyLib;
using RST;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace ShowShipSlots
{
    [HarmonyPatch(typeof(Ship), nameof(Ship.Update))]
    public static class Ship_Update_Patch
    {
        /// <summary>
        /// If true, makes the slots visible.  Otherwise show the modules as normal.
        /// </summary>
        private static bool IsVisible;
        public static void Postfix(Ship __instance)
        {
            if (Input.GetKeyUp(Plugin.ShowSlotKey))
            {

                foreach (ModuleSlotRoot moduleSlotRoot in __instance.ModuleSlotRoots)
                {
                    if (moduleSlotRoot != null && moduleSlotRoot.Module != null)
                    {
                        ShipModule module = moduleSlotRoot.Module;

                        Vector3 size = IsVisible ? new Vector3(0, 0, 0) : new Vector3(1, 1, 1);

                        module.gameObject.transform.localScale = size;
                    }
                }

                IsVisible = !IsVisible;

            }
        }
    }

}
