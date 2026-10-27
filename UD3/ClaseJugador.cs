using UnityEngine;
using UnityEngine.InputSystem;

public class ClaseJugador : MonoBehaviour
{
    Keyboard kb;//Acceso al teclado
    
    BasicPlayer player;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        kb = Keyboard.current;//Inicializa el teclado. Las inicializaciones se suelen hacer en Start() o en Awake()

        player1 =new BasicPlayer("Mi personaje", 10);//Inicializa el personaje con nombre y vida
        player2 = new BasicPlayer("Otro personaje",15,5);//Inicializa el personaje sin considerar los valores por defecto.

        Debug.Log($"Se ha creado el personaje {player1.name}");
        Debug.Log($"Se ha creado el personaje {player2.name}");
    }

    // Update is called once per frame
    void Update()
    {
        IncreaseHealth();
    }

    void IncreaseHealth()
    {
        //Se incrementa la salud del personaje al presionar la tecla h
        if (kb.hKey.wasPressedThisFrame)//Si se presiona la tecla h (KeyDown), aumenta la vida del personaje
        {
            player.health++;
            Debug.Log($"Vida de  mi personaje: {player.health}");
        }
    }
}
