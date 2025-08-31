using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int hp;

    public void TakeDamage(int damageAmount, int id, Player player)
    {
        hp -= damageAmount;
        if (hp <= 0)
        {
            player.RemoveEnemy(id);
            Destroy(gameObject);
        }
    }
}
