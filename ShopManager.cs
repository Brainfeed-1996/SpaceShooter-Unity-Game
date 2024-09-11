using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public int gems = 0;
    public int coins = 0;

    public void BuySpeedBoost()
    {
        if (gems >= 10)
        {
            gems -= 10;
            // Appliquer le bonus de vitesse
        }
    }

    public void BuyExtraLife()
    {
        if (coins >= 100)
        {
            coins -= 100;
            // Ajouter une vie supplémentaire
        }
    }

    public void AddGems(int amount)
    {
        gems += amount;
    }

    public void AddCoins(int amount)
    {
        coins += amount;
    }
}
