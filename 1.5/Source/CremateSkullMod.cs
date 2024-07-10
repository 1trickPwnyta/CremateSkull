using HarmonyLib;
using Verse;

namespace CremateSkull
{
    public class CremateSkullMod : Mod
    {
        public const string PACKAGE_ID = "cremateskull.1trickPwnyta";
        public const string PACKAGE_NAME = "Cremate Skull";

        public CremateSkullMod(ModContentPack content) : base(content)
        {
            var harmony = new Harmony(PACKAGE_ID);
            harmony.PatchAll();

            Log.Message($"[{PACKAGE_NAME}] Loaded.");
        }
    }
}
