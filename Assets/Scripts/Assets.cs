using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Assets : MonoBehaviour
{
    private int currentAge = 30;
    public int addedAge = 1;

    void Start()
    {
        ComputeAge();
        UnityEngine.Debug.Log($"A string can have variables like interted directly!");
    }

    void ComputeAge()
    {
        int totalAge = currentAge + addedAge;

        // Используйте полное имя пространства имен для Debug
        UnityEngine.Debug.Log("Общий возраст: " + totalAge);
    }
}
