using UnityEngine;
using UnityEngine.InputSystem;

public class Play : MonoBehaviour
{
    Keyboard kb;
    Character personaje;

    public string nombrePersonaje="Personaje";//Para evitar valores mágicos, se puede usar un campo serializado para asignar el nombre del personaje desde el Inspector de Unity.
    public int puntosVidaPersonaje=25; //Para evitar valores mágicos, se puede usar un campo serializado para asignar los puntos de vida del personaje desde el Inspector de Unity.
    public int velocidadPersonaje = 5; //Para evitar valores mágicos, se puede usar un campo serializado para asignar la velocidad del personaje desde el Inspector de Unity.   
    public int nivelPersonaje = 1; //Para evitar valores mágicos, se puede usar un campo serializado para asignar la velocidad del personaje desde el Inspector de Unity.   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        kb = Keyboard.current;
        personaje = new Character("Personaje", 10, 5, 1);//Valores mágicos
        //personaje= new Character(nombrePersonaje, puntosVidaPersonaje, velocidadPersonaje,nivelPersonaje);//Con campo serializado evitando valores mágicos

        Debug.Log("INICIALIZACIÓN DEL PERSONAJE BÁSICO");
        Debug.Log($"Nombre del personaje: {personaje.NamePlayer}");
        Debug.Log($"Health: {personaje.Health}");
        //Debug.Log($"Health: {personaje._health}");//Esta línea da error porque _health es un campo privado de la clase Character y no es accesible desde la clase Play.
        Debug.Log($"Speed: {personaje.Speed}");
        //Debug.Log($"Level: {personaje._level}");//Esta línea da error porque _level es un campo protegido de la clase Character y no es accesible desde la clase Play.
        Debug.Log($"Level: {personaje.Level}");
    }

    // Update is called once per frame
    void Update()
    {
        //al pulsar la techa h aumentamos la vida del personaje en 1
        if (kb.hKey.wasPressedThisFrame)
        {
            IncreaseHealthCharacter();
            
        }
        if (kb.lKey.wasPressedThisFrame)
        {
            personaje.Level+=100;
            Debug.Log($"Nivele incrementado: {personaje.Level}");
        }


    }

    public void IncreaseHealthCharacter()
    {
        personaje.Health++;
        //personaje._health++;//Esta línea da error porque _health es un campo privado de la clase Character y no es accesible desde la clase Play.
        Debug.Log($"Health: {personaje.Health}");
    }

}
