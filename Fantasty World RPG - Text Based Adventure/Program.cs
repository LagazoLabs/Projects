using System;
using System.Data.SqlTypes;
using System.Threading.Tasks;

// variables to control the ending
double true_ending = 0;
double bad_ending = 0;

// stat variables
int strength = 0;
int defense = 0;
int wisdom = 0;
int stamina = 0;
int skill = 0;

// decision variables
string stat_option;
string job_option;
bool job_option_valid = false;
string selected_story_id;
string selected_story_name = "";

//Console.WriteLine("Fantasty World RPG : Text Based Adventure");
Console.WriteLine("""                   
███████╗ █████╗ ███╗   ██╗████████╗ █████╗ ███████╗██╗   ██╗
██╔════╝██╔══██╗████╗  ██║╚══██╔══╝██╔══██╗██╔════╝╚██╗ ██╔╝
█████╗  ███████║██╔██╗ ██║   ██║   ███████║███████╗ ╚████╔╝ 
██╔══╝  ██╔══██║██║╚██╗██║   ██║   ██╔══██║╚════██║  ╚██╔╝  
██║     ██║  ██║██║ ╚████║   ██║   ██║  ██║███████║   ██║   
╚═╝     ╚═╝  ╚═╝╚═╝  ╚═══╝   ╚═╝   ╚═╝  ╚═╝╚══════╝   ╚═╝   
      ██╗    ██╗ ██████╗ ██████╗ ██╗     ██████╗ 
      ██║    ██║██╔═══██╗██╔══██╗██║     ██╔══██╗
      ██║ █╗ ██║██║   ██║██████╔╝██║     ██║  ██║
      ██║███╗██║██║   ██║██╔══██╗██║     ██║  ██║
      ╚███╔███╔╝╚██████╔╝██║  ██║███████╗██████╔╝
       ╚══╝╚══╝  ╚═════╝ ╚═╝  ╚═╝╚══════╝╚═════╝ 
               ██████╗ ██████╗  ██████╗ 
               ██╔══██╗██╔══██╗██╔════╝ 
               ██████╔╝██████╔╝██║  ███╗
               ██╔══██╗██╔═══╝ ██║   ██║
               ██║  ██║██║     ╚██████╔╝
               ╚═╝  ╚═╝╚═╝      ╚═════╝
                              
                                  
           ▀█▀ █▀▀ ▀▄▀ ▀█▀   █▄▄ ▄▀█ █▀ █▀▀ █▀▄
           ░█░ ██▄ █░█ ░█░   █▄█ █▀█ ▄█ ██▄ █▄▀
                                               
          ▄▀█ █▀▄ █░█ █▀▀ █▄░█ ▀█▀ █░█ █▀█ █▀▀
          █▀█ █▄▀ ▀▄▀ ██▄ █░▀█ ░█░ █▄█ █▀▄ ██▄
""");
Console.WriteLine("");

Console.WriteLine("Player Name:");
string player_name = Console.ReadLine();
Console.WriteLine("");

// Player Stats Determiner
Console.WriteLine("Lets get to know you...");
Console.WriteLine("");

Console.WriteLine("Would you consider yourself athletic? (Y/N)");
stat_option = Console.ReadLine();
Console.WriteLine("");
if (stat_option == "Y" || stat_option == "y")
{
    strength += 2;
    stamina += 1;
    skill += 2;
}
else
{
    strength += 1;
    skill += 1;
}

Console.WriteLine("Do you often find yourself giving advice to others? (Y/N)");
stat_option = Console.ReadLine();
Console.WriteLine("");
if (stat_option == "Y" || stat_option == "y")
{
    wisdom += 2;
    defense += 2;
    skill += 1;
}
else
{
    wisdom += 1;
    defense += 1;
}

Console.WriteLine("Can you keep going even when things get tough or exhausting? (Y/N)");
stat_option = Console.ReadLine();
Console.WriteLine("");
if (stat_option == "Y" || stat_option == "y")
{
    strength += 2;
    defense += 1;
    stamina += 2;
}
else
{
    strength += 1;
    stamina += 1;
}

Console.WriteLine("Are you good at handling criticism and standing up for yourself? (Y/N)");
stat_option = Console.ReadLine();
Console.WriteLine("");
if (stat_option == "Y" || stat_option == "y")
{
    strength += 2;
    defense += 2;
    wisdom += 1;
}
else
{
    strength += 1;
    defense += 1;
}

