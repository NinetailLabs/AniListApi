using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using SwitchAppDesign.AniListAPI.v2.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilders;
using SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilders.PrebuiltQueries;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;
using SwitchAppDesign.AniListAPI.v2.Models;

namespace SwitchAppDesign.AniListAPI.v2
{
    /// <summary>
    /// Exposes all available queries to the AniList API. Includes pre-built queries as well as more advanced custom built queries.
    /// </summary>
    public class AniListApi
    {
        private static AniListProxy _proxy;
        private readonly JsonSerializerSettings _serializerSettings;

        public AniListApi()
        {
            _proxy = new AniListProxy();
            _serializerSettings = new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };
        }

        /// <summary>
        /// Fetches a basic instance of media model of type anime.
        /// </summary>
        public async Task<Media> GetBasicAnimeByAniListId(int anilistMediaId)
        {
            try
            {
                var query = new PreBuiltMediaQueries().BasicAnimeMediaQuery(anilistMediaId);

                var rawQuery = GetBody(query);

                var result = await _proxy.GenericPostAsync<Media>(rawQuery, AniListQueryType.Media);

                return result;
            }
            catch (Exception e)
            {
                HandleException(e);
            }

            return await Task.FromResult<Media>(null);
        }

        /// <summary>
        /// Fetches a full instance of media model of type anime.
        /// </summary>
        public async Task<Media> GetFullAnimeByAniListId(int anilistMediaId)
        {
            try
            {
                var query = new PreBuiltMediaQueries().FullAnimeQuery(anilistMediaId);

                var rawQuery = GetBody(query);

                var result = await _proxy.GenericPostAsync<Media>(rawQuery, AniListQueryType.Media);

                return result;
            }
            catch (Exception e)
            {
                HandleException(e);
            }

            return await Task.FromResult<Media>(null);
        }

        /// <summary>
        /// Fetches a full instance of media model of type anime.
        /// </summary>
        public async Task<IEnumerable<Media>> SearchFullAnime(string searchPhrase)
        {
            try
            {
                var query = new PreBuiltPageQueries().SearchFullAnimeQuery(searchPhrase);


                var rawQuery = GetBody(query);

                var result = await _proxy.GenericPostAsync<Page>(content: rawQuery, queryType: AniListQueryType.Page);

                return result.media;
            }
            catch (Exception e)
            {
                HandleException(e);
            }

            return await Task.FromResult<IEnumerable<Media>>(null);
        }

        /// <summary>
        /// Retrieve an AniList entry via its associated MyAnimeList Id
        /// </summary>
        /// <param name="malId">MyAnimeList Id for the anime</param>
        /// <returns>Anime entries for the Id</returns>
        public async Task<Media> GetFullAnimeByMalId(int malId)
        {
            try
            {
                var query = new PreBuiltMediaQueries().MyAnimeListIdAnimeQuery(malId);
                var rawQuery = GetBody(query);
                var result = await _proxy.GenericPostAsync<Media>(rawQuery, AniListQueryType.Media);

                return result;
            }
            catch (Exception exception)
            {
                HandleException(exception);
            }

            return await Task.FromResult<Media>(null);
        }

        /// <summary>
        /// Retrieve an AniList entry via its Id
        /// </summary>
        /// <param name="aniListId">AniList Id for the entry</param>
        /// <returns>Anime entry for the Id</returns>
        public async Task<Media> GetFullAnimeById(int aniListId)
        {
            try
            {
                var query = new PreBuiltMediaQueries().FullAnimeQuery(aniListId);
                var rawQuery = GetBody(query);
                var result = await _proxy.GenericPostAsync<Media>(rawQuery, AniListQueryType.Media);

                return result;
            }
            catch (Exception exception)
            {
                HandleException(exception);
            }

            return await Task.FromResult<Media>(null);
        }

        /// <summary>
        /// Retrieve a character from AniList by the character Id.
        /// </summary>
        /// <param name="characterId">AniList Id of the character to retrieve</param>
        /// <returns>Character for the Id</returns>
        public async Task<Character> GetFullCharacterById(int characterId)
        {
            try
            {
                var query = new PreBuiltCharacterQueries().FullCharacterQuery(characterId);
                var rawQuery = GetBody(query);
                var result = await _proxy.GenericPostAsync<Character>(rawQuery, AniListQueryType.Character);

                return result;
            }
            catch (Exception exception)
            {
                HandleException(exception);
            }

            return await Task.FromResult<Character>(null);
        }

        #region SharedBehaviour

        private HttpContent GetBody(GraphQuery query)
        {
            return new StringContent(JsonConvert.SerializeObject(query, _serializerSettings), Encoding.UTF8,
                "application/json");
        }

        private static void HandleException(Exception e)
        {
            switch (e)
            {
                case GraphQueryFieldInvalidException fieldException:
                {
#if DEBUG
                    Console.WriteLine(e);
#endif
                    throw fieldException;
                }

                case GraphQueryArgumentInvalidException argumentException:
                {
#if DEBUG
                    Console.WriteLine(e);
#endif

                    throw argumentException;
                }

                default:
                {
#if DEBUG
                    Console.WriteLine(e);
#endif
                    throw e;
                }
            }
        }

        #endregion
    }
}