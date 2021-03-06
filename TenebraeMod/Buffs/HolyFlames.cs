using TenebraeMod.NPCs;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TenebraeMod.Buffs
{
	public class HolyFlames : ModBuff
	{
		public override void SetDefaults() {
			DisplayName.SetDefault("Holy Flames");
			Description.SetDefault("The longer you have it, the more it burns");
			Main.debuff[Type] = true;
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
			longerExpertDebuff = true;
		}

		public override void Update(Player player, ref int buffIndex) {
			player.GetModPlayer<TenebraeModPlayer>().holyflames = true;
		}

        public override void Update(NPC npc, ref int buffIndex) {
			npc.GetGlobalNPC<NPCDebuffs>().holyflames = true;
		}
	}
}