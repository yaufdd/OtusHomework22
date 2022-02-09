using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Warrior : Enemy, IPointerClickHandler
{

    
    
    void Update() {
        if (warriorClicked){
            move();
        }
    }
    
    private void OnTriggerEnter(Collider other) {
        doDamage();
        takeDamage();
    }
     
     
    public void OnPointerClick(PointerEventData eventData){
        
        warriorClicked = !warriorClicked;

    }
}
