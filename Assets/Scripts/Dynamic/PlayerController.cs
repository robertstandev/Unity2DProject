using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(SpriteRenderer))]
public class PlayerController : MonoBehaviour
{
     private PlayerInput inputComponent;
     private Movement movementComponent;
     private Jump jumpComponent;
     private CheckSurroundings checkSurroundingsComponent;
     private Stamina staminaComponent;

     private Rigidbody2D rb;
     private SpriteRenderer sprite;
     private bool canModify = true;

     private void Awake(){
          inputComponent = GetComponent<PlayerInput>();
          movementComponent = GetComponent<Movement>();
          jumpComponent = GetComponent<Jump>();
          checkSurroundingsComponent = GetComponent<CheckSurroundings>();
          staminaComponent = GetComponent<Stamina>();

          rb = GetComponent<Rigidbody2D>();
          sprite = GetComponent<SpriteRenderer>();
     }

     private void FixedUpdate(){
          checkSurroundings();
          checkInput();
     }

     private void checkSurroundings(){
          if(canModify && checkSurroundingsComponent.isGrounded(sprite)){                                 //its on the ground
               canModify = false;
               staminaComponent.startStaminaModifierTimer(0.3f, staminaComponent.addStamina, 5);
               jumpComponent.setJumpCounter(0);
          }else if(!canModify && !checkSurroundingsComponent.isGrounded(sprite)){                         //just jumped
               canModify = true;
               staminaComponent.stopStaminaModifierTimer();
          }
     }

     private void checkInput(){     
          if(inputComponent.isSpacePressed()){
               checkJump();
               inputComponent.executedSpacePressed();
          }  

          if(inputComponent.isLeftPressed()){
               checkOrientationAndMove(false);
          }else if(inputComponent.isRightPressed()){
               checkOrientationAndMove(true);
          }
     }

     private void checkOrientationAndMove(bool isMovingRight){
          if(movementComponent.isFacingRight() != isMovingRight){
               movementComponent.flip();
          }

          movementComponent.move(rb);
     }

     private void checkJump(){
          if(jumpComponent.canJump() && staminaComponent.getStamina() >= 10){
               staminaComponent.substractStamina(10);
               jumpComponent.jump(rb);
          }
     }
}
