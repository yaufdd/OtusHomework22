using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Archer : Enemy,  IPointerClickHandler
{

    private bool isClicked = false;
    void Update() {
        if(archerClicked){
            move();
        }
        
        
    }
    
    private void OnTriggerEnter(Collider other) {
        doDamage();
        takeDamage();
    }

    public void OnPointerClick(PointerEventData eventData){
        archerClicked = !archerClicked;
    }   
}