Console.WriteLine("Do you pick up new skills or hobbies quickly? (Y/N)");
stat_option = Console.ReadLine();
Console.WriteLine("");
if (stat_option == "Y" || stat_option == "y")
{
    skill += 2;
    strength += 2;
    wisdom += 1;
}
else
{
    skill += 1;
    strength += 1;
}

Console.WriteLine("Do you enjoy pushing your limits? (Y/N)");
stat_option = Console.ReadLine();
Console.WriteLine("");
if (stat_option == "Y" || stat_option == "y")
{
    strength += 2;
    skill += 2;
    stamina += 1;
    wisdom -= 1;
}
else
{
    strength += 1;
    skill += 1;
    wisdom += 1;
}

Console.WriteLine("Are you someone who seeks knowledge and values learning? (Y/N)");
stat_option = Console.ReadLine();
Console.WriteLine("");
if (stat_option == "Y" || stat_option == "y")
{
    wisdom += 2;
    skill += 2;
    defense += 1;
}
else
{
    wisdom += 1;
    skill += 1;
}

Console.WriteLine("Can you stay focused and productive over long periods? (Y/N)");
stat_option = Console.ReadLine();
Console.WriteLine("");
if (stat_option == "Y" || stat_option == "y")
{
    stamina += 2;
    skill += 2;
    wisdom += 1;
    defense += 1;
}
else
{
    stamina += 1;
    skill += 1;
}

Console.WriteLine("Do you tend to stay calm and collected under pressure? (Y/N)");
stat_option = Console.ReadLine();
Console.WriteLine("");
if (stat_option == "Y" || stat_option == "y")
{
    defense += 2;
    stamina += 2;
    wisdom += 1;
}
else
{
    defense += 1;
    stamina += 1;
}

Console.WriteLine("Are you known for being quick to solve problems or think on your feet? (Y/N)");
stat_option = Console.ReadLine();
Console.WriteLine("");
if (stat_option == "Y" || stat_option == "y")
{
    skill += 2;
    wisdom += 2;
    strength += 1;
}
else
{
    skill += 1;
    wisdom += 1;
}

Console.WriteLine("Your Stats Are... : ");
Console.WriteLine("Strength: " + strength);
Console.WriteLine("Defense: " + defense);
Console.WriteLine("Wisdom: " + wisdom);
Console.WriteLine("Stamina: " + stamina);
Console.WriteLine("Skill: " + skill);
Console.WriteLine("");

Console.WriteLine("Hello " + player_name + "! You are an aspiring hero, you want to become known throughout the lands" +
    "who protects and serves! You visit the job/request board at the town square and find some that interest you.");

while (job_option_valid == false)
{
    Console.WriteLine("[1] Retrieve The Lost Artifact");
    Console.WriteLine("[2] Defeat The Local Bandits");
    Console.WriteLine("[3] Harvest Divine Fruit From Forest");
    Console.WriteLine("[4] Help The Knights Train");
    Console.WriteLine("");

    Console.WriteLine("[#]: ");
    job_option = Console.ReadLine();
    Console.WriteLine("");


    if (job_option == "1" || job_option == "2" || job_option == "3" || job_option == "4")
    {
        job_option_valid = true;

        if (job_option == "1")
        {
            selected_story_id = "1";
            selected_story_name = "Retrieve The Lost Artifact";
        }
        else if (job_option == "2")
        {
            selected_story_id = "2";
            selected_story_name = "Defeat The Local Bandits";
        }
        else if (job_option == "3")
        {
            selected_story_id = "3";
            selected_story_name = "Harvest Divine Fruit From Forest";
        }
        else if (job_option == "4")
        {
            selected_story_id = "4";
            selected_story_name = "Help The Knights Train";
        }
        Console.WriteLine($"You have choosen '{selected_story_name}'. Goodluck {player_name}!");
        Console.WriteLine("You told the clerk who manages the job board that you have accepted the job.");
        Console.WriteLine("Now you wait...");
        Console.WriteLine("");
    }
    else
    {
        Console.WriteLine("Invalid Job: Input number between [1-4].");
        Console.WriteLine("");
    }

    if (job_option == "1")
    {
        Console.WriteLine("...");
        Console.WriteLine("");
        retrieve_the_lost_artifact(true_ending, bad_ending,
            player_name, strength, defense, wisdom, stamina, skill);
        Console.WriteLine("""
                        
            ░▒▓████████▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓████████▓▒░      ░▒▓████████▓▒░▒▓███████▓▒░░▒▓███████▓▒░  
               ░▒▓█▓▒░   ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░             ░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░ 
               ░▒▓█▓▒░   ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░             ░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░ 
               ░▒▓█▓▒░   ░▒▓████████▓▒░▒▓██████▓▒░        ░▒▓██████▓▒░ ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░ 
               ░▒▓█▓▒░   ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░             ░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░ 
               ░▒▓█▓▒░   ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░             ░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░ 
               ░▒▓█▓▒░   ░▒▓█▓▒░░▒▓█▓▒░▒▓████████▓▒░      ░▒▓████████▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓███████▓▒░  
            """);
    }
    else if (job_option == "2" || job_option == "3" || job_option == "4")
    {
        Console.WriteLine("This story is not completed yet...");
    }
}

