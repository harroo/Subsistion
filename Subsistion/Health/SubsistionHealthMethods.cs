
using SubsistionInternal;

public static partial class Subsistion {

    public static void RestoreHealth () {

        SubsistionHealthManager.health = SubsistionHealthManager.maxHealth;
    }

    public static void SetMaxHealth (int level) {

        SubsistionHealthManager.maxHealth = level;
    }
    public static void SetHealth (int level) {

        SubsistionHealthManager.health = level;
    }

    public static void IncreaseHealth (int points) {

        SubsistionHealthManager.health += points;
        onHeal(points);
    }
    public static void DecreaseHealth (int points) {

        SubsistionHealthManager.health -= points;
        onDamage(points);
    }

    public static int MaxHealth => SubsistionHealthManager.maxHealth;

    public static int Health => SubsistionHealthManager.health;
}
