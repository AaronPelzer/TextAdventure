using System;

public class StreetScene{

  public void Street(){

    Console.WriteLine(MainClass.g.streetText);

    bool st = false;

    while(st == false){

      string choice = MainClass.p.Interact();

      if(choice == "IRON GATE"){

        Console.WriteLine(MainClass.g.gateText);

        choice = MainClass.p.Interact();
        if(choice == "CONFUSE"){
          Console.WriteLine(MainClass.g.confuseText);

          choice = MainClass.p.Interact();

          if(choice == "BIG PARTY"){

            Console.WriteLine(MainClass.g.partyText);

            MainClass.mansion = true;
            st = true;

          }
          else if(choice == "FAKEY POCKET"){

            MainClass.p.Ability(choice);

            if(MainClass.fakeUse == true){
              Console.WriteLine(MainClass.g.fakeSuccess);
              Console.WriteLine("\r\n The guards look at Fakey Pocket and start taking to it like if it was you. That was easy. You go into the mansion, hoping the rest of this heist is as easy.");
              MainClass.mansion = true;
              st = true;
            }
            else{
              Console.WriteLine(MainClass.g.fakeFail);
              Console.WriteLine(MainClass.g.gameOver);
              st = true;
            }

          }
          else{
            //Reiterate to the player to type exactly what is written to Interact().
            Console.WriteLine("You need to be more specific. Don't forget to CAPITALIZE!");
          }
        }
        else if(choice == "SNEAK"){
          MainClass.p.Ability(choice);

          if(MainClass.sneakUse == true){
            Console.WriteLine(MainClass.g.sneakSuccess);
            Console.WriteLine("\r\n You take advantage of the fact that the guards are trying to tell the birds on the arch that they are trespassing to do a little trespassing of your own. Into the mansion you go!");
            MainClass.mansion = true;
            st = true;
          }
          else{
            Console.WriteLine(MainClass.g.sneakFail);
            Console.WriteLine(MainClass.g.gameOver);
            Console.Write("Would you like to play again? Type YES or NO");
            string restart = Console.ReadLine();
            if(restart == "YES"){
              MainClass.Reset();
            }
            else{
              MainClass.End();
            }
          }
        }
        else{
          //Reiterate to the player to type exactly what is written to Interact().
          Console.WriteLine("You need to be more specific. Don't forget to CAPITALIZE!"); 
        }

      }
      else if(choice == "OPENING"){

      }
      else{
        //Reiterate to the player to type exactly what is written to Interact().
        Console.WriteLine("You need to be more specific. Don't forget to CAPITALIZE!");
      }

    }

  }
}