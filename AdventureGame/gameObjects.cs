using System;

public class GameObject
{

    /*
    Contains all of the text for progression of the story as well as varied responses based on whether or not Picky has knowledge, is successful, or has eaten breakfast.
    */

    public string sneakSuccess = "\r\n You did it! You managed to sneak by undetected!";

    public string sneakFail = "\r\n Oh no! You tripped and fell. In your surprise, you yelped! Anyone nearby probably heard that.";

    public string fakeSuccess = "\r\n Awesome! You high five Fakey Pocket as it putters around to confuse the authorities.";

    public string fakeFail = "\r\n Darn! The latches on Fakey Pocket malfunctioned and only the mechanical arms have deployed and are flailing around on the ground.";

    public string timeSuccess = "\r\n Well that's cool. Time Whorl hits the target and emits an ethereal light. Anything in the light is slowed down. You can take your time now.";

    public string timeFail = "\r\n Gah! Time Whorl short circuited and didn't work!";

    public string hideSuccess = "\r\n Quiet as a mouse, you hide and remain undetected.";

    public string hideFail = "\r\n Oh no! There was something sharp in the hiding spot and you made a sound!";

    public string gameOver = "\r\n Well this stinks. You got caught! Maybe you should rethink your plan before you TRY AGAIN.";

    public string win = "\r\n Fantastic! You managed to steal the Pipe Dream Citrine! You've completed your first step into becoming the ultimate thief. Like Cut Lass. Man... She was so cool. Now it's time be cool like her!";

    public string introText = "\r\n Your name is Picky Pocket, a 13-year old thief who was orphaned and has grown-up in Lowborn Town with the Kind Old Lady raising you to become the little pickpocket you are. \r\n" + "You are sitting on your bed in the small loft of the Kind Old Lady's House. \r\n" + "There is a NEWSPAPER ARTICLE dated March 14th 17XX. \r\n" + "There is also a small STACK OF BOOKS resting on a shelf to the right. \r\n" + "You hear the KIND OLD LADY calling your name.";

    public string newsText = "\r\n The clipping is old and yellow. The headline reads 'NOTORIOUS ROGUE VANISHES'. \r\n" + "The image shows the wanted poster created by the Babylon Corporation of the illustrious Cut Lass, a pirate turned thief that had plagued the Babylon Corporation for years. \r\n" + "She was so cool!!";

    public string bookText = "\r\n On top of the stack is a leather bound notebook, work and tattered.\r\n" + "It was given to you by the Kind Old Lady. \r\n" + "It's where you write down your inner most aspirations and all of your accomplishments, like the time you managed to steal a whole jar of candy from Tasty's Treats over in the Garden Variety Center Plaza.\r\n" + "You should really do that again; It was fun AND delicious";

    public string chestText = "\r\n You shout back that you'll be right there.\r\n" + "At the foot of your bed is a chest. In it are your boots, your backpack, a SMALL METAL BOX, and a glowing ALARM CLOCK. You should TAKE EVERYTHING.";

    public string boxText = "\r\n You carefully pick up the small metal box and make sure the latches are all in place. \r\n" + "This is Fakey Pocket, a compact automaton built for you by the Old Tinkerer. \r\n" + "It looksl ike you, if you were made of metal and soulless. You use it to confuse the authorities so that you can get away if you're in trouble.\r\n" + "And it knows how to get back home so you don't have to worry about losing it! \r\n" + "So helpful that Fakey Pocket.";

    public string clockText = "\r\n You are mesmerized by the cool, blue glow of the face of the clock. It was made by the Old Tinkerer.\r\n" + "When you throw it at or near the authorities it slows down time around them to give you extra time to get away. \r\n" + "You thought only Babylon Corporation scientists could get their hands on such tech. \r\n" + "Guess the Old Tinkerer has more connections than you thought. \r\n" + "Oh, it's called the Time Whorl.";

    public string kitchenText = "\r\n The Kind Old Lady is sitting at the small dinner table by the window that faces the dirty, muddy sheet outside. \r\n" + "She doesn't look like most of the people in Lowborn Town. Well, her clothes do, but she doesn't. \r\n" + "She looks like she used to be a lady from some place. But she's way kinder than those people. \r\n" + "That's why she is the Kind Old Lady. \r\n" + "There is some food on the table. You should EAT BREAKFAST. \r\n" + "'Are you ready for your first Big Score?' The Kind Old Lady asks, waiting for your ANSWER";

    public string breakText = "\r\n It's some oatmeal.... WITH SUGAR AND CINNAMON?!?!?!? \r\n" + "You look up at the Kind Old Lady who just nods and smiles. You wonder how she got it. \r\n" + "Usually you have to scope out the Market in the Garden Variety Center to get some. \r\n" + "You take the spoon and start shoveling the oatmeal into your gob.";

