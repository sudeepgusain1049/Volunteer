using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Volunteer.Business.Services
{
    public interface ITokenManagerService
    {
        String GetWebAPIToken();
    }
}
