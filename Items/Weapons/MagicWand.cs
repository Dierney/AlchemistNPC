﻿using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.Localization;

namespace AlchemistNPC.Items.Weapons
{
	public class MagicWand : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Royal Magic Wand"
			+"\nShoots a laser beam that can eliminate everything on its way.");
			DisplayName.AddTranslation(GameCulture.Russian, "Волшебная Палочка");
			Tooltip.AddTranslation(GameCulture.Russian, "Королевская Волшебная Палочка\nИспускает лазерный луч, который способен уничтожить всё на своём пути."); 
		}

		public override void SetDefaults()
		{
			item.damage = 120;
			item.noMelee = true;
			item.magic = true;
			item.channel = true;                            //Channel so that you can held the weapon [Important]
			item.mana = 15;
			item.rare = 11;
			item.width = 30;
			item.height = 30;
			item.useTime = 20;
			item.UseSound = SoundID.Item13;
			item.useStyle = 5;
			item.shootSpeed = 14f;
			item.useAnimation = 20;   
			item.knockBack = 1;			
			item.shoot = mod.ProjectileType("MagicWand");
			item.value = Item.sellPrice(1, 0, 0, 0);
		}
	}
}
