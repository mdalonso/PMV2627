using System.Collections.Generic;
using UnityEngine;

public static class Statistics
{
    private static int _maxEnemies = 10;

    public static List<Enemy> enemies = new List<Enemy>();

    public static int MaxEnemies
    {
        get => _maxEnemies;
        set => _maxEnemies = Mathf.Max(0, value);
    }
}
