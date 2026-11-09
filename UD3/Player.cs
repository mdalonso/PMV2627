using UnityEngine;

public class Player:Character,IAttack
{
    public int Strength { get; set; }

    public Player (string namePlayer,int health,int speed, int level, int strength) : base(namePlayer, health, speed, level)
    {
        Strength = strength;
    }

    public override void ShowMessage()
    {
        Debug.Log("INFORME DE PLAYER===================================");
        Debug.Log($"Nombre del PLAYER: {NamePlayer}");
        Debug.Log($"Salud del PLAYER: {Health}");
        Debug.Log($"Velocidad del PLAYER: {speed}");
        Debug.Log($"Nivel del PLAYER: {Level}");
        Debug.Log($"Fuerza del PLAYER: {Strength}");
    }

    public void Attack()
    {
        Debug.Log("Lógica de ataque de player");
    }
}
