using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Identity
{
    public class ApplicationIdentityDbcontext:IdentityDbContext<ApplicationUser>
    {
        public ApplicationIdentityDbcontext(DbContextOptions<ApplicationIdentityDbcontext>options):base(options)
        {

        }
    }
}
