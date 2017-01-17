using IdentityServer4;
using IdentityServer4.Models;
using System.Collections.Generic;

namespace IdentityServer.Configuration
{
    public class APIResource
    {
        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource
                {
                    Name = "mvc",
                     ApiSecrets = new List<Secret> { new Secret("superSecretPassword".Sha256() )},
                     Scopes = new List<Scope>
                     {
                         new Scope("open"),
                         new Scope("slack_user_id"),
                         new Scope(IdentityServerConstants.StandardScopes.OpenId),
                         new Scope(IdentityServerConstants.StandardScopes.Profile),
                         new Scope(IdentityServerConstants.StandardScopes.Email)
                     }
                }
            };
        }
    }
}
