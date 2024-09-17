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
        private static bool IsVisible = true;
        private static DateTime LastInvoke = DateTime.MinValue;

        public static void Postfix(Ship __instance)
        {
            if (Input.GetKeyUp(Plugin.ShowSlotKey))
            {
                //Prevent multiple invokes.  For some reason the combat mode
                //  appears to be invoking update twice in a row.
                if (DateTime.Now > LastInvoke + TimeSpan.FromMilliseconds(250))
                {
                    LastInvoke = DateTime.Now;
                }
                else
                {
                    return;
                }


                
                IsVisible = !IsVisible;

                //Must deselect everything or selected objects will be destroyed.  Not sure why.
                SelectionManager.DeselectAll();

                foreach (ModuleSlotRoot moduleSlotRoot in __instance.ModuleSlotRoots
                    .Where(x => x?.Module != null))
                {
                    moduleSlotRoot.Module.transform.Find("unpackedgroup").gameObject.SetActive(IsVisible);
                }
            }
        }
    }

}
