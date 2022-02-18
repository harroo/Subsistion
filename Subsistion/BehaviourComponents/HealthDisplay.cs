
using UnityEngine;
using UnityEngine.UI;

using SubsistionInternal;

[RequireComponent(typeof(Slider))]
public class HealthDisplay : MonoBehaviour {

    private Slider slider;
    private void Awake () {

        slider = GetComponent<Slider>();
    }

    private void Start () {

        SubsistionHealthManager.AddToEvents(this);
    }
    private void OnDestroy () {

        SubsistionHealthManager.RemoveFromEvents(this);
    }

    public void Configure () {

        slider.minValue = 0;
        slider.maxValue = SubsistionHealthManager.maxHealth;
        slider.wholeNumbers = true;
    }
    public void RefreshDisplay () {

        slider.value = SubsistionHealthManager.health;
    }
}
