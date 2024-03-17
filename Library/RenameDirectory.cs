namespace GiantBombArchiveDownloader.Library;

public static class RenameDirectory
{
    public static void RenameDirectories()
    {
        bool bts = false;
        string sourceDirectory = "";
        string destinationDirectory = "";

        var list = new List<string>();

        /* List<string> list =
            Directory
                .GetDirectories(@$"/Users/ricardolourenco/Downloads/Giant Bomb/Endurance Run - Persona 4/", "gb-2300-???-*")
                .Order()
                .ToList();

        list.AddRange(Directory
                .GetDirectories(@$"/Users/ricardolourenco/Downloads/Giant Bomb/Endurance Run - Persona 4/", "gb-2300-????-*")
                .Order());

        bts = true;
        int j = 0;

        for(int i = 82; i <= (81 + list.Count) ; i++)
        {
            bts = CreatePersona4(i, bts, list[j], destinationDirectory);
            j += 1;
        } */

        /*for(int i = 1; i <= 18; i++)
        {
            CreateStealMySunshine(i, sourceDirectory, destinationDirectory);
        }*/

        /*list = Directory
                .GetDirectories(@$"/Users/ricardolourenco/Downloads/Giant Bomb/Endurance Run - Deadly Premonition (VJ)/", "gb-2300-????-*")
                .Order()
                .ToList();

        for(int i = 1; i <= 38; i++)
        {
            CreateDeadlyPremonition(i, "VJ", list[i - 1], destinationDirectory);
        }*/

        /*list = Directory
            .GetDirectories(@$"/Users/ricardolourenco/Downloads/Giant Bomb/Endurance Run - Deadly Premonition (BR)/", "gb-2300-????-*")
            .Order()
            .ToList();

        for(int i = 1; i <= 41; i++)
        {
            CreateDeadlyPremonition(i, "BR", list[i - 1], destinationDirectory);
        }*/

        list = Directory
            .GetDirectories(@$"/Users/ricardolourenco/Downloads/Giant Bomb/Endurance Run - Chrono Trigger/", "gb-2300-????-*")
            .Order()
            .ToList();

        for(int i = 1; i <= 42; i++)
        {
            CreateChronoTrigger(i, list[i - 1], destinationDirectory);
        }

        /*list = Directory
            .GetDirectories(@$"/Users/ricardolourenco/Downloads/Giant Bomb/Endurance Run - Shenmue/", "gb-2300-?????-*")
            .Order()
            .ToList();

        for(int i = 1; i <= 27; i++)
        {
            CreateShenmue(i, list[i - 1], destinationDirectory);
        }*/
    }

    static void CreateShenmue(int EpisodeNumber, string sourceDirectory, string destinationDirectory)
    {
        if(EpisodeNumber != 27)
        {
            destinationDirectory = @$"/Users/ricardolourenco/Downloads/Giant Bomb/Endurance Run - Shenmue/{EpisodeNumber:00}. Endurance Run - Shenmue - Part {EpisodeNumber:00}";
            Directory.Move(sourceDirectory, destinationDirectory);
            //Directory.CreateDirectory(@$"/Users/ricardolourenco/Downloads/Giant Bomb/Endurance Run - Shenmue/{EpisodeNumber:00}. Endurance Run - Shenmue - Part {EpisodeNumber:00}");
        }
        else
        {
            destinationDirectory = @$"/Users/ricardolourenco/Downloads/Giant Bomb/Endurance Run - Shenmue/{EpisodeNumber:00}. Endurance Run - Shenmue - Part {EpisodeNumber:00} (Epilogue)";
            Directory.Move(sourceDirectory, destinationDirectory);
            //Directory.CreateDirectory(@$"/Users/ricardolourenco/Downloads/Giant Bomb/Endurance Run - Shenmue/{EpisodeNumber:00}. Endurance Run - Shenmue - Part {EpisodeNumber:00} (Epilogue)");
        }
    }

