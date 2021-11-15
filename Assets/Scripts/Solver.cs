using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Solver : MonoBehaviour
{
    public bool Solve(List<Stack<int>> containers)
    {
        var totalCount = GetTotalBallCount(containers);
        
        return true;
    }

    bool Move(Stack<int> from, Stack<int> to)
    {
        if (to.Count == 4) return false;
        if (CheckSameColor(from)) return false;
        if (from.Peek() == to.Peek() || to.Peek() == 0)
        {
            var ball = from.Pop();
            to.Push(ball);
            return true;
        }

        return false;
    }

    List<int> GetTopBalls(List<Stack<int>> containers)
    {
        var balls = new List<int>();
        foreach (var container in containers)
        {
            var top = container.Peek();
            if (!balls.Contains(top))
            {
                balls.Add(top);
            }
        }
        balls.Sort();
        return balls;
    }

    int GetTotalBallCount(List<Stack<int>> containers)
    {
        var sum = 0;
        foreach (var container in containers)
        {
            sum += container.Count;
        }

        return sum;
    }

    bool CheckSameColor(Stack<int> container)
    {
        if (container.Count != 4) return false;

        var first = container.Pop();
        var second = container.Pop();
        var third= container.Pop();
        var fourth = container.Pop();
        return (first == second) && (second == third) && (third == fourth);
    }
}
