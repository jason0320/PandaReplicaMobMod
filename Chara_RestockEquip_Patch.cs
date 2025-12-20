using System;
using System.Collections.Generic;
using System.Text;
using HarmonyLib;

namespace Mod_PandaReplicaMobMod
{
    [HarmonyPatch(typeof(Chara), "RestockEquip")]
    internal class Chara_RestockEquip_Patch
    {
        public static void Postfix(Chara __instance, bool onCreate)
        {

            if (__instance.id == "hp_earth_omega")
            { 
                if (onCreate)
                {
                    Thing thing = ThingGen.Create("blunt_earth");
                    thing.SetReplica(on: true);
                    thing.rarity = Rarity.Normal;
                    __instance.AddThing(thing);
                    __instance.body.Equip(thing);
                    thing.rarity = Rarity.Artifact;
                }
            }

            if (__instance.id == "hp_elemental_beta")
            {
                if (onCreate)
                {
                    Thing thing = ThingGen.Create("staff_element");
                    thing.SetReplica(on: true);
                    thing.rarity = Rarity.Normal;
                    __instance.AddThing(thing);
                    __instance.body.Equip(thing);
                    thing.rarity = Rarity.Artifact;
                }
            }
        }
    }
}
