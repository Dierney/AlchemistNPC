using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace AlchemistNPC.Items
{
	public class SunkroveraCrystal : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sunkrovera Crystal");
			Tooltip.SetDefault("Ruby, containing Blood of Demons"
			+"\nIt burns you even through gloves");
			DisplayName.AddTranslation(GameCulture.Russian, "Кристалл Сункроверы");
			Tooltip.AddTranslation(GameCulture.Russian, "Рубин, хранящий Кровь Демонов\nОбжигает вас даже сквозь перчатки"); 
		}    
		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 32;
			item.maxStack = 999;
			item.value = 50000;
			item.rare = 5;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Ruby);
			recipe.AddIngredient(ItemID.LivingFireBlock, 3);
			recipe.AddIngredient(null, "CrystalDust", 3);
			recipe.AddIngredient(ItemID.SoulofFright, 3);
			recipe.AddIngredient(ItemID.FragmentSolar, 2);
			recipe.AddIngredient(ItemID.FragmentNebula, 2);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}
