using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace AlchemistNPC.Items
{
	public class TornNote4 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Torn Note #4");
			Tooltip.SetDefault("'Defeating the Moon Lord allows the creation of Ultimate Accessories."
			+"\nOne of them is the Sephirothic Fruit." 
			+"\nNot only does it increase your minion damage by 15% and give +2 max minions..."
			+"\nBut it also allows your minions to ignore invincibility frames'"
			+"\nThere seems to be something important, but you can't read it yet. Not without other parts. Maybe Jeweler can help you.");
			DisplayName.AddTranslation(GameCulture.Russian, "Изорванная записка #4");
			Tooltip.AddTranslation(GameCulture.Russian, "'После победы на Лунным Лордом ты сможешь скрафтить Ультимативные Аксессуары.\nОдин из них - это Плод Сефирот.\nОн не только увеливает урон прислужников на 15% и дают 2 дополнительных слота для прислужников...\nТакже он позволяет прислужникам игнорировать период неуязвимости противника.'\nЗдесь ещё есть что-то важное, но вы не можете это прочесть. Не без других частей.\nВозможно, Ювелир сможет помочь."); 
		}

		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 36;
			item.maxStack = 99;
			item.value = 150000;
			item.rare = 5;
		}
	}
}
