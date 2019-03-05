using System;

public class PickyPocket{

//Picky uses items
//Picky has an inventory
//Picky can know/not know what something is
//Picky can have different success rates based on having breakfast

  /*
  Picky's inventory space created
  */
  public static int numItemSlots = 4;
  public static string[] items = new string[numItemSlots];

  /*
  Picky's abilities are off
  */
  public bool sneakS = false; //Sneaky Dash
  public bool fakeS = false;  //Fakey Pocket
  public bool timeS = false;  //Time Whorl
  public bool hideS = false;  //Hide
  /*
  Picky's success rates
  */
  public static Random rnd = new Random(); //Random Number Generator
  static int sneak = rnd.Next(1,10); //Reference to Sneaky Dash success rate
  static int fake = rnd.Next(1,20);  //Reference to Fakey Pocket success rate
  static int time = rnd.Next(1,20);  //Reference to Time Whorl success rate
  static int hide = rnd.Next(1,10);  //Reference to Hide success rate

  public string Interact(){
    //This method is used in all scene's to receive user input
    Console.Write("\r\n"+ "What will you interact with?");       //Console.Write asks for user input
    string choice = Console.ReadLine(); //Console.ReadLine saves user input
    return choice; //User input is given back to check against conditions in a scene

  }

  public void invReset(){
        Array.Clear(items,0, numItemSlots);
  }

  public void AddItem(string itemToAdd){
    //This method is used in scenes where items are to be picked up by Picky
    
    for(int i = 0; i < items.Length; i++){ //As long as there is space in the inventory

      if(items[i] == null){                //and the slot is empty

        items[i] = itemToAdd;              //add item to inventory
        Console.WriteLine("You have " + items[i] + " in your backpack.");
        break;
      }

    }

    if(items[numItemSlots-1] != null){
        Console.WriteLine("Your backpack is full.");
    }

  
  }

  public void RemoveItem (string itemToRemove){
    //This method is used in scenes where items are to be dropped/used by Picky  

    for(int i = 0; i < items.Length; i++){ //As long as there are items in the inventory

      if(items[i] == itemToRemove){        //and there is a slot with an item

        Console.WriteLine("You have used " + items[i]);
        items[i] = null;                   //remove item from inventory
        break;
      }

    }    

    if(items[0] == null){
      Console.WriteLine("You have nothing in your backpack.");
    }
  }

  public void SneakyDash(bool breakfast){
   //Method that controls the success rate of Sneaky Dash

    if(breakfast){                //If Picky ate breakfast
      if(sneak > 2){              //90% chance
        sneakS = true;            //of success
      }
      else{                       //10% chance
        sneakS = false;           //of failure
      }
    }
    else{                         //If Picky did not eat breakfast
      if(sneak > 5){              //50% chance
        sneakS = true;            //of success
      }
      else{                       //50% chance
        sneakS = false;           //of failure
      }
    }
  }

  public void FakeyPocket(bool breakfast){
   //Method that controls the success rate of Fakey Pocket

    if(breakfast){                //If Picky ate breakfast
      if(fake > 5){               //75% chance
        fakeS = true;             //of success
      }
      else{                       //25% chance
        fakeS = false;            //of failure
      }
    }
    else{                         //If Picky did not eat breakfast
      if(fake > 9){               //45% chance
        fakeS = true;             //of success
      }
      else{                       //55% chance
        fakeS = false;            //of failure
      }
    }

  }

  public void TimeWhorl(bool breakfast){
    //Method that controls success rate of Time Whorl

    if(breakfast){                //If Picky ate breakfast
      if(time > 5){               //75% chance
        timeS = true;             //of success
      }
      else{                       //25% chance
        timeS = false;            //of failure
      }
    }
    else{                         //If Picky did not eat breakfast
      if(time > 9){               //45% chance
        timeS = true;             //of success
      }
      else{                       //55% chance
        timeS = false;            //of failure
      }
    }
  }

  public void Hide(bool breakfast){
    //Method that controls success rate of Hide
  
    if(breakfast){                //If Picky ate breakfast
      if(hide > 2){               //90% chance
        hideS = true;             //of success
      }
      else{                       //10% chance
        hideS = false;            //of failure
      }
    }
    else{                         //If Picky did not eat breakfast
      if(hide > 5){               //50% chance
        hideS = true;             //of success
      }
      else{                       //50% chance
        hideS = false;            //of failure
      }
    }
  }

  public void Ability(string abl){
    //Method that uses abilities

    if(abl == "SNEAK"){
      
      SneakyDash(MainClass.breakf);
      
      if(sneakS == true){
        MainClass.sneakUse = true;
      }
    }
    
    if(abl == "FAKEY POCKET"){
      FakeyPocket(MainClass.breakf);
      
      if(fakeS == true){
        MainClass.fakeUse = false;

        string fPocket = "FAKEY POCKET";
        RemoveItem(fPocket);
      }
    }
    if(abl == "TIME WHORL"){
      TimeWhorl(MainClass.breakf);
      if(timeS == true){
        MainClass.timeUse = false;

        string tWhorl = "TIME WHORL";
        RemoveItem(tWhorl);
      }
    }

    if(abl == "HIDE"){
      Hide(MainClass.breakf);
      
      if(hideS == true){
        MainClass.hideUse = false;
      }
    }    

  }
}