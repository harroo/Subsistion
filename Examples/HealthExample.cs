
using UnityEngine;

public class HealthExample : MonoBehaviour {

    public float moveForce;

    private Rigidbody _rigidbody;

    private void Awake () {

        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Start () {

        Subsistion.SetMaxHealth(4);
        Subsistion.RestoreHealth();

        Subsistion.onDeath = () => {

            Debug.Log("Game Over!");

            Subsistion.RestoreHealth();
            transform.position = Vector3.zero;
        };

        Subsistion.onDamage = (int e) => {

            Debug.Log("Damage Taken!");
        };
    }

    private void FixedUpdate () {

        _rigidbody.AddForce(new Vector3(
            Input.GetAxis("Horizontal") * moveForce, 0,
            Input.GetAxis("Vertical") * moveForce
        ));
    }

    private void OnCollisionEnter (Collision collision) {

        if (collision.collider.tag != "Danger") return;

        Subsistion.DecreaseHealth(1);
    }
}
