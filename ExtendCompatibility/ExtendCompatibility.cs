using HarmonyLib;
using NeosModLoader;
using System;
using FrooxEngine;
using FrooxEngine.LogiX;
using BaseX;

namespace ExtendCompatibility
{
	public class ExtendCompatibility : NeosMod
	{
		public override string Name => "ExtendCompatibility";
		public override string Author => "eia485";
		public override string Version => "1.0.0";
		public override string Link => "https://github.com/EIA485/NeosExtendCompatibility/";
		public override void OnEngineInit()
		{
			Harmony harmony = new Harmony("net.eia485.ExtendCompatibility");
			harmony.PatchAll();
		}

		[HarmonyPatch(typeof(SyncElement))]
		class ExtendCompatibilityPatch
		{
			[HarmonyFinalizer]
			[HarmonyPatch("DecodeFull")]
			static Exception FullFinalizer()
			{
				return null;
			}

			[HarmonyFinalizer]
			[HarmonyPatch("DecodeDelta")]
			static Exception DeltaFinalizer()
			{
				return null;
			}
		}
	}
}