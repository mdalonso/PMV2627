using UnityEngine;
using UnityEngine.InputSystem;

public class Play : MonoBehaviour
{
    Keyboard kb;
    Character personaje;
    Player player;
    Enemy enemigo;

    string nombrePersonaje="Mi Personaje";
    int healthPersonaje = -10;
    int speedPersonaje = 15;

    string nombrePlayer = "Mi Player";
    int healthPlayer = 20;
    int speedPlayer = 10;
    int levelPlayer = 1;
    int strengthPlayer = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        kb=Keyboard.current;

        personaje =new Character(nombrePersonaje, healthPersonaje,speedPersonaje);

        Debug.Log("INICIALIZACIÓN DE PERSONAJE BÁSICO****************");
        Debug.Log($"Nombre del personaje: {personaje.NamePlayer}");
        //Debug.Log($"Salud del personaje: {personaje._health}");
        Debug.Log($"Salud del personaje: {personaje.Health}");
        Debug.Log($"Velocidad del personaje: {personaje.speed}");
        Debug.Log($"Nivel del personaje: {personaje.Level}");

        Debug.Log("**************************************************");

        player=new Player(nombrePlayer,healthPlayer,speedPlayer,levelPlayer,strengthPlayer);

        Debug.Log("INICIALIZACIÓN DE PLAYER ****************");
        Debug.Log($"Nombre del PLAYER: {player.NamePlayer}");
        //Debug.Log($"Salud del personaje: {player._health}");
        Debug.Log($"Salud del PLAYER: {player.Health}");
        Debug.Log($"Velocidad del PLAYER: {player.speed}");
        Debug.Log($"Nivel del PLAYER: {player.Level}");
        Debug.Log($"Fuerza del PLAYER: {player.Strength}");

        Debug.Log("**************************************************");

        //enemigo=new Enemy("Enemigo1", 10, 5, 1, 2);
        CrearEnemigos(15);

        Debug.Log($"Número de enemigos creados: {Enemy.nEnemies}");

    }

    // Update is called once per frame
    void Update()
    {
        if (kb.hKey.wasPressedThisFrame)
        {
            personaje.Health++;
            Debug.Log($"Incremento de Salud del personaje: {personaje.Health}");

        }

        if (kb.dKey.wasPressedThisFrame)
        {
            personaje.Health = -20;
            Debug.Log($"Asignación negativa de Salud del personaje: {personaje.Health}");

        }

        if (kb.mKey.wasPressedThisFrame)
        {
            personaje.ShowMessage();
            player.ShowMessage();
        }

        if (kb.sKey.wasPressedThisFrame)
        {
            enemigo.Shoot();
        }

        if (kb.pKey.wasPressedThisFrame)
        {
            player.Attack();
            int index = Random.Range(0, Statistics.enemies.Count);
            Statistics.enemies[index].TakeDamage(1);

        }

        if (kb.eKey.wasPressedThisFrame)
        {
            //Generar un número aleatorio entre 0 y el número de enemigos creados
            int index = Random.Range(0, Statistics.enemies.Count);
            Statistics.enemies[index].Attack();
            player.TakeDamage(1);
        }
    }

    public void CrearEnemigos(int num)
    {
        if (num>Statistics.MaxEnemies)
        {
            Debug.Log($"No se pueden crear más de {Statistics.MaxEnemies} enemigos");
            num=Statistics.MaxEnemies;
        }
        for (int i = 0; i < num; i++)
        {
            Enemy e = new Enemy("Enemigo" + (i + 1), 10, 5, 1, 2);
            Statistics.enemies.Add(e);
        }
    }
}
