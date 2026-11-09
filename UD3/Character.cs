using System.Net.NetworkInformation;
using UnityEngine;

public class Character
{

    //public string namePlayer;

    public string NamePlayer { get;  private set; }//propiedad autoimplementada
    private int _health;

    public int Health
    {
        get { return _health; }
        set {
            //if (value < 0) _health = 0;
            //else _health = value;

            _health = Mathf.Max(0,value);

            if (_health <= 0) Die();
        }

    }
    internal int speed;

    protected int _level;

    public int Level
    {
        get => _level; //get { return _level; }
        set => _level = Mathf.Max(1, value);
    }

    public Character(string namePlayer, int health,int speed, int level=1)
    {
        this.NamePlayer = namePlayer;
        //_health = health;
        Health = health;
        this.speed = speed;
        _level = level;
    }

    //El método Die sólo es accesible desde el interior de la clase. Se llama en el setter de health
    private void Die()
    {
        Debug.Log(NamePlayer + " has died.");

    }
    //Método TakeDamage: resta vida  por haber recibido un daño.
    //Hace uso de la propiedad para acceder al campo Health.
    public void TakeDamage(int damage)
    {
        Health -= damage;
    }

    public virtual void ShowMessage()
    {
        Debug.Log("INFORME DE PERSONAJE BÁSICO*********************************");
    }




}
