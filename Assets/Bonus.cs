using UnityEngine;

public class Bonus : MonoBehaviour
{
    public enum BonusType { SpeedBoost, Shield, ExtraLife }
    public BonusType bonusType;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ApplyBonus(other.gameObject);
            Destroy(gameObject);
        }
    }

    void ApplyBonus(GameObject player)
    {
        PlayerController playerController = player.GetComponent<PlayerController>();

        switch (bonusType)
        {
            case BonusType.SpeedBoost:
                playerController.StartCoroutine(playerController.SpeedBoost());
                break;
            case BonusType.Shield:
                playerController.ActivateShield();
                break;
            case BonusType.ExtraLife:
                playerController.GainExtraLife();
                break;
        }
    }
}
