using System;
using System.Linq;
using System.Threading.Tasks;
using SwitchAppDesign.AniListAPI.v2;

namespace ApiTestConsoleApp_Core
{
    internal class Program
    {
        private static async Task Main()
        {
            const string search = "Attack on Titan";
            const int malId = 39063;
            const int anilistId = 107418;
            var api = new AniListApi();
            
            var scum = await api.SearchFullAnime(search);
            Console.WriteLine($"Found {scum.Count()} entries for: {search}");
            
            var malEntries = await api.GetFullAnimeByMalId(malId);
            Console.WriteLine($"Found {malEntries.title.english} for Mal Id: {malId}");

            var anilistEntry = await api.GetBasicAnimeByAniListId(anilistId);
            Console.WriteLine($"Found {anilistEntry.title.english} for Anilist Id: {anilistId}");

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

    }
}
