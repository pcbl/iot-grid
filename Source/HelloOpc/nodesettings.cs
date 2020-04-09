using System;
using System.Collections.Generic;
using System.Text;

namespace HelloOpc
{
    public class SubscriptionDefinition
    {
        public string DiscoveryUrl { get; set; }

        public Node[] DataItems { get; set; }
    }

    public class Node
    {
        public string Id { get; set; }
        public string NsId { get; set; }
    }
}
