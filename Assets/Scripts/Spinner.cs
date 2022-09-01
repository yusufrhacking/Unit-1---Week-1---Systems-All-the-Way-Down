using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public enum Direction
    {
        Forward,
        Right,
        Left,
        Back
    }

    // Update is called once per frame
    void Update()
    {
        int randValue = 3;
        int repetitions = 30;
        System.Random rand = new System.Random();
        Direction getDir = (Direction)(rand).Next(0, 5);
        switch (getDir)
        {
            case Direction.Forward:
                for (int x = 0; x < repetitions; x++)
                {
                    transform.position += Vector3.forward * Time.deltaTime * rand.Next(0, randValue);
                }
                break;
            case Direction.Right:
                for (int x = 0; x < repetitions; x++)
                {
                    transform.position += Vector3.right * Time.deltaTime * rand.Next(0, randValue);
                }
                break;
            case Direction.Left:
                for (int x = 0; x < repetitions; x++)
                {
                    transform.position += Vector3.left * Time.deltaTime * rand.Next(0, randValue);
                }
                break;
            case Direction.Back:
                for (int x = 0; x < repetitions; x++)
                {
                    transform.position += Vector3.back * Time.deltaTime * rand.Next(0, randValue);
                }
                break;
            default:
                transform.position += Vector3.forward * Time.deltaTime; break;
        }

    }
}
