using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Enemy : MonoBehaviour
{   
    public bool warriorClicked = false;
    public bool archerClicked = false;
    public int enemyHp = 100;
    public int damage = 10;

    private float x, y, z;
 
    
    public void move()
    {

        x = transform.position.x;
        z = transform.position.z;
        if (Input.GetKey("d")){
            x += 0.1f;
            transform.position = new Vector3(x,y,z);  
        }

        if (Input.GetKey("a")){
            x -= 0.1f;
            transform.position = new Vector3(x,y,z);
   
        }
            
        if (Input.GetKey("w")){
            z += 0.1f;
            transform.position = new Vector3(x,y,z);

        
        }
        if (Input.GetKey("s")){
            z -= 0.1f;
            transform.position = new Vector3(x,y,z);

        
        }

        // if (Input.GetMouseButtonUp(0)){
        //     Vector3 position = Input.mousePosition;
        //     position = Camera.main.ScreenToWorldPoint(position);
        //     transform.position = position;
        // }   хотел попробовать реализовать движене объекта с помощью мышки, но не получилось(объясните пж почему)  
        
        
    }
                
    public void doDamage(){
        Debug.Log("Do damage");
        
    }
   
                
    public void takeDamage(){
       Debug.Log("Damage taken");
   }

   

}