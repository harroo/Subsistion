
using System;
using System.Collections.Generic;

using UnityEngine;

namespace SubsistionInternal {

    public static class SubsistionHealthManager {

        private static List<HealthDisplay> displayBehaviours
            = new List<HealthDisplay>();

        public static void AddToEvents (HealthDisplay displayBehaviour) {

            displayBehaviours.Add(displayBehaviour);
            displayBehaviour.Configure();
        }
        public static void RemoveFromEvents (HealthDisplay displayBehaviour) {

            displayBehaviours.Remove(displayBehaviour);
        }

        public static void Reconfigure () {

            foreach (var displayBehaviour in displayBehaviours)
                displayBehaviour.Configure();
        }
        public static void Refresh () {

            foreach (var displayBehaviour in displayBehaviours)
                displayBehaviour.RefreshDisplay();
        }

        private static int _maxHealth;
        public static int maxHealth {

            get { return _maxHealth; }
            set { _maxHealth = value; Reconfigure(); Refresh(); }
        }

        private static int _health;
        public static int health {

            get { return _health; }
            set { _health = value; Refresh(); CheckDeath(); }
        }

        public static Action onDeathAction;
        public static void CheckDeath () {

            if (health <= 0) onDeathAction();
        }
    }
}
