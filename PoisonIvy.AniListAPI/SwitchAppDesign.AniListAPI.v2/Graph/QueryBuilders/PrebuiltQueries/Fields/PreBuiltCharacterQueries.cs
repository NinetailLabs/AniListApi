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
        }
    }
}