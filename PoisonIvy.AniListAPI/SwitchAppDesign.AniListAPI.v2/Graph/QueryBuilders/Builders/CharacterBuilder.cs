using SwitchAppDesign.AniListAPI.v2.Graph.Arguments;
using SwitchAppDesign.AniListAPI.v2.Graph.Fields;
using SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilders.QueryBuilderArguments;
using SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilders.QueryBuilderFields;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilders.Builders
{
    /// <summary>
    /// Assist with building Character queries
    /// </summary>
    public class CharacterBuilder : GraphQueryBuilder
    {
        /// <summary>
        ///     Default Constructor
        /// </summary>
        internal CharacterBuilder()
        {
            InitializeBuilder(AniListQueryType.Character);
        }


        /// <summary>
        ///     Construct with the query type
        /// </summary>
        /// <param name="queryType"></param>
        public CharacterBuilder(AniListQueryType queryType)
        {
            InitializeBuilder(queryType);
        }

        /// <summary>
        ///     The main fields for a media query.
        /// </summary>
        public MediaQueryFields MediaQueryFields { get; private set; }

        /// <summary>
        ///     The main arguments for a media query.
        /// </summary>
        public MediaQueryArguments MediaQueryArguments { get; private set; }

        /// <summary>
        ///     Access point for the media query fields.
        /// </summary>
        public MediaQueryBuilderFields OtherFields { get; private set; }

        /// <summary>
        ///     Access point for all media query arguments.
        /// </summary>
        public MediaQueryBuilderArguments OtherArguments { get; private set; }

        private void InitializeBuilder(AniListQueryType queryType)
        {
            InitializeBase(queryType);

            MediaQueryFields = new MediaQueryFields(queryType);
            MediaQueryArguments = new MediaQueryArguments(queryType);

            OtherFields = new MediaQueryBuilderFields(queryType);
            OtherArguments = new MediaQueryBuilderArguments(queryType);
        }
    }
}