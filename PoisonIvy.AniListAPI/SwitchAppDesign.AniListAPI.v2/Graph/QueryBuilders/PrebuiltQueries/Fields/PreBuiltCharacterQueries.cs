using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilders.PrebuiltQueries
{
    /// <summary>
    ///     Assist with building Character queries
    /// </summary>
    public partial class PreBuiltCharacterQueries
    {
        /// <summary>
        ///     Set up the builder to request all the character fields that it can
        /// </summary>
        private void FullCharacterFields()
        {
            _builder.AddField(_builder.OtherFields.Character.IdQueryField());
            _builder.AddField(_builder.OtherFields.Character.NameQueryField(
                new List<GraphQueryField>
                {
                    _builder.OtherFields.Name.FirstQueryField(),
                    _builder.OtherFields.Name.LastQueryField(),
                    _builder.OtherFields.Name.NativeQueryField()
                }));
            _builder.AddField(_builder.OtherFields.Character.DescriptionQueryField());
            _builder.AddField(_builder.OtherFields.Character.ImageQueryField(
                fields: new List<GraphQueryField>
                {
                    _builder.OtherFields.CoverImageData.MediumQueryField(),
                    _builder.OtherFields.CoverImageData.LargeQueryField()
                }));
            _builder.AddField(_builder.OtherFields.Character.SiteUrlQueryField());

            _builder.AddField(_builder.OtherFields.Character.MediaQueryField(
                fields: new List<GraphQueryField>
                {
                    _builder.OtherFields.MediaConnection.EdgesQueryField(
                        fields: new List<GraphQueryField>
                        {
                            _builder.OtherFields.MediaEdge.IdQueryField(),
                            _builder.OtherFields.MediaEdge.NodeQueryField(
                                fields: new List<GraphQueryField>
                                {
                                    _builder.MediaQueryFields.TitleQueryField(
                                        fields: new List<GraphQueryField>
                                        {
                                            _builder.OtherFields.MediaTitle.EnglishQueryField(),
                                            _builder.OtherFields.MediaTitle.RomajiQueryField(),
                                            _builder.OtherFields.MediaTitle.NativeQueryField()
                                        }),
                                    _builder.MediaQueryFields.CoverImageQueryField(
                                        fields: new List<GraphQueryField>
                                        {
                                            _builder.OtherFields.CoverImageData.MediumQueryField(),
                                            _builder.OtherFields.CoverImageData.LargeQueryField()
                                        }),
                                    _builder.MediaQueryFields.SiteUrlQueryField(),
                                    _builder.MediaQueryFields.TypeQueryField()
                                }),
                            _builder.OtherFields.MediaEdge.CharacterRoleQueryField()
                        })
                }));
        }
    }
}