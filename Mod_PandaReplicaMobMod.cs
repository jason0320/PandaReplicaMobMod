using System;
using System.IO;
using System.Resources;
using BepInEx;
using HarmonyLib;

namespace Mod_PandaReplicaMobMod
{
    [BepInPlugin("panda.replicamob.mod", "Panda's Replica Mob Mod", "1.0.0.0")]
    internal class Mod_PandaReplicaMobMod : BaseUnityPlugin
    {
        private void Start()
        {
            var harmony = new Harmony("Panda's Replica Mob Mod");
            harmony.PatchAll();
        }
        private void OnStartCore()
        {
            string pathToExcelFile = Path.GetDirectoryName(((BaseUnityPlugin)this).Info.Location) + "/ReplicaMob.xlsx";
            SourceManager sources = Core.Instance.sources;
            ModUtil.ImportExcel(pathToExcelFile, "Chara", sources.charas);
        }
    }
}
