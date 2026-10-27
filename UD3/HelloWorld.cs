using UnityEngine;
using UnityEngine.InputSystem;

//1. Declaración de campos de diferentes tipos primitivos de datos.
//2. Inicialización de campos en Start()
//3. Ámbito de campos: Se pueden usar en todos los métodos de la clase.
//4. Ámbito de variables: Se usan sólo donde están declados

public class HelloWorld : MonoBehaviour
{
    //Tipos primitivos de datos:
    int health;//Valores enteros
    float speed;//Valores decimales en punto flotante
    string namePlayer;//Valores de texto (cadenas)
    bool damage; //Valores booleanos (true o false)
    char confirm; //Valores de texto (un solo carácter)

    int count = 1; //Los campos se pueden inicializar en la propia declaración.

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //Se ejecuta al justo antes de mostrar el primer frame si el objeto al que se asocia
    //el script está activo o bien en el momento de su activación si es que no se ha ejecutado antes por estar
    //desactivado al iniciar la escena.SÓLO SE EJECUTA UNA VEZ.
    void Start()
    {
        Debug.Log("¡Hola Mundo!");

        //Los campos son accesibles por todos los métodos de la clase
        //Inicialización de campos
        health = 5;
        speed = 10.5f;//Cuando asignamos valor a una variable de tipo float es necesario poner la f.
        namePlayer = "Jugador"; //Cadenas se encierran entre comillas dobles
        damage = false;
        confirm = 'y';//Caracter se encierra entre comillas simples.

        //Debug.Log(nameInTime);//Esta línea da error porque la variable nameInTime es local al método Update() y no es accesible desde Start().
    }

    // Update is called once per frame
    void Update()
    {
        string nameInTime;//Declaramos una variable local, sólo accesible dentro del método Update()
        
        Debug.Log("Vamos a aprender a programar en Unity.");
        
        //Los campos son accesibles por todos los métodos de la clase
        //operador + con valores numéricos (suma)
        health++;//El operador ++ incrementa en 1 el valor de la variable
        speed--;//El operador -- decrementa en 1 el valor de la variable

        //Operadores aritméticos:
        //a+b; a-b; a*b; a/b; a%b
        //a+=b; a-=b; a*=b; a/=b

        Debug.Log("Con concatenación: Health: " + health + " Speed: " + speed); //Concatenación de cadenas (operador +)
        Debug.Log($"Con interpolación: Health: {health} Speed {speed}");//Interpolación de cadenas 

        //Ámbito de las variables
        count++; //--> Después cambiarlo por una llamada a IncreaseCounter()
        nameInTime = $"Nombre del jugador: {namePlayer} {count}";
        Debug.Log(nameInTime);

        //IncreaseCounter();

        MovementManager();

    }

    void IncreaseCounter()
    {
        //nameInTime contiene un nombre de jugador que depende de un contador que se incrementa en cada frame
        string nameInTime;
        
        count++;
        nameInTime = namePlayer + " " + count;
        Debug.Log("Nombre de Jugador:" + nameInTime);
    }
    //Métodos de simulación del movimiento del jugador
    void MoveForward()
    {
        Debug.Log("El jugador se mueve hacia adelante");
    }
    void MoveBackward()
    {
        Debug.Log("El jugador se mueve hacia atrás");
    }
    void MoveLeftward()
    {
        Debug.Log("El jugador se mueve a la izquierda");
    }
    void MoveRightward()
    {
        Debug.Log("El jugador se mueve a la derecha");
    }

    //Gestión de la entrada del usuario para el movimiento del jugador
    void MovementManager()
    {
        //Manejo básico de la entrada del usuario
        Keyboard kb = Keyboard.current;

        if (kb == null) return; // no hay teclado conectado
        
        //Se puede usar el operador || (OR) para combinar varias condiciones
        if (kb.wKey.isPressed || kb.upArrowKey.isPressed)
        {
            MoveForward();
        }
        if (kb.sKey.isPressed)
        {
            MoveBackward();
        }
        if (kb.aKey.isPressed)
        {
            MoveLeftward();
        }
        if (kb.dKey.isPressed)
        {
            MoveRightward();
        }


       
    }
}
