using UnityEngine;

public class Character
{
    //C# moderno ***********************************
    //Se sustituye la declaración de campos por propiedades autoimplementadas salvo:
    //- Cuando estamos declarando campos privados de uso interno de la clase (no requieren ser accedidos desde el exterior en ningún caso)
    //- Se requiere implementar lógica interna en los getters/setters

    //public string namePlayer;
    public string NamePlayer { get;set; } //Propiedad automática (C# 3.0 en adelante)
    //internal int speed;

    private int _health;
    public int Health{
        //get { return _health; }
        get => _health; //Expresión lambda (C# 6.0 en adelante)
        //set { _health = value; }
        //set => _health = value; //Expresión lambda (C# 6.0 en adelante)

        set
        {
            _health=Mathf.Max(0,value); //Evita que la vida sea negativa
            if (_health<=0) Die();
        }
    }
    internal int Speed { get; set; } //Propiedad automática (C# 3.0 en adelante)
    protected int _level;

    public int Level
    {
        get => _level;
        set => _level = Mathf.Max(1, value); //Evita que el nivel sea menor que 1   
    }
    //Propiedad automática con modificador de acceso protected, solo accesible desde la clase Character y sus subclases
    protected bool Ready { get; set; } //Propiedad automática (C# 3.0 en adelante)

    public Character(string namePlayer, int health,int speed,int level, bool ready=true)
    {
        //this.namePlayer = namePlayer;//con campo
        NamePlayer = namePlayer;//con propiedad
        //this._health = health;//Asignar valor al campo directamente
        Health = health;//Asignar valor a través del setter para que se ejecute la lógica de validación
        //this.speed = speed;//con campo
        Speed = speed;//con propiedad
        Level = level;
    }

    public void Die()
    {
       //Debug.Log($"El personaje {namePlayer} ha muerto");
       Debug.Log($"El personaje {NamePlayer} ha muerto");
    }

    
}
