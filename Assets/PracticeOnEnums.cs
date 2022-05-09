using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeOnEnums : MonoBehaviour
{
    // Start is called before the first frame update
    /*Enums is a value type that represents a set of related name integral constants, they are declared with keyWord enum.
     *Benifits of enums:
        *Express and limit available optins for a variables value.
        *Named values provide readability.
     */
    // public GameState gameState;
    public int gameState;
    void Start()
    {
        //gameState = GameState.idle;
        gameState = 3;
    }

    // Update is called once per frame
    void Update()
    {
        #region
        /*  switch (gameState)
             {

              //Using switch Based on gameStates
             case GameState.walking:
                  Debug.Log("**GameState is walking**");
                  break;
              case GameState.running:
                  Debug.Log("**GameState is running**");
                  break ;
              case GameState.jumping:
                  Debug.Log("**GameState is jumping**");
                  break;
              default: 
                 Debug.Log("**GameState is idle**");
                  break;*/
        #endregion
        switch(gameState)
        {

            //Using switch Based on values
            case 0:
                Debug.Log("**GameState is walking**");
                break;
            case 1:
                Debug.Log("**GameState is running**");
                break;
            case 2:
                Debug.Log("**GameState is jumping**");
                break;
            case 3:
                Debug.Log("**GameState is idle**");
                break; 
    }

}
}
public enum GameState{ running=1,walking=2,idle=3,jumping=4 }
