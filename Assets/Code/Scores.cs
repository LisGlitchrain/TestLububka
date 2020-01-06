using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Movement))]
public class Scores : MonoBehaviour
{
    public int currentScore;
    public Movement movement;
    // Start is called before the first frame update
    void Start()
    {
        movement = GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentScore < (int) movement.currentDistance) currentScore = (int) movement.currentDistance;
    }
}
