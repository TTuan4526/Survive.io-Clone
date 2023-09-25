using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Manager Controller")]
    public BooleanManager Boolean;
    public PlayerManager PlayerPrefab;
    public AudioManager Sounds;
    public JoystickManager JoystManager;
    public SpawnManager Spawner;
    public TimerManager Timer;
    public BtnManager BtnManager;
    public WeaponsManager WeaponSpawn;
    public UIManager UIManager;

    [Header("Screen Main Menu")]
    public GameObject screenHome;
    public GameObject screenVolve;
    public GameObject screenShop;
    public GameObject screenDeath;
    public GameObject screenEquipment;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