void retrieve_the_lost_artifact(double true_ending, double bad_ending,
    string player_name, int strength, int defense, int wisdom, int stamina, int skill)
{
    string dialouge_transition;
    bool story_choice_valid = false;
    string story_choice;

    Console.WriteLine("The next day... you hear a knock on your door...");
    Console.WriteLine("You open the door to see who's outside.");

    Console.WriteLine($"{player_name}: Hello?");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine($"Historian: Hello you must be {player_name}!");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine($"{player_name}: Thats correct!");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine($"Historian: I hear you're going to help me with what I lost.");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine($"{player_name}: Yes! So what did you lose? I saw it was an 'artifact'?");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine($"Historian: Yes, it was an ancient artifact of incredible power.");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine($"Historian: Not only is it my lifes work... but...");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine($"Historian: If it got into the wrong hands...");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine($"{player_name}: I understand. So where did you last lose it?");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine($"Historian: I lost them at a hiking trip at the Mountains of Doom.");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine($"{player_name}: Mountains of Doom? Seriously? Who even names these things?");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine($"Historian: They are named the Mountains of Doom because many perish trying to climb them. They are also filled with monsters.");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine($"{player_name}: Wait... why were you even there???");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine($"Historian: The artifact came from the Mountains of Doom, I was looking for leads and information.");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine($"{player_name}: Alright...");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine($"Historian: Anyway here a map of the trail of the trail I took. If you find the artifact, please bring it back!");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine($"Historian: Anyway here a map of the trail of the trail I took. If you find the artifact, please bring it back!");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine($"{player_name}: Thanks!");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine($"Historian: Goodluck, and please. Be Careful!");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine("");

    Console.WriteLine("You are now close to the mountains of doom... the hike up ahead looks quite dangerous.");
    Console.WriteLine("However something is blocking your path, a huge pile of rocks caused from a landslide...");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine("How do you proceed?");
    while (story_choice_valid == false)
    {
        Console.WriteLine("[1] Break The Rocks");
        Console.WriteLine("[2] Climb Over The Rocks");
        Console.WriteLine("[#]: ");
        story_choice = Console.ReadLine();
        Console.WriteLine("");
        if (story_choice == "2")
        {
            if (skill >= 10)
            {
                Console.WriteLine("You climbed over the rocks effortlessly.");
                skill += 2;
                true_ending += 1;
            }
            else if (skill <= 9 && skill >= 6)
            {
                Console.WriteLine("You climbed over the rocks!.");
                skill += 1;
                true_ending += 0.5;
                bad_ending += 0.5;
            }
            else
            {
                Console.WriteLine("You climbed over the rocks... but it was a struggle.");
                skill += 1;
                bad_ending += 1;
            }
            story_choice_valid = true;
        }
        else if (story_choice == "1")
        {
            if (strength >= 10)
            {
                Console.WriteLine("You destroyed the rocks effortlessly.");
                strength += 2;
                true_ending += 1;
            }
            else if (strength <= 9 && strength >= 6)
            {
                Console.WriteLine("You destroyed the rocks!.");
                strength += 1;
                true_ending += 0.5;
                bad_ending += 0.5;
            }
            else
            {
                Console.WriteLine("You destroyed the rocks... but it was a struggle.");
                strength += 1;
                bad_ending += 1;
            }
            story_choice_valid = true;
        }
    }

    Console.WriteLine("");
    Console.WriteLine("Onwards!");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine($"...");
    dialouge_transition = Console.ReadLine();

    Console.WriteLine("You are now climbing up the mountain. The trail keeps getting steeper...");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine("You can't continue on like this...");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine("How do you proceed?");
    story_choice_valid = false;
    while (story_choice_valid == false)
    {
        Console.WriteLine("[1] Find Something To Help");
        Console.WriteLine("[2] Look For Another Way");
        Console.WriteLine("[3] Power Through It");
        Console.WriteLine("[#]: ");
        story_choice = Console.ReadLine();
        Console.WriteLine("");
        if (story_choice == "1")
        {
            if (wisdom >= 10)
            {
                Console.WriteLine("You found a rock climbing cane... it must of been 'left behind' ...s");
                dialouge_transition = Console.ReadLine();
                wisdom += 2;
                true_ending += 1;
            }
            else if (wisdom <= 9 && wisdom >= 6)
            {
                Console.WriteLine("You found a sturdy branch to help you climb.");
                dialouge_transition = Console.ReadLine();
                wisdom += 1;
                true_ending += 0.5;
                bad_ending += 0.5;
            }
            else
            {
                Console.WriteLine("You found a decent branch to help you climb.");
                dialouge_transition = Console.ReadLine();
                wisdom += 1;
                bad_ending += 1;
            }
            story_choice_valid = true;
        }
        else if (story_choice == "2")
        {
            if (skill >= 10)
            {
                Console.WriteLine("You found a significantly less steeper path, you decide to take it.");
                dialouge_transition = Console.ReadLine();
                skill += 2;
                true_ending += 1;
            }
            else if (skill <= 9 && skill >= 6)
            {
                Console.WriteLine("You found a less steeper path, you decide to take it.");
                dialouge_transition = Console.ReadLine();
                skill += 1;
                true_ending += 0.5;
                bad_ending += 0.5;
            }
            else
            {
                Console.WriteLine("You could not find any paths, and decide to continue on the current path.");
                dialouge_transition = Console.ReadLine();
                skill += 1;
                bad_ending += 1;
            }
            story_choice_valid = true;
        }
        else if (story_choice == "3")
        {
            if (strength >= 10)
            {
                Console.WriteLine("Using your sheer strength, you manage to power through the egrecious hike.");
                dialouge_transition = Console.ReadLine();
                strength += 2;
                true_ending += 1;
            }
            else if (strength <= 9 && strength >= 6)
            {
                Console.WriteLine("You try to power through but still struggle.");
                dialouge_transition = Console.ReadLine();
                strength += 1;
                true_ending += 0.5;
                bad_ending += 0.5;
            }
            else
            {
                Console.WriteLine("You try to power through but sometimes feel the pain catching up.");
                dialouge_transition = Console.ReadLine();
                strength += 1;
                bad_ending += 1;
            }
            story_choice_valid = true;
        }
    }

    Console.WriteLine("");
    Console.WriteLine("...");
    dialouge_transition = Console.ReadLine();

    Console.WriteLine("You're getting close to the spot where the Historian said he lost the artifact...");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine("You're...");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine("Almost...");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine("...");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine("...");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine("...");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine("There...?!");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine("Oh wow there is a big monster blocking your path!");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine("How do you proceed?");
    dialouge_transition = Console.ReadLine();

    story_choice_valid = false;
    while (story_choice_valid == false)
    {
        Console.WriteLine("[1] Fight The Monster!");
        Console.WriteLine("[2] Evade The Monster!");
        Console.WriteLine("[3] Reason With The Monster");
        Console.WriteLine("[#]: ");
        story_choice = Console.ReadLine();

        Console.WriteLine("");
        if (story_choice == "1")
        {
            Console.WriteLine("...");
            dialouge_transition = Console.ReadLine();
            Console.WriteLine("...");
            dialouge_transition = Console.ReadLine();
            Console.WriteLine("...");
            dialouge_transition = Console.ReadLine();
            if (strength >= 15)
            {
                Console.WriteLine("The monster has been slain! Wow, you really did it!");
                dialouge_transition = Console.ReadLine();
                strength += 2;
                true_ending += 1;
            }
            else if (strength <= 14 && strength >= 7)
            {
                Console.WriteLine("You did! It was a hard fought battle but you won!");
                dialouge_transition = Console.ReadLine();
                strength += 1;
                true_ending += 0.5;
                bad_ending += 0.5;
            }
            else
            {
                Console.WriteLine("You almost died.. wow, that really was not a good idea.");
                dialouge_transition = Console.ReadLine();
                strength += 1;
                bad_ending += 1;
            }
            story_choice_valid = true;
        }
        else if (story_choice == "2")
        {
            Console.WriteLine("...");
            dialouge_transition = Console.ReadLine();
            Console.WriteLine("...");
            dialouge_transition = Console.ReadLine();
            Console.WriteLine("...");
            dialouge_transition = Console.ReadLine();
            if (skill >= 15)
            {
                Console.WriteLine("You successfully avoided the monster it was real confused.");
                dialouge_transition = Console.ReadLine();
                strength += 2;
                true_ending += 1;
            }
            else if (skill <= 14 && skill >= 7)
            {
                Console.WriteLine("You avoided the monster, but you almost alerted it!");
                dialouge_transition = Console.ReadLine();
                strength += 1;
                true_ending += 0.5;
                bad_ending += 0.5;
            }
            else
            {
                Console.WriteLine("You startled the monster, but you barley got away... ouch....");
                dialouge_transition = Console.ReadLine();
                strength += 1;
                bad_ending += 1;
            }
            story_choice_valid = true;
        }
        else if (story_choice == "3")
        {
            Console.WriteLine("...");
            dialouge_transition = Console.ReadLine();
            Console.WriteLine("...");
            dialouge_transition = Console.ReadLine();
            Console.WriteLine("...");
            dialouge_transition = Console.ReadLine();
            if (wisdom >= 20)
            {
                Console.WriteLine("The monster has been... pacified?");
                dialouge_transition = Console.ReadLine();
                Console.WriteLine("Huh...");
                dialouge_transition = Console.ReadLine();
                Console.WriteLine("Wow!");
                dialouge_transition = Console.ReadLine();
                Console.WriteLine("Good Work!");
                dialouge_transition = Console.ReadLine();
                wisdom += 2;
                true_ending += 1;
            }
            else
            {
                Console.WriteLine("You almost died.. wow, that really was not a good idea.");
                dialouge_transition = Console.ReadLine();
                Console.WriteLine("You barley made it out of that.");
                dialouge_transition = Console.ReadLine();

                wisdom += 1;
                bad_ending += 1;
            }
            story_choice_valid = true;
        }
    }
    Console.WriteLine("");

    Console.WriteLine("...");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine("...");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine("...");
    dialouge_transition = Console.ReadLine();

    Console.WriteLine("You just realized something...");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine($"{player_name}: Am I even going to get paid for this?!");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine($"{player_name}: I know I volunteered, but I'm risking my neck out here!");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine($"{player_name}: Ugh!");
    dialouge_transition = Console.ReadLine();

    Console.WriteLine("...");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine("...");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine("...");
    dialouge_transition = Console.ReadLine();

    Console.WriteLine($"{player_name}: I'm starving...");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine($"{player_name}: I need some food...");
    dialouge_transition = Console.ReadLine();

    Console.WriteLine("You notice some fruit from a bush...");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine("You also notice some animals that would be easy to hunt...");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine("You ALSO notice a nearby camp... looks... abandonded?");
    dialouge_transition = Console.ReadLine();

    Console.WriteLine("How do you proceed?");
    dialouge_transition = Console.ReadLine();

    story_choice_valid = false;
    while (story_choice_valid == false)
    {
        Console.WriteLine("[1] Harvest The Fruit!");
        Console.WriteLine("[2] Kill The Animals!");
        Console.WriteLine("[3] Loot The Camp");
        Console.WriteLine("[#]: ");
        story_choice = Console.ReadLine();

        Console.WriteLine("");
        if (story_choice == "1")
        {
            Console.WriteLine("...");
            dialouge_transition = Console.ReadLine();
            Console.WriteLine("...");
            dialouge_transition = Console.ReadLine();
            Console.WriteLine("...");
            dialouge_transition = Console.ReadLine();
            if (skill >= 15)
            {
                Console.WriteLine("You harvested the fruit without any effort.");
                dialouge_transition = Console.ReadLine();
                skill += 2;
                true_ending += 1;
            }
            else if (skill <= 14 && skill >= 7)
            {
                Console.WriteLine("You harvest the fruit, took a bit though...");
                dialouge_transition = Console.ReadLine();
                skill += 1;
                true_ending += 0.5;
                bad_ending += 0.5;
            }
            else
            {
                Console.WriteLine("Took you longer than needed to get the fruit... but at least you have food.");
                dialouge_transition = Console.ReadLine();
                skill += 1;
                bad_ending += 0.5;
            }
            story_choice_valid = true;
        }
        else if (story_choice == "2")
        {
            Console.WriteLine("...");
            dialouge_transition = Console.ReadLine();
            Console.WriteLine("...");
            dialouge_transition = Console.ReadLine();
            Console.WriteLine("...");
            dialouge_transition = Console.ReadLine();
            if (skill >= 15)
            {
                Console.WriteLine("You hunted the animals and spent a bit also cooking them...");
                dialouge_transition = Console.ReadLine();
                strength += 2;
                true_ending += 1;
            }
            else if (skill <= 14 && skill >= 7)
            {
                Console.WriteLine("You hunted the animals, but some got away.");
                dialouge_transition = Console.ReadLine();
                strength += 1;
                true_ending += 0.5;
                bad_ending += 0.5;
            }
            else
            {
                Console.WriteLine("You hunted the animals, but you only got an arm... At least it's food...");
                dialouge_transition = Console.ReadLine();
                strength += 1;
                bad_ending += 1;
            }
            story_choice_valid = true;
        }
        else if (story_choice == "3")
        {
            Console.WriteLine("...");
            dialouge_transition = Console.ReadLine();
            Console.WriteLine("...");
            dialouge_transition = Console.ReadLine();
            Console.WriteLine("...");
            dialouge_transition = Console.ReadLine();
            if (defense >= 15)
            {
                Console.WriteLine("You decided to loot the camp... looks nice no has been here...");
                dialouge_transition = Console.ReadLine();
                defense += 2;
                bad_ending += 1;
            }
            else if (defense <= 14 && defense >= 7)
            {
                Console.WriteLine("You looted the camp... but it does look like someone was here... ");
                dialouge_transition = Console.ReadLine();
                Console.WriteLine("Too late now...");
                dialouge_transition = Console.ReadLine();
                defense += 1;
                bad_ending += 1;
            }
            else
            {
                Console.WriteLine("You looted the camp... looks like someone was just here... oh boy...");
                dialouge_transition = Console.ReadLine();
                Console.WriteLine("but you're starving...");
                dialouge_transition = Console.ReadLine();
                Console.WriteLine("it's too late now...");
                dialouge_transition = Console.ReadLine();
                defense += 1;
                bad_ending += 3;
            }
            story_choice_valid = true;
        }
    }

    Console.WriteLine("");

    Console.WriteLine("Well now you're replenished and ready to find the artifact at long last!");

    Console.WriteLine("...");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine("...");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine("...");
    dialouge_transition = Console.ReadLine();

    dialouge_transition = Console.ReadLine();
    Console.WriteLine("You're finally around the place where the Historian lost his artifact!");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine("How do you proceed?");
    dialouge_transition = Console.ReadLine();

    story_choice_valid = false;
    while (story_choice_valid == false)
    {
        Console.WriteLine("[1] Search The Caves");
        Console.WriteLine("[2] Search From The Trees!");
        Console.WriteLine("[#]: ");
        story_choice = Console.ReadLine();

        Console.WriteLine("");
        if (story_choice == "1")
        {
            Console.WriteLine("...");
            dialouge_transition = Console.ReadLine();
            Console.WriteLine("...");
            dialouge_transition = Console.ReadLine();
            Console.WriteLine("...");
            dialouge_transition = Console.ReadLine();
            if (skill >= 15 && wisdom >= 10)
            {
                Console.WriteLine("You searched the caves and you have a good idea now on where to find the artifact.");
                dialouge_transition = Console.ReadLine();
                skill += 2;
                true_ending += 1;
            }
            else if ((skill <= 14 && skill >= 7) && wisdom >= 10)
            {
                Console.WriteLine("You searched the caves and only have little clues on where to look...");
                dialouge_transition = Console.ReadLine();
                skill += 1;
                true_ending += 0.5;
                bad_ending += 0.5;
            }
            else
            {
                Console.WriteLine("You searched the caves and found no clues or leads...");
                dialouge_transition = Console.ReadLine();
                skill += 1;
                bad_ending += 1;
            }
            story_choice_valid = true;
        }
        else if (story_choice == "2")
        {
            Console.WriteLine("...");
            dialouge_transition = Console.ReadLine();
            Console.WriteLine("...");
            dialouge_transition = Console.ReadLine();
            Console.WriteLine("...");
            dialouge_transition = Console.ReadLine();
            if (skill >= 15 && wisdom >= 10)
            {
                Console.WriteLine("You climbed a tree to look for places to search in, you found some good locations.");
                dialouge_transition = Console.ReadLine();
                strength += 2;
                true_ending += 1;
            }
            else if ((skill <= 14 && skill >= 7) && wisdom >= 10)
            {
                Console.WriteLine("You climbed a tree to look for places to search in, you found little places to go to.");
                dialouge_transition = Console.ReadLine();
                strength += 1;
                true_ending += 0.5;
                bad_ending += 0.5;
            }
            else
            {
                Console.WriteLine("You climbed a tree to look for places to search in, but found nothing.");
                dialouge_transition = Console.ReadLine();
                strength += 1;
                bad_ending += 1;
                dialouge_transition = Console.ReadLine();
                Console.WriteLine("...");
                dialouge_transition = Console.ReadLine();
                Console.WriteLine("...");
                dialouge_transition = Console.ReadLine();
            }
            story_choice_valid = true;
        }
    }

    Console.WriteLine("...");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine("...");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine("...");
    dialouge_transition = Console.ReadLine();

    Console.WriteLine("...");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine("...");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine("...");
    dialouge_transition = Console.ReadLine();

    Console.WriteLine("...");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine("...");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine("...");
    dialouge_transition = Console.ReadLine();

    Console.WriteLine("You-");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine("You....");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine("You found it!");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine("Haha yes!");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine("Wow it's quite shiny...");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine("... and pretty...");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine("Now...");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine("");

    story_choice_valid = false;
    while (story_choice_valid == false)
    {
        Console.WriteLine("[1] Time to take it back to the Historian! A job well completed!");
        Console.WriteLine("[2] Ugh I almost died for this thing, I'm just gonna pocket it for money...");
        Console.WriteLine("[#]: ");
        story_choice = Console.ReadLine();

        Console.WriteLine("");
        if (story_choice == "1")
        {

            Console.WriteLine("...");
            dialouge_transition = Console.ReadLine();
            Console.WriteLine("...");
            dialouge_transition = Console.ReadLine();
            Console.WriteLine("...");
            dialouge_transition = Console.ReadLine();

            Console.WriteLine($"{player_name}: Yeah this will help build up my reputation as a hero!");
            dialouge_transition = Console.ReadLine();
            Console.WriteLine($"{player_name}: I gained experience and a lot of new insight...");
            dialouge_transition = Console.ReadLine();
            Console.WriteLine($"{player_name}: Let's go home....");
            dialouge_transition = Console.ReadLine();

            true_ending += 1;
            story_choice_valid = true;
        }
        else if (story_choice == "2")
        {
            Console.WriteLine("...");
            dialouge_transition = Console.ReadLine();
            Console.WriteLine("...");
            dialouge_transition = Console.ReadLine();
            Console.WriteLine("...");
            dialouge_transition = Console.ReadLine();
            Console.WriteLine($"{player_name}: yeah...");
            dialouge_transition = Console.ReadLine();
            Console.WriteLine($"{player_name}: he won't know about this...");
            dialouge_transition = Console.ReadLine();
            Console.WriteLine($"{player_name}: he'll just assume it's lost for good if we tell him...");
            dialouge_transition = Console.ReadLine();
            Console.WriteLine("...");
            dialouge_transition = Console.ReadLine();
            Console.WriteLine("...");
            dialouge_transition = Console.ReadLine();
            Console.WriteLine("...");
            bad_ending += 5;
            story_choice_valid = true;
        }
    }

    Console.WriteLine("...");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine("...");
    dialouge_transition = Console.ReadLine();
    Console.WriteLine("...");

    if (true_ending > bad_ending)
    {
        Console.WriteLine("You return safely...");
        dialouge_transition = Console.ReadLine();
        Console.WriteLine("You return the lost artifact to the Historian.");
        dialouge_transition = Console.ReadLine();

        Console.WriteLine($"Historian: Thank you!");
        dialouge_transition = Console.ReadLine();
        Console.WriteLine($"Historian: Thank you!");
        dialouge_transition = Console.ReadLine();
        Console.WriteLine($"Historian: Thank you!");
        dialouge_transition = Console.ReadLine();
        Console.WriteLine($"Historian: Thank you!");
        dialouge_transition = Console.ReadLine();
        Console.WriteLine($"Historian: Thank you!");
        dialouge_transition = Console.ReadLine();
        Console.WriteLine($"{player_name}: You're welcome!");
        dialouge_transition = Console.ReadLine();
        Console.WriteLine($"Historian: You're a life saver, I can't thank you enough.");
        dialouge_transition = Console.ReadLine();
        Console.WriteLine($"Historian: Here is your payment!");
        dialouge_transition = Console.ReadLine();
        Console.WriteLine($"{player_name}: Woah!");
        dialouge_transition = Console.ReadLine();
        Console.WriteLine($"{player_name}: Are you sure I can have all of this?!");
        dialouge_transition = Console.ReadLine();
        Console.WriteLine($"Historian: It's the least I can do!");
        dialouge_transition = Console.ReadLine();
        Console.WriteLine($"{player_name}: Well Thanks!");
        dialouge_transition = Console.ReadLine();
        Console.WriteLine($"Historian: I'll even put a good word for you, you'll be offered more jobs!");
        dialouge_transition = Console.ReadLine();
        Console.WriteLine($"{player_name}: Wow!");
        dialouge_transition = Console.ReadLine();
        Console.WriteLine($"Historian: Well good luck! Thanks again!");
        dialouge_transition = Console.ReadLine();
        Console.WriteLine($"{player_name}: You're welcome!");
        dialouge_transition = Console.ReadLine();
        Console.WriteLine($"{player_name}: ...");
        dialouge_transition = Console.ReadLine();
        Console.WriteLine($"{player_name}: ...");
        dialouge_transition = Console.ReadLine();
        Console.WriteLine($"{player_name}: ...");
        dialouge_transition = Console.ReadLine();
        Console.WriteLine($"{player_name}: Well time to head and rest. I'm exahusted!");
        dialouge_transition = Console.ReadLine();

        Console.WriteLine("...");
        dialouge_transition = Console.ReadLine();
        Console.WriteLine("...");
        dialouge_transition = Console.ReadLine();
        Console.WriteLine("...");
        dialouge_transition = Console.ReadLine();

        Console.WriteLine("You got 'The Good Ending'");
        dialouge_transition = Console.ReadLine();
    }
    else if (bad_ending > true_ending)
    {
        Console.WriteLine("On your way down....");
        dialouge_transition = Console.ReadLine();

        Console.WriteLine("...");
        dialouge_transition = Console.ReadLine();
        Console.WriteLine("...");
        dialouge_transition = Console.ReadLine();
        Console.WriteLine("...");
        dialouge_transition = Console.ReadLine();

        Console.WriteLine("!!!");
        dialouge_transition = Console.ReadLine();
        Console.WriteLine("*clunk*");
        dialouge_transition = Console.ReadLine();
        Console.WriteLine("*skshh!*");
        dialouge_transition = Console.ReadLine();
        Console.WriteLine("*smshhh!*");
        dialouge_transition = Console.ReadLine();
        Console.WriteLine("*plfhhh*");
        dialouge_transition = Console.ReadLine();

        Console.WriteLine("...");
        dialouge_transition = Console.ReadLine();
        Console.WriteLine("...");
        dialouge_transition = Console.ReadLine();
        Console.WriteLine("...");
        dialouge_transition = Console.ReadLine();

        Console.WriteLine("You triped...");
        dialouge_transition = Console.ReadLine();
        Console.WriteLine("You were too injuried and hungry.");
        dialouge_transition = Console.ReadLine();
        Console.WriteLine("You died...");
        dialouge_transition = Console.ReadLine();

        Console.WriteLine("...");
        dialouge_transition = Console.ReadLine();
        Console.WriteLine("...");
        dialouge_transition = Console.ReadLine();
        Console.WriteLine("...");
        dialouge_transition = Console.ReadLine();

        Console.WriteLine("You got 'The Bad Ending'");
        dialouge_transition = Console.ReadLine();
    }
}
