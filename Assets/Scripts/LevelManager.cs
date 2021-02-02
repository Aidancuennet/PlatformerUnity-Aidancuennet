using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;

    public Transform respawnPoint;
    public GameObject PlayerPrefab;

    private void Awake()
    {
        instance = this;
    }

    public void Respawn()
    {
        Instantiate(PlayerPrefab, respawnPoint.position, Quaternion.identity);
    }
}
