/*

// This Class Contains the data and the links that will sent to the client.
1. public T Data { get; set; } = default!;
==>RestDTO<T> is a generic property which will hold any type of data (T), and it provides a default value for the property.
==>public T Data { get; set; } = default!; This line makes the RestDTO<T> class generic, so it can wrap any data type without knowing the type in advance.
==>This way, RestDTO<T> can be used for any type of data—whether it's a single object (e.g., UserDTO), a list (e.g., List<UserDTO>), or any other structure.
==> Default Value Assignment: = default!; assigns the default value for T (e.g., null for reference types or 0 for integers) to ensure Data is initialized when an instance of RestDTO<T> is created, even if no data is explicitly set. This prevents errors related to uninitialized properties.
==> RestDTO<T>: Data can wrap any kind of response data without needing multiple DTO classes for each type.

2.public List<LinkDTO> Links { get; set; } = new List<LinkDTO>();
==>The Links property is a list of LinkDTO objects that include URLs or URIs to related resources or actions.
==>This helps make the API more self-descriptive, providing clients with links they can follow to related resources (e.g., "self", "next", "previous")
==>By including these links, clients can navigate the API dynamically without hardcoding URLs, improving the API’s usability and maintainability.
==> " Default Initialization with new List<LinkDTO>() " :=> = new List<LinkDTO>(); initializes Links as an empty list by default. This ensures that Links is never null, so even if no links are added, clients can safely access it as an empty collection.
==> This avoids null reference issues when iterating over Links and allows the code to work without additional null checks.
*/

namespace MyBGList.DTO
{
    public class RestDTO<T>
    {
        public T Data { get; set; } = default!;

        public List<LinkDTO> Links { get; set; } = new List<LinkDTO>();
    }
}
