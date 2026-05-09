using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace
{
    public class  : ModItem
    {
        public override void SetStaticDefaults()
        {
            Item.SetNameOverride("");
        }

        public override void SetDefaults()
        {
            Item.damage = ;
            Item.DamageType = ;
            Item.width = ;
            Item.height = ;
            Item.useTime = ;
            Item.useAnimation = ;
            Item.useStyle = ;
            Item.noMelee = ;
            Item.knockBack = ;
            Item.value = Item.buyPrice();
            Item.rare = ItemRarityID.;
            Item.UseSound = SoundID.Item;
            Item.autoReuse = ;
            Item.shoot = ProjectileID.Bullet;
            Item.shootSpeed = ;
            Item.useAmmo = AmmoID.Bullet;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient();
            recipe.AddIngredient();
            recipe.AddTile();
            recipe.Register();
        }
    }
}