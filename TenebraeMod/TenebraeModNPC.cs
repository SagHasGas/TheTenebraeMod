using TenebraeMod.Buffs;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Graphics.Shaders;
using static Terraria.ModLoader.ModContent;
using TenebraeMod.Items.Accessories;

namespace TenebraeMod {
	public class TenebraeModNPC : GlobalNPC {
		public override bool InstancePerEntity => true;

        public override void NPCLoot(NPC npc) {
            switch(npc.type) {
                case NPCID.BlackRecluse:
                    if (Main.expertMode ? Main.rand.NextBool(25) : Main.rand.NextBool(50)) {
                        Item.NewItem(npc.Hitbox,ItemType<VenomAntidote>());
                    }
                    break;
                case NPCID.GiantBat:
                    if (Main.expertMode ? Main.rand.NextBool(25) : Main.rand.NextBool(50)) {
                        Item.NewItem(npc.Hitbox,ItemType<FeralShots>());
                    }
                    break;
                case NPCID.IlluminantBat:
                    if (Main.expertMode ? Main.rand.NextBool(25) : Main.rand.NextBool(50)) {
                        Item.NewItem(npc.Hitbox,ItemType<FeralShots>());
                    }
                    break;
                case NPCID.Lavabat:
                    if (Main.expertMode ? Main.rand.NextBool(25) : Main.rand.NextBool(50)) {
                        Item.NewItem(npc.Hitbox,ItemType<FeralShots>());
                    }
                    break;
                case NPCID.GiantFlyingFox:
                    if (Main.expertMode ? Main.rand.NextBool(25) : Main.rand.NextBool(50)) {
                        Item.NewItem(npc.Hitbox,ItemType<FeralShots>());
                    }
                    break;
                case NPCID.Vampire:
                    if (Main.expertMode ? Main.rand.NextBool(25) : Main.rand.NextBool(50)) {
                        Item.NewItem(npc.Hitbox,ItemType<FeralShots>());
                    }
                    break;
            }
        }

        public override void ModifyHitNPC(NPC npc, NPC target, ref int damage, ref float knockback, ref bool crit) {
            if (npc.HasBuff(BuffType<Berserked>())) {
                damage = (int)(damage*0.75f);
            }
        }

        public override void ModifyHitPlayer(NPC npc, Player target, ref int damage, ref bool crit) {
            if (npc.HasBuff(BuffType<Berserked>())) {
                damage = (int)(damage*0.75f);
            }
        }
    }
}