    public string ansText1 = "\r\n You're very happy with your yummy breakfast and thank the Kind Old Lady. Now you can layout your plan for the Kind Old Lady. \r\n" + "Lowborn Town is an awful place, but that did not stop the Babylon Corporation from taking a ton of land to build their giant factories. \r\n" + "They needed someone to run it too, someone who would be too wrapped up in themselves to care about how bad Lowborn Town was. \r\n" + "That's whow they found Talor Batsgy, a self-made millionare who was not afraid to show off her wealth to the poor inhabitatns of Lowborn Town. \r\n" + "In her fancy Mansion, built to cover up the lovely ocean view from the people so she could have it all to herfself, is the largest gem in the world, the Pipe Dream Citrine. \r\n" + "It's supposed to have some curse on it, but this is the first thing Cut Lass ever stole from the Babylon Corporation, so you have to steal it too. \r\n" + "There are sure to be Babylon Un-Thieving Troops watching it, so you are goign to have to be very careful! \r\n \n" + "You hear the church bell start to ring. It's time to go! You hop out of your seat and run to hug the Kind Old Lady, telling her you should be home before dinner. She laughs and wishes you luck. You thank her and scamper out of the small shack you both call home.";

    public string ansText2 = "\r\n You nod and layout your plan for the Kind Old Lady. \r\n" + "Lowborn Town is an awful place, but that did not stop the Babylon Corporation from taking a ton of land to build their giant factories. \r\n" + "They needed someone to run it too, someone who would be too wrapped up in themselves to care about how bad Lowborn Town was. \r\n" + "That's whow they found Talor Batsgy, a self-made millionare who was not afraid to show off her wealth to the poor inhabitatns of Lowborn Town. \r\n" + "In her fancy Mansion, built to cover up the lovely ocean view from the people so she could have it all to herfself, is the largest gem in the world, the Pipe Dream Citrine. \r\n" + "It's supposed to have some curse on it, but this is the first thing Cut Lass ever stole from the Babylon Corporation, so you have to steal it too. \r\n" + "There are sure to be Babylon Un-Thieving Troops watching it, so you are goign to have to be very careful! \r\n \n" + "You hear the church bell start to ring. It's time to go! You hop out of your seat and run to hug the Kind Old Lady, telling her you should be home before dinner. She laughs and wishes you luck. You thank her and scamper out of the small shack you both call home.";

    public string streetText = "\r\n After trekking through all of Lowborn Town (that place is huge when you're under 4 feet tall), you now stand across the street from Taylor Batsgy's extravagant mansion. There is a large IRON GATE with two of Babylon's Un-Thieving Troops standing guard. A few days ago you noticed that a little further down the street there is an OPENING in the brick fence covered up now by a gaudy poster of Miss Batsgy announcing some other party she's hosting.";

    public string gateText = "\r\n The guards are huge. They are also very dumb. \r\n" + "When you were sneaking around trying to gather as much information as you could before today's big heist, you saw one questioning the other what his business was with Miss Batsgy after coming back from what you think was a bathroom break. \r\n" + "Apparently, he had forgotten who the other troop was. You might be able to CONFUSE them. Then again maybe you should SNEAK past them.";

    public string confuseText = "\r\n Confident, you come out of the bush you were hiding in and walk up to the guards. They both saw you but for some reason they are squinting at you. \r\n" + "'Re you some kind o' tiny human?' The guard on the left asks you. \r\n." + "You give him a weird look. 'Hello tiny human! Are you from another place where all humans are tiny?' \r\n" + "You're confused now. \r\n" + "Shaking your head, you decide to go along with it and tell them you are from the island of Tye Knee located in the Left Most Ocean and are here to meet with Taylor Batsgy. \r\n" + "Both guards seemed to have stopped functioning. They're just kind of looking at you and you swear the one on the right might be drooling. \r\n" + "They snap out of it and seem to be ready to open the door when the guard on the right shakes his head. \r\n" + "'Wait, are you sure? Miss Batsgy said she wasn't expecting anyone because she's preparing for that BIG PARTY.' he says looking at you with suspicion. \r\n" + "'I fink yer right! Ain't 'eard o' no guests today!' The guard on the left says. \r\n" + "Maybe you should use FAKEY POCKET to distract them.";

    public string partyText = "\r\n This is almost too easy. You cross your arms over your chest and sigh in an exaggerated manner. \r\n" + "You say that it's unbelievable that Taylor, who is your dearest friend, would higher such unhelpful guards \r\n." + "When you get inside you're absolutely going to tell her that she should fire the two guards who were so rude and mean to a royal from the island of Tye Knee. \r\n" + "The two guards suddenly seem to panic and immediately open the gates for you. As you walk past them, they seem to be begging you to not say anything to Miss Batsgy. You tell them you will think about it and proceed to the Mansion.";

}