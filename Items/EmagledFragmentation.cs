using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace AlchemistNPC.Items
{
	public class EmagledFragmentation : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Emagled Fragmentation");
			Tooltip.SetDefault("Origin of any Celestial Fragments."
				+ "\n25 of it could be transformed into 2 fragments of any type.");
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(10, 4));
			DisplayName.AddTranslation(GameCulture.Russian, "Небесные обломки");
			Tooltip.AddTranslation(GameCulture.Russian, "То, из чего рождаются все Небесные Фрагменты.\n25 могут быть преобразованы в 2 фрагмента любого типа."); 
		}    
		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 30;
			item.maxStack = 999;
			item.value = 20000;
			item.rare = 8;
		}

	}
}
