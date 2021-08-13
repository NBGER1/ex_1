using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : IDamageable
{
    public void TakeDamage(float damage)
    {
        Debug.Log("I was hit for = " + damage);
    }
 
}
