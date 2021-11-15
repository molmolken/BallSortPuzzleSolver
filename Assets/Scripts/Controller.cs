using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    /*
     *
     * Controller　→ DM → UIController
     *               ↓
     *   Player  ←  Solver　→ Logger
    */
    
    enum state
    {
        SelectNumberOfContainer,
        PutBalls,
        Solve,
        Complete,
    }
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
