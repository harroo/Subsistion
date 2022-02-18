
using SubsistionInternal;

public static partial class Subsistion {

    public static System.Action onDeath {

        get { return SubsistionHealthManager.onDeathAction; }
        set { SubsistionHealthManager.onDeathAction = value; }
    }

    public static System.Action<int> onDamage;
    public static System.Action<int> onHeal;
}
