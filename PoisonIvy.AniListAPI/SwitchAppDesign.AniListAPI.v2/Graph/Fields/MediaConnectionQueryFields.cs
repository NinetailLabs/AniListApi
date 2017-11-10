using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    internal class MediaConnection
    {
        public MediaConnection()
        {
            InitializeProperties();
        }

        public GraphQLQueryField EdgesQueryField { get; private set; }

        public GraphQLQueryField NodesQueryField { get; private set; }

        /// <summary>
        /// The pagination information
        /// </summary>
        public GraphQLQueryField PageInfoQueryField { get; private set; }

        private void InitializeProperties()
        {
            EdgesQueryField = new GraphQLQueryField("edges", new FieldRules(false));
            NodesQueryField = new GraphQLQueryField("nodes", new FieldRules(false));
            PageInfoQueryField = new GraphQLQueryField("pageInfo", new FieldRules(false));
        }
    }
}
