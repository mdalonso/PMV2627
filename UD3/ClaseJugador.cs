using UnityEngine;
using UnityEngine.InputSystem;

public class ClaseJugador : MonoBehaviour
{
    Keyboard kb;
    BasicPlayer player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        kb = Keyboard.current;//Inicializa el teclado

        player =new BasicPlayer("Mi personaje", 10);//Inicializa el personaje con nombre y vida

        Debug.Log($"Se ha creado el personaje {player.name}");
    }

    // Update is called once per frame
    void Update()
    {
        IncreaseHealth();
    }

    void IncreaseHealth()
    {
        //Se incrementa la salud del personaje al presionar la tecla h
        if (kb.hKey.wasPressedThisFrame)//Si se presiona la tecla h, aumenta la vida del personaje
        {
            player.health++;
            Debug.Log($"Vida de  mi personaje: {player.health}");
        }
    }
}
