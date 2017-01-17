using IdentityServer4;
using IdentityServer4.Models;
using System.Collections.Generic;

namespace IdentityServer.Configuration
{
    public class Clients
    {
        public static IEnumerable<Client> Client()
        {
            return new List<Client>
                {
                    new Client
                    {
                        ClientId = "mvc",
                        ClientName = "MVC Client",
                        AllowedGrantTypes = GrantTypes.HybridAndClientCredentials,
                        AllowAccessTokensViaBrowser = true,
                        // where to redirect to after login
                        RedirectUris = { "http://localhost:58877/signin-oidc" },
                        // where to redirect to after logout
                        PostLogoutRedirectUris = { "http://localhost:58877/" },
                        AllowedScopes = new List<string>
                        {
                            "open",
                            IdentityServerConstants.StandardScopes.Email,
                            IdentityServerConstants.StandardScopes.OpenId,
                            IdentityServerConstants.StandardScopes.Profile,
                            "slack_user_id"
                        },
                        //RequireClientSecret = false,
                        ClientSecrets = new List<Secret>
                        {
                            new Secret("superSecretPassword".Sha256())
                        },
                        //AccessTokenType = AccessTokenType.Reference,
                        AllowOfflineAccess = true,
                    }


                    //new Client
                    //{
                    //    ClientId = "lol",
                    //    ClientName = "LOL",
                    //    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    //    AllowAccessTokensViaBrowser = true,
                    //    // where to redirect to after login
                    //    RedirectUris = { "http://localhost:58877/signin-oidc" },
                    //    // where to redirect to after logout
                    //    PostLogoutRedirectUris = { "http://localhost:58877" },
                    //    AllowedScopes = new List<string>
                    //    {
                    //        "open",
                    //        IdentityServerConstants.StandardScopes.OpenId,
                    //        IdentityServerConstants.StandardScopes.Profile,
                    //    },
                    //    //RequireClientSecret = false,
                    //    ClientSecrets = new List<Secret>
                    //    {
                    //        new Secret("superSecretPassword".Sha256())
                    //    },
                    //    AllowOfflineAccess = true
                    //}
                };
        }
    }
}
