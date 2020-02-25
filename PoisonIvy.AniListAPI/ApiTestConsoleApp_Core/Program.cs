using System;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
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
            const int characterId = 125946;
            var api = new AniListApi();
            
            //var scum = await api.SearchFullAnime(search);
            //Console.WriteLine($"Found {scum.Count()} entries for: {search}");
            
            //var malEntries = await api.GetFullAnimeByMalId(malId);
            //Console.WriteLine($"Found {malEntries.title.english} for Mal Id: {malId}");

            //var aniListIdEntry = await api.GetFullAnimeByAniListId(malEntries.id ?? 0);
            //aniListIdEntry.Should().BeEquivalentTo(malEntries);

            //var anilistEntry = await api.GetBasicAnimeByAniListId(anilistId);
            //Console.WriteLine($"Found {anilistEntry.title.english} for Anilist Id: {anilistId}");

            var characterEntry = await api.GetFullCharacterById(characterId);
            Console.WriteLine($"Retrieve {characterEntry.name} for character Id: {characterId}");

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

    }
}
