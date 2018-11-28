using System;

namespace HotChocolate.Types
{
    public class PageInfoType
        : ObjectType<PageInfo>
    {
    }

    public class EdgeType
        : ObjectType
    {

    }



    public class PageInfo
    {
        public bool HasPreviousPage { get; set; }
        public bool hasNextPage { get; set; }
    }
}
