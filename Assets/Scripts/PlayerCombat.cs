using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{


    [SerializeField] Animator animator;

    [SerializeField] LayerMask enemyLayers;
    [SerializeField] private Transform attackPoint;

    [SerializeField] float attackRange = 0.5f;
    [SerializeField] private int attackDamage = 50;

    public float attackRate = 2f;
    public float nextAttackTime = 0f;



    // Update is called once per frame
    void Update()
    {
        if(Time.time >= nextAttackTime)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Attack();
                nextAttackTime = Time.time + 1f / attackRate;
            }

        }
       
    }


    void Attack()
    {
        animator.SetTrigger("Attack");
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);


        foreach(Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<Enemy>().TakeDamage(attackDamage);
        }

    }


    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
        
            return;
        
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }

}
