using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilders.PrebuiltQueries
{
    partial class PreBuiltMediaQueries
    {
        private void BasicAnimeFields()
        {
            _builder.AddField(_builder.MediaQueryFields.TitleQueryField(
                fields: new List<GraphQueryField>
                {
                    _builder.OtherFields.MediaTitle.EnglishQueryField(),
                    _builder.OtherFields.MediaTitle.RomajiQueryField()
                }));
            _builder.AddField(_builder.MediaQueryFields.FormatQueryField());
            _builder.AddField(_builder.MediaQueryFields.StatusQueryField());
            _builder.AddField(_builder.MediaQueryFields.DescriptionQueryField());
            _builder.AddField(_builder.MediaQueryFields.StartDateQueryField());
            _builder.AddField(_builder.MediaQueryFields.EndDateQueryField());
            _builder.AddField(_builder.MediaQueryFields.SeasonQueryField());
            _builder.AddField(_builder.MediaQueryFields.EpisodesQueryField());
            _builder.AddField(_builder.MediaQueryFields.DurationQueryField());
            _builder.AddField(_builder.MediaQueryFields.CountryOfOriginQueryField());
            _builder.AddField(_builder.MediaQueryFields.SourceQueryField());
            _builder.AddField(_builder.MediaQueryFields.UpdatedAtQueryField());
            _builder.AddField(_builder.MediaQueryFields.CoverImageQueryField(
                fields: new List<GraphQueryField>
                {
                    _builder.OtherFields.CoverImageData.MediumQueryField(),
                    _builder.OtherFields.CoverImageData.LargeQueryField(),
                }));
            _builder.AddField(_builder.MediaQueryFields.GenresQueryField());
            _builder.AddField(_builder.MediaQueryFields.AverageScoreQueryField());
            _builder.AddField(_builder.MediaQueryFields.IsAdultQueryField());
            _builder.AddField(_builder.MediaQueryFields.NextAiringEpisodeQueryField(
                fields: new List<GraphQueryField>
                {
                    _builder.OtherFields.AiringSchedule.AiringAtQueryField(),
                    _builder.OtherFields.AiringSchedule.EpisodeQueryField()
                }));
        }

        private void FullAnimeFields()
        {
            _builder.AddField(_builder.MediaQueryFields.IdQueryField());
            _builder.AddField(_builder.MediaQueryFields.IdMalQueryField());
            _builder.AddField(_builder.MediaQueryFields.MeanScoreQueryField());
            _builder.AddField(_builder.MediaQueryFields.AverageScoreQueryField());
            _builder.AddField(_builder.MediaQueryFields.PopularityQueryField());
            _builder.AddField(_builder.MediaQueryFields.SiteUrlQueryField());
            _builder.AddField(_builder.MediaQueryFields.TypeQueryField());
            _builder.AddField(_builder.MediaQueryFields.TitleQueryField(
                fields: new List<GraphQueryField>
                {
                    _builder.OtherFields.MediaTitle.EnglishQueryField(),
                    _builder.OtherFields.MediaTitle.RomajiQueryField(),
                    _builder.OtherFields.MediaTitle.NativeQueryField()
                }));
            _builder.AddField(_builder.MediaQueryFields.FormatQueryField());
            _builder.AddField(_builder.MediaQueryFields.StatusQueryField());
            _builder.AddField(_builder.MediaQueryFields.DescriptionQueryField());
            _builder.AddField(_builder.MediaQueryFields.StartDateQueryField());
            _builder.AddField(_builder.MediaQueryFields.EndDateQueryField());
            _builder.AddField(_builder.MediaQueryFields.SeasonQueryField());
            _builder.AddField(_builder.MediaQueryFields.EpisodesQueryField());
            _builder.AddField(_builder.MediaQueryFields.DurationQueryField());
            _builder.AddField(_builder.MediaQueryFields.CountryOfOriginQueryField());
            _builder.AddField(_builder.MediaQueryFields.SourceQueryField());
            _builder.AddField(_builder.MediaQueryFields.UpdatedAtQueryField());
            _builder.AddField(_builder.MediaQueryFields.CoverImageQueryField(
                fields: new List<GraphQueryField>
                {
                    _builder.OtherFields.CoverImageData.MediumQueryField(),
                    _builder.OtherFields.CoverImageData.LargeQueryField()
                }));
            _builder.AddField(_builder.MediaQueryFields.BannerImageQueryField());
            _builder.AddField(_builder.MediaQueryFields.GenresQueryField());
            _builder.AddField(_builder.MediaQueryFields.SynonymsQueryField());
            _builder.AddField(_builder.MediaQueryFields.TagsQueryField(
                fields: new List<GraphQueryField>
                {
                    _builder.OtherFields.MediaTag.IdQueryField(),
                    _builder.OtherFields.MediaTag.NameQueryField(),
                    _builder.OtherFields.MediaTag.DescriptionQueryField(),
                    _builder.OtherFields.MediaTag.CategoryQueryField(),
                    _builder.OtherFields.MediaTag.RankQueryField(),
                    _builder.OtherFields.MediaTag.IsGeneralSpoilerQueryField(),
                    _builder.OtherFields.MediaTag.IsMediaSpoilerQueryField(),
                    _builder.OtherFields.MediaTag.IsAdultQueryField()
                }));
            _builder.AddField(_builder.MediaQueryFields.RelationsQueryField(
                fields: new List<GraphQueryField>
                {
                    _builder.OtherFields.MediaConnection.EdgesQueryField(
                        fields: new List<GraphQueryField>
                        {
                            _builder.OtherFields.MediaEdge.IdQueryField(),
                            _builder.OtherFields.MediaEdge.NodeQueryField(
                                fields: new List<GraphQueryField>
                                {
                                    _builder.MediaQueryFields.IdQueryField(),
                                    _builder.MediaQueryFields.TitleQueryField(
                                        fields: new List<GraphQueryField>
                                        {
                                            _builder.OtherFields.MediaTitle.EnglishQueryField(),
                                        }),
                                    _builder.MediaQueryFields.SiteUrlQueryField()
                                }),
                            _builder.OtherFields.MediaEdge.RelationTypeQueryField(),
                            _builder.OtherFields.MediaEdge.IsMainStudioQueryField()

                        })
                }));
            _builder.AddField(_builder.MediaQueryFields.CharactersQueryField(
                fields: new List<GraphQueryField>
                {
                    _builder.OtherFields.CharacterConnection.EdgesQueryField(
                        fields: new List<GraphQueryField>
                        {
                            _builder.OtherFields.CharacterEdge.IdQueryField(),
                            _builder.OtherFields.CharacterEdge.NodeQueryField(
                                fields: new List<GraphQueryField>
                                {
                                    _builder.OtherFields.Character.IdQueryField(),
                                    _builder.OtherFields.Character.DescriptionQueryField(),
                                    _builder.OtherFields.Character.NameQueryField(
                                        fields: new List<GraphQueryField>
                                        {
                                            _builder.OtherFields.Name.FirstQueryField(),
                                            _builder.OtherFields.Name.LastQueryField()
                                        }),
                                    _builder.OtherFields.Character.ImageQueryField(  
                                        fields: new List<GraphQueryField>
                                        {
                                            _builder.OtherFields.CoverImageData.MediumQueryField(),
                                            _builder.OtherFields.CoverImageData.LargeQueryField()
                                        }),
                                    _builder.OtherFields.Character.SiteUrlQueryField()
                                }),
                            _builder.OtherFields.CharacterEdge.RoleQueryField(),
                            _builder.OtherFields.CharacterEdge.VoiceActorsQueryField(
                                fields: new List<GraphQueryField>
                                {
                                    _builder.OtherFields.Staff.NameQueryField(fields: new List<GraphQueryField>
                                    {
                                        _builder.OtherFields.Name.FirstQueryField(),
                                        _builder.OtherFields.Name.LastQueryField()
                                    }),
                                    _builder.OtherFields.Staff.LanguageQueryField(),
                                    _builder.OtherFields.Staff.IdQueryField(),
                                    _builder.OtherFields.Staff.DescriptionQueryField(),
                                    _builder.OtherFields.Staff.SiteUrlQueryField(),
                                    _builder.OtherFields.Staff.ImageQueryField(
                                        fields: new List<GraphQueryField>
                                        {
                                            _builder.OtherFields.CoverImageData.LargeQueryField()
                                        })
                                })
                        })
                },
                arguments: new List<object>
                {
                    _builder.OtherArguments.CharacterConnection.SortQueryArgument(new[] { CharacterSort.Role })
                }));
            _builder.AddField(_builder.MediaQueryFields.IsAdultQueryField());
            _builder.AddField(_builder.MediaQueryFields.NextAiringEpisodeQueryField(
                fields: new List<GraphQueryField>
                {
                    _builder.OtherFields.AiringSchedule.AiringAtQueryField(),
                    _builder.OtherFields.AiringSchedule.EpisodeQueryField()
                }));
            _builder.AddField(_builder.MediaQueryFields.AiringScheduleQueryField(
                fields: new List<GraphQueryField>
                {
                    _builder.OtherFields.AiringScheduleConnection.EdgesQueryField(
                        fields: new List<GraphQueryField>
                        {
                            _builder.OtherFields.AiringScheduleEdge.IdQueryField(),
                            _builder.OtherFields.AiringScheduleEdge.NodeQueryField(
                                fields: new List<GraphQueryField>
                                {
                                    _builder.OtherFields.AiringSchedule.AiringAtQueryField(),
                                    _builder.OtherFields.AiringSchedule.EpisodeQueryField()
                                }),
                        })
                }));
            _builder.AddField(_builder.MediaQueryFields.ExternalLinksQueryField(
                fields: new List<GraphQueryField>
                {
                    _builder.OtherFields.MediaExternalLink.IdQueryField(),
                    _builder.OtherFields.MediaExternalLink.SiteQueryField(),
                    _builder.OtherFields.MediaExternalLink.UrlQueryField()
                }));
            _builder.MediaQueryFields.StreamingEpisodesQueryField(
                fields: new List<GraphQueryField>
                {
                    _builder.OtherFields.MediaStreamingEpisode.TitleQueryField(),
                    _builder.OtherFields.MediaStreamingEpisode.ThumbnailQueryField(),
                    _builder.OtherFields.MediaStreamingEpisode.UrlQueryField(),
                    _builder.OtherFields.MediaStreamingEpisode.SiteQueryField()
                });
            _builder.MediaQueryFields.SiteUrlQueryField();
        }
    }
}
