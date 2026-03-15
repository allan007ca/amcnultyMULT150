using UnityEngine;

public class ImportantFunctions : MonoBehaviour
{
   
    void Start()
    {
        print("Start runs before an object Updates");
        
    }

    
    void Update()
    {
        print("This is called once a frame");
       
    }
}