using IdentityServer4.Models;
using System.Collections.Generic;

namespace IdentityServer.Configuration
{
    public class GetIdentityResource
    {
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile()
            };
        }
    }
}
