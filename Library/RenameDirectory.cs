namespace GiantBombArchiveDownloader.Library;

public static class RenameDirectory
{
    public static void RenameDirectories()
    {
        /*RemoveER("Chrono Trigger");

        RemoveER("Deadly Premonition (BR)");

        RemoveER("Deadly Premonition (VJ)");

        RemoveER("Persona 4");

        RemoveER("Shenmue");

        RemoveER("The Matrix Online - Not Like This");*/

        /*bool bts = false;
        string sourceDirectory = "";
        string destinationDirectory = "";

        var list = new List<string>
        {
            @$"/Users/ricardolourenco/Downloads/giantbomb/Endurance Run - The Matrix Online - Not Like This/gb-2300-997-ID7GX8R"
        };

        list.AddRange(Directory
                .GetDirectories(@$"/Users/ricardolourenco/Downloads/giantbomb/Endurance Run - The Matrix Online - Not Like This/", "gb-2300-????-*")
                .Order()
                .ToList());

        for(int i = 1; i <= 5 ; i++)
        {
            CreateMatrix(i, list[i - 1], destinationDirectory);
        }

        list = Directory
                .GetDirectories(@$"/Users/ricardolourenco/Downloads/Giant Bomb/Endurance Run - Persona 4/")
                .Order()
                .ToList();

        for(int i = 1; i <= 156 ; i++)
        {
            bts = CreatePersona4(i, bts, list[j], destinationDirectory);
        }

        for(int i = 1; i <= 18; i++)
        {
            CreateStealMySunshine(i, sourceDirectory, destinationDirectory);
        }

        list = Directory
                .GetDirectories(@$"/Users/ricardolourenco/Downloads/Giant Bomb/Endurance Run - Deadly Premonition (VJ)/", "gb-2300-????-*")
                .Order()
                .ToList();

        for(int i = 1; i <= 38; i++)
        {
            CreateDeadlyPremonition(i, "VJ", list[i - 1], destinationDirectory);
        }

        list = Directory
            .GetDirectories(@$"/Users/ricardolourenco/Downloads/Giant Bomb/Endurance Run - Deadly Premonition (BR)/", "gb-2300-????-*")
            .Order()
            .ToList();

        for(int i = 1; i <= 41; i++)
        {
            CreateDeadlyPremonition(i, "BR", list[i - 1], destinationDirectory);
        }

        list = Directory
            .GetDirectories(@$"/Users/ricardolourenco/Downloads/Giant Bomb/Endurance Run - Chrono Trigger/", "gb-2300-????-*")
            .Order()
            .ToList();

        for(int i = 1; i <= 42; i++)
        {
            CreateChronoTrigger(i, list[i - 1], destinationDirectory);
        }

        list = Directory
            .GetDirectories(@$"/Users/ricardolourenco/Downloads/Giant Bomb/Endurance Run - Shenmue/", "gb-2300-?????-*")
            .Order()
            .ToList();

        for(int i = 1; i <= 27; i++)
        {
            CreateShenmue(i, list[i - 1], destinationDirectory);
        }*/
    }

    static void RemoveER(string series)
    {
        var list = Directory
            .GetDirectories(@$"/Volumes/External HDD 4TB/Movies, Videos & Series/Giant Bomb/Endurance Run/{series}", "*Endurance Run - *")
            .ToList();

        foreach(var dir in list)
        {
            var newDir = dir.Replace("Endurance Run - ", "");
            Directory.Move(dir, newDir);
        }
    }

    static void CreateMatrix(int EpisodeNumber, string sourceDirectory, string destinationDirectory)
    {
        if(EpisodeNumber != 5)
        {
            destinationDirectory = @$"/Users/ricardolourenco/Downloads/giantbomb/Endurance Run - The Matrix Online - Not Like This/{EpisodeNumber:00}. Endurance Run - The Matrix Online - Not Like This - Part {EpisodeNumber:00}";
            Directory.Move(sourceDirectory, destinationDirectory);
        }
        else
        {
            destinationDirectory = @$"/Users/ricardolourenco/Downloads/giantbomb/Endurance Run - The Matrix Online - Not Like This/{EpisodeNumber:00}. Endurance Run - The Matrix Online - Not Like This - Finale";
            Directory.Move(sourceDirectory, destinationDirectory);
        }
    }

    static void CreateShenmue(int EpisodeNumber, string sourceDirectory, string destinationDirectory)
    {
        if(EpisodeNumber != 27)
        {
            destinationDirectory = @$"/Users/ricardolourenco/Downloads/Giant Bomb/Endurance Run - Shenmue/{EpisodeNumber:00}. Endurance Run - Shenmue - Part {EpisodeNumber:00}";
            Directory.Move(sourceDirectory, destinationDirectory);
        }
        else
        {
            destinationDirectory = @$"/Users/ricardolourenco/Downloads/Giant Bomb/Endurance Run - Shenmue/{EpisodeNumber:00}. Endurance Run - Shenmue - Part {EpisodeNumber:00} (Epilogue)";
            Directory.Move(sourceDirectory, destinationDirectory);
        }
    }

    static void CreateChronoTrigger(int EpisodeNumber, string sourceDirectory, string destinationDirectory)
    {
        destinationDirectory = @$"/Users/ricardolourenco/Downloads/Giant Bomb/Endurance Run - Chrono Trigger/{EpisodeNumber:00}. Endurance Run - Chrono Trigger - Part {EpisodeNumber:00}";
        Directory.Move(sourceDirectory, destinationDirectory);
    }

    static void CreateDeadlyPremonition(int EpisodeNumber, string Team, string sourceDirectory, string destinationDirectory)
    {
        destinationDirectory = @$"/Users/ricardolourenco/Downloads/Giant Bomb/Endurance Run - Deadly Premonition ({Team})/{EpisodeNumber:00}. Endurance Run - Deadly Premonition - Part {Team}-{EpisodeNumber:00}";
        Directory.Move(sourceDirectory, destinationDirectory);
    }

    static void CreateStealMySunshine(int EpisodeNumber, string sourceDirectory, string destinationDirectory)
    {
        sourceDirectory = @$"/Users/ricardolourenco/Downloads/Giant Bomb/Steal My Sunshine/steal-my-sunshine-episode-{EpisodeNumber:00}";
        destinationDirectory = @$"/Users/ricardolourenco/Downloads/Giant Bomb/Steal My Sunshine/{EpisodeNumber:00}. Steal My Sunshine - Episode {EpisodeNumber:00}";
        Directory.Move(sourceDirectory, destinationDirectory);
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

        return BehindTheScenes;
    }
}