    static void CreateChronoTrigger(int EpisodeNumber, string sourceDirectory, string destinationDirectory)
    {
        destinationDirectory = @$"/Users/ricardolourenco/Downloads/Giant Bomb/Endurance Run - Chrono Trigger/{EpisodeNumber:00}. Endurance Run - Chrono Trigger - Part {EpisodeNumber:00}";
        Directory.Move(sourceDirectory, destinationDirectory);
        //Directory.CreateDirectory(@$"/Users/ricardolourenco/Downloads/Giant Bomb/Endurance Run - Chrono Trigger/{EpisodeNumber:00}. Endurance Run - Chrono Trigger - Part {EpisodeNumber:00}");
    }

    static void CreateDeadlyPremonition(int EpisodeNumber, string Team, string sourceDirectory, string destinationDirectory)
    {
        destinationDirectory = @$"/Users/ricardolourenco/Downloads/Giant Bomb/Endurance Run - Deadly Premonition ({Team})/{EpisodeNumber:00}. Endurance Run - Deadly Premonition - Part {Team}-{EpisodeNumber:00}";
        Directory.Move(sourceDirectory, destinationDirectory);
        //Directory.CreateDirectory(@$"/Users/ricardolourenco/Downloads/Giant Bomb/Endurance Run - Deadly Premonition ({Team})/{EpisodeNumber:00}. Endurance Run - Deadly Premonition - Part {Team}-{EpisodeNumber:00}");
    }

    static void CreateStealMySunshine(int EpisodeNumber, string sourceDirectory, string destinationDirectory)
    {
        sourceDirectory = @$"/Users/ricardolourenco/Downloads/Giant Bomb/Steal My Sunshine/steal-my-sunshine-episode-{EpisodeNumber:00}";
        destinationDirectory = @$"/Users/ricardolourenco/Downloads/Giant Bomb/Steal My Sunshine/{EpisodeNumber:00}. Steal My Sunshine - Episode {EpisodeNumber:00}";
        Directory.Move(sourceDirectory, destinationDirectory);
        //Directory.CreateDirectory(@$"/Users/ricardolourenco/Downloads/Giant Bomb/Steal My Sunshine/{EpisodeNumber:00}. Steal My Sunshine - Episode {EpisodeNumber:00}");
    }

    static bool CreatePersona4(int EpisodeNumber, bool BehindTheScenes, string sourceDirectory, string destinationDirectory)
    {
        if(EpisodeNumber == 51 && BehindTheScenes == false)
        {
            //sourceDirectory = @$"/Users/ricardolourenco/Downloads/Giant Bomb/Endurance Run - Persona 4/endurance-run-persona-4-part-{EpisodeNumber - 1:00}-bts";
            destinationDirectory = @$"/Users/ricardolourenco/Downloads/Giant Bomb/Endurance Run - Persona 4/{EpisodeNumber:000}. Behind the Scenes - Endurance Run Ep. {EpisodeNumber - 1:00}";
            BehindTheScenes = true;
        }
        else if(BehindTheScenes == true)
        {
            //sourceDirectory = @$"/Users/ricardolourenco/Downloads/Giant Bomb/Endurance Run - Persona 4/endurance-run-persona-4-part-{EpisodeNumber - 1:00}";
            destinationDirectory = @$"/Users/ricardolourenco/Downloads/Giant Bomb/Endurance Run - Persona 4/{EpisodeNumber:000}. Endurance Run - Persona 4 - Part {EpisodeNumber - 1:00}";
        }
        else
        {
            //sourceDirectory = @$"/Users/ricardolourenco/Downloads/Giant Bomb/Endurance Run - Persona 4/endurance-run-persona-4-part-{EpisodeNumber:00}";
            destinationDirectory = @$"/Users/ricardolourenco/Downloads/Giant Bomb/Endurance Run - Persona 4/{EpisodeNumber:000}. Endurance Run - Persona 4 - Part {EpisodeNumber:00}";
        }

        Directory.Move(sourceDirectory, destinationDirectory);
        //Console.WriteLine($"{EpisodeNumber}, {sourceDirectory}, {destinationDirectory}");

        return BehindTheScenes;
    }
}