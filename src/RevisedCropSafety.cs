using System;

using UnityEngine;
using HarmonyLib;
using UnityModManagerNet;

namespace RevisedCropSafety
{
    static class Main
    {

        public static UnityModManager.ModEntry mod;

        static bool Load(UnityModManager.ModEntry modEntry)
        {
            var harmony = new Harmony(modEntry.Info.Id);
            harmony.PatchAll();

            mod = modEntry;

            // mod.Logger.Log("loaded!");

            return true;
        }
        
    }

    [HarmonyPatch(typeof(Weather), "IsSafeForPlantingCrops")]
    static class Weather__IsSafeForPlantingCrops__Patch
    {
        static void Postfix(ref bool __result, ref Weather __instance) {
            // Main.mod.Logger.Log("Weather.IsSafeForPlantingCrops postfix");
            // don't plant crops if nighttime temperatures over the next week would reach -0 C
            if (__result) {
                for (int i = 0; i <= 7; i++) {
                    float futureTemperature = Weather.CalcAverageTemperatureInCelsiusFromDayOfYear(Session.Instance.DayOfYear + i) - (Weather.DiurnalTemperatureVariationInCelsius / 2.0f);
                    // Main.mod.Logger.Log($"{Session.Instance.DayOfYear} {i} {futureTemperature}");
                    if (futureTemperature <= 0.0f) {
                        __result = false;
                        break;
                    }
                }
            }
        }
    }
}
