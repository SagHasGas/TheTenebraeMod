using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace TenebraeMod.Items.Weapons
{
    public class SpectreSpikyBall : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Spectre Spiky Ball");
            Tooltip.SetDefault("Can travel through walls and inflict lifesteal");
        }

        public override void SetDefaults() {
            item.thrown = true;
            item.maxStack = 999;
            item.consumable = true;
            item.damage = 15;
            item.width = 14;
            item.height = 14;
            item.useTime = 15;
            item.useAnimation = 15;
            item.noUseGraphic = true;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.knockBack = 1;
            item.value = 100;
            item.rare = ItemRarityID.Yellow;
            item.shootSpeed = 5f;
            item.shoot = mod.ProjectileType("SpectreSpikyBallProjectile");
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SpikyBall,25);
            recipe.AddIngredient(ItemID.SpectreBar);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this,25);
            recipe.AddRecipe();
        }
    }

    internal class SpectreSpikyBallProjectile : ModProjectile {
		public override string Texture => "TenebraeMod/Items/Weapons/SpectreSpikyBall";
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Spectre Spiky Ball");
		}

		public override void SetDefaults() {
			projectile.thrown = true;
			projectile.aiStyle = -1;
			projectile.width = 14;
			projectile.height = 14;
			projectile.penetrate = 10;
			projectile.friendly = true;
			projectile.tileCollide = false;
            projectile.light = 0.5f;
            projectile.alpha = 64;
		}

        public override void AI() {
            projectile.velocity *= 0.98f;
            projectile.rotation += projectile.velocity.X * 0.1f;
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) {
            projectile.magic = true;
            projectile.ghostHeal(damage,target.Center);
            projectile.magic = false;
        }
    }
}