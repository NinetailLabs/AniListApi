using SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilders.Builders;

namespace SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilders.PrebuiltQueries
{
    /// <summary>
    /// Queries that have been pre-built to retrieve Character information
    /// </summary>
    public partial class PreBuiltCharacterQueries
    {
        /// <summary>
        /// Internal Constructor
        /// </summary>
        internal PreBuiltCharacterQueries()
        {

        }

        /// <summary>
        /// Query to retrieve a character and all related shows from AniList
        /// </summary>
        /// <param name="characterId">Id of the character to retrieve</param>
        /// <returns>Query to fulfill the retrieval</returns>
        internal GraphQuery FullCharacterQuery(int characterId)
        {
            _builder = new CharacterBuilder();

            _builder.AddArgument(_builder.OtherArguments.Character.IdQueryArgument(characterId));

            FullCharacterFields();

            return _builder.BuildQuery();
        }

        /// <summary>
        /// CharacterBuilder instance
        /// </summary>
        private CharacterBuilder _builder;
    }
}