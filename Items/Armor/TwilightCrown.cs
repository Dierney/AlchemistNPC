using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace AlchemistNPC.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class TwilightCrown : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Twilight Crown (O-02-63)");
			DisplayName.AddTranslation(GameCulture.Russian, "Сумеречная Корона (O-02-63)"); 
			Tooltip.SetDefault("'Efforts of three birds to defeat the beast became one."
			+ "\nIt could stop countless incidents but you’d have to be prepared to step into the Black Forest.'"
			+ "\n[c/FF0000:EGO armor piece]"
			+ "\nIncreases melee speed by 30%");
			Tooltip.AddTranslation(GameCulture.Russian, "Усилия трёх птиц, чтобы одолеть Зверя, став едиными.\nОно способно остановить бесчисленные несчастные случаи.\nНо вам нужно быть готовыми, чтобы войти в Тёмный Лес.\n[c/FF0000:Э.П.О.С часть брони]\nУвеличивает скорость атак в ближнем бою 30%");
		ModTranslation text = mod.CreateTranslation("TwilightSetBonus");
		text.SetDefault("Increases current melee/magic damage by 30% and adds 15% to melee/magic critical strike chance"
		+ "\nIncludes all bonuses from Big Bird Lamp");
		text.AddTranslation(GameCulture.Russian, "Увеличивает текущий урон в ближнем бою/магический на 30% и добаляет 15% к шансу критического удара\nВключает в себя бонусы от Лампы Большой Птицы");
		mod.AddTranslation(text);
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 1000000;
			item.rare = 12;
			item.defense = 30;
		}

		public override void UpdateEquip(Player player)
		{
			player.meleeSpeed *= 1.30f;
		}
		
		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("TwilightSuit") && legs.type == mod.ItemType("TwilightLeggings");
		}

		public override void UpdateArmorSet(Player player)
		{
			string TwilightSetBonus = Language.GetTextValue("Mods.AlchemistNPC.TwilightSetBonus");
			player.setBonus = TwilightSetBonus;
			player.meleeDamage *= 1.35f;
			player.magicDamage *= 1.35f;
			player.meleeCrit += 20;
			player.magicCrit += 20;
			player.AddBuff(mod.BuffType("BigBirdLamp"), 300);
			player.thrownDamage += 0.05f;
            player.meleeDamage += 0.05f;
            player.rangedDamage += 0.05f;
            player.minionDamage += 0.05f;
            player.rangedCrit += 5;
            player.thrownCrit += 5;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "JustitiaCrown");
			recipe.AddIngredient(null, "MasksBundle");
			recipe.AddIngredient(null, "EmagledFragmentation", 100);
			recipe.AddTile(null, "WingoftheWorld");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}