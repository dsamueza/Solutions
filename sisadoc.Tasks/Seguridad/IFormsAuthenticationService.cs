﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sisadoc.Tasks.Seguridad
{
    public interface IFormsAuthenticationService
    {
        void SignIn(string userName, bool createPersistentCookie);
        void SignOut();
    }

}
