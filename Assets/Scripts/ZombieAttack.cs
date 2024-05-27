using UnityEngine;

public class ZombieAttack : MonoBehaviour
{
    [SerializeField] private float ZombieHealth;
    [SerializeField] private float Speed;
    [SerializeField] private float Damage;
    public GameObject Player;

    void Start()
    {
        if (Player == null)
        {
            Debug.LogError("Player GameObject is not assigned in the Inspector");
        }
    }

    void FixedUpdate()
    {
        if (Player != null)
        {
            // Calculate the direction to the player
            transform.position = Vector3.Lerp(transform.position, Player.transform.position, Speed * Time.deltaTime);
        }
    }
}
