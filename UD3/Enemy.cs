using UnityEngine;

public class Enemy:Character,IAttack
{
    public int BulletCount { get; set; }
    public static int nEnemies = 0;

    public Enemy(string name, int health, int speed, int level, int bulletCount=100) : base(name, health, speed, level)
    {
        BulletCount = bulletCount;
        nEnemies++;//Cada vez que se crea un enemigo, se incrementa el contador de enemigos
    }

    public void Shoot()
    {
        BulletCount--;
        Debug.Log("Disporando bala, balas restantes: " + BulletCount);
        if (BulletCount <= 0) Debug.Log("No hay balas");

    }

    public void Attack()
    {
        Debug.Log("Lógica de ataque de enemigo");
        Debug.Log($"El enemigo {NamePlayer} está atacando");
    }

   
}
