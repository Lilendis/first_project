using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public int health = 5;
    public int level = 2;
    public float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        // Измеение количества здоровья
        health += level;
        print("Здоровье игрока " + health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
    }
}
