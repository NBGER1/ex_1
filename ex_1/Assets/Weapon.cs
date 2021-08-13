using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon 
{
    protected float Cooldown;
    protected float ReloadTime;
    protected float Damage;
    // API for Player
    public abstract void Reload();
    public abstract void Fire(IDamageable target);

    protected Weapon(float cooldown, float reloadtime, float damage){
        Cooldown = cooldown;
        ReloadTime = reloadtime;
        Damage = damage;
    }
   
}

public class Rifle : Weapon
{

    public override void Reload()
    {
        Debug.Log("Reloading = " + ReloadTime);
    }
    public override void Fire(IDamageable target)
    {
        Debug.Log("Firing = " + Damage);
        target.TakeDamage(Damage);
    }
    public Rifle(float cooldown, float reloadtime, float damage): base(cooldown,reloadtime,damage){}

}

public class Shotgun : Weapon
{

    public override void Reload()
    {
         Debug.Log("Reloading = " + ReloadTime);
    }
    public override void Fire(IDamageable target)
    {
         Debug.Log("Firing = " + Damage);
         target.TakeDamage(Damage);
    }
    public Shotgun(float cooldown, float reloadtime, float damage): base(cooldown,reloadtime,damage){}

}

// rider