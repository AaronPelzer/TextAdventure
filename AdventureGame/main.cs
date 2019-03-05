using System;


class MainClass
{

    /*
    These booleans determine whether a scene is active.
    */
    public static bool intro = false;
    public static bool kitchen = false;
    public static bool street = false;
    public static bool mansion = false;
    public static bool breakf = false;

    /*
    These booleans determine whether an ability has been used
    */

    public static bool sneakUse = false;
    public static bool fakeUse = false;
    public static bool timeUse = false;
    public static bool hideUse = false;

    /*
    References objects for the PickyPocket and GameObject classes
    */

    public static PickyPocket p = new PickyPocket();
    public static GameObject g = new GameObject();



    public static void Main(string[] args)
    {

        //Console.WriteLine prints to the console
        Console.WriteLine("Welcome to Picky Pocket's Quest For Greatness. \r\n" + "This is a text adventure! Make sure to type commands to progress the story.\r\n" + "Items you can interact, locations you can visit, and action you can take with will be CAPITALIZED. \r\n" + "Enjoy! \r\n \r\n" + "====================== ");

        //Calls the Intro Scene
        IntroScene iScene = new IntroScene(); //Create intro Scene
        iScene.Intro(); //Call Intro Method of intro scene

        if (kitchen == true)
        { //If Intro Scene is done

            KitchenScene kScene = new KitchenScene(); //Create kitchen Scene
            kScene.Kitchen(); //Call kitchen Method of Kitchen scene
        }

        if (street == true)
        { //If Kitchen Scene is done

            StreetScene sScene = new StreetScene(); //Create Street scene
            sScene.Street(); //Call Street Method of Street Scene

        }
    }

    public static void Reset()
    {
        intro = false;
        kitchen = false;
        street = false;
        mansion = false;
        breakf = false;
        sneakUse = false;
        fakeUse = false;
        timeUse = false;
        hideUse = false;

        p.invReset();

        IntroScene iScene = new IntroScene();
        iScene.Intro();
    }

    public static void End()
    {
        Console.WriteLine("Thanks for playing!");
    }

}