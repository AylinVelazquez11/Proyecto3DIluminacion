using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiosConTeclas : MonoBehaviour
{
    public int numeroEscenaA;
    public int numeroEscenaD;
    public int numeroEscenaP;
    public int numeroEscenaS;


    void Start()
    {
        
    }

  
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene(numeroEscenaP);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            SceneManager.LoadScene(numeroEscenaA);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            SceneManager.LoadScene(numeroEscenaD);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            SceneManager.LoadScene(numeroEscenaS);
        }
    }
}
