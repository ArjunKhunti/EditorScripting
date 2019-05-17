using UnityEngine;
using System.Collections;

public class LevelScript : MonoBehaviour
{
    public int exp;

    public int Level
    {
        get { return exp / 500; }
    }
}