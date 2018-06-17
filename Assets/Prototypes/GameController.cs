using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameController : MonoBehaviour
{
    #region Static Instance 
    public static GameController Instance = null;

    void Awake()
    {
        Instance = this;
    }

    void OnApplicationQuit()
    {
        Instance = null;
    }
    #endregion

    public void DestroyAllTiles()
    {
        var tiles = GameObject.FindGameObjectsWithTag("Tile");
        tiles.ToList().ForEach(Destroy);
    }
}