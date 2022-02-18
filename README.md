
#Subsistion
A useful ol' lot of Survival-Mechanics that you can import and use to easily implement Health, Leveling, Stamina, etcetera to your Unity3D-Project.

##Install
Simply copy the [Subsistion/](https://github.com/harroo/Subsistion/tree/main/Subsistion) folder into your Unity-Project's Assets directory.

##Usage
###`Health-System`
You can apply the `HealthDisplay` MonoBehaviour Component unto a `Slider` and it will display the Health-Levels.

You can also access the Health-Levels with some simple Methods.
```cs
// Restores the Health-Level to the maximum;
Subsistion.RestoreHealth();

// Sets the maximum Health-Level.
Subsistion.SetMaxHealth(int level);

// Sets the current Health-Level.
Subsistion.SetHealth(int level);

// Increases the Health-Level by the value.
Subsistion.IncreaseHealth(int points);

// Decreases the Health-Level by the value.
Subsistion.DecreaseHealth(int points);
```

There are also a few Events, you can access them as such.
```cs
// Here're a few ways that you can access the 'On Death' Action-Event.
Subsistion.onDeath = MyOnDeathMethod;
Subsistion.onDeath = () => { Debug.Log("Game Over!"); }

// Called when Damage is taken.
// This is a System.Action<int>
Subsistion.onDamage;

// Called when Healed.
// This is also a System.Action<int>
Subsistion.OnHeal;
```

---

Spelling and Orthography correction: [Kieralia](https://github.com/kieralia)
