using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace AlchemistNPC.Items
{
	public class HeartofYuiS : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Heart of Yui");
			Tooltip.SetDefault("Summons small Pixie Helper"
			+"\nEnlights treasures, creatures and traps");
			DisplayName.AddTranslation(GameCulture.Russian, "Сердце Юи"); 
			Tooltip.AddTranslation(GameCulture.Russian, "Вызывает маленькую Фею-Помошника\nПодсвечивает сокровища, существ и ловушки");
		}

		public override void SetDefaults()
		{
			item.damage = 0;
			item.useStyle = 1;
			item.shoot = mod.ProjectileType("YuiS");
			item.width = 16;
			item.height = 30;
			item.UseSound = SoundID.Item2;
			item.useAnimation = 20;
			item.useTime = 20;
			item.rare = 8;
			item.noMelee = true;
			item.value = Item.sellPrice(5, 0, 0, 0);
			item.buffType = mod.BuffType("YuiS");
		}

		public override void UseStyle(Player player)
		{
			if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
			{
				player.AddBuff(item.buffType, 3600, true);
			}
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "HeartofYui");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}