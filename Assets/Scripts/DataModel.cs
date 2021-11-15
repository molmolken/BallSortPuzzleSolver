using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataModel : MonoBehaviour
{
    List<Stack<int>> containers;

    int containerCount;

    public void CreateContainers(int number)
    {
        containerCount = number;

        containers = new List<Stack<int>>();
        for (int i = 0; i < number; i++)
        {
            containers.Add(new Stack<int>(4));
        }
    }

    public void PutBalls(List<int> ballList)
    {
        if (ballList.Count % 4 != 0) Debug.LogError("Error : Number of Balls must be a multiple of four.");

        if (ballList.Count / 4 != containerCount) Debug.LogError("Container count is wrong.");

        int index = 0;
        foreach (var ball in ballList)
        {
            if (containers[index].Count == 4) index++;
            
            containers[index].Push(ball);
        }
    }
}