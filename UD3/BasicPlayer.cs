using UnityEngine;

public class BasicPlayer
{
    public string name;
    public int health;
    public int speed;

    public BasicPlayer(string nameIni, int healthIni,int speed)
    {
        name = nameIni;
        health = healthIni;
        this.speed=speed;//Si tienen el mismo nombre hay que desambiguar con this.
    }
}
