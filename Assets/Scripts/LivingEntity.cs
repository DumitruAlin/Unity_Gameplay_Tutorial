using Interfaces;
using UnityEngine;

public class LivingEntity : MonoBehaviour, IDamageable
{

    // will not show in inspector or other classes, derrived will have it inherited
    public  float    startingHealth;
    private float    health;
    
    // needed in Enemy
    protected bool     dead;

    // will still be called (as it is in parent type) even if child has it's own, overriden method
    protected virtual void Start()
    {
        health = startingHealth;
    }
    
    public void TakeHit(float damage, RaycastHit hit)
    {
        health -= damage;
        if (health <= 0 && !dead)
        {
            Die();
        }
    }

    private void Die()
    {
        dead = true;
        Destroy(gameObject);
    }
}
