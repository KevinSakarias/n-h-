using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int healthPoints = 1;
    [SerializeField] bool isPlayer = false;

    bool isDead = false;

    public void TakeDamage(int damage)
    {
        healthPoints -= damage;

        if (healthPoints <= 0)
        {
            isDead = true;

            if (!isPlayer)
            {
                Destroy(this.gameObject);
            }
        }

    }

    public bool GetIsDead()
    {
        return isDead;
    }
}
