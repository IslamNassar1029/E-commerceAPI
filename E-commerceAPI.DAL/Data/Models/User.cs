using Microsoft.AspNetCore.Identity;

namespace E_commerceAPI.DAL;

public class User :IdentityUser
{
    public IEnumerable<Cart> Carts { get; set; } = new HashSet<Cart>();

}
