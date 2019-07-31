using SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilders.Builders;
using SwitchAppDesign.AniListAPI.v2.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilders.PrebuiltQueries
{
    /// <summary>
    /// All pre-built queries for media.
    /// </summary>
    public partial class PreBuiltMediaQueries
    {
        private MediaQueryBuilder _builder;

        internal PreBuiltMediaQueries()
        {
        }

        internal GraphQuery BasicAnimeMediaQuery(int anilistMediaId)
        {
            _builder = new MediaQueryBuilder();

            _builder.AddArgument(_builder.MediaQueryArguments.IdQueryArgument(anilistMediaId));
            _builder.AddArgument(_builder.MediaQueryArguments.TypeArgument(MediaType.Anime));

            BasicAnimeFields();

            return _builder.BuildQuery();
        }

        internal GraphQuery FullAnimeQuery(int anilistMediaId)
        {
            _builder = new MediaQueryBuilder();

            _builder.AddArgument(_builder.MediaQueryArguments.IdQueryArgument(anilistMediaId));
            _builder.AddArgument(_builder.MediaQueryArguments.TypeArgument(MediaType.Anime));

            FullAnimeFields();

            return _builder.BuildQuery();
        }

        internal GraphQuery MyAnimeListIdAnimeQuery(int malId)
        {
            _builder = new MediaQueryBuilder();

            _builder.AddArgument(_builder.MediaQueryArguments.IdMyAnimeListArgument(malId));
            _builder.AddArgument(_builder.MediaQueryArguments.TypeArgument(MediaType.Anime));
            
            FullAnimeFields();

            return _builder.BuildQuery();
        }
    }
}
