﻿using HarmonyLib;

public class Main
{
    public static Harmony HarmonyInstance;

    public static void Load()
    {
        // UnityEngine.Application.SetStackTraceLogType(UnityEngine.LogType.Log, UnityEngine.StackTraceLogType.None);

        HarmonyInstance = new Harmony("RevisedCropSafety");
        HarmonyInstance.PatchAll();
        UnityEngine.Debug.Log("[RevisedCropSafety] loaded!");
    }

    public static void Unload()
    {
        UnityEngine.Debug.Log("[RevisedCropSafety] unloading!");
        if (HarmonyInstance != null)
        {
            HarmonyInstance.UnpatchAll();
        }
    }
}

[HarmonyPatch(typeof(Weather), "IsSafeForPlantingCrops")]
static class Weather__IsSafeForPlantingCrops__Patch
{
    static void Postfix(ref bool __result, ref Weather __instance)
    {
        // don't plant crops if nighttime temperatures over the next week would reach -0 C
        // UnityEngine.Debug.Log("[RevisedCropSafety] postfix");
        if (__result)
        {
            for (int i = 0; i <= 7; i++)
            {
                float futureTemperature = Weather.CalcAverageTemperatureInCelsiusFromDayOfYear(Session.Instance.DayOfYear + i) - (Weather.DiurnalTemperatureVariationInCelsius / 2.0f);
                // UnityEngine.Debug.Log($"[RevisedCropSafety] {Session.Instance.DayOfYear} {i} {futureTemperature}");
                if (futureTemperature <= 0.0f)
                {
                    __result = false;
                    break;
                }
            }
        }
    }
}