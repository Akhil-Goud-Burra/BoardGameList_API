
/*
 * This Class will host Descriptive Links
    1. This LinkDTO class is a Data Transfer Object (DTO) designed to encapsulate information about a hyperlink.
    2. Links are included in API responses to provide additional context or navigational options to the client.
*/

namespace MyBGList.DTO
{
    public class LinkDTO
    {
        public LinkDTO(string href, string rel, string type)
        {
            Href = href;
            Rel = rel;
            Type = type;
        }

        public string Href { get; private set; }

        public string Rel { get; private set; }

        public string Type { get; private set; }
    }
}
