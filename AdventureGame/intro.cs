using System;

public class IntroScene
{

    public void Intro()
    { //Method

        //References GameObject and prints appropriate text
        Console.WriteLine(MainClass.g.introText);

        //Repeat until Intro Scene is complete [true]
        while (MainClass.intro == false)
        {

            //Create reference to PickyPockets Interact method
            string choice = MainClass.p.Interact();
            //Check user input against possible options
            if (choice == "NEWSPAPER ARTICLE")
            {

                //References GameObject and prints appropriate text
                Console.WriteLine(MainClass.g.newsText);

            }
            else if (choice == "STACK OF BOOKS")
            {

                //References GameObject and prints appropriate text
                Console.WriteLine(MainClass.g.bookText);
            }
            else if (choice == "KIND OLD LADY")
            {

                bool KOL = false; //Boolean for TAKE EVERYTHING
                bool box = false; //Boolean for SMALL METAL BOX
                bool clock = false; //Boolean for ALARM CLOCK

                string fPocket; //var for Fakey Pocket
                string tWhorl;  //var for Time Whorl

                //References GameObject and prints appropriate text
                Console.WriteLine(MainClass.g.chestText);

                while (KOL == false)
                { //While this scene is not complete
                  //Get user input again
                    string roomChoice = MainClass.p.Interact();

                    if (roomChoice == "SMALL METAL BOX")
                    {

                        //References GameObject and prints appropriate text
                        Console.WriteLine(MainClass.g.boxText);

                        box = true; //Picky knows what the box is
                    }
                    else if (roomChoice == "ALARM CLOCK")
                    {

                        //References GameObject and prints appropriate text
                        Console.WriteLine(MainClass.g.clockText);

                        clock = true; //Picky knows what the clock is
                    }
                    else if (roomChoice == "TAKE EVERYTHING" || (box == true && clock == true))
                    {
                        //Determines appropriate response for whether or not Picky knows or does not
                        //know what a certain item is
                        //This will run immediately after Picky looks at both items or if TAKE EVERYTHING is typed
                        if (box == true && clock == false)
                        {
                            //MainClass.p knows what the box is but not the clock
                            Console.WriteLine("\r\n You put on your boots then place Fakey Pocket along with the weird clock in your backpack. You hop down to the floor from your loft and go to the kitchen where the Kind Old Lady is.");

                            //Changes how Fakey Pocket and Time Whorl are called in Picky's backpack
                            fPocket = "FAKEY POCKET";
                            tWhorl = "WEIRD CLOCK";
                            MainClass.p.AddItem(fPocket);
                            MainClass.p.AddItem(tWhorl);

                        }
                        else if (box == false && clock == true)
                        {
                            //MainClass.p knows what the clock is but not the box
                            Console.WriteLine("\r\n You put on your boots then place the metal box along with the Time Whorl in your backpack. You hop down to the floor from your loft and go to the kitchen where the Kind Old Lady is.");

                            //Changes how Fakey Pocket and Time Whorl are called in Picky's backpack      
                            fPocket = "METAL BOX";
                            tWhorl = "TIME WHORL";
                            MainClass.p.AddItem(fPocket);
                            MainClass.p.AddItem(tWhorl);
                        }
                        else if (box == true && clock == true)
                        {
                            //MainClass.p knows what the box and clock are
                            Console.WriteLine("\r\n You put on your boots thrn place Fakey Pocket along with the Time Whorl in your backpack. You hop down to the floor from your loft and go to the kitchen where the Kind Old Lady is.");
                            //Changes how Fakey Pocket and Time Whorl are called in Picky's backpack 
                            fPocket = "FAKEY POCKET";
                            tWhorl = "TIME WHORL";
                            MainClass.p.AddItem(fPocket);
                            MainClass.p.AddItem(tWhorl);
                        }
                        else
                        {
                            //MainClass.p does not know what the box and the clock are
                            Console.WriteLine("\r\n You put on your boots then place the metal box along with the weird clock in your backpack. You hop down to the floor from your loft and go to the kitchen where the Kind Old Lady is.");
                            //Changes how Fakey Pocket and Time Whorl are called in Picky's backpack      
                            fPocket = "METAL BOX";
                            tWhorl = "WEIRD CLOCK";
                            MainClass.p.AddItem(fPocket);
                            MainClass.p.AddItem(tWhorl);
                        }

                        MainClass.kitchen = true; //Start the kitchen scene
                        MainClass.intro = true; //End the Intro Scene
                        KOL = true; //End TAKE EVERYTHING

                    }
                    else
                    {
                        //Reiterate to the player to type exactly what is written to Interact().
                        Console.WriteLine("You need to be more specific. Don't forget to CAPITALIZE!");

                    }
                }

            }
            else
            {
                //Reiterate to the player to type exactly what is written to Interact().
                Console.WriteLine("You need to be more specific. Don't forget to CAPITALIZE!");

            }
        }
    }
}