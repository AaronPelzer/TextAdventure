using System;

public class KitchenScene{

  public void Kitchen(){ //Method

    bool kit = false; //Condition for kitchen loop to start
 
    //References GameObject and prints appropriate text
    Console.WriteLine(MainClass.g.kitchenText);

    //Kitchen scene runs until complete [kit == true]
    while(kit == false){
      
      //Create reference to PickyPockets Interact method
      string kitChoice = MainClass.p.Interact();

      if(kitChoice == "EAT BREAKFAST"){
        
        //References GameObject and prints appropriate text
        Console.WriteLine(MainClass.g.breakText);
        //Picky has eaten breakfast
        MainClass.breakf = true;
      
      }
      else if(kitChoice == "ANSWER" || MainClass.breakf == true){

        if(MainClass.breakf == true){
          
          //References GameObject and prints appropriate text
           Console.WriteLine(MainClass.g.ansText1);

          MainClass.street = true; //Start street scene
          MainClass.kitchen = false; //End kitchen scene
          kit = true; //End this loop

        }
        else{
          
          //References GameObject and prints appropriate text
          Console.WriteLine(MainClass.g.ansText2);

          MainClass.street = true; //Start street scene
          MainClass.kitchen = false; //End kitchen scene
          kit = true; //End this loop
        }

      }
      else{
        //Reiterate to the player to type exactly what is written to Interact().
        Console.WriteLine("You need to be more specific. Don't forget to CAPITALIZE!");
      }

    }
  